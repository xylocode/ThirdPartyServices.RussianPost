using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.RussianPost.Calculation.Res
{
    public class DeliveryTime
    {
        [JsonPropertyName("max-days")]
        public int? MaxDays { get; set; }

        [JsonPropertyName("min-days")]
        public int? MinDays { get; set; }
    }
}