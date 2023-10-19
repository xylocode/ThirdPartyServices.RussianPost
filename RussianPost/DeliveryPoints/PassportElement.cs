using System.Collections.Generic;
using System.Text.Json.Serialization;
using XyloCode.ThirdPartyServices.RussianPost.Helpers;

namespace XyloCode.ThirdPartyServices.RussianPost.DeliveryPoints
{
    public class PassportElement
    {
        [JsonPropertyName("address")]
        public Address Address { get; set; }

        [JsonPropertyName("addressFias")]
        public AddressFias AddressFias { get; set; }

        [JsonPropertyName("ecom")]
        [JsonConverter(typeof(StringAsNBooleanJsonConverter))]
        public bool? Ecom { get; set; }

        [JsonPropertyName("ecomOptions")]
        public EcomOptions EcomOptions { get; set; }

        [JsonPropertyName("latitude")]
        [JsonConverter(typeof(StringAsNDoubleJsonConverter))]
        public double? Latitude { get; set; }

        [JsonPropertyName("longitude")]
        [JsonConverter(typeof(StringAsNDoubleJsonConverter))]
        public double? Longitude { get; set; }

        [JsonPropertyName("onlineParcel")]
        [JsonConverter(typeof(StringAsNBooleanJsonConverter))]
        public bool? OnlineParcel { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("workTime")]
        public List<string> WorkTime { get; set; }

        [JsonPropertyName("holidays")]
        public List<Holiday> Holidays { get; set; }

        [JsonPropertyName("brandName")]
        public string BrandName { get; set; }
    }
}