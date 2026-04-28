
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateRecordingRequest
    {
        /// <summary>
        /// Audio file (WAV recommended, 1-12 seconds)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] File { get; set; }

        /// <summary>
        /// Audio file (WAV recommended, 1-12 seconds)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filename { get; set; }

        /// <summary>
        /// Display name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Transcript of the clip
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Emotion label
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emotion")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Emotion { get; set; }

        /// <summary>
        /// Include in training
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_active")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsActive { get; set; }

        /// <summary>
        /// Include for Resemble Fill
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fill")]
        public bool? Fill { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRecordingRequest" /> class.
        /// </summary>
        /// <param name="file">
        /// Audio file (WAV recommended, 1-12 seconds)
        /// </param>
        /// <param name="filename">
        /// Audio file (WAV recommended, 1-12 seconds)
        /// </param>
        /// <param name="name">
        /// Display name
        /// </param>
        /// <param name="text">
        /// Transcript of the clip
        /// </param>
        /// <param name="emotion">
        /// Emotion label
        /// </param>
        /// <param name="isActive">
        /// Include in training
        /// </param>
        /// <param name="fill">
        /// Include for Resemble Fill
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateRecordingRequest(
            byte[] file,
            string filename,
            string name,
            string text,
            string emotion,
            bool isActive,
            bool? fill)
        {
            this.File = file ?? throw new global::System.ArgumentNullException(nameof(file));
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Emotion = emotion ?? throw new global::System.ArgumentNullException(nameof(emotion));
            this.IsActive = isActive;
            this.Fill = fill;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRecordingRequest" /> class.
        /// </summary>
        public CreateRecordingRequest()
        {
        }
    }
}