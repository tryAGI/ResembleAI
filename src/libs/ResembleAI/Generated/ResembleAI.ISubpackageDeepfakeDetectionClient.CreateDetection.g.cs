#nullable enable

namespace ResembleAI
{
    public partial interface ISubpackageDeepfakeDetectionClient
    {
        /// <summary>
        /// Create deepfake detection<br/>
        /// Analyze audio, image, and video for deepfake detection
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.DeepfakeDetectionCreateDetectionResponse200> CreateDetectionAsync(

            global::ResembleAI.CreateDetectionRequest request,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create deepfake detection<br/>
        /// Analyze audio, image, and video for deepfake detection
        /// </summary>
        /// <param name="url">
        /// HTTPS URL to audio, image, or video file
        /// </param>
        /// <param name="callbackUrl">
        /// POST destination when analysis completes
        /// </param>
        /// <param name="visualize">
        /// Generate visualization artifacts
        /// </param>
        /// <param name="frameLength">
        /// Window size in seconds (audio/video)<br/>
        /// Default Value: 2
        /// </param>
        /// <param name="startRegion">
        /// Start of segment to analyze (seconds)
        /// </param>
        /// <param name="endRegion">
        /// End of segment to analyze (seconds)
        /// </param>
        /// <param name="maxVideoFps">
        /// Downsample high-frame-rate media
        /// </param>
        /// <param name="maxVideoSecs">
        /// Cap processed duration
        /// </param>
        /// <param name="modelTypes">
        /// Use talking_head for face-swaps
        /// </param>
        /// <param name="intelligence">
        /// Run multimodal intelligence analysis on the media<br/>
        /// Default Value: false
        /// </param>
        /// <param name="audioSourceTracing">
        /// Enable audio source tracing to identify synthetic audio origin<br/>
        /// Default Value: false
        /// </param>
        /// <param name="useReverseSearch">
        /// Enable reverse image search to improve detection accuracy for image files. Searches the web for matching images and uses AI to classify whether the match indicates a known fake. Only applies to image detections.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="useOodDetector">
        /// Enable out-of-distribution detection<br/>
        /// Default Value: false
        /// </param>
        /// <param name="zeroRetentionMode">
        /// Enable Zero Retention Mode to automatically delete submitted media after detection completes. When enabled, media URLs are redacted and the filename is tokenized.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.DeepfakeDetectionCreateDetectionResponse200> CreateDetectionAsync(
            string url,
            string? callbackUrl = default,
            bool? visualize = default,
            int? frameLength = default,
            double? startRegion = default,
            double? endRegion = default,
            double? maxVideoFps = default,
            double? maxVideoSecs = default,
            global::ResembleAI.DetectPostRequestBodyContentApplicationJsonSchemaModelTypes? modelTypes = default,
            bool? intelligence = default,
            bool? audioSourceTracing = default,
            bool? useReverseSearch = default,
            bool? useOodDetector = default,
            bool? zeroRetentionMode = default,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}