using Newtonsoft.Json;
using System;
using System.Text.Json.Serialization;

namespace IdentityAngular
{
    public class UserOrder
    {
        [JsonPropertyName("title")]
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        [JsonPropertyName("dateofpurchase")]
        [JsonProperty(PropertyName = "dateofpurchase")]
        public DateTime DateOfPurchase { get; set; }

        [JsonPropertyName("totlalamount")]
        [JsonProperty(PropertyName = "totlalamount")]
        public Double TotlalAmount { get; set; }

        [JsonPropertyName("status")]
        [JsonProperty(PropertyName = "status")]
        public bool Status { get; set; }
    }
}