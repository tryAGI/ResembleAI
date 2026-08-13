#nullable enable

namespace ResembleAI
{
    public partial interface ISignalClient
    {
        /// <summary>
        /// Score content<br/>
        /// Score a piece of content against the fraud and scam categories available to your team<br/>
        /// and return a verdict with the best-matching categories.<br/>
        /// Supply exactly one of:<br/>
        /// - **Text** — `application/json` with a `text` field.<br/>
        /// - **File** — `multipart/form-data` with the media attached as `file`. Audio, image, and<br/>
        ///   video are supported, up to 15 MB. The media type is detected from the file's MIME type<br/>
        ///   unless `media_type` is supplied.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.SignalScoreResponse> CreateSignalSubmissionAsync(

            global::ResembleAI.CreateSignalSubmissionRequest request,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Score content<br/>
        /// Score a piece of content against the fraud and scam categories available to your team<br/>
        /// and return a verdict with the best-matching categories.<br/>
        /// Supply exactly one of:<br/>
        /// - **Text** — `application/json` with a `text` field.<br/>
        /// - **File** — `multipart/form-data` with the media attached as `file`. Audio, image, and<br/>
        ///   video are supported, up to 15 MB. The media type is detected from the file's MIME type<br/>
        ///   unless `media_type` is supplied.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AutoSDKHttpResponse<global::ResembleAI.SignalScoreResponse>> CreateSignalSubmissionAsResponseAsync(

            global::ResembleAI.CreateSignalSubmissionRequest request,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Score content<br/>
        /// Score a piece of content against the fraud and scam categories available to your team<br/>
        /// and return a verdict with the best-matching categories.<br/>
        /// Supply exactly one of:<br/>
        /// - **Text** — `application/json` with a `text` field.<br/>
        /// - **File** — `multipart/form-data` with the media attached as `file`. Audio, image, and<br/>
        ///   video are supported, up to 15 MB. The media type is detected from the file's MIME type<br/>
        ///   unless `media_type` is supplied.
        /// </summary>
        /// <param name="text">
        /// Text to analyze.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.SignalScoreResponse> CreateSignalSubmissionAsync(
            string text,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}