
#nullable enable

namespace ResembleAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BillingWalletUpdateBillingAutoReloadResponse200
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_reload")]
        public global::ResembleAI.BillingAutoReloadSetting? AutoReload { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingWalletUpdateBillingAutoReloadResponse200" /> class.
        /// </summary>
        /// <param name="autoReload"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BillingWalletUpdateBillingAutoReloadResponse200(
            global::ResembleAI.BillingAutoReloadSetting? autoReload)
        {
            this.AutoReload = autoReload;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingWalletUpdateBillingAutoReloadResponse200" /> class.
        /// </summary>
        public BillingWalletUpdateBillingAutoReloadResponse200()
        {
        }

    }
}