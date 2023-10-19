using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.RussianPost.Calculation.Res
{
    public class CalculationResponse
    {
        [JsonPropertyName("avia-rate")]
        public Price AviaRate { get; set; }

        [JsonPropertyName("completeness-checking-rate")]
        public Price CompletenessCheckingRate { get; set; }

        [JsonPropertyName("delivery-time")]
        public DeliveryTime DeliveryTime { get; set; }

        [JsonPropertyName("fragile-rate")]
        public Price FragileRate { get; set; }

        [JsonPropertyName("ground-rate")]
        public Price GroundRate { get; set; }

        [JsonPropertyName("insurance-rate")]
        public Price InsuranceRate { get; set; }

        [JsonPropertyName("notice-payment-method")]
        public string NoticePaymentMethod { get; set; }

        [JsonPropertyName("notice-rate")]
        public Price NoticeRate { get; set; }

        [JsonPropertyName("oversize-rate")]
        public Price OversizeRate { get; set; }

        [JsonPropertyName("payment-method")]
        public string PaymentMethod { get; set; }

        [JsonPropertyName("sms-notice-recipient-rate")]
        public Price SmsNoticeRecipientRate { get; set; }

        [JsonPropertyName("total-rate")]
        public int? TotalRate { get; set; }

        [JsonPropertyName("total-vat")]
        public int? TotalVat { get; set; }
    }
}
