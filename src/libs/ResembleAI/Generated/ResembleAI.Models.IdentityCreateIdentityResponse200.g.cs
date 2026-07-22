
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IdentityCreateIdentityResponse200
    {
        /// <summary>
        /// Whether the voice was enrolled for matching immediately
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        public bool? Success { get; set; }

        /// <summary>
        /// Identity summary returned by the list and simple-create endpoints
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item")]
        public global::ResembleAI.IdentitySummary? Item { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IdentityCreateIdentityResponse200" /> class.
        /// </summary>
        /// <param name="success">
        /// Whether the voice was enrolled for matching immediately
        /// </param>
        /// <param name="item">
        /// Identity summary returned by the list and simple-create endpoints
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IdentityCreateIdentityResponse200(
            bool? success,
            global::ResembleAI.IdentitySummary? item)
        {
            this.Success = success;
            this.Item = item;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IdentityCreateIdentityResponse200" /> class.
        /// </summary>
        public IdentityCreateIdentityResponse200()
        {
        }

    }
}