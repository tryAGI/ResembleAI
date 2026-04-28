#nullable enable

namespace ResembleAI
{
    public partial interface ISubpackageSpeechToTextClient
    {
        /// <summary>
        /// Ask intelligence question<br/>
        /// Submit a question about a completed transcript
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.SpeechToTextAskTranscriptQuestionResponse200> AskTranscriptQuestionAsync(
            global::System.Guid uuid,

            global::ResembleAI.AskTranscriptQuestionRequest request,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Ask intelligence question<br/>
        /// Submit a question about a completed transcript
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="query">
        /// Question to ask about the transcript
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.SpeechToTextAskTranscriptQuestionResponse200> AskTranscriptQuestionAsync(
            global::System.Guid uuid,
            string query,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}