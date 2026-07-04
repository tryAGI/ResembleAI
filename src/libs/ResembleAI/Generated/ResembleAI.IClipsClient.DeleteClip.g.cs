#nullable enable

namespace ResembleAI
{
    public partial interface IClipsClient
    {
        /// <summary>
        /// Delete clip<br/>
        /// Delete a clip
        /// </summary>
        /// <param name="projectUuid"></param>
        /// <param name="clipUuid"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.ClipsDeleteClipResponse200> DeleteClipAsync(
            string projectUuid,
            string clipUuid,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete clip<br/>
        /// Delete a clip
        /// </summary>
        /// <param name="projectUuid"></param>
        /// <param name="clipUuid"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AutoSDKHttpResponse<global::ResembleAI.ClipsDeleteClipResponse200>> DeleteClipAsResponseAsync(
            string projectUuid,
            string clipUuid,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}