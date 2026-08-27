
#nullable enable

namespace ResembleAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BillingSubscriptionResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscription")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ResembleAI.JsonConverters.OneOfJsonConverter<global::ResembleAI.BillingSubscription, object>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ResembleAI.OneOf<global::ResembleAI.BillingSubscription, object> Subscription { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingSubscriptionResponse" /> class.
        /// </summary>
        /// <param name="subscription"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BillingSubscriptionResponse(
            global::ResembleAI.OneOf<global::ResembleAI.BillingSubscription, object> subscription)
        {
            this.Subscription = subscription;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingSubscriptionResponse" /> class.
        /// </summary>
        public BillingSubscriptionResponse()
        {
        }

    }
}