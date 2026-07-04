#nullable enable

namespace ResembleAI
{
    public partial interface IVoicesClient
    {
        /// <summary>
        /// Get voice<br/>
        /// Get voice details
        /// </summary>
        /// <param name="voiceUuid"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.VoicesGetVoiceResponse200> GetVoiceAsync(
            string voiceUuid,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get voice<br/>
        /// Get voice details
        /// </summary>
        /// <param name="voiceUuid"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AutoSDKHttpResponse<global::ResembleAI.VoicesGetVoiceResponse200>> GetVoiceAsResponseAsync(
            string voiceUuid,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}