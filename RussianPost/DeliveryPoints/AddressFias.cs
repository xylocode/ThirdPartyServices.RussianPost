using System;
using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.RussianPost.DeliveryPoints
{
    public class AddressFias
    {
        [JsonPropertyName("addGarCode")]
        public Guid? AddGarCode { get; set; }

        [JsonPropertyName("ads")]
        public string Ads { get; set; }

        [JsonPropertyName("locationGarCode")]
        public Guid? LocationGarCode { get; set; }

        [JsonPropertyName("regGarId")]
        public Guid? RegGarId { get; set; }
    }
}