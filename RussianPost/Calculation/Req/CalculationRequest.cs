using System.Text.Json.Serialization;
using XyloCode.ThirdPartyServices.RussianPost.Enums;

namespace XyloCode.ThirdPartyServices.RussianPost.Calculation.Req
{
    public class CalculationRequest
    {
        /// <summary>
        /// Признак услуги проверки комплектности
        /// </summary>
        [JsonPropertyName("completeness-checking")]
        public bool? CompletenessChecking { get; set; }


        /// <summary>
        /// Отметка "Курьер"
        /// </summary>
        [JsonPropertyName("courier")]
        public bool? Courier { get; set; }


        /// <summary>
        /// Объявленная ценность
        /// </summary>
        [JsonPropertyName("declared-value")]
        public int? DeclaredValue { get; set; }

        [JsonPropertyName("dimension")]
        public Dimension Dimension { get; set; }

        [JsonPropertyName("dimension-type")]
        public DimensionType? DimensionType { get; set; }

        [JsonPropertyName("entries-type")]
        public EntriesType? EntriesType { get; set; }

        [JsonPropertyName("fragile")]
        public bool? Fragile { get; set; }

        [JsonPropertyName("index-from")]
        public string IndexFrom { get; set; }

        [JsonPropertyName("index-to")]
        public string IndexTo { get; set; }

        [JsonPropertyName("mail-category")]
        public MailCategory? MailCategory { get; set; }

        [JsonPropertyName("mail-direct")]
        public int? MailDirect { get; set; }

        [JsonPropertyName("mail-type")]
        public MailType? MailType { get; set; }

        [JsonPropertyName("mass")]
        public int? Mass { get; set; }

        [JsonPropertyName("notice-payment-method")]
        public PaymentMethod? NoticePaymentMethod { get; set; }

        [JsonPropertyName("payment-method")]
        public PaymentMethod? PaymentMethod { get; set; }

        [JsonPropertyName("sms-notice-recipient")]
        public int? SmsNoticeRecipient { get; set; }

        [JsonPropertyName("transport-type")]
        public TransportType? TransportType { get; set; }

        [JsonPropertyName("with-order-of-notice")]
        public bool? WithOrderOfNotice { get; set; }

        [JsonPropertyName("with-simple-notice")]
        public bool? WithSimpleNotice { get; set; }
    }
}
