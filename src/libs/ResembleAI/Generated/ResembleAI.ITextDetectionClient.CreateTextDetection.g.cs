#nullable enable

namespace ResembleAI
{
    public partial interface ITextDetectionClient
    {
        /// <summary>
        /// Detect AI-generated text<br/>
        /// Submit a passage of text and classify it as AI-generated or human-written.<br/>
        /// Processing is asynchronous by default: the response returns immediately with `status: processing`,<br/>
        /// and you can poll `GET /text_detect/{uuid}` or supply a `callback_url` to be notified. Send the<br/>
        /// `Prefer: wait` header to block until the verdict is available and receive the completed item in the<br/>
        /// same response. Allow a generous client timeout when waiting, since the first request after a period<br/>
        /// of inactivity can take several minutes while the model warms up.<br/>
        /// Requests are rejected with a 400 when `text` is missing, exceeds 100,000 characters, or contains<br/>
        /// fewer than 25 words. Each successfully scored request bills one Text Detection unit; abstained<br/>
        /// (`uncertain`) results are not billed.
        /// </summary>
        /// <param name="prefer"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.TextDetectResponse> CreateTextDetectionAsync(

            global::ResembleAI.TextDetectRequest request,
            global::ResembleAI.TextDetectPostParametersPrefer? prefer = default,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Detect AI-generated text<br/>
        /// Submit a passage of text and classify it as AI-generated or human-written.<br/>
        /// Processing is asynchronous by default: the response returns immediately with `status: processing`,<br/>
        /// and you can poll `GET /text_detect/{uuid}` or supply a `callback_url` to be notified. Send the<br/>
        /// `Prefer: wait` header to block until the verdict is available and receive the completed item in the<br/>
        /// same response. Allow a generous client timeout when waiting, since the first request after a period<br/>
        /// of inactivity can take several minutes while the model warms up.<br/>
        /// Requests are rejected with a 400 when `text` is missing, exceeds 100,000 characters, or contains<br/>
        /// fewer than 25 words. Each successfully scored request bills one Text Detection unit; abstained<br/>
        /// (`uncertain`) results are not billed.
        /// </summary>
        /// <param name="prefer"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AutoSDKHttpResponse<global::ResembleAI.TextDetectResponse>> CreateTextDetectionAsResponseAsync(

            global::ResembleAI.TextDetectRequest request,
            global::ResembleAI.TextDetectPostParametersPrefer? prefer = default,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Detect AI-generated text<br/>
        /// Submit a passage of text and classify it as AI-generated or human-written.<br/>
        /// Processing is asynchronous by default: the response returns immediately with `status: processing`,<br/>
        /// and you can poll `GET /text_detect/{uuid}` or supply a `callback_url` to be notified. Send the<br/>
        /// `Prefer: wait` header to block until the verdict is available and receive the completed item in the<br/>
        /// same response. Allow a generous client timeout when waiting, since the first request after a period<br/>
        /// of inactivity can take several minutes while the model warms up.<br/>
        /// Requests are rejected with a 400 when `text` is missing, exceeds 100,000 characters, or contains<br/>
        /// fewer than 25 words. Each successfully scored request bills one Text Detection unit; abstained<br/>
        /// (`uncertain`) results are not billed.
        /// </summary>
        /// <param name="prefer"></param>
        /// <param name="text">
        /// The text to analyze. Must contain at least 25 words (whitespace-delimited) and at most 100,000 characters. Shorter passages are rejected with a 400 because no threshold reliably separates casual human writing from AI-generated text below that length.
        /// </param>
        /// <param name="thinking">
        /// How much reasoning effort the detector spends on the passage. Higher levels can improve accuracy on ambiguous text at the cost of latency.<br/>
        /// Default Value: low
        /// </param>
        /// <param name="threshold">
        /// Probability cutoff used to turn the AI-likelihood score into the `ai` or `human` prediction. Scores at or above the threshold are reported as `ai`.
        /// </param>
        /// <param name="callbackUrl">
        /// POST destination for the result once processing finishes. The body matches the response of `GET /text_detect/{uuid}` with an additional top-level `error` field when analysis failed.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.TextDetectResponse> CreateTextDetectionAsync(
            string text,
            global::ResembleAI.TextDetectPostParametersPrefer? prefer = default,
            global::ResembleAI.TextDetectRequestThinking? thinking = default,
            double? threshold = default,
            string? callbackUrl = default,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}