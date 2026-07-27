
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// Content Credentials (C2PA) verification result for audio, image, and video media. Returned when verification has completed. A fallback verification failure returns `validation_state: Unavailable` and does not fail the detection.
    /// </summary>
    public sealed partial class DetectC2paManifest
    {
        /// <summary>
        /// Verification state. `NotPresent` means no embedded Content Credentials were found; `Unavailable` means verification could not complete.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("validation_state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ResembleAI.JsonConverters.DetectC2PaManifestValidationStateJsonConverter))]
        public global::ResembleAI.DetectC2PaManifestValidationState? ValidationState { get; set; }

        /// <summary>
        /// Active C2PA manifest identifier when credentials are present
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active_manifest")]
        public string? ActiveManifest { get; set; }

        /// <summary>
        /// Raw manifest details returned by C2PA tooling
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("manifests")]
        public object? Manifests { get; set; }

        /// <summary>
        /// Detailed validation results returned by C2PA tooling
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("validation_results")]
        public object? ValidationResults { get; set; }

        /// <summary>
        /// Generic message when verification is unavailable
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DetectC2paManifest" /> class.
        /// </summary>
        /// <param name="validationState">
        /// Verification state. `NotPresent` means no embedded Content Credentials were found; `Unavailable` means verification could not complete.
        /// </param>
        /// <param name="activeManifest">
        /// Active C2PA manifest identifier when credentials are present
        /// </param>
        /// <param name="manifests">
        /// Raw manifest details returned by C2PA tooling
        /// </param>
        /// <param name="validationResults">
        /// Detailed validation results returned by C2PA tooling
        /// </param>
        /// <param name="message">
        /// Generic message when verification is unavailable
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DetectC2paManifest(
            global::ResembleAI.DetectC2PaManifestValidationState? validationState,
            string? activeManifest,
            object? manifests,
            object? validationResults,
            string? message)
        {
            this.ValidationState = validationState;
            this.ActiveManifest = activeManifest;
            this.Manifests = manifests;
            this.ValidationResults = validationResults;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DetectC2paManifest" /> class.
        /// </summary>
        public DetectC2paManifest()
        {
        }

    }
}