using CryptoExchange.Net.Converters.SystemTextJson;
using System.Text.Json.Serialization;

namespace Coinbase.Net.Objects.Models
{
    /// <summary>
    /// Travel Rule beneficiary postal address
    /// </summary>
    [SerializationModel]
    public record CoinbaseTravelRuleBeneficiaryAddress
    {
        /// <summary>
        /// ["<c>address1</c>"] First address line
        /// </summary>
        [JsonPropertyName("address1")]
        public string? Address1 { get; set; }

        /// <summary>
        /// ["<c>address2</c>"] Second address line
        /// </summary>
        [JsonPropertyName("address2")]
        public string? Address2 { get; set; }

        /// <summary>
        /// ["<c>address3</c>"] Third address line
        /// </summary>
        [JsonPropertyName("address3")]
        public string? Address3 { get; set; }

        /// <summary>
        /// ["<c>city</c>"] City
        /// </summary>
        [JsonPropertyName("city")]
        public string? City { get; set; }

        /// <summary>
        /// ["<c>state</c>"] State or region
        /// </summary>
        [JsonPropertyName("state")]
        public string? State { get; set; }

        /// <summary>
        /// ["<c>country</c>"] ISO country code
        /// </summary>
        [JsonPropertyName("country")]
        public string? Country { get; set; }

        /// <summary>
        /// ["<c>postal_code</c>"] Postal code
        /// </summary>
        [JsonPropertyName("postal_code")]
        public string? PostalCode { get; set; }
    }
}
