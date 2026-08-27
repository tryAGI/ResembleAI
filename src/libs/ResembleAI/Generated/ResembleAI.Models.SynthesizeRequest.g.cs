
#nullable enable

namespace ResembleAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SynthesizeRequest
    {
        /// <summary>
        /// Voice UUID to use for synthesis
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_uuid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VoiceUuid { get; set; }

        /// <summary>
        /// Optional project UUID to store the clip
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_uuid")]
        public string? ProjectUuid { get; set; }

        /// <summary>
        /// Optional title for the generated clip
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Text or SSML to synthesize (max 3,000 characters)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Data { get; set; }

        /// <summary>
        /// Audio precision for WAV output<br/>
        /// Default Value: PCM_32
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("precision")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ResembleAI.JsonConverters.SynthesizePostRequestBodyContentApplicationJsonSchemaPrecisionJsonConverter))]
        public global::ResembleAI.SynthesizePostRequestBodyContentApplicationJsonSchemaPrecision? Precision { get; set; }

        /// <summary>
        /// Audio output format<br/>
        /// Default Value: wav
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ResembleAI.JsonConverters.SynthesizePostRequestBodyContentApplicationJsonSchemaOutputFormatJsonConverter))]
        public global::ResembleAI.SynthesizePostRequestBodyContentApplicationJsonSchemaOutputFormat? OutputFormat { get; set; }

        /// <summary>
        /// Audio sample rate in Hz
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sample_rate")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ResembleAI.JsonConverters.SynthesizePostRequestBodyContentApplicationJsonSchemaSampleRateJsonConverter))]
        public global::ResembleAI.SynthesizePostRequestBodyContentApplicationJsonSchemaSampleRate? SampleRate { get; set; }

        /// <summary>
        /// Enable HD synthesis with small latency trade-off<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_hd")]
        public bool? UseHd { get; set; }

        /// <summary>
        /// When true, automatically applies your team's custom pronunciations to matching words in the input text. Defaults to false.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apply_custom_pronunciations")]
        public bool? ApplyCustomPronunciations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SynthesizeRequest" /> class.
        /// </summary>
        /// <param name="voiceUuid">
        /// Voice UUID to use for synthesis
        /// </param>
        /// <param name="data">
        /// Text or SSML to synthesize (max 3,000 characters)
        /// </param>
        /// <param name="projectUuid">
        /// Optional project UUID to store the clip
        /// </param>
        /// <param name="title">
        /// Optional title for the generated clip
        /// </param>
        /// <param name="precision">
        /// Audio precision for WAV output<br/>
        /// Default Value: PCM_32
        /// </param>
        /// <param name="outputFormat">
        /// Audio output format<br/>
        /// Default Value: wav
        /// </param>
        /// <param name="sampleRate">
        /// Audio sample rate in Hz
        /// </param>
        /// <param name="useHd">
        /// Enable HD synthesis with small latency trade-off<br/>
        /// Default Value: false
        /// </param>
        /// <param name="applyCustomPronunciations">
        /// When true, automatically applies your team's custom pronunciations to matching words in the input text. Defaults to false.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SynthesizeRequest(
            string voiceUuid,
            string data,
            string? projectUuid,
            string? title,
            global::ResembleAI.SynthesizePostRequestBodyContentApplicationJsonSchemaPrecision? precision,
            global::ResembleAI.SynthesizePostRequestBodyContentApplicationJsonSchemaOutputFormat? outputFormat,
            global::ResembleAI.SynthesizePostRequestBodyContentApplicationJsonSchemaSampleRate? sampleRate,
            bool? useHd,
            bool? applyCustomPronunciations)
        {
            this.VoiceUuid = voiceUuid ?? throw new global::System.ArgumentNullException(nameof(voiceUuid));
            this.ProjectUuid = projectUuid;
            this.Title = title;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Precision = precision;
            this.OutputFormat = outputFormat;
            this.SampleRate = sampleRate;
            this.UseHd = useHd;
            this.ApplyCustomPronunciations = applyCustomPronunciations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SynthesizeRequest" /> class.
        /// </summary>
        public SynthesizeRequest()
        {
        }

    }
}