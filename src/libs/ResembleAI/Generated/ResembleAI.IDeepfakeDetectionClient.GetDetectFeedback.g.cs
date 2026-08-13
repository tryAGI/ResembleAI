#nullable enable

namespace ResembleAI
{
    public partial interface IDeepfakeDetectionClient
    {
        /// <summary>
        /// Get detection feedback<br/>
        /// Retrieve your own feedback for a detect. Returns 404 when *you* haven't answered this<br/>
        /// detect, even if the detect exists and a teammate has answered it.
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.DeepfakeDetectionGetDetectFeedbackResponse200> GetDetectFeedbackAsync(
            string uuid,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get detection feedback<br/>
        /// Retrieve your own feedback for a detect. Returns 404 when *you* haven't answered this<br/>
        /// detect, even if the detect exists and a teammate has answered it.
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AutoSDKHttpResponse<global::ResembleAI.DeepfakeDetectionGetDetectFeedbackResponse200>> GetDetectFeedbackAsResponseAsync(
            string uuid,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}