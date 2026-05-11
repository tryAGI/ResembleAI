#nullable enable

namespace ResembleAI
{
    public partial interface ISubpackageSpeechToTextClient
    {
        /// <summary>
        /// Create transcript job<br/>
        /// Submit audio or video for transcription
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.SpeechToTextCreateTranscriptResponse200> CreateTranscriptAsync(

            global::ResembleAI.CreateTranscriptRequest request,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create transcript job<br/>
        /// Submit audio or video for transcription
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AutoSDKHttpResponse<global::ResembleAI.SpeechToTextCreateTranscriptResponse200>> CreateTranscriptAsResponseAsync(

            global::ResembleAI.CreateTranscriptRequest request,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create transcript job<br/>
        /// Submit audio or video for transcription
        /// </summary>
        /// <param name="file">
        /// Audio or video file (max 500 MB, 20 minutes)
        /// </param>
        /// <param name="filename">
        /// Audio or video file (max 500 MB, 20 minutes)
        /// </param>
        /// <param name="query">
        /// Optional intelligence question to evaluate after transcription
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.SpeechToTextCreateTranscriptResponse200> CreateTranscriptAsync(
            byte[]? file = default,
            string? filename = default,
            string? query = default,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}