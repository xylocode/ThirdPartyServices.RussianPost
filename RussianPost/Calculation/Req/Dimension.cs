using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.RussianPost.Calculation.Req
{
    public class Dimension
    {
        [JsonPropertyName("height")]
        public int? Height { get; set; }

        [JsonPropertyName("length")]
        public int? Length { get; set; }

        [JsonPropertyName("width")]
        public int? Width { get; set; }
    }
}
