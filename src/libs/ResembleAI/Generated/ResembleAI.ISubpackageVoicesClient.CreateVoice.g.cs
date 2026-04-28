#nullable enable

namespace ResembleAI
{
    public partial interface ISubpackageVoicesClient
    {
        /// <summary>
        /// Create voice<br/>
        /// Create a new voice
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.VoicesCreateVoiceResponse200> CreateVoiceAsync(

            global::ResembleAI.CreateVoiceRequest request,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create voice<br/>
        /// Create a new voice
        /// </summary>
        /// <param name="name"></param>
        /// <param name="voiceType">
        /// Default Value: professional
        /// </param>
        /// <param name="datasetUrl"></param>
        /// <param name="callbackUri"></param>
        /// <param name="language">
        /// Default Value: en-US
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.VoicesCreateVoiceResponse200> CreateVoiceAsync(
            string name,
            global::ResembleAI.VoicesPostRequestBodyContentApplicationJsonSchemaVoiceType? voiceType = default,
            string? datasetUrl = default,
            string? callbackUri = default,
            string? language = default,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}