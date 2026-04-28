
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentsPostRequestBodyContentApplicationJsonSchemaLlm
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        public string? Provider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning_effort")]
        public string? ReasoningEffort { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timezone")]
        public string? Timezone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("built_in_tools")]
        public global::ResembleAI.AgentsPostRequestBodyContentApplicationJsonSchemaLlmBuiltInTools? BuiltInTools { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentsPostRequestBodyContentApplicationJsonSchemaLlm" /> class.
        /// </summary>
        /// <param name="prompt"></param>
        /// <param name="provider"></param>
        /// <param name="model"></param>
        /// <param name="reasoningEffort"></param>
        /// <param name="temperature"></param>
        /// <param name="timezone"></param>
        /// <param name="builtInTools"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentsPostRequestBodyContentApplicationJsonSchemaLlm(
            string? prompt,
            string? provider,
            string? model,
            string? reasoningEffort,
            double? temperature,
            string? timezone,
            global::ResembleAI.AgentsPostRequestBodyContentApplicationJsonSchemaLlmBuiltInTools? builtInTools)
        {
            this.Prompt = prompt;
            this.Provider = provider;
            this.Model = model;
            this.ReasoningEffort = reasoningEffort;
            this.Temperature = temperature;
            this.Timezone = timezone;
            this.BuiltInTools = builtInTools;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentsPostRequestBodyContentApplicationJsonSchemaLlm" /> class.
        /// </summary>
        public AgentsPostRequestBodyContentApplicationJsonSchemaLlm()
        {
        }
    }
}