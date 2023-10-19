using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.RussianPost.CleanPhoneNumber
{
    public class CleanPhoneNumberRequest
    {
        /// <summary>
        /// Идентификатор записи.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }


        /// <summary>
        /// Область/край трелефонного номера.
        /// </summary>
        [JsonPropertyName("area")]
        public string Area { get; set; }

        /// <summary>
        /// Оригинальные номер одной строкой.
        /// </summary>
        [JsonPropertyName("original-phone")]
        public string OriginalPhone { get; set; }


        /// <summary>
        /// Город телефонного номера.
        /// </summary>
        [JsonPropertyName("place")]
        public string Place { get; set; }


        /// <summary>
        /// Регион телефонного номера.
        /// </summary>
        [JsonPropertyName("region")]
        public string Region { get; set; }
    }
}
