using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpreedlyWebApp.Spreedly.SpreedlyModels
{
    [JsonObject("transaction")]
    public class SpreedlyTransactionRequest
    {
        [JsonProperty("payment_method_token")]
        public string PaymentMethodToken { get; set; }

        [JsonProperty("amount")]
        public long Amount { get; set; }

        [JsonProperty("currency_code")]
        public string CurrencyCode { get; set; }

        [JsonProperty("retain_on_success")]
        public bool RetainOnSuccess { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}