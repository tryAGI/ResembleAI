#nullable enable

namespace ResembleAI
{
    public partial interface ISubpackageDuetsClient
    {
        /// <summary>
        /// Update duet voice<br/>
        /// Update a custom duet voice (default voices cannot be modified)
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.DuetsUpdateDuetVoiceResponse200> UpdateDuetVoiceAsync(
            int id,

            global::ResembleAI.UpdateDuetVoiceRequest request,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update duet voice<br/>
        /// Update a custom duet voice (default voices cannot be modified)
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AutoSDKHttpResponse<global::ResembleAI.DuetsUpdateDuetVoiceResponse200>> UpdateDuetVoiceAsResponseAsync(
            int id,

            global::ResembleAI.UpdateDuetVoiceRequest request,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update duet voice<br/>
        /// Update a custom duet voice (default voices cannot be modified)
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="stylePrompt"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.DuetsUpdateDuetVoiceResponse200> UpdateDuetVoiceAsync(
            int id,
            string? name = default,
            string? stylePrompt = default,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}