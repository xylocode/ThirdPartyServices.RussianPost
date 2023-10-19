using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.RussianPost.DeliveryPoints
{
    public class EcomOptions
    {
        [JsonPropertyName("cardPayment")]
        public bool? CardPayment { get; set; }

        [JsonPropertyName("cashPayment")]
        public bool? CashPayment { get; set; }

        [JsonPropertyName("contentsChecking")]
        public bool? ContentsChecking { get; set; }

        [JsonPropertyName("functionalityChecking")]
        public bool? FunctionalityChecking { get; set; }

        [JsonPropertyName("partialRedemption")]
        public bool? PartialRedemption { get; set; }

        [JsonPropertyName("returnAvailable")]
        public bool? ReturnAvailable { get; set; }

        [JsonPropertyName("weightLimit")]
        public double? WeightLimit { get; set; }

        [JsonPropertyName("withFitting")]
        public bool? WithFitting { get; set; }

        [JsonPropertyName("brandName")]
        public string BrandName { get; set; }

        [JsonPropertyName("getto")]
        public string Getto { get; set; }
    }
}