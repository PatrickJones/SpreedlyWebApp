using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpreedlyWebApp.Spreedly.SpreedlyModels
{
    [JsonObject("transaction")]
    public class SpreedlyTransaction
    {
        [JsonProperty("on_test_gateway")]
        public bool OnTestGateway { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }

        [JsonProperty("succeeded")]
        public bool Succeeded { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("transaction_type")]
        public string TransactionType { get; set; }

        [JsonProperty("order_id")]
        public string OrderId { get; set; }

        [JsonProperty("ip")]
        public string Ip { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("merchant_name_descriptor")]
        public string MerchantNameDescriptor { get; set; }

        [JsonProperty("merchant_location_descriptor")]
        public string MerchantLocationDescriptor { get; set; }

        [JsonProperty("gateway_specific_fields")]
        public string GatewaySpecificFields { get; set; }

        [JsonProperty("gateway_specific_response_fields")]
        public SpreedlyGatewaySpecificResponseFields GatewaySpecificResponseFields { get; set; }

        [JsonProperty("gateway_transaction_id")]
        [JsonConverter(typeof(SpreedlyParseStringConverter))]
        public long GatewayTransactionId { get; set; }

        [JsonProperty("gateway_latency_ms")]
        public long GatewayLatencyMs { get; set; }

        [JsonProperty("amount")]
        public long Amount { get; set; }

        [JsonProperty("currency_code")]
        public string CurrencyCode { get; set; }

        [JsonProperty("retain_on_success")]
        public bool RetainOnSuccess { get; set; }

        [JsonProperty("payment_method_added")]
        public bool PaymentMethodAdded { get; set; }

        [JsonProperty("message_key")]
        public string MessageKey { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("gateway_token")]
        public string GatewayToken { get; set; }

        [JsonProperty("gateway_type")]
        public string GatewayType { get; set; }

        [JsonProperty("response")]
        public SpreedlyResponse Response { get; set; }

        [JsonProperty("shipping_address")]
        public SpreedlyShippingAddress ShippingAddress { get; set; }

        [JsonProperty("api_urls")]
        public List<SpreedlyApiUrl> ApiUrls { get; set; }

        [JsonProperty("payment_method")]
        public SpreedlyPaymentMethod PaymentMethod { get; set; }
    }
}