#nullable enable

namespace ResembleAI
{
    public partial interface ISubpackageCustomPronunciationsClient
    {
        /// <summary>
        /// Delete custom pronunciation<br/>
        /// Permanently remove a custom pronunciation. Takes effect immediately.
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.CustomPronunciationsDeletePronunciationResponse200> DeletePronunciationAsync(
            global::System.Guid uuid,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete custom pronunciation<br/>
        /// Permanently remove a custom pronunciation. Takes effect immediately.
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AutoSDKHttpResponse<global::ResembleAI.CustomPronunciationsDeletePronunciationResponse200>> DeletePronunciationAsResponseAsync(
            global::System.Guid uuid,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}