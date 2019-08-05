using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpreedlyWebApp.Spreedly.SpreedlyModels
{
    [JsonObject("payment_method")]
    public class SpreedlyPaymentMethod
    {
        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("data")]
        public SpreedlyData Data { get; set; }

        [JsonProperty("storage_state")]
        public string StorageState { get; set; }

        [JsonProperty("test")]
        public bool Test { get; set; }

        [JsonProperty("metadata")]
        public SpreedlyMetadata Metadata { get; set; }

        [JsonProperty("last_four_digits")]
        [JsonConverter(typeof(SpreedlyParseStringConverter))]
        public long LastFourDigits { get; set; }

        [JsonProperty("first_six_digits")]
        [JsonConverter(typeof(SpreedlyParseStringConverter))]
        public long FirstSixDigits { get; set; }

        [JsonProperty("card_type")]
        public string CardType { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("month")]
        public long Month { get; set; }

        [JsonProperty("year")]
        public long Year { get; set; }

        [JsonProperty("address1")]
        public string Address1 { get; set; }

        [JsonProperty("address2")]
        public string Address2 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("full_name")]
        public string FullName { get; set; }

        [JsonProperty("eligible_for_card_updater")]
        public string EligibleForCardUpdater { get; set; }

        [JsonProperty("shipping_address1")]
        public string ShippingAddress1 { get; set; }

        [JsonProperty("shipping_address2")]
        public string ShippingAddress2 { get; set; }

        [JsonProperty("shipping_city")]
        public string ShippingCity { get; set; }

        [JsonProperty("shipping_state")]
        public string ShippingState { get; set; }

        [JsonProperty("shipping_zip")]
        public string ShippingZip { get; set; }

        [JsonProperty("shipping_country")]
        public string ShippingCountry { get; set; }

        [JsonProperty("shipping_phone_number")]
        public string ShippingPhoneNumber { get; set; }

        [JsonProperty("payment_method_type")]
        public string PaymentMethodType { get; set; }

        [JsonProperty("errors")]
        public List<string> Errors { get; set; }

        [JsonProperty("fingerprint")]
        public string Fingerprint { get; set; }

        [JsonProperty("verification_value")]
        public string VerificationValue { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }
    }
}