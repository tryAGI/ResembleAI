
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateRecordingRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emotion")]
        public string? Emotion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_active")]
        public bool? IsActive { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateRecordingRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="text"></param>
        /// <param name="emotion"></param>
        /// <param name="isActive"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateRecordingRequest(
            string? name,
            string? text,
            string? emotion,
            bool? isActive)
        {
            this.Name = name;
            this.Text = text;
            this.Emotion = emotion;
            this.IsActive = isActive;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateRecordingRequest" /> class.
        /// </summary>
        public UpdateRecordingRequest()
        {
        }

    }
}