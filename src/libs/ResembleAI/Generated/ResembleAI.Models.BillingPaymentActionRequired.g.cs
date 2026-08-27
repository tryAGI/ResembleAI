
#nullable enable

namespace ResembleAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BillingPaymentActionRequired
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requires_action")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool RequiresAction { get; set; }

        /// <summary>
        /// Client secret used to complete the required payment authentication.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_secret")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClientSecret { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingPaymentActionRequired" /> class.
        /// </summary>
        /// <param name="requiresAction"></param>
        /// <param name="clientSecret">
        /// Client secret used to complete the required payment authentication.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BillingPaymentActionRequired(
            bool requiresAction,
            string clientSecret)
        {
            this.RequiresAction = requiresAction;
            this.ClientSecret = clientSecret ?? throw new global::System.ArgumentNullException(nameof(clientSecret));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingPaymentActionRequired" /> class.
        /// </summary>
        public BillingPaymentActionRequired()
        {
        }

    }
}