using System;
using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.RussianPost.DeliveryPoints
{
    public class Rst
    {
        [JsonPropertyName("fn")]
        public TimeOnly Fn { get; set; }

        [JsonPropertyName("st")]
        public TimeOnly St { get; set; }
    }
}