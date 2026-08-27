
#nullable enable

namespace ResembleAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BillingWalletResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wallet")]
        public global::ResembleAI.BillingWallet? Wallet { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingWalletResponse" /> class.
        /// </summary>
        /// <param name="wallet"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BillingWalletResponse(
            global::ResembleAI.BillingWallet? wallet)
        {
            this.Wallet = wallet;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingWalletResponse" /> class.
        /// </summary>
        public BillingWalletResponse()
        {
        }

    }
}