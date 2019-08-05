using Newtonsoft.Json;
using SpreedlyWebApp.Spreedly.SpreedlyModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpreedlyWebApp.Spreedly
{
    public static class SpreedlySerialize
    {
        public static string ToJson(this SpreedlyTransactionResponse self) => JsonConvert.SerializeObject(self, SpreedlyConverter.Settings);
    }
}