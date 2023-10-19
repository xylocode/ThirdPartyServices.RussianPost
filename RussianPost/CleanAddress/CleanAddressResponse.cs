using System.Text.Json.Serialization;
using XyloCode.ThirdPartyServices.RussianPost.Enums;

namespace XyloCode.ThirdPartyServices.RussianPost.CleanAddress
{
    public class CleanAddressResponse
    {
        [JsonPropertyName("address-type")]
        public AddressType AddressType { get; set; }

        [JsonPropertyName("area")]
        public string Area { get; set; }

        [JsonPropertyName("building")]
        public string Building { get; set; }

        [JsonPropertyName("corpus")]
        public string Corpus { get; set; }

        [JsonPropertyName("hotel")]
        public string Hotel { get; set; }

        [JsonPropertyName("house")]
        public string House { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("index")]
        public string Index { get; set; }

        [JsonPropertyName("letter")]
        public string Letter { get; set; }

        [JsonPropertyName("location")]
        public string Location { get; set; }

        [JsonPropertyName("num-address-type")]
        public string NumAddressType { get; set; }

        [JsonPropertyName("original-address")]
        public string OriginalAddress { get; set; }

        [JsonPropertyName("place")]
        public string Place { get; set; }

        [JsonPropertyName("quality-code")]
        public QualityCode QualityCode { get; set; }

        [JsonPropertyName("region")]
        public string Region { get; set; }

        [JsonPropertyName("room")]
        public string Room { get; set; }

        [JsonPropertyName("slash")]
        public string Slash { get; set; }

        [JsonPropertyName("street")]
        public string Street { get; set; }

        [JsonPropertyName("validation-code")]
        public ValidationCode ValidationCode { get; set; }
    }
}
