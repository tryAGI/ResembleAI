
#nullable enable

namespace ResembleAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class IdentityCreateIdentityRequest0
    {
        /// <summary>
        /// Speaker name/identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// URL to an audio sample (one of url, audio, signed_id is required)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Signed ID from a secure upload
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signed_id")]
        public string? SignedId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IdentityCreateIdentityRequest0" /> class.
        /// </summary>
        /// <param name="name">
        /// Speaker name/identifier
        /// </param>
        /// <param name="url">
        /// URL to an audio sample (one of url, audio, signed_id is required)
        /// </param>
        /// <param name="signedId">
        /// Signed ID from a secure upload
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IdentityCreateIdentityRequest0(
            string name,
            string? url,
            string? signedId)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Url = url;
            this.SignedId = signedId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IdentityCreateIdentityRequest0" /> class.
        /// </summary>
        public IdentityCreateIdentityRequest0()
        {
        }

    }
}