#nullable enable

namespace ResembleAI
{
    public partial interface ITextDetectionClient
    {
        /// <summary>
        /// Get text detection<br/>
        /// Retrieve a text detection by UUID. Poll this endpoint until `status` is `completed` or `failed`.
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.TextDetectResponse> GetTextDetectionAsync(
            string uuid,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get text detection<br/>
        /// Retrieve a text detection by UUID. Poll this endpoint until `status` is `completed` or `failed`.
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AutoSDKHttpResponse<global::ResembleAI.TextDetectResponse>> GetTextDetectionAsResponseAsync(
            string uuid,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}