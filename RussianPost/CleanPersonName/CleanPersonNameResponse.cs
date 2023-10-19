using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.RussianPost.CleanPersonName
{
    public class CleanPersonNameResponse
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("middle-name")]
        public string MiddleName { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("original-fio")]
        public string OriginalFio { get; set; }


        /// <summary>
        /// Код качества нормализации ФИО.
        /// </summary>
        [JsonPropertyName("quality-code")]
        public QualityCode QualityCode { get; set; }


        [JsonPropertyName("surname")]
        public string Surname { get; set; }


        /// <summary>
        /// Приемлемое ли качество произведенной очистки.
        /// </summary>
        [JsonPropertyName("valid")]
        public bool? Valid { get; set; }
    }
}
