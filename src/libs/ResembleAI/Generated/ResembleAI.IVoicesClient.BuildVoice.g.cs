#nullable enable

namespace ResembleAI
{
    public partial interface IVoicesClient
    {
        /// <summary>
        /// Build voice<br/>
        /// Start voice training
        /// </summary>
        /// <param name="voiceUuid"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.VoicesBuildVoiceResponse200> BuildVoiceAsync(
            string voiceUuid,

            global::ResembleAI.BuildVoiceRequest request,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Build voice<br/>
        /// Start voice training
        /// </summary>
        /// <param name="voiceUuid"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AutoSDKHttpResponse<global::ResembleAI.VoicesBuildVoiceResponse200>> BuildVoiceAsResponseAsync(
            string voiceUuid,

            global::ResembleAI.BuildVoiceRequest request,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Build voice<br/>
        /// Start voice training
        /// </summary>
        /// <param name="voiceUuid"></param>
        /// <param name="fill">
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.VoicesBuildVoiceResponse200> BuildVoiceAsync(
            string voiceUuid,
            bool? fill = default,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}