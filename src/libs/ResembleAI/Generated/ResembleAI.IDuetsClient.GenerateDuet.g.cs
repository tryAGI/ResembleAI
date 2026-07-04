#nullable enable

namespace ResembleAI
{
    public partial interface IDuetsClient
    {
        /// <summary>
        /// Generate duet<br/>
        /// Generate conversational audio with two speakers
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.DuetsGenerateDuetResponse200> GenerateDuetAsync(

            global::ResembleAI.GenerateDuetRequest request,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate duet<br/>
        /// Generate conversational audio with two speakers
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AutoSDKHttpResponse<global::ResembleAI.DuetsGenerateDuetResponse200>> GenerateDuetAsResponseAsync(

            global::ResembleAI.GenerateDuetRequest request,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate duet<br/>
        /// Generate conversational audio with two speakers
        /// </summary>
        /// <param name="voicePairId">
        /// Voice pair ID to use
        /// </param>
        /// <param name="script"></param>
        /// <param name="title">
        /// Optional title for the duet
        /// </param>
        /// <param name="callbackUri">
        /// Webhook URL for completion notification
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.DuetsGenerateDuetResponse200> GenerateDuetAsync(
            int voicePairId,
            global::System.Collections.Generic.IList<global::ResembleAI.DuetPostRequestBodyContentApplicationJsonSchemaScriptItems> script,
            string? title = default,
            string? callbackUri = default,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}