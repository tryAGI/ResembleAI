#nullable enable

namespace ResembleAI
{
    public partial interface IDetectIntelligenceClient
    {
        /// <summary>
        /// Get answer to a detection question<br/>
        /// Retrieve the status and answer for a previously submitted question. Poll until status is completed or failed.
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="questionUuid"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.DetectIntelligenceGetDetectIntelligenceQuestionResponse200> GetDetectIntelligenceQuestionAsync(
            string uuid,
            string questionUuid,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get answer to a detection question<br/>
        /// Retrieve the status and answer for a previously submitted question. Poll until status is completed or failed.
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="questionUuid"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AutoSDKHttpResponse<global::ResembleAI.DetectIntelligenceGetDetectIntelligenceQuestionResponse200>> GetDetectIntelligenceQuestionAsResponseAsync(
            string uuid,
            string questionUuid,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}