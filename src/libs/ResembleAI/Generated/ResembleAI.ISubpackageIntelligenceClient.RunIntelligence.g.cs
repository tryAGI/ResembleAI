#nullable enable

namespace ResembleAI
{
    public partial interface ISubpackageIntelligenceClient
    {
        /// <summary>
        /// Run intelligence<br/>
        /// Analyze audio, image, or video for comprehensive insights. Optionally reference an existing detect to associate.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.IntelligenceRunIntelligenceResponse200> RunIntelligenceAsync(

            global::ResembleAI.RunIntelligenceRequest request,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Run intelligence<br/>
        /// Analyze audio, image, or video for comprehensive insights. Optionally reference an existing detect to associate.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AutoSDKHttpResponse<global::ResembleAI.IntelligenceRunIntelligenceResponse200>> RunIntelligenceAsResponseAsync(

            global::ResembleAI.RunIntelligenceRequest request,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Run intelligence<br/>
        /// Analyze audio, image, or video for comprehensive insights. Optionally reference an existing detect to associate.
        /// </summary>
        /// <param name="mediaToken">
        /// Token for uploaded media file (from secure upload)
        /// </param>
        /// <param name="url">
        /// HTTPS URL to audio, image, or video file
        /// </param>
        /// <param name="detectId">
        /// UUID of an existing detect to associate
        /// </param>
        /// <param name="mediaType">
        /// Explicit media type (auto-detected if not provided)
        /// </param>
        /// <param name="callbackUrl">
        /// URL that receives the final intelligence payload via HTTP POST. When present, the request runs asynchronously and returns 202 Accepted.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.IntelligenceRunIntelligenceResponse200> RunIntelligenceAsync(
            string? mediaToken = default,
            string? url = default,
            global::System.Guid? detectId = default,
            global::ResembleAI.IntelligencePostRequestBodyContentApplicationJsonSchemaMediaType? mediaType = default,
            string? callbackUrl = default,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}