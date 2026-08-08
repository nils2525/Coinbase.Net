using System.Text.Json.Serialization;
using CryptoExchange.Net.Attributes;
using CryptoExchange.Net.Converters.SystemTextJson;

namespace Coinbase.Net.Enums
{
    /// <summary>
    /// Travel Rule self-owned wallet value
    /// </summary>
    [JsonConverter(typeof(EnumConverter<CoinbaseTravelRuleIsSelf>))]
    public enum CoinbaseTravelRuleIsSelf
    {
        /// <summary>
        /// ["<c>IS_SELF_FALSE</c>"] Wallet is not owned by the user
        /// </summary>
        [Map("IS_SELF_FALSE")]
        False,

        /// <summary>
        /// ["<c>IS_SELF_TRUE</c>"] Wallet is owned by the user
        /// </summary>
        [Map("IS_SELF_TRUE")]
        True
    }
}
