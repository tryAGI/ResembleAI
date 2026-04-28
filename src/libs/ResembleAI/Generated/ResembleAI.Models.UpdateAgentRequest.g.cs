
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateAgentRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_uuid")]
        public string? VoiceUuid { get; set; }

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
        public global::ResembleAI.AgentsUuidPatchRequestBodyContentApplicationJsonSchemaDynamicVariables? DynamicVariables { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("asr")]
        public global::ResembleAI.AgentsUuidPatchRequestBodyContentApplicationJsonSchemaAsr? Asr { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turn")]
        public global::ResembleAI.AgentsUuidPatchRequestBodyContentApplicationJsonSchemaTurn? Turn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm")]
        public global::ResembleAI.AgentsUuidPatchRequestBodyContentApplicationJsonSchemaLlm? Llm { get; set; }

        /// <summary>
        /// RAG search strategy
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ResembleAI.JsonConverters.AgentsUuidPatchRequestBodyContentApplicationJsonSchemaSearchModeJsonConverter))]
        public global::ResembleAI.AgentsUuidPatchRequestBodyContentApplicationJsonSchemaSearchMode? SearchMode { get; set; }

        /// <summary>
        /// Number of chunks to retrieve per query for RAG
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_chunks_per_query")]
        public int? MaxChunksPerQuery { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhooks")]
        public global::System.Collections.Generic.IList<object>? Webhooks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system_tools")]
        public global::ResembleAI.AgentsUuidPatchRequestBodyContentApplicationJsonSchemaSystemTools? SystemTools { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAgentRequest" /> class.
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
        /// RAG search strategy
        /// </param>
        /// <param name="maxChunksPerQuery">
        /// Number of chunks to retrieve per query for RAG
        /// </param>
        /// <param name="webhooks"></param>
        /// <param name="systemTools"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateAgentRequest(
            string? name,
            string? voiceUuid,
            int? phoneNumberId,
            global::System.Collections.Generic.IList<string>? languages,
            global::ResembleAI.AgentsUuidPatchRequestBodyContentApplicationJsonSchemaDynamicVariables? dynamicVariables,
            global::ResembleAI.AgentsUuidPatchRequestBodyContentApplicationJsonSchemaAsr? asr,
            global::ResembleAI.AgentsUuidPatchRequestBodyContentApplicationJsonSchemaTurn? turn,
            global::ResembleAI.AgentsUuidPatchRequestBodyContentApplicationJsonSchemaLlm? llm,
            global::ResembleAI.AgentsUuidPatchRequestBodyContentApplicationJsonSchemaSearchMode? searchMode,
            int? maxChunksPerQuery,
            global::System.Collections.Generic.IList<object>? webhooks,
            global::ResembleAI.AgentsUuidPatchRequestBodyContentApplicationJsonSchemaSystemTools? systemTools)
        {
            this.Name = name;
            this.VoiceUuid = voiceUuid;
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
        /// Initializes a new instance of the <see cref="UpdateAgentRequest" /> class.
        /// </summary>
        public UpdateAgentRequest()
        {
        }
    }
}