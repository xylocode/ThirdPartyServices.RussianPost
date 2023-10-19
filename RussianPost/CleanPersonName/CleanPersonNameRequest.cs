using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.RussianPost.CleanPersonName
{
    /// <summary>
    /// Запрос нормализации ФИО
    /// </summary>
    public class CleanPersonNameRequest
    {
        /// <summary>
        /// Идентификатор записи.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Оригинальные фамилия, имя , отчество одной строкой.
        /// </summary>
        [JsonPropertyName("original-fio")]
        public string OriginalName { get; set; }
    }
}
