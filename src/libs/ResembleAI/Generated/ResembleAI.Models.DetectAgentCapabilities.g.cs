
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// Read-only feature flags for a managed Detect Agent.
    /// </summary>
    public sealed partial class DetectAgentCapabilities
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Media { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reverse_search")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool ReverseSearch { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("identity")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Identity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("grounding")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Grounding { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("structured")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Structured { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Tools { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("knowledge")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Knowledge { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DetectAgentCapabilities" /> class.
        /// </summary>
        /// <param name="media"></param>
        /// <param name="reverseSearch"></param>
        /// <param name="identity"></param>
        /// <param name="grounding"></param>
        /// <param name="structured"></param>
        /// <param name="tools"></param>
        /// <param name="knowledge"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DetectAgentCapabilities(
            bool media,
            bool reverseSearch,
            bool identity,
            bool grounding,
            bool structured,
            bool tools,
            bool knowledge)
        {
            this.Media = media;
            this.ReverseSearch = reverseSearch;
            this.Identity = identity;
            this.Grounding = grounding;
            this.Structured = structured;
            this.Tools = tools;
            this.Knowledge = knowledge;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DetectAgentCapabilities" /> class.
        /// </summary>
        public DetectAgentCapabilities()
        {
        }

    }
}