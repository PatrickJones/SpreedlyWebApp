using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpreedlyWebApp.Spreedly.SpreedlyModels
{
    public class SpreedlyData
    {
        [JsonProperty("my_payment_method_identifier")]
        [JsonConverter(typeof(SpreedlyParseStringConverter))]
        public long MyPaymentMethodIdentifier { get; set; }

        [JsonProperty("extra_stuff")]
        public SpreedlyExtraStuff ExtraStuff { get; set; }
    }
}