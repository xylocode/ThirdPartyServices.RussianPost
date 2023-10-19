using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.RussianPost.CleanPhoneNumber
{
    public class CleanPhoneNumberResponse
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("original-phone")]
        public string OriginalPhone { get; set; }

        [JsonPropertyName("phone-city-code")]
        public string PhoneCityCode { get; set; }

        [JsonPropertyName("phone-country-code")]
        public string PhoneCountryCode { get; set; }

        [JsonPropertyName("phone-extension")]
        public string PhoneExtension { get; set; }

        [JsonPropertyName("phone-number")]
        public string PhoneNumber { get; set; }

        [JsonPropertyName("quality-code")]
        public QualityCode QualityCode { get; set; }
    }
}
