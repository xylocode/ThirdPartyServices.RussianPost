using System.Text.Json.Serialization;
using XyloCode.ThirdPartyServices.RussianPost.Enums;

namespace XyloCode.ThirdPartyServices.RussianPost.DeliveryPoints
{
    public class Address
    {
        [JsonPropertyName("addressType")]
        public AddressType? AddressType { get; set; }

        [JsonPropertyName("area")]
        public string Area { get; set; }

        [JsonPropertyName("house")]
        public string House { get; set; }

        [JsonPropertyName("index")]
        public string Index { get; set; }

        [JsonPropertyName("manualInput")]
        public bool? ManualInput { get; set; }

        [JsonPropertyName("place")]
        public string Place { get; set; }

        [JsonPropertyName("region")]
        public string Region { get; set; }

        [JsonPropertyName("street")]
        public string Street { get; set; }

        [JsonPropertyName("corpus")]
        public string Corpus { get; set; }
    }

}