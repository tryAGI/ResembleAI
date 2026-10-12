
#nullable enable

namespace ResembleAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateMusicDetectionRequest
    {
        /// <summary>
        /// The audio file to analyze. Must be 150 MB or smaller.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] File { get; set; }

        /// <summary>
        /// The audio file to analyze. Must be 150 MB or smaller.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filename { get; set; }

        /// <summary>
        /// Display name for the detection. Defaults to the source filename.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// POST destination for the result once processing finishes. The body matches the response of `GET /detect/{uuid}`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callback_url")]
        public string? CallbackUrl { get; set; }

        /// <summary>
        /// Return a base64-encoded heatmap image in `metrics.image`.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visualize")]
        public bool? Visualize { get; set; }

        /// <summary>
        /// Start of the segment to analyze, in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_region")]
        public double? StartRegion { get; set; }

        /// <summary>
        /// End of the segment to analyze, in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_region")]
        public double? EndRegion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMusicDetectionRequest" /> class.
        /// </summary>
        /// <param name="file">
        /// The audio file to analyze. Must be 150 MB or smaller.
        /// </param>
        /// <param name="filename">
        /// The audio file to analyze. Must be 150 MB or smaller.
        /// </param>
        /// <param name="name">
        /// Display name for the detection. Defaults to the source filename.
        /// </param>
        /// <param name="callbackUrl">
        /// POST destination for the result once processing finishes. The body matches the response of `GET /detect/{uuid}`.
        /// </param>
        /// <param name="visualize">
        /// Return a base64-encoded heatmap image in `metrics.image`.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="startRegion">
        /// Start of the segment to analyze, in seconds.
        /// </param>
        /// <param name="endRegion">
        /// End of the segment to analyze, in seconds.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateMusicDetectionRequest(
            byte[] file,
            string filename,
            string? name,
            string? callbackUrl,
            bool? visualize,
            double? startRegion,
            double? endRegion)
        {
            this.File = file ?? throw new global::System.ArgumentNullException(nameof(file));
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.Name = name;
            this.CallbackUrl = callbackUrl;
            this.Visualize = visualize;
            this.StartRegion = startRegion;
            this.EndRegion = endRegion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMusicDetectionRequest" /> class.
        /// </summary>
        public CreateMusicDetectionRequest()
        {
        }

    }
}