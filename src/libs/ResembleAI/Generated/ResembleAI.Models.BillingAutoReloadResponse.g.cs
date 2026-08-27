
#nullable enable

namespace ResembleAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BillingAutoReloadResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_reload")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ResembleAI.JsonConverters.OneOfJsonConverter<global::ResembleAI.BillingAutoReloadSetting, object>))]
        public global::ResembleAI.OneOf<global::ResembleAI.BillingAutoReloadSetting, object>? AutoReload { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minimum_reload_amount_cents")]
        public int? MinimumReloadAmountCents { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maximum_reload_amount_cents")]
        public int? MaximumReloadAmountCents { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingAutoReloadResponse" /> class.
        /// </summary>
        /// <param name="autoReload"></param>
        /// <param name="minimumReloadAmountCents"></param>
        /// <param name="maximumReloadAmountCents"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BillingAutoReloadResponse(
            global::ResembleAI.OneOf<global::ResembleAI.BillingAutoReloadSetting, object>? autoReload,
            int? minimumReloadAmountCents,
            int? maximumReloadAmountCents)
        {
            this.AutoReload = autoReload;
            this.MinimumReloadAmountCents = minimumReloadAmountCents;
            this.MaximumReloadAmountCents = maximumReloadAmountCents;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingAutoReloadResponse" /> class.
        /// </summary>
        public BillingAutoReloadResponse()
        {
        }

    }
}