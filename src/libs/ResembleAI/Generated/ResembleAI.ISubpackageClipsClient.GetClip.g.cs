#nullable enable

namespace ResembleAI
{
    public partial interface ISubpackageClipsClient
    {
        /// <summary>
        /// Get clip<br/>
        /// Get clip details
        /// </summary>
        /// <param name="projectUuid"></param>
        /// <param name="clipUuid"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.ClipsGetClipResponse200> GetClipAsync(
            string projectUuid,
            string clipUuid,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get clip<br/>
        /// Get clip details
        /// </summary>
        /// <param name="projectUuid"></param>
        /// <param name="clipUuid"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AutoSDKHttpResponse<global::ResembleAI.ClipsGetClipResponse200>> GetClipAsResponseAsync(
            string projectUuid,
            string clipUuid,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}