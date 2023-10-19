# Russian Post API client library

Unofficial .NET library for accessing the Russian Post API with partial implementation (postoffice list, calculator, normalization of postal addresses, names and telephone numbers).

- [NuGet](https://www.nuget.org/packages/XyloCode.ThirdPartyServices.RussianPost) (.NET library)
- [GitHub](https://github.com/xylocode/ThirdPartyServices.RussianPost) (source code)
- [Official documentation](https://otpravka.pochta.ru/specification)

#### Supported Platforms

- .NET 6.0 LTS;
- .NET 7.0.

## Russian Post

Russian Post (Russian: Почта России, Pochta Rossii) is the national postal operator of Russia. The company is responsible for the delivery of mail in Russia, and the issuing of postage stamps. Russian Post employs about 390,000 people and has over 42,000 post offices, with its headquarters in Moscow.

Official website: [https://www.pochta.ru/](https://www.pochta.ru/).

## Supported Methods

- List of post offices
- Normalization of postal address
- Normalization of the surname and given names of the correspondent
- Phone number normalization
- Shipping cost calculation
- Information about the user's limits (the total number of requests per day allowed for the user and the balance in the current day)

## How to use

```cs
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
            var res = api.Calculation(req5);
            ;

        }
    }
}
```

## License

MIT License
