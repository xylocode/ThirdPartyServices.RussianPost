using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.RussianPost.DeliveryPoints
{
    public class DeliveryPointRegistry
    {
        [JsonPropertyName("passportElements")]
        public List<PassportElement> PassportElements { get; set; }

        [JsonPropertyName("unloadingDate")]
        public DateTime? UnloadingDate { get; set; }

        [JsonPropertyName("vsnapshot")]
        public string Vsnapshot { get; set; }
    }
}
