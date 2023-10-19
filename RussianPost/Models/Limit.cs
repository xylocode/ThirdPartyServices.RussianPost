using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.RussianPost.Models
{
    public class Limit
    {
        /// <summary>
        /// Количество запросов по API разрешенных для клиента
        /// </summary>
        [JsonPropertyName("allowed-count")]
        public int? AllowedCount { get; set; }

        /// <summary>
        /// Текущее количество по API у клиента
        /// </summary>
        [JsonPropertyName("current-count")]
        public int? CurrentCount { get; set; }
    }
}
