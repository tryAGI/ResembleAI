#nullable enable

namespace ResembleAI
{
    public partial interface ISubpackageCustomPronunciationsClient
    {
        /// <summary>
        /// Toggle pronunciation active status<br/>
        /// Enable or disable a pronunciation without deleting it. Inactive pronunciations are not used during synthesis.
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.CustomPronunciationsUpdatePronunciationResponse200> UpdatePronunciationAsync(
            global::System.Guid uuid,

            global::ResembleAI.UpdatePronunciationRequest request,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Toggle pronunciation active status<br/>
        /// Enable or disable a pronunciation without deleting it. Inactive pronunciations are not used during synthesis.
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="active">
        /// Set to false to disable, true to re-enable
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.CustomPronunciationsUpdatePronunciationResponse200> UpdatePronunciationAsync(
            global::System.Guid uuid,
            bool active,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}