using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpreedlyWebApp.Spreedly
{
    public class AppEnums
    {
        public enum SpreedlyTransactionResponseCodes
        {
            Success = 1,
            MissingAPIKey = 2,
            Error = 3,
            Fail = 4
        }
    }
}