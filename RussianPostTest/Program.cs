using XyloCode.ThirdPartyServices.RussianPost;
using XyloCode.ThirdPartyServices.RussianPost.Calculation.Req;
using XyloCode.ThirdPartyServices.RussianPost.CleanAddress;
using XyloCode.ThirdPartyServices.RussianPost.CleanPersonName;
using XyloCode.ThirdPartyServices.RussianPost.CleanPhoneNumber;
using XyloCode.ThirdPartyServices.RussianPost.Enums;
using XyloCode.ThirdPartyServices.RussianPost.Helpers;

namespace RussianPostTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get an access token on the website:
            // https://otpravka.pochta.ru/settings#/api-settings
            const string accessToken = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx";
            const string login = "i.ivanov@example.com"; // login for https://otpravka.pochta.ru/
            const string password = "xxxxxxxxxxxxxxxx"; // password for https://otpravka.pochta.ru/

            var tracer = new LoggingHandler();
            var api = new RussianPostClient(accessToken, login, password, httpMessageHandler: tracer);

            var req1 = new CleanAddressRequest
            {
                Id = Guid.NewGuid().ToString(),
                OriginalAddress = "125252, РОССИЯ, Г. МОСКВА, ВН.ТЕР.Г. МУНИЦИПАЛЬНЫЙ ОКРУГ ХОРОШЕВСКИЙ, 3-Я ПЕСЧАНАЯ УЛ., Д. 2А",
            };
            var res1 = api.CleanAddresses(req1);

            var req2 = new CleanPersonNameRequest
            {
                Id = Guid.NewGuid().ToString(),
                OriginalName = "Тинькофф Олег Юрьевич",
            };
            var res2 = api.CleanPersonNames(req2);

            var req3 = new CleanPhoneNumberRequest
            {
                Id = Guid.NewGuid().ToString(),
                OriginalPhone = "+7 (495) 739-47-12"
            };
            var res3 = api.CleanPhoneNumbers(req3);

            var res4 = api.GetPostOffices();

            var req5 = new CalculationRequest
            {
                IndexFrom = "125252",
                IndexTo = "630090",
                Mass = 1_300,
                PaymentMethod = PaymentMethod.CASHLESS, 
                Courier = true,
                DeclaredValue = 80_000_00,
                EntriesType = EntriesType.SALE_OF_GOODS,
                MailType = MailType.EMS,
                MailCategory = MailCategory.WITH_DECLARED_VALUE,
                TransportType = TransportType.STANDARD,
                DimensionType = DimensionType.S,
                SmsNoticeRecipient = 1,
            };
            var res5 = api.Calculation(req5);
            ;

        }
    }
}