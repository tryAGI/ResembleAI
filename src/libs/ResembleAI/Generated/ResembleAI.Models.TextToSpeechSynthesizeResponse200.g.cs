
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TextToSpeechSynthesizeResponse200
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        public bool? Success { get; set; }

        /// <summary>
        /// Base64-encoded audio bytes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_content")]
        public byte[]? AudioContent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_timestamps")]
        public global::ResembleAI.AudioTimestamps? AudioTimestamps { get; set; }

        /// <summary>
        /// Audio duration in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public double? Duration { get; set; }

        /// <summary>
        /// Raw synthesis time
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("synth_duration")]
        public double? SynthDuration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_format")]
        public string? OutputFormat { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sample_rate")]
        public int? SampleRate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issues")]
        public global::System.Collections.Generic.IList<string>? Issues { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextToSpeechSynthesizeResponse200" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="audioContent">
        /// Base64-encoded audio bytes
        /// </param>
        /// <param name="audioTimestamps"></param>
        /// <param name="duration">
        /// Audio duration in seconds
        /// </param>
        /// <param name="synthDuration">
        /// Raw synthesis time
        /// </param>
        /// <param name="outputFormat"></param>
        /// <param name="sampleRate"></param>
        /// <param name="title"></param>
        /// <param name="issues"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextToSpeechSynthesizeResponse200(
            bool? success,
            byte[]? audioContent,
            global::ResembleAI.AudioTimestamps? audioTimestamps,
            double? duration,
            double? synthDuration,
            string? outputFormat,
            int? sampleRate,
            string? title,
            global::System.Collections.Generic.IList<string>? issues)
        {
            this.Success = success;
            this.AudioContent = audioContent;
            this.AudioTimestamps = audioTimestamps;
            this.Duration = duration;
            this.SynthDuration = synthDuration;
            this.OutputFormat = outputFormat;
            this.SampleRate = sampleRate;
            this.Title = title;
            this.Issues = issues;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextToSpeechSynthesizeResponse200" /> class.
        /// </summary>
        public TextToSpeechSynthesizeResponse200()
        {
        }
    }
}