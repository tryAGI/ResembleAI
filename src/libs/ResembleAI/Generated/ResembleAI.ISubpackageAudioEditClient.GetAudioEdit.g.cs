#nullable enable

namespace ResembleAI
{
    public partial interface ISubpackageAudioEditClient
    {
        /// <summary>
        /// Get audio edit<br/>
        /// Get status and result of an audio edit
        /// </summary>
        /// <param name="audioEditUuid"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AudioEditGetAudioEditResponse200> GetAudioEditAsync(
            string audioEditUuid,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}