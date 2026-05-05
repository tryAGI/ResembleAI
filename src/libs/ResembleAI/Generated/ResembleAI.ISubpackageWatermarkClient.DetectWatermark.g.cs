#nullable enable

namespace ResembleAI
{
    public partial interface ISubpackageWatermarkClient
    {
        /// <summary>
        /// Detect watermark<br/>
        /// Detect a watermark in an audio, image, or video file. The media type is automatically detected from the file content. Use the `Prefer: wait` header for synchronous processing.
        /// </summary>
        /// <param name="prefer"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.WatermarkDetectWatermarkResponse200> DetectWatermarkAsync(

            global::ResembleAI.DetectWatermarkRequest request,
            global::ResembleAI.WatermarkDetectPostParametersPrefer? prefer = default,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Detect watermark<br/>
        /// Detect a watermark in an audio, image, or video file. The media type is automatically detected from the file content. Use the `Prefer: wait` header for synchronous processing.
        /// </summary>
        /// <param name="prefer"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AutoSDKHttpResponse<global::ResembleAI.WatermarkDetectWatermarkResponse200>> DetectWatermarkAsResponseAsync(

            global::ResembleAI.DetectWatermarkRequest request,
            global::ResembleAI.WatermarkDetectPostParametersPrefer? prefer = default,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Detect watermark<br/>
        /// Detect a watermark in an audio, image, or video file. The media type is automatically detected from the file content. Use the `Prefer: wait` header for synchronous processing.
        /// </summary>
        /// <param name="prefer"></param>
        /// <param name="url">
        /// HTTPS URL to the media file (audio, image, or video).
        /// </param>
        /// <param name="customMessage">
        /// Custom message used during encoding for image/video. Ignored for audio.<br/>
        /// Default Value: resembleai
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.WatermarkDetectWatermarkResponse200> DetectWatermarkAsync(
            string url,
            global::ResembleAI.WatermarkDetectPostParametersPrefer? prefer = default,
            string? customMessage = default,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}