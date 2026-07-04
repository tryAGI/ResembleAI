#nullable enable

namespace ResembleAI
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Update agent<br/>
        /// Update an existing agent's configuration
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AgentsUpdateAgentResponse200> UpdateAgentAsync(
            global::System.Guid uuid,

            global::ResembleAI.UpdateAgentRequest request,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update agent<br/>
        /// Update an existing agent's configuration
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AutoSDKHttpResponse<global::ResembleAI.AgentsUpdateAgentResponse200>> UpdateAgentAsResponseAsync(
            global::System.Guid uuid,

            global::ResembleAI.UpdateAgentRequest request,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update agent<br/>
        /// Update an existing agent's configuration
        /// </summary>
        /// <param name="uuid"></param>
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AgentsUpdateAgentResponse200> UpdateAgentAsync(
            global::System.Guid uuid,
            string? name = default,
            string? voiceUuid = default,
            int? phoneNumberId = default,
            global::System.Collections.Generic.IList<string>? languages = default,
            global::ResembleAI.AgentsUuidPatchRequestBodyContentApplicationJsonSchemaDynamicVariables? dynamicVariables = default,
            global::ResembleAI.AgentsUuidPatchRequestBodyContentApplicationJsonSchemaAsr? asr = default,
            global::ResembleAI.AgentsUuidPatchRequestBodyContentApplicationJsonSchemaTurn? turn = default,
            global::ResembleAI.AgentsUuidPatchRequestBodyContentApplicationJsonSchemaLlm? llm = default,
            global::ResembleAI.AgentsUuidPatchRequestBodyContentApplicationJsonSchemaSearchMode? searchMode = default,
            int? maxChunksPerQuery = default,
            global::System.Collections.Generic.IList<object>? webhooks = default,
            global::ResembleAI.AgentsUuidPatchRequestBodyContentApplicationJsonSchemaSystemTools? systemTools = default,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}