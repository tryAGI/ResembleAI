#nullable enable

namespace ResembleAI
{
    public partial interface ISubpackageWatermarkClient
    {
        /// <summary>
        /// Apply watermark<br/>
        /// Apply a watermark to an audio, image, or video file. The media type is automatically detected from the file content. Use the `Prefer: wait` header for synchronous processing.
        /// </summary>
        /// <param name="prefer"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.WatermarkApplyWatermarkResponse200> ApplyWatermarkAsync(

            global::ResembleAI.ApplyWatermarkRequest request,
            global::ResembleAI.WatermarkApplyPostParametersPrefer? prefer = default,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Apply watermark<br/>
        /// Apply a watermark to an audio, image, or video file. The media type is automatically detected from the file content. Use the `Prefer: wait` header for synchronous processing.
        /// </summary>
        /// <param name="prefer"></param>
        /// <param name="url">
        /// HTTPS URL to the media file (audio, image, or video).
        /// </param>
        /// <param name="strength">
        /// Watermark strength for image/video. Ignored for audio.<br/>
        /// Default Value: 0.2F
        /// </param>
        /// <param name="customMessage">
        /// Custom message to embed for image/video. Ignored for audio.<br/>
        /// Default Value: resembleai
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.WatermarkApplyWatermarkResponse200> ApplyWatermarkAsync(
            string url,
            global::ResembleAI.WatermarkApplyPostParametersPrefer? prefer = default,
            double? strength = default,
            string? customMessage = default,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}