
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdatePronunciationRequest
    {
        /// <summary>
        /// Set to false to disable, true to re-enable
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Active { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePronunciationRequest" /> class.
        /// </summary>
        /// <param name="active">
        /// Set to false to disable, true to re-enable
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdatePronunciationRequest(
            bool active)
        {
            this.Active = active;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePronunciationRequest" /> class.
        /// </summary>
        public UpdatePronunciationRequest()
        {
        }
    }
}