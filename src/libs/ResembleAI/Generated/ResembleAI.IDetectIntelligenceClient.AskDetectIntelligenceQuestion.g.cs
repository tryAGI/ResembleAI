#nullable enable

namespace ResembleAI
{
    public partial interface IDetectIntelligenceClient
    {
        /// <summary>
        /// Ask a question about a detection<br/>
        /// Submit a natural-language question about a completed detection report. Returns 202 Accepted while the answer is generated in the background.
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.DetectIntelligenceAskDetectIntelligenceQuestionResponse202> AskDetectIntelligenceQuestionAsync(
            string uuid,

            global::ResembleAI.AskDetectIntelligenceQuestionRequest request,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Ask a question about a detection<br/>
        /// Submit a natural-language question about a completed detection report. Returns 202 Accepted while the answer is generated in the background.
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AutoSDKHttpResponse<global::ResembleAI.DetectIntelligenceAskDetectIntelligenceQuestionResponse202>> AskDetectIntelligenceQuestionAsResponseAsync(
            string uuid,

            global::ResembleAI.AskDetectIntelligenceQuestionRequest request,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Ask a question about a detection<br/>
        /// Submit a natural-language question about a completed detection report. Returns 202 Accepted while the answer is generated in the background.
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="query">
        /// The natural-language question to ask about the detection
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.DetectIntelligenceAskDetectIntelligenceQuestionResponse202> AskDetectIntelligenceQuestionAsync(
            string uuid,
            string query,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}