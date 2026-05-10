
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreatePronunciationRequest
    {
        /// <summary>
        /// The word or phrase (2-100 characters). Letters, accented characters, apostrophes, hyphens, and spaces only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("word")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Word { get; set; }

        /// <summary>
        /// Reference audio file (wav, flac, mp3, m4a, ogg, webm, aac). Duration 200ms-10s. Max 10MB.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] Audio { get; set; }

        /// <summary>
        /// Reference audio file (wav, flac, mp3, m4a, ogg, webm, aac). Duration 200ms-10s. Max 10MB.
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
        /// Initializes a new instance of the <see cref="CreatePronunciationRequest" /> class.
        /// </summary>
        /// <param name="word">
        /// The word or phrase (2-100 characters). Letters, accented characters, apostrophes, hyphens, and spaces only.
        /// </param>
        /// <param name="audio">
        /// Reference audio file (wav, flac, mp3, m4a, ogg, webm, aac). Duration 200ms-10s. Max 10MB.
        /// </param>
        /// <param name="audioname">
        /// Reference audio file (wav, flac, mp3, m4a, ogg, webm, aac). Duration 200ms-10s. Max 10MB.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreatePronunciationRequest(
            string word,
            byte[] audio,
            string audioname)
        {
            this.Word = word ?? throw new global::System.ArgumentNullException(nameof(word));
            this.Audio = audio ?? throw new global::System.ArgumentNullException(nameof(audio));
            this.Audioname = audioname ?? throw new global::System.ArgumentNullException(nameof(audioname));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePronunciationRequest" /> class.
        /// </summary>
        public CreatePronunciationRequest()
        {
        }

    }
}