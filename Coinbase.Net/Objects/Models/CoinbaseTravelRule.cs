using Coinbase.Net.Enums;
using CryptoExchange.Net.Converters.SystemTextJson;
using System.Text.Json.Serialization;

namespace Coinbase.Net.Objects.Models
{
    /// <summary>
    /// Travel Rule data for a crypto send
    /// </summary>
    [SerializationModel]
    public record CoinbaseTravelRule
    {
        /// <summary>
        /// ["<c>beneficiary_wallet_type</c>"] Beneficiary wallet type
        /// </summary>
        [JsonPropertyName("beneficiary_wallet_type")]
        public CoinbaseTravelRuleBeneficiaryWalletType? BeneficiaryWalletType { get; set; }

        /// <summary>
        /// ["<c>is_self</c>"] Whether the transfer is to a wallet owned by the user
        /// </summary>
        [JsonPropertyName("is_self")]
        public CoinbaseTravelRuleIsSelf? IsSelf { get; set; }

        /// <summary>
        /// ["<c>beneficiary_name</c>"] Beneficiary full name
        /// </summary>
        [JsonPropertyName("beneficiary_name")]
        public string? BeneficiaryName { get; set; }

        /// <summary>
        /// ["<c>beneficiary_address</c>"] Beneficiary postal address
        /// </summary>
        [JsonPropertyName("beneficiary_address")]
        public CoinbaseTravelRuleBeneficiaryAddress? BeneficiaryAddress { get; set; }

        /// <summary>
        /// ["<c>beneficiary_financial_institution</c>"] Beneficiary financial institution or virtual asset provider id
        /// </summary>
        [JsonPropertyName("beneficiary_financial_institution")]
        public string? BeneficiaryFinancialInstitution { get; set; }

        /// <summary>
        /// ["<c>transfer_purpose</c>"] Transfer purpose
        /// </summary>
        [JsonPropertyName("transfer_purpose")]
        public string? TransferPurpose { get; set; }
    }
}
