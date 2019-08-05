using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpreedlyWebApp.Spreedly.SpreedlyModels
{
    public class SpreedlyExtraStuff
    {
        [JsonProperty("some_other_things")]
        public string SomeOtherThings { get; set; }
    }
}