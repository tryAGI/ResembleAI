#nullable enable

namespace ResembleAI
{
    public partial interface ISubpackageSpeechToTextClient
    {
        /// <summary>
        /// Get intelligence question status<br/>
        /// Check the status of a specific question
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="questionUuid"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.SpeechToTextGetTranscriptQuestionResponse200> GetTranscriptQuestionAsync(
            global::System.Guid uuid,
            global::System.Guid questionUuid,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}