#nullable enable

namespace ResembleAI
{
    public partial interface IWatermarkClient
    {
        /// <summary>
        /// Apply watermark<br/>
        /// Apply a Perth v2 watermark to an audio, image, or video file. The media type is automatically detected from the file content. Processing is asynchronous unless the `Prefer: wait` header is supplied.
        /// </summary>
        /// <param name="prefer"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.WatermarkApplyResponse> ApplyWatermarkAsync(

            global::ResembleAI.WatermarkApplyRequest request,
            global::ResembleAI.WatermarkApplyPostParametersPrefer? prefer = default,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Apply watermark<br/>
        /// Apply a Perth v2 watermark to an audio, image, or video file. The media type is automatically detected from the file content. Processing is asynchronous unless the `Prefer: wait` header is supplied.
        /// </summary>
        /// <param name="prefer"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AutoSDKHttpResponse<global::ResembleAI.WatermarkApplyResponse>> ApplyWatermarkAsResponseAsync(

            global::ResembleAI.WatermarkApplyRequest request,
            global::ResembleAI.WatermarkApplyPostParametersPrefer? prefer = default,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Apply watermark<br/>
        /// Apply a Perth v2 watermark to an audio, image, or video file. The media type is automatically detected from the file content. Processing is asynchronous unless the `Prefer: wait` header is supplied.
        /// </summary>
        /// <param name="prefer"></param>
        /// <param name="url">
        /// Public HTTPS URL to the audio, image, or video source.
        /// </param>
        /// <param name="strength">
        /// Watermark strength for image/video. Ignored for audio.<br/>
        /// Default Value: 0.2F
        /// </param>
        /// <param name="customMessage">
        /// Message to embed in image/video. Ignored for audio.<br/>
        /// Default Value: resembleai
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.WatermarkApplyResponse> ApplyWatermarkAsync(
            string url,
            global::ResembleAI.WatermarkApplyPostParametersPrefer? prefer = default,
            double? strength = default,
            string? customMessage = default,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}