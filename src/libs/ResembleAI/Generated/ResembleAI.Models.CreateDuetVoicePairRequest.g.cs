
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDuetVoicePairRequest
    {
        /// <summary>
        /// ID of first voice
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_1_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Voice1Id { get; set; }

        /// <summary>
        /// ID of second voice
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_2_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Voice2Id { get; set; }

        /// <summary>
        /// Optional pair name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDuetVoicePairRequest" /> class.
        /// </summary>
        /// <param name="voice1Id">
        /// ID of first voice
        /// </param>
        /// <param name="voice2Id">
        /// ID of second voice
        /// </param>
        /// <param name="name">
        /// Optional pair name
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDuetVoicePairRequest(
            int voice1Id,
            int voice2Id,
            string? name)
        {
            this.Voice1Id = voice1Id;
            this.Voice2Id = voice2Id;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDuetVoicePairRequest" /> class.
        /// </summary>
        public CreateDuetVoicePairRequest()
        {
        }
    }
}