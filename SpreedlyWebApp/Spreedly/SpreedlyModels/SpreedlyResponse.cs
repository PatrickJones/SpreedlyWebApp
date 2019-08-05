using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpreedlyWebApp.Spreedly.SpreedlyModels
{
    [JsonObject("response")]
    public class SpreedlyResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("avs_code")]
        public string AvsCode { get; set; }

        [JsonProperty("avs_message")]
        public string AvsMessage { get; set; }

        [JsonProperty("cvv_code")]
        public string CvvCode { get; set; }

        [JsonProperty("cvv_message")]
        public string CvvMessage { get; set; }

        [JsonProperty("pending")]
        public bool Pending { get; set; }

        [JsonProperty("result_unknown")]
        public bool ResultUnknown { get; set; }

        [JsonProperty("error_code")]
        public string ErrorCode { get; set; }

        [JsonProperty("error_detail")]
        public string ErrorDetail { get; set; }

        [JsonProperty("cancelled")]
        public bool Cancelled { get; set; }

        [JsonProperty("fraud_review")]
        public string FraudReview { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }
    }
}