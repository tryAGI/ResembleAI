#nullable enable

namespace ResembleAI
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Create agent<br/>
        /// Create a new voice agent
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AgentsCreateAgentResponse200> CreateAgentAsync(

            global::ResembleAI.CreateAgentRequest request,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create agent<br/>
        /// Create a new voice agent
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AutoSDKHttpResponse<global::ResembleAI.AgentsCreateAgentResponse200>> CreateAgentAsResponseAsync(

            global::ResembleAI.CreateAgentRequest request,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create agent<br/>
        /// Create a new voice agent
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AgentsCreateAgentResponse200> CreateAgentAsync(
            string name,
            string voiceUuid,
            int? phoneNumberId = default,
            global::System.Collections.Generic.IList<string>? languages = default,
            object? dynamicVariables = default,
            global::ResembleAI.AgentsPostRequestBodyContentApplicationJsonSchemaAsr? asr = default,
            global::ResembleAI.AgentsPostRequestBodyContentApplicationJsonSchemaTurn? turn = default,
            global::ResembleAI.AgentsPostRequestBodyContentApplicationJsonSchemaLlm? llm = default,
            global::ResembleAI.AgentsPostRequestBodyContentApplicationJsonSchemaSearchMode? searchMode = default,
            int? maxChunksPerQuery = default,
            global::System.Collections.Generic.IList<global::ResembleAI.AgentsPostRequestBodyContentApplicationJsonSchemaWebhooksItems>? webhooks = default,
            global::ResembleAI.AgentsPostRequestBodyContentApplicationJsonSchemaSystemTools? systemTools = default,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}