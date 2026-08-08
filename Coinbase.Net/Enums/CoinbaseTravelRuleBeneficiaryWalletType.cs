using System.Text.Json.Serialization;
using CryptoExchange.Net.Attributes;
using CryptoExchange.Net.Converters.SystemTextJson;

namespace Coinbase.Net.Enums
{
    /// <summary>
    /// Travel Rule beneficiary wallet type
    /// </summary>
    [JsonConverter(typeof(EnumConverter<CoinbaseTravelRuleBeneficiaryWalletType>))]
    public enum CoinbaseTravelRuleBeneficiaryWalletType
    {
        /// <summary>
        /// ["<c>WALLET_TYPE_SELF_HOSTED</c>"] Self hosted wallet
        /// </summary>
        [Map("WALLET_TYPE_SELF_HOSTED")]
        SelfHosted,

        /// <summary>
        /// ["<c>WALLET_TYPE_EXCHANGE</c>"] Exchange wallet
        /// </summary>
        [Map("WALLET_TYPE_EXCHANGE", "WALLET_TYPE_SELF_EXCHANGE")]
        Exchange
    }
}
