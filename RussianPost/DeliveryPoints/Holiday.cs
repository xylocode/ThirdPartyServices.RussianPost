using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.RussianPost.DeliveryPoints
{
    public class Holiday
    {
        [JsonPropertyName("df")]
        public DateOnly Df { get; set; }

        [JsonPropertyName("ds")]
        public DateOnly Ds { get; set; }

        [JsonPropertyName("work")]
        public List<Work> Work { get; set; }
    }
}