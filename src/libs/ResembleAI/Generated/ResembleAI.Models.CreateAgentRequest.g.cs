
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAgentRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_uuid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VoiceUuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phone_number_id")]
        public int? PhoneNumberId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("languages")]
        public global::System.Collections.Generic.IList<string>? Languages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dynamic_variables")]
        public object? DynamicVariables { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("asr")]
        public global::ResembleAI.AgentsPostRequestBodyContentApplicationJsonSchemaAsr? Asr { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turn")]
        public global::ResembleAI.AgentsPostRequestBodyContentApplicationJsonSchemaTurn? Turn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm")]
        public global::ResembleAI.AgentsPostRequestBodyContentApplicationJsonSchemaLlm? Llm { get; set; }

        /// <summary>
        /// RAG search strategy - speed (faster) or accuracy (more thorough)<br/>
        /// Default Value: accuracy
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ResembleAI.JsonConverters.AgentsPostRequestBodyContentApplicationJsonSchemaSearchModeJsonConverter))]
        public global::ResembleAI.AgentsPostRequestBodyContentApplicationJsonSchemaSearchMode? SearchMode { get; set; }

        /// <summary>
        /// Number of relevant chunks to retrieve per query for RAG<br/>
        /// Default Value: 8
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_chunks_per_query")]
        public int? MaxChunksPerQuery { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhooks")]
        public global::System.Collections.Generic.IList<global::ResembleAI.AgentsPostRequestBodyContentApplicationJsonSchemaWebhooksItems>? Webhooks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system_tools")]
        public global::ResembleAI.AgentsPostRequestBodyContentApplicationJsonSchemaSystemTools? SystemTools { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="voiceUuid"></param>
        /// <param name="phoneNumberId"></param>
        /// <param name="languages"></param>
        /// <param name="dynamicVariables"></param>
        /// <param name="asr"></param>
        /// <param name="turn"></param>
        /// <param name="llm"></param>
        /// <param name="searchMode">
        /// RAG search strategy - speed (faster) or accuracy (more thorough)<br/>
        /// Default Value: accuracy
        /// </param>
        /// <param name="maxChunksPerQuery">
        /// Number of relevant chunks to retrieve per query for RAG<br/>
        /// Default Value: 8
        /// </param>
        /// <param name="webhooks"></param>
        /// <param name="systemTools"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAgentRequest(
            string name,
            string voiceUuid,
            int? phoneNumberId,
            global::System.Collections.Generic.IList<string>? languages,
            object? dynamicVariables,
            global::ResembleAI.AgentsPostRequestBodyContentApplicationJsonSchemaAsr? asr,
            global::ResembleAI.AgentsPostRequestBodyContentApplicationJsonSchemaTurn? turn,
            global::ResembleAI.AgentsPostRequestBodyContentApplicationJsonSchemaLlm? llm,
            global::ResembleAI.AgentsPostRequestBodyContentApplicationJsonSchemaSearchMode? searchMode,
            int? maxChunksPerQuery,
            global::System.Collections.Generic.IList<global::ResembleAI.AgentsPostRequestBodyContentApplicationJsonSchemaWebhooksItems>? webhooks,
            global::ResembleAI.AgentsPostRequestBodyContentApplicationJsonSchemaSystemTools? systemTools)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.VoiceUuid = voiceUuid ?? throw new global::System.ArgumentNullException(nameof(voiceUuid));
            this.PhoneNumberId = phoneNumberId;
            this.Languages = languages;
            this.DynamicVariables = dynamicVariables;
            this.Asr = asr;
            this.Turn = turn;
            this.Llm = llm;
            this.SearchMode = searchMode;
            this.MaxChunksPerQuery = maxChunksPerQuery;
            this.Webhooks = webhooks;
            this.SystemTools = systemTools;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentRequest" /> class.
        /// </summary>
        public CreateAgentRequest()
        {
        }

    }
}