#nullable enable

namespace ResembleAI
{
    public partial interface IDeepfakeDetectionClient
    {
        /// <summary>
        /// Submit detection feedback<br/>
        /// Tell Resemble whether a detection verdict was right — and when it wasn't, what it<br/>
        /// should have been. The answer is stored with a snapshot of what the model said at the<br/>
        /// time of submission (verdict, score, media type, raw metrics), so it stays interpretable<br/>
        /// even if the detect is later re-run or deleted.<br/>
        /// Upserts on `(detect, user)`: re-posting edits your existing answer rather than adding a<br/>
        /// second one. There is no separate update call. Feedback is per user, not per team — a<br/>
        /// teammate's answer on the same detect is invisible to you.<br/>
        /// The detect must have completed processing; feedback on a pending or failed detect is<br/>
        /// rejected with 400. Teams without Detect access also receive 400 (not 403).
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.DeepfakeDetectionCreateDetectFeedbackResponse200> CreateDetectFeedbackAsync(
            string uuid,

            global::ResembleAI.CreateDetectFeedbackRequest request,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Submit detection feedback<br/>
        /// Tell Resemble whether a detection verdict was right — and when it wasn't, what it<br/>
        /// should have been. The answer is stored with a snapshot of what the model said at the<br/>
        /// time of submission (verdict, score, media type, raw metrics), so it stays interpretable<br/>
        /// even if the detect is later re-run or deleted.<br/>
        /// Upserts on `(detect, user)`: re-posting edits your existing answer rather than adding a<br/>
        /// second one. There is no separate update call. Feedback is per user, not per team — a<br/>
        /// teammate's answer on the same detect is invisible to you.<br/>
        /// The detect must have completed processing; feedback on a pending or failed detect is<br/>
        /// rejected with 400. Teams without Detect access also receive 400 (not 403).
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AutoSDKHttpResponse<global::ResembleAI.DeepfakeDetectionCreateDetectFeedbackResponse200>> CreateDetectFeedbackAsResponseAsync(
            string uuid,

            global::ResembleAI.CreateDetectFeedbackRequest request,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Submit detection feedback<br/>
        /// Tell Resemble whether a detection verdict was right — and when it wasn't, what it<br/>
        /// should have been. The answer is stored with a snapshot of what the model said at the<br/>
        /// time of submission (verdict, score, media type, raw metrics), so it stays interpretable<br/>
        /// even if the detect is later re-run or deleted.<br/>
        /// Upserts on `(detect, user)`: re-posting edits your existing answer rather than adding a<br/>
        /// second one. There is no separate update call. Feedback is per user, not per team — a<br/>
        /// teammate's answer on the same detect is invisible to you.<br/>
        /// The detect must have completed processing; feedback on a pending or failed detect is<br/>
        /// rejected with 400. Teams without Detect access also receive 400 (not 403).
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="type">
        /// What the verdict should have been.<br/>
        ///   - `correct` — the verdict was right.<br/>
        ///   - `should_be_ai_generated` — we said authentic; it is AI-generated.<br/>
        ///   - `should_be_authentic` — we said AI-generated; it is genuine and unaltered.<br/>
        ///   - `should_be_non_ai` — no model generated it, but it may still be edited, spliced, or a human impersonation.<br/>
        ///   - `should_be_neutral` — neither call is right; the media is genuinely ambiguous.<br/>
        ///   - `skipped` — the verdict was wrong, but the reviewer didn't say how.
        /// </param>
        /// <param name="comment">
        /// Free text, up to 1000 characters. Trimmed; blank becomes `null`.
        /// </param>
        /// <param name="source">
        /// Where the answer came from. Use a stable, aggregatable value such as a product<br/>
        /// or queue name — not a per-request identifier. Truncated to 64 characters<br/>
        /// rather than rejected.<br/>
        /// Default Value: api
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.DeepfakeDetectionCreateDetectFeedbackResponse200> CreateDetectFeedbackAsync(
            string uuid,
            global::ResembleAI.DetectUuidFeedbackPostRequestBodyContentApplicationJsonSchemaType type,
            string? comment = default,
            string? source = default,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}