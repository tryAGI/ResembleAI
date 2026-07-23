#nullable enable

namespace ResembleAI
{
    public partial interface IWatermarkClient
    {
        /// <summary>
        /// Detect watermark<br/>
        /// Detect a watermark in an audio, image, or video file. Audio runs Perth v1 and Perth v2 concurrently; image/video is publicly reported as Perth v2. Processing is asynchronous unless the `Prefer: wait` header is supplied.
        /// </summary>
        /// <param name="prefer"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.WatermarkDetectResponse> DetectWatermarkAsync(

            global::ResembleAI.WatermarkDetectRequest request,
            global::ResembleAI.WatermarkDetectPostParametersPrefer? prefer = default,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Detect watermark<br/>
        /// Detect a watermark in an audio, image, or video file. Audio runs Perth v1 and Perth v2 concurrently; image/video is publicly reported as Perth v2. Processing is asynchronous unless the `Prefer: wait` header is supplied.
        /// </summary>
        /// <param name="prefer"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AutoSDKHttpResponse<global::ResembleAI.WatermarkDetectResponse>> DetectWatermarkAsResponseAsync(

            global::ResembleAI.WatermarkDetectRequest request,
            global::ResembleAI.WatermarkDetectPostParametersPrefer? prefer = default,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Detect watermark<br/>
        /// Detect a watermark in an audio, image, or video file. Audio runs Perth v1 and Perth v2 concurrently; image/video is publicly reported as Perth v2. Processing is asynchronous unless the `Prefer: wait` header is supplied.
        /// </summary>
        /// <param name="prefer"></param>
        /// <param name="url">
        /// Public HTTPS URL to the audio, image, or video source.
        /// </param>
        /// <param name="customMessage">
        /// Message used when applying the image/video watermark. Ignored for audio.<br/>
        /// Default Value: resembleai
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.WatermarkDetectResponse> DetectWatermarkAsync(
            string url,
            global::ResembleAI.WatermarkDetectPostParametersPrefer? prefer = default,
            string? customMessage = default,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}