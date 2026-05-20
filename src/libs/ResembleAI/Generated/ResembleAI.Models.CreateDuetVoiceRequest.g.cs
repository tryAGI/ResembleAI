
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDuetVoiceRequest
    {
        /// <summary>
        /// Voice name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Optional style prompt
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style_prompt")]
        public string? StylePrompt { get; set; }

        /// <summary>
        /// Audio file (MP3/WAV/M4A/OGG/AAC/FLAC max 10 MB)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] Audio { get; set; }

        /// <summary>
        /// Audio file (MP3/WAV/M4A/OGG/AAC/FLAC max 10 MB)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audioname")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Audioname { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDuetVoiceRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Voice name
        /// </param>
        /// <param name="audio">
        /// Audio file (MP3/WAV/M4A/OGG/AAC/FLAC max 10 MB)
        /// </param>
        /// <param name="audioname">
        /// Audio file (MP3/WAV/M4A/OGG/AAC/FLAC max 10 MB)
        /// </param>
        /// <param name="stylePrompt">
        /// Optional style prompt
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDuetVoiceRequest(
            string name,
            byte[] audio,
            string audioname,
            string? stylePrompt)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.StylePrompt = stylePrompt;
            this.Audio = audio ?? throw new global::System.ArgumentNullException(nameof(audio));
            this.Audioname = audioname ?? throw new global::System.ArgumentNullException(nameof(audioname));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDuetVoiceRequest" /> class.
        /// </summary>
        public CreateDuetVoiceRequest()
        {
        }

    }
}