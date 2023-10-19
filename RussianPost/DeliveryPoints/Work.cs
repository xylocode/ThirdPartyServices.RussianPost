using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.RussianPost.DeliveryPoints
{
    public class Work
    {
        [JsonPropertyName("dt")]
        public DateOnly Dt { get; set; }

        [JsonPropertyName("fn")]
        public TimeOnly? Fn { get; set; }

        [JsonPropertyName("nm")]
        public int Nm { get; set; }

        [JsonPropertyName("st")]
        public TimeOnly? St { get; set; }

        [JsonPropertyName("rst")]
        public List<Rst> Rst { get; set; }
    }

}