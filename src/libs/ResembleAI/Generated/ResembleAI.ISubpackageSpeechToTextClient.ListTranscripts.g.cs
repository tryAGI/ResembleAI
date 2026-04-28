#nullable enable

namespace ResembleAI
{
    public partial interface ISubpackageSpeechToTextClient
    {
        /// <summary>
        /// List transcripts<br/>
        /// Retrieve paginated list of transcript jobs
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 25
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.SpeechToTextListTranscriptsResponse200> ListTranscriptsAsync(
            int page,
            int? perPage = default,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}