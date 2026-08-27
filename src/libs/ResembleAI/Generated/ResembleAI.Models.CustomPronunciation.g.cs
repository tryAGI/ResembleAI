
#nullable enable

namespace ResembleAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CustomPronunciation
    {
        /// <summary>
        /// Unique identifier for the pronunciation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uuid")]
        public global::System.Guid? Uuid { get; set; }

        /// <summary>
        /// The word or phrase this pronunciation applies to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("word")]
        public string? Word { get; set; }

        /// <summary>
        /// Processing status. Only "ready" pronunciations are applied during synthesis.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ResembleAI.JsonConverters.CustomPronunciationStatusJsonConverter))]
        public global::ResembleAI.CustomPronunciationStatus? Status { get; set; }

        /// <summary>
        /// Whether this pronunciation is active and will be applied during synthesis
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// URL to the uploaded reference audio
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_url")]
        public string? AudioUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomPronunciation" /> class.
        /// </summary>
        /// <param name="uuid">
        /// Unique identifier for the pronunciation
        /// </param>
        /// <param name="word">
        /// The word or phrase this pronunciation applies to
        /// </param>
        /// <param name="status">
        /// Processing status. Only "ready" pronunciations are applied during synthesis.
        /// </param>
        /// <param name="active">
        /// Whether this pronunciation is active and will be applied during synthesis
        /// </param>
        /// <param name="audioUrl">
        /// URL to the uploaded reference audio
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomPronunciation(
            global::System.Guid? uuid,
            string? word,
            global::ResembleAI.CustomPronunciationStatus? status,
            bool? active,
            string? audioUrl,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt)
        {
            this.Uuid = uuid;
            this.Word = word;
            this.Status = status;
            this.Active = active;
            this.AudioUrl = audioUrl;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomPronunciation" /> class.
        /// </summary>
        public CustomPronunciation()
        {
        }

    }
}