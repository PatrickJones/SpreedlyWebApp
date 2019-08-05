using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpreedlyWebApp.Spreedly.SpreedlyModels
{
    [JsonObject("api_urls")]
    public class SpreedlyApiUrl
    {
        [JsonProperty("referencing_transaction")]
        public List<string> ReferencingTransaction { get; set; }
    }
}