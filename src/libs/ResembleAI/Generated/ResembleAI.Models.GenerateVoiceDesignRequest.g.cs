
#nullable enable

namespace ResembleAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GenerateVoiceDesignRequest
    {
        /// <summary>
        /// Description of desired voice
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserPrompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateVoiceDesignRequest" /> class.
        /// </summary>
        /// <param name="userPrompt">
        /// Description of desired voice
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateVoiceDesignRequest(
            string userPrompt)
        {
            this.UserPrompt = userPrompt ?? throw new global::System.ArgumentNullException(nameof(userPrompt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateVoiceDesignRequest" /> class.
        /// </summary>
        public GenerateVoiceDesignRequest()
        {
        }

    }
}