#nullable enable

namespace ResembleAI
{
    public partial interface IDeepfakeDetectionClient
    {
        /// <summary>
        /// Delete detection feedback<br/>
        /// Retract your own feedback. Idempotent — returns 200 whether or not a row existed. Only<br/>
        /// your row is removed; a teammate's answer on the same detect is untouched. Works even on<br/>
        /// a detect that later failed.
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.DeepfakeDetectionDeleteDetectFeedbackResponse200> DeleteDetectFeedbackAsync(
            string uuid,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete detection feedback<br/>
        /// Retract your own feedback. Idempotent — returns 200 whether or not a row existed. Only<br/>
        /// your row is removed; a teammate's answer on the same detect is untouched. Works even on<br/>
        /// a detect that later failed.
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AutoSDKHttpResponse<global::ResembleAI.DeepfakeDetectionDeleteDetectFeedbackResponse200>> DeleteDetectFeedbackAsResponseAsync(
            string uuid,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}