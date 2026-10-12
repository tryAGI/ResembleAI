
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// Request metadata. Music detections always include `detector` set to `music`.
    /// </summary>
    public sealed partial class MusicDetectItemExtraParams
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detector")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ResembleAI.JsonConverters.MusicDetectItemExtraParamsDetectorJsonConverter))]
        public global::ResembleAI.MusicDetectItemExtraParamsDetector? Detector { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MusicDetectItemExtraParams" /> class.
        /// </summary>
        /// <param name="detector"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MusicDetectItemExtraParams(
            global::ResembleAI.MusicDetectItemExtraParamsDetector? detector)
        {
            this.Detector = detector;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MusicDetectItemExtraParams" /> class.
        /// </summary>
        public MusicDetectItemExtraParams()
        {
        }

    }
}