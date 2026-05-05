#nullable enable

namespace ResembleAI
{
    public partial interface ISubpackageSpeechToTextClient
    {
        /// <summary>
        /// List intelligence questions<br/>
        /// List all questions asked about a transcript
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 25
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.SpeechToTextListTranscriptQuestionsResponse200> ListTranscriptQuestionsAsync(
            global::System.Guid uuid,
            int page,
            int? perPage = default,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List intelligence questions<br/>
        /// List all questions asked about a transcript
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 25
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AutoSDKHttpResponse<global::ResembleAI.SpeechToTextListTranscriptQuestionsResponse200>> ListTranscriptQuestionsAsResponseAsync(
            global::System.Guid uuid,
            int page,
            int? perPage = default,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}