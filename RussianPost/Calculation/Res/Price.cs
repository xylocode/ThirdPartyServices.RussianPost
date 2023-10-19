using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.RussianPost.Calculation.Res
{
    public class Price
    {
        [JsonPropertyName("rate")]
        public int? Value { get; set; }

        [JsonPropertyName("vat")]
        public int? Vat { get; set; }
    }
}