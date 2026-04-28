#nullable enable

namespace ResembleAI
{
    public partial interface ISubpackageAudioEnhancementClient
    {
        /// <summary>
        /// Get audio enhancement<br/>
        /// Poll this endpoint to check the status of an enhancement job and retrieve the download URL when complete.
        /// </summary>
        /// <param name="enhancementUuid"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AudioEnhancementGetAudioEnhancementResponse200> GetAudioEnhancementAsync(
            string enhancementUuid,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}