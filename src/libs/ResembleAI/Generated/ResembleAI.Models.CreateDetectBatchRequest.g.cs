
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDetectBatchRequest
    {
        /// <summary>
        /// One or more media files. Repeat the `files[]` field for each file. Mutually exclusive with `file`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("files[]")]
        public global::System.Collections.Generic.IList<byte[]>? Files { get; set; }

        /// <summary>
        /// A single `.zip` archive containing media files. Mutually exclusive with `files[]`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        public byte[]? File { get; set; }

        /// <summary>
        /// A single `.zip` archive containing media files. Mutually exclusive with `files[]`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// POST destination invoked when the batch reaches a terminal state.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callback_url")]
        public string? CallbackUrl { get; set; }

        /// <summary>
        /// Run multimodal intelligence on every file in the batch.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("intelligence")]
        public bool? Intelligence { get; set; }

        /// <summary>
        /// Opt in to let a strong intelligence finding escalate an otherwise non-fake verdict to "Likely Fake". Has no effect unless `intelligence` is also true.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("infer_from_intelligence")]
        public bool? InferFromIntelligence { get; set; }

        /// <summary>
        /// Run identity search against the team's saved identities (audio/video only).<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_identity")]
        public bool? SearchIdentity { get; set; }

        /// <summary>
        /// Generate visualization artifacts.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visualize")]
        public bool? Visualize { get; set; }

        /// <summary>
        /// Enable audio source tracing on each audio file.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_source_tracing_enabled")]
        public bool? AudioSourceTracingEnabled { get; set; }

        /// <summary>
        /// Window size in seconds (audio/video).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frame_length")]
        public int? FrameLength { get; set; }

        /// <summary>
        /// Start of segment to analyze (seconds).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_region")]
        public double? StartRegion { get; set; }

        /// <summary>
        /// End of segment to analyze (seconds).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_region")]
        public double? EndRegion { get; set; }

        /// <summary>
        /// Cap processed video duration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_video_secs")]
        public double? MaxVideoSecs { get; set; }

        /// <summary>
        /// Use LLM-assisted video analysis.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_llm")]
        public bool? UseLlm { get; set; }

        /// <summary>
        /// Focus detection on faces for video children by masking non-face regions. Audio and<br/>
        /// image children use an effective value of `false`. Retrieve each child's effective value<br/>
        /// with `GET /detect/{uuid}`; the aggregate batch response does not include this field.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("face_only")]
        public bool? FaceOnly { get; set; }

        /// <summary>
        /// Enable Zero Retention Mode for every file in the batch.<br/>
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
        /// Initializes a new instance of the <see cref="CreateDetectBatchRequest" /> class.
        /// </summary>
        /// <param name="files">
        /// One or more media files. Repeat the `files[]` field for each file. Mutually exclusive with `file`.
        /// </param>
        /// <param name="file">
        /// A single `.zip` archive containing media files. Mutually exclusive with `files[]`.
        /// </param>
        /// <param name="filename">
        /// A single `.zip` archive containing media files. Mutually exclusive with `files[]`.
        /// </param>
        /// <param name="callbackUrl">
        /// POST destination invoked when the batch reaches a terminal state.
        /// </param>
        /// <param name="intelligence">
        /// Run multimodal intelligence on every file in the batch.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="inferFromIntelligence">
        /// Opt in to let a strong intelligence finding escalate an otherwise non-fake verdict to "Likely Fake". Has no effect unless `intelligence` is also true.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="searchIdentity">
        /// Run identity search against the team's saved identities (audio/video only).<br/>
        /// Default Value: false
        /// </param>
        /// <param name="visualize">
        /// Generate visualization artifacts.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="audioSourceTracingEnabled">
        /// Enable audio source tracing on each audio file.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="frameLength">
        /// Window size in seconds (audio/video).
        /// </param>
        /// <param name="startRegion">
        /// Start of segment to analyze (seconds).
        /// </param>
        /// <param name="endRegion">
        /// End of segment to analyze (seconds).
        /// </param>
        /// <param name="maxVideoSecs">
        /// Cap processed video duration.
        /// </param>
        /// <param name="useLlm">
        /// Use LLM-assisted video analysis.
        /// </param>
        /// <param name="faceOnly">
        /// Focus detection on faces for video children by masking non-face regions. Audio and<br/>
        /// image children use an effective value of `false`. Retrieve each child's effective value<br/>
        /// with `GET /detect/{uuid}`; the aggregate batch response does not include this field.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="zeroRetentionMode">
        /// Enable Zero Retention Mode for every file in the batch.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDetectBatchRequest(
            global::System.Collections.Generic.IList<byte[]>? files,
            byte[]? file,
            string? filename,
            string? callbackUrl,
            bool? intelligence,
            bool? inferFromIntelligence,
            bool? searchIdentity,
            bool? visualize,
            bool? audioSourceTracingEnabled,
            int? frameLength,
            double? startRegion,
            double? endRegion,
            double? maxVideoSecs,
            bool? useLlm,
            bool? faceOnly,
            bool? zeroRetentionMode)
        {
            this.Files = files;
            this.File = file;
            this.Filename = filename;
            this.CallbackUrl = callbackUrl;
            this.Intelligence = intelligence;
            this.InferFromIntelligence = inferFromIntelligence;
            this.SearchIdentity = searchIdentity;
            this.Visualize = visualize;
            this.AudioSourceTracingEnabled = audioSourceTracingEnabled;
            this.FrameLength = frameLength;
            this.StartRegion = startRegion;
            this.EndRegion = endRegion;
            this.MaxVideoSecs = maxVideoSecs;
            this.UseLlm = useLlm;
            this.FaceOnly = faceOnly;
            this.ZeroRetentionMode = zeroRetentionMode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDetectBatchRequest" /> class.
        /// </summary>
        public CreateDetectBatchRequest()
        {
        }

    }
}