#nullable enable

namespace ResembleAI
{
    public partial interface ISubpackageDeepfakeDetectionClient
    {
        /// <summary>
        /// Create deepfake detection<br/>
        /// Analyze audio, image, and video for deepfake detection.<br/>
        /// Supply media via one of three intake methods:<br/>
        /// - **Direct file upload** — `multipart/form-data` with the file attached as `file`. Files must be 150 MB or smaller and use one of the supported audio/video/image extensions. For larger files, use the secure upload flow.<br/>
        /// - **Public URL** — `application/json` with a `url` field. The API fetches the URL itself.<br/>
        /// - **Secure upload token** — `application/json` with a `media_token` field obtained from `POST /secure_uploads`.<br/>
        /// Exactly one of `file`, `url`, or `media_token` must be provided per request.
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
        /// Analyze audio, image, and video for deepfake detection.<br/>
        /// Supply media via one of three intake methods:<br/>
        /// - **Direct file upload** — `multipart/form-data` with the file attached as `file`. Files must be 150 MB or smaller and use one of the supported audio/video/image extensions. For larger files, use the secure upload flow.<br/>
        /// - **Public URL** — `application/json` with a `url` field. The API fetches the URL itself.<br/>
        /// - **Secure upload token** — `application/json` with a `media_token` field obtained from `POST /secure_uploads`.<br/>
        /// Exactly one of `file`, `url`, or `media_token` must be provided per request.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AutoSDKHttpResponse<global::ResembleAI.DeepfakeDetectionCreateDetectionResponse200>> CreateDetectionAsResponseAsync(

            global::ResembleAI.CreateDetectionRequest request,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create deepfake detection<br/>
        /// Analyze audio, image, and video for deepfake detection.<br/>
        /// Supply media via one of three intake methods:<br/>
        /// - **Direct file upload** — `multipart/form-data` with the file attached as `file`. Files must be 150 MB or smaller and use one of the supported audio/video/image extensions. For larger files, use the secure upload flow.<br/>
        /// - **Public URL** — `application/json` with a `url` field. The API fetches the URL itself.<br/>
        /// - **Secure upload token** — `application/json` with a `media_token` field obtained from `POST /secure_uploads`.<br/>
        /// Exactly one of `file`, `url`, or `media_token` must be provided per request.
        /// </summary>
        /// <param name="file">
        /// The media file to analyze (audio, video, or image). Must be 150 MB or smaller.
        /// </param>
        /// <param name="filename">
        /// The media file to analyze (audio, video, or image). Must be 150 MB or smaller.
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
        /// <param name="maxVideoSecs">
        /// Cap processed duration
        /// </param>
        /// <param name="modelTypes">
        /// Use talking_head for face-swaps
        /// </param>
        /// <param name="modality">
        /// Video only. Selects which detection components run for a video file:<br/>
        /// `audio` (audio track only), `video` (visual frames only), or `all` (both — the default).<br/>
        /// Ignored for audio and image inputs. Invalid values are rejected with HTTP 400.<br/>
        /// Default Value: all
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
        /// Enable reverse image search to improve detection accuracy for image files. Only applies to image detections.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="useOodDetector">
        /// Enable out-of-distribution detection<br/>
        /// Default Value: false
        /// </param>
        /// <param name="zeroRetentionMode">
        /// Enable Zero Retention Mode to automatically delete submitted media after detection completes.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.DeepfakeDetectionCreateDetectionResponse200> CreateDetectionAsync(
            byte[] file,
            string filename,
            string? callbackUrl = default,
            bool? visualize = default,
            int? frameLength = default,
            double? startRegion = default,
            double? endRegion = default,
            double? maxVideoSecs = default,
            global::ResembleAI.DetectPostRequestBodyContentMultipartFormDataSchemaModelTypes? modelTypes = default,
            global::ResembleAI.DetectPostRequestBodyContentMultipartFormDataSchemaModality? modality = default,
            bool? intelligence = default,
            bool? audioSourceTracing = default,
            bool? useReverseSearch = default,
            bool? useOodDetector = default,
            bool? zeroRetentionMode = default,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create deepfake detection<br/>
        /// Analyze audio, image, and video for deepfake detection.<br/>
        /// Supply media via one of three intake methods:<br/>
        /// - **Direct file upload** — `multipart/form-data` with the file attached as `file`. Files must be 150 MB or smaller and use one of the supported audio/video/image extensions. For larger files, use the secure upload flow.<br/>
        /// - **Public URL** — `application/json` with a `url` field. The API fetches the URL itself.<br/>
        /// - **Secure upload token** — `application/json` with a `media_token` field obtained from `POST /secure_uploads`.<br/>
        /// Exactly one of `file`, `url`, or `media_token` must be provided per request.
        /// </summary>
        /// <param name="file">
        /// The media file to analyze (audio, video, or image). Must be 150 MB or smaller.
        /// </param>
        /// <param name="filename">
        /// The media file to analyze (audio, video, or image). Must be 150 MB or smaller.
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
        /// <param name="maxVideoSecs">
        /// Cap processed duration
        /// </param>
        /// <param name="modelTypes">
        /// Use talking_head for face-swaps
        /// </param>
        /// <param name="modality">
        /// Video only. Selects which detection components run for a video file:<br/>
        /// `audio` (audio track only), `video` (visual frames only), or `all` (both — the default).<br/>
        /// Ignored for audio and image inputs. Invalid values are rejected with HTTP 400.<br/>
        /// Default Value: all
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
        /// Enable reverse image search to improve detection accuracy for image files. Only applies to image detections.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="useOodDetector">
        /// Enable out-of-distribution detection<br/>
        /// Default Value: false
        /// </param>
        /// <param name="zeroRetentionMode">
        /// Enable Zero Retention Mode to automatically delete submitted media after detection completes.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.DeepfakeDetectionCreateDetectionResponse200> CreateDetectionAsync(
            global::System.IO.Stream file,
            string filename,
            string? callbackUrl = default,
            bool? visualize = default,
            int? frameLength = default,
            double? startRegion = default,
            double? endRegion = default,
            double? maxVideoSecs = default,
            global::ResembleAI.DetectPostRequestBodyContentMultipartFormDataSchemaModelTypes? modelTypes = default,
            global::ResembleAI.DetectPostRequestBodyContentMultipartFormDataSchemaModality? modality = default,
            bool? intelligence = default,
            bool? audioSourceTracing = default,
            bool? useReverseSearch = default,
            bool? useOodDetector = default,
            bool? zeroRetentionMode = default,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create deepfake detection<br/>
        /// Analyze audio, image, and video for deepfake detection.<br/>
        /// Supply media via one of three intake methods:<br/>
        /// - **Direct file upload** — `multipart/form-data` with the file attached as `file`. Files must be 150 MB or smaller and use one of the supported audio/video/image extensions. For larger files, use the secure upload flow.<br/>
        /// - **Public URL** — `application/json` with a `url` field. The API fetches the URL itself.<br/>
        /// - **Secure upload token** — `application/json` with a `media_token` field obtained from `POST /secure_uploads`.<br/>
        /// Exactly one of `file`, `url`, or `media_token` must be provided per request.
        /// </summary>
        /// <param name="file">
        /// The media file to analyze (audio, video, or image). Must be 150 MB or smaller.
        /// </param>
        /// <param name="filename">
        /// The media file to analyze (audio, video, or image). Must be 150 MB or smaller.
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
        /// <param name="maxVideoSecs">
        /// Cap processed duration
        /// </param>
        /// <param name="modelTypes">
        /// Use talking_head for face-swaps
        /// </param>
        /// <param name="modality">
        /// Video only. Selects which detection components run for a video file:<br/>
        /// `audio` (audio track only), `video` (visual frames only), or `all` (both — the default).<br/>
        /// Ignored for audio and image inputs. Invalid values are rejected with HTTP 400.<br/>
        /// Default Value: all
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
        /// Enable reverse image search to improve detection accuracy for image files. Only applies to image detections.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="useOodDetector">
        /// Enable out-of-distribution detection<br/>
        /// Default Value: false
        /// </param>
        /// <param name="zeroRetentionMode">
        /// Enable Zero Retention Mode to automatically delete submitted media after detection completes.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AutoSDKHttpResponse<global::ResembleAI.DeepfakeDetectionCreateDetectionResponse200>> CreateDetectionAsResponseAsync(
            global::System.IO.Stream file,
            string filename,
            string? callbackUrl = default,
            bool? visualize = default,
            int? frameLength = default,
            double? startRegion = default,
            double? endRegion = default,
            double? maxVideoSecs = default,
            global::ResembleAI.DetectPostRequestBodyContentMultipartFormDataSchemaModelTypes? modelTypes = default,
            global::ResembleAI.DetectPostRequestBodyContentMultipartFormDataSchemaModality? modality = default,
            bool? intelligence = default,
            bool? audioSourceTracing = default,
            bool? useReverseSearch = default,
            bool? useOodDetector = default,
            bool? zeroRetentionMode = default,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}