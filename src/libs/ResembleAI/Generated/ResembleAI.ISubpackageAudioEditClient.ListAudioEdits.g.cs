#nullable enable

namespace ResembleAI
{
    public partial interface ISubpackageAudioEditClient
    {
        /// <summary>
        /// List audio edits<br/>
        /// Retrieve paginated list of audio edits
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AudioEditListAudioEditsResponse200> ListAudioEditsAsync(
            int page,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}