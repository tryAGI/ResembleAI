#nullable enable

namespace ResembleAI
{
    public partial interface IDeepfakeDetectionClient
    {
        /// <summary>
        /// Delete deepfake detection<br/>
        /// Delete a detection belonging to the authenticated user's team. Once deleted, the detection is no longer returned by list or get requests.
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.DeepfakeDetectionDeleteDetectionResponse200> DeleteDetectionAsync(
            string uuid,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete deepfake detection<br/>
        /// Delete a detection belonging to the authenticated user's team. Once deleted, the detection is no longer returned by list or get requests.
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AutoSDKHttpResponse<global::ResembleAI.DeepfakeDetectionDeleteDetectionResponse200>> DeleteDetectionAsResponseAsync(
            string uuid,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}