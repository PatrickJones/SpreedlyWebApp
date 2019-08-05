using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpreedlyWebApp.Spreedly.SpreedlyModels
{
    public class SpreedlyMetadata
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("another_key")]
        public long AnotherKey { get; set; }

        [JsonProperty("final_key")]
        public bool FinalKey { get; set; }
    }
}