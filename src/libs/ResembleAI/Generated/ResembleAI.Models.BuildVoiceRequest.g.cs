
#nullable enable

namespace ResembleAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BuildVoiceRequest
    {
        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fill")]
        public bool? Fill { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildVoiceRequest" /> class.
        /// </summary>
        /// <param name="fill">
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BuildVoiceRequest(
            bool? fill)
        {
            this.Fill = fill;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildVoiceRequest" /> class.
        /// </summary>
        public BuildVoiceRequest()
        {
        }

    }
}