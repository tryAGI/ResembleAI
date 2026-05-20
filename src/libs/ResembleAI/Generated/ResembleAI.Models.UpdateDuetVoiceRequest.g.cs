
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateDuetVoiceRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style_prompt")]
        public string? StylePrompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDuetVoiceRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="stylePrompt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateDuetVoiceRequest(
            string? name,
            string? stylePrompt)
        {
            this.Name = name;
            this.StylePrompt = stylePrompt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDuetVoiceRequest" /> class.
        /// </summary>
        public UpdateDuetVoiceRequest()
        {
        }

    }
}