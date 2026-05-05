#nullable enable

namespace ResembleAI
{
    public partial interface ISubpackageDeepfakeDetectionClient
    {
        /// <summary>
        /// Get batch status<br/>
        /// Retrieve the latest aggregate status for a batch. The response shape mirrors<br/>
        /// the create response — `status`, `completed_count`, and `failed_count` update<br/>
        /// as child detects progress. Use the `detect_uuids` array to fetch per-file<br/>
        /// results via `GET /detect/{uuid}`.
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.DeepfakeDetectionGetDetectBatchResponse200> GetDetectBatchAsync(
            string uuid,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get batch status<br/>
        /// Retrieve the latest aggregate status for a batch. The response shape mirrors<br/>
        /// the create response — `status`, `completed_count`, and `failed_count` update<br/>
        /// as child detects progress. Use the `detect_uuids` array to fetch per-file<br/>
        /// results via `GET /detect/{uuid}`.
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AutoSDKHttpResponse<global::ResembleAI.DeepfakeDetectionGetDetectBatchResponse200>> GetDetectBatchAsResponseAsync(
            string uuid,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}