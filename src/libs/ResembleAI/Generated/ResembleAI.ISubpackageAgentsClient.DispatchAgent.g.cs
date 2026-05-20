#nullable enable

namespace ResembleAI
{
    public partial interface ISubpackageAgentsClient
    {
        /// <summary>
        /// Dispatch agent<br/>
        /// Make an outbound call with an agent
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AgentsDispatchAgentResponse200> DispatchAgentAsync(
            global::System.Guid uuid,

            global::ResembleAI.DispatchAgentRequest request,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Dispatch agent<br/>
        /// Make an outbound call with an agent
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AutoSDKHttpResponse<global::ResembleAI.AgentsDispatchAgentResponse200>> DispatchAgentAsResponseAsync(
            global::System.Guid uuid,

            global::ResembleAI.DispatchAgentRequest request,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Dispatch agent<br/>
        /// Make an outbound call with an agent
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="phoneNumber">
        /// Destination phone number
        /// </param>
        /// <param name="dynamicVariables">
        /// Runtime variable overrides
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AgentsDispatchAgentResponse200> DispatchAgentAsync(
            global::System.Guid uuid,
            string phoneNumber,
            global::ResembleAI.AgentsUuidDispatchPostRequestBodyContentApplicationJsonSchemaDynamicVariables? dynamicVariables = default,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}