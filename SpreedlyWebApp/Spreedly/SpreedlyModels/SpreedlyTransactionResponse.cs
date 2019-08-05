using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpreedlyWebApp.Spreedly.SpreedlyModels
{
    public class SpreedlyTransactionResponse
    {
        //public static SpreedlyTransactionResponse FromJson(string json) => JsonConvert.DeserializeObject<SpreedlyTransactionResponse>(json, SpreedlyConverter.Settings);
        [JsonProperty("transaction")]
        public SpreedlyTransaction Transaction { get; set; }
    }
}