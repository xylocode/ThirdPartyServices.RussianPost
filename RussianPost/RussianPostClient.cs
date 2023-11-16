using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Unicode;
using XyloCode.ThirdPartyServices.RussianPost.Calculation.Req;
using XyloCode.ThirdPartyServices.RussianPost.Calculation.Res;
using XyloCode.ThirdPartyServices.RussianPost.CleanAddress;
using XyloCode.ThirdPartyServices.RussianPost.CleanPersonName;
using XyloCode.ThirdPartyServices.RussianPost.CleanPhoneNumber;
using XyloCode.ThirdPartyServices.RussianPost.DeliveryPoints;
using XyloCode.ThirdPartyServices.RussianPost.Helpers;
using XyloCode.ThirdPartyServices.RussianPost.Models;

namespace XyloCode.ThirdPartyServices.RussianPost
{
    public sealed class RussianPostClient
    {
        private const string baseUri = "https://otpravka-api.pochta.ru";
        private readonly HttpClient httpClient;
        private readonly JsonSerializerOptions jso;
        private readonly QueryStringSerializer qss;

        /// <summary>
        /// Клиент доступа к API Почта России.
        /// </summary>
        /// <param name="accessToken">Токен авторизации приложения</param>
        /// <param name="login">Логин к сайту pochta.ru</param>
        /// <param name="password">Пароль к сайту pochta.ru</param>
        public RussianPostClient(
            string accessToken,
            string login,
            string password,
            string baseUri = baseUri,
            HttpMessageHandler httpMessageHandler = null,
            bool disposeHandler = true)
        {
            if (httpMessageHandler is null)
                httpClient = new HttpClient();
            else
                httpClient = new HttpClient(httpMessageHandler, disposeHandler);

            httpClient.BaseAddress = new Uri(baseUri);
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("AccessToken", accessToken);
            var userAuth = "Basic " + Convert.ToBase64String(Encoding.UTF8.GetBytes(login + ":" + password));
            httpClient.DefaultRequestHeaders.Add("X-User-Authorization", userAuth);

            jso = new JsonSerializerOptions
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
            };
            jso.Converters.Add(new JsonStringEnumConverter());
            jso.Converters.Add(new DateOnlyJsonConverter());
            jso.Converters.Add(new TimeOnlyJsonConverter());
            jso.Converters.Add(new NTimeOnlyJsonConverter());

            qss = new QueryStringSerializer
            {
                ArraySerializationMode = QueryStringSerializer.ArraySerializationModeEnum.NameSquareBrackets,
            };
        }


        private enum RequestMethod : byte
        {
            GET,
            POST,
            PUT,
            DELETE,
            PATCH,
        }

        private TRes Send<TRes>(RequestMethod method, string path)
        {
            httpClient.DefaultRequestHeaders.Accept.Clear();
            HttpResponseMessage res = method switch
            {
                RequestMethod.GET => httpClient.GetAsync(path).Result,
                RequestMethod.DELETE => httpClient.DeleteAsync(path).Result,
                _ => throw new NotSupportedException(),
            };

            return res
                .Content
                .ReadFromJsonAsync<TRes>(jso)
                .Result;
        }


        private TRes Send<TRes, TReq>(RequestMethod method, string path, TReq req)
        {
            if (method == RequestMethod.GET || method == RequestMethod.DELETE)
                path = string.Concat(path, "?", qss.Serialize(req));

            httpClient.DefaultRequestHeaders.Accept.Clear();
            HttpResponseMessage res;
            switch (method)
            {
                case RequestMethod.GET:
                    res = httpClient.GetAsync(path).Result;
                    break;

                case RequestMethod.POST:
                    res = httpClient.PostAsJsonAsync(path, req, jso).Result;
                    break;

                case RequestMethod.PUT:
                    res = httpClient.PutAsJsonAsync(path, req, jso).Result;
                    break;

                case RequestMethod.DELETE:
                    res = httpClient.DeleteAsync(path).Result;
                    break;

                case RequestMethod.PATCH:
#if NET6_0
                    res = httpClient.PatchAsync(path, JsonContent.Create(req, options: jso)).Result;
#endif
#if NET7_0_OR_GREATER || NET8_0_OR_GREATER
                    res = httpClient.PatchAsJsonAsync(path, req, jso).Result;
#endif
                    break;

                default:
                    throw new NotSupportedException();
            }

            return res
                .Content
                .ReadFromJsonAsync<TRes>(jso)
                .Result;
        }


        /// <summary>
        /// Возвращает общее количество запросов в сутки, разрешенное для пользователя, и остаток в текущих сутках.
        /// </summary>
        public Limit GetLimit() =>
            Send<Limit>(RequestMethod.GET, "/1.0/settings/limit");


        /// <summary>
        /// Рассчитывает стоимость пересылки в зависимости от указанных входных данных.
        /// Индекс ОПС точки отправления берется из профиля клиента.
        /// Возвращаемые значения указываются в копейках.
        /// </summary>
        public CalculationResponse Calculation(CalculationRequest request) =>
            Send<CalculationResponse, CalculationRequest>(RequestMethod.POST, "/1.0/tariff", request);


        /// <summary>
        /// Разделяет и помещает сущности переданных адресов (город, улица) в соответствующие поля возвращаемого объекта.
        /// Параметр id (идентификатор записи) используется для установления соответствия переданных и полученных записей, так как порядок сортировки возвращаемых записей не гарантируется.
        /// Метод автоматически ищет и возвращает индекс близлежащего ОПС по указанному адресу.
        /// Адрес считается корректным к отправке, если в ответе запроса:
        /// quality-code=GOOD, POSTAL_BOX, ON_DEMAND или UNDEF_05;
        /// validation-code=VALIDATED, OVERRIDDEN или CONFIRMED_MANUALLY.
        /// </summary>
        public List<CleanAddressResponse> CleanAddresses(params CleanAddressRequest[] requests) =>
            Send<List<CleanAddressResponse>, CleanAddressRequest[]>(RequestMethod.POST, "/1.0/clean/address", requests);


        /// <summary>
        /// Очищает, разделяет и помещает значения ФИО в соответствующие поля возвращаемого объекта.
        /// Параметр id (идентификатор записи) используется для установления соответствия переданных и полученных записей, так как порядок сортировки возвращаемых записей не гарантируется.
        /// </summary>
        public List<CleanPersonNameResponse> CleanPersonNames(params CleanPersonNameRequest[] requests) =>
            Send<List<CleanPersonNameResponse>, CleanPersonNameRequest[]>(RequestMethod.POST, "/1.0/clean/physical", requests);


        /// <summary>
        /// Принимает номера телефонов в неотформатированном виде, который может включать пробелы, символы: +-().
        /// Очищает, разделяет и помещает сущности телефона (код города, номер) в соответствующие поля возвращаемого объекта.
        /// Если номер телефона 11-ти значный (мобильный), то дополнительные параметры, кроме original-phone и id, указывать не обязательно.
        /// Если номер телефона стационарный, то необходимо опционально указать дополнительные параметры для определения кода города.
        /// Параметр id (идентификатор записи) используется для установления соответствия переданных и полученных записей, так как порядок сортировки возвращаемых записей не гарантируется.
        /// </summary>
        public List<CleanPhoneNumberResponse> CleanPhoneNumbers(params CleanPhoneNumberRequest[] requests) =>
            Send<List<CleanPhoneNumberResponse>, CleanPhoneNumberRequest[]>(RequestMethod.POST, "/1.0/clean/phone", requests);


        /// <summary>
        /// Выгружает данные ОПС, ПВЗ, Почтоматов из Паспорта ОПС.
        /// </summary>
        public DeliveryPointRegistry GetPostOffices()
        {
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/octet-stream"));

            var ms = new MemoryStream();
            var res = httpClient
                .GetAsync("/1.0/unloading-passport/zip?type=ALL")
                .Result;

            var fileName = res
                .Content
                ?.Headers
                ?.ContentDisposition
                ?.FileName;

            if (string.IsNullOrWhiteSpace(fileName))
                throw new FileNotFoundException();

            var fileTemplate = fileName[..fileName.IndexOf('.')];

            res
                .Content
                .ReadAsStream()
                .CopyTo(ms);

            if (ms.Length == 0)
                throw new Exception("Данные отсутствуют (пустой поток).");

            var zip = new ZipArchive(ms);
            foreach (var entry in zip.Entries)
            {
                if (entry.Name.StartsWith(fileTemplate))
                {
                    var stream = entry.Open();
                    return JsonSerializer.Deserialize<DeliveryPointRegistry>(stream, jso);
                }
            }
            return null;
        }
    }
}
