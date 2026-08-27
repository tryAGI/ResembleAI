
#nullable enable

namespace ResembleAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BillingForbiddenError
    {
        /// <summary>
        /// Human-readable authorization or eligibility error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Error { get; set; }

        /// <summary>
        /// Machine-readable error code when one is available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string? ErrorCode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingForbiddenError" /> class.
        /// </summary>
        /// <param name="error">
        /// Human-readable authorization or eligibility error.
        /// </param>
        /// <param name="errorCode">
        /// Machine-readable error code when one is available.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BillingForbiddenError(
            string error,
            string? errorCode)
        {
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingForbiddenError" /> class.
        /// </summary>
        public BillingForbiddenError()
        {
        }

    }
}