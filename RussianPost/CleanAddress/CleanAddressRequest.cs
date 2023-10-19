using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.RussianPost.CleanAddress
{
    /// <summary>
    /// Запрос на нормализацию адреса.
    /// </summary>
    public class CleanAddressRequest
    {
        /// <summary>
        /// Идентификатор записи.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }


        /// <summary>
        /// Оригинальные адрес одной строкой.
        /// </summary>
        [JsonPropertyName("original-address")]
        public string OriginalAddress { get; set; }
    }
}
