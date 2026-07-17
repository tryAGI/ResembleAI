
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDetectionRequest
    {
        /// <summary>
        /// The media file to analyze (audio, video, or image). Must be 150 MB or smaller.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] File { get; set; }

        /// <summary>
        /// The media file to analyze (audio, video, or image). Must be 150 MB or smaller.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filename { get; set; }

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
        /// Cap processed duration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_video_secs")]
        public double? MaxVideoSecs { get; set; }

        /// <summary>
        /// Video only. Selects which detection components run for a video file:<br/>
        /// `audio` (audio track only), `video` (visual frames only), or `all` (both — the default).<br/>
        /// Ignored for audio and image inputs. Invalid values are rejected with HTTP 400.<br/>
        /// Default Value: all
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modality")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ResembleAI.JsonConverters.DetectPostRequestBodyContentMultipartFormDataSchemaModalityJsonConverter))]
        public global::ResembleAI.DetectPostRequestBodyContentMultipartFormDataSchemaModality? Modality { get; set; }

        /// <summary>
        /// Focus visual video detection on faces by masking non-face regions. Effective only for<br/>
        /// video inputs with `modality=all` or `modality=video`. Audio, image, and `modality=audio`<br/>
        /// video requests are accepted but use an effective value of `false`.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("face_only")]
        public bool? FaceOnly { get; set; }

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
        /// Enable reverse image search to improve detection accuracy for image files. Only applies to image detections.<br/>
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
        /// Enable Zero Retention Mode to automatically delete submitted media after detection completes.<br/>
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
        /// <param name="file">
        /// The media file to analyze (audio, video, or image). Must be 150 MB or smaller.
        /// </param>
        /// <param name="filename">
        /// The media file to analyze (audio, video, or image). Must be 150 MB or smaller.
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
        /// <param name="maxVideoSecs">
        /// Cap processed duration
        /// </param>
        /// <param name="modality">
        /// Video only. Selects which detection components run for a video file:<br/>
        /// `audio` (audio track only), `video` (visual frames only), or `all` (both — the default).<br/>
        /// Ignored for audio and image inputs. Invalid values are rejected with HTTP 400.<br/>
        /// Default Value: all
        /// </param>
        /// <param name="faceOnly">
        /// Focus visual video detection on faces by masking non-face regions. Effective only for<br/>
        /// video inputs with `modality=all` or `modality=video`. Audio, image, and `modality=audio`<br/>
        /// video requests are accepted but use an effective value of `false`.<br/>
        /// Default Value: false
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
        /// Enable reverse image search to improve detection accuracy for image files. Only applies to image detections.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="useOodDetector">
        /// Enable out-of-distribution detection<br/>
        /// Default Value: false
        /// </param>
        /// <param name="zeroRetentionMode">
        /// Enable Zero Retention Mode to automatically delete submitted media after detection completes.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDetectionRequest(
            byte[] file,
            string filename,
            string? callbackUrl,
            bool? visualize,
            int? frameLength,
            double? startRegion,
            double? endRegion,
            double? maxVideoSecs,
            global::ResembleAI.DetectPostRequestBodyContentMultipartFormDataSchemaModality? modality,
            bool? faceOnly,
            bool? intelligence,
            bool? audioSourceTracing,
            bool? useReverseSearch,
            bool? useOodDetector,
            bool? zeroRetentionMode)
        {
            this.File = file ?? throw new global::System.ArgumentNullException(nameof(file));
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.CallbackUrl = callbackUrl;
            this.Visualize = visualize;
            this.FrameLength = frameLength;
            this.StartRegion = startRegion;
            this.EndRegion = endRegion;
            this.MaxVideoSecs = maxVideoSecs;
            this.Modality = modality;
            this.FaceOnly = faceOnly;
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