
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDetectionRequest
    {
        /// <summary>
        /// HTTPS URL to audio, image, or video file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// POST destination when analysis completes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callback_url")]
        public string? CallbackUrl { get; set; }

        /// <summary>
        /// Generate visualization artifacts
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visualize")]
        public bool? Visualize { get; set; }

        /// <summary>
        /// Window size in seconds (audio/video)<br/>
        /// Default Value: 2
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frame_length")]
        public int? FrameLength { get; set; }

        /// <summary>
        /// Start of segment to analyze (seconds)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_region")]
        public double? StartRegion { get; set; }

        /// <summary>
        /// End of segment to analyze (seconds)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_region")]
        public double? EndRegion { get; set; }

        /// <summary>
        /// Downsample high-frame-rate media
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_video_fps")]
        public double? MaxVideoFps { get; set; }

        /// <summary>
        /// Cap processed duration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_video_secs")]
        public double? MaxVideoSecs { get; set; }

        /// <summary>
        /// Use talking_head for face-swaps
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_types")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ResembleAI.JsonConverters.DetectPostRequestBodyContentApplicationJsonSchemaModelTypesJsonConverter))]
        public global::ResembleAI.DetectPostRequestBodyContentApplicationJsonSchemaModelTypes? ModelTypes { get; set; }

        /// <summary>
        /// Run multimodal intelligence analysis on the media<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("intelligence")]
        public bool? Intelligence { get; set; }

        /// <summary>
        /// Enable audio source tracing to identify synthetic audio origin<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_source_tracing")]
        public bool? AudioSourceTracing { get; set; }

        /// <summary>
        /// Enable reverse image search to improve detection accuracy for image files. Searches the web for matching images and uses AI to classify whether the match indicates a known fake. Only applies to image detections.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_reverse_search")]
        public bool? UseReverseSearch { get; set; }

        /// <summary>
        /// Enable out-of-distribution detection<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_ood_detector")]
        public bool? UseOodDetector { get; set; }

        /// <summary>
        /// Enable Zero Retention Mode to automatically delete submitted media after detection completes. When enabled, media URLs are redacted and the filename is tokenized.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("zero_retention_mode")]
        public bool? ZeroRetentionMode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDetectionRequest" /> class.
        /// </summary>
        /// <param name="url">
        /// HTTPS URL to audio, image, or video file
        /// </param>
        /// <param name="callbackUrl">
        /// POST destination when analysis completes
        /// </param>
        /// <param name="visualize">
        /// Generate visualization artifacts
        /// </param>
        /// <param name="frameLength">
        /// Window size in seconds (audio/video)<br/>
        /// Default Value: 2
        /// </param>
        /// <param name="startRegion">
        /// Start of segment to analyze (seconds)
        /// </param>
        /// <param name="endRegion">
        /// End of segment to analyze (seconds)
        /// </param>
        /// <param name="maxVideoFps">
        /// Downsample high-frame-rate media
        /// </param>
        /// <param name="maxVideoSecs">
        /// Cap processed duration
        /// </param>
        /// <param name="modelTypes">
        /// Use talking_head for face-swaps
        /// </param>
        /// <param name="intelligence">
        /// Run multimodal intelligence analysis on the media<br/>
        /// Default Value: false
        /// </param>
        /// <param name="audioSourceTracing">
        /// Enable audio source tracing to identify synthetic audio origin<br/>
        /// Default Value: false
        /// </param>
        /// <param name="useReverseSearch">
        /// Enable reverse image search to improve detection accuracy for image files. Searches the web for matching images and uses AI to classify whether the match indicates a known fake. Only applies to image detections.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="useOodDetector">
        /// Enable out-of-distribution detection<br/>
        /// Default Value: false
        /// </param>
        /// <param name="zeroRetentionMode">
        /// Enable Zero Retention Mode to automatically delete submitted media after detection completes. When enabled, media URLs are redacted and the filename is tokenized.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDetectionRequest(
            string url,
            string? callbackUrl,
            bool? visualize,
            int? frameLength,
            double? startRegion,
            double? endRegion,
            double? maxVideoFps,
            double? maxVideoSecs,
            global::ResembleAI.DetectPostRequestBodyContentApplicationJsonSchemaModelTypes? modelTypes,
            bool? intelligence,
            bool? audioSourceTracing,
            bool? useReverseSearch,
            bool? useOodDetector,
            bool? zeroRetentionMode)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.CallbackUrl = callbackUrl;
            this.Visualize = visualize;
            this.FrameLength = frameLength;
            this.StartRegion = startRegion;
            this.EndRegion = endRegion;
            this.MaxVideoFps = maxVideoFps;
            this.MaxVideoSecs = maxVideoSecs;
            this.ModelTypes = modelTypes;
            this.Intelligence = intelligence;
            this.AudioSourceTracing = audioSourceTracing;
            this.UseReverseSearch = useReverseSearch;
            this.UseOodDetector = useOodDetector;
            this.ZeroRetentionMode = zeroRetentionMode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDetectionRequest" /> class.
        /// </summary>
        public CreateDetectionRequest()
        {
        }
    }
}