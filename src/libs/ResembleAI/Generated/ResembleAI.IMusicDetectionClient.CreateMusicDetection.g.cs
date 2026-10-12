#nullable enable

namespace ResembleAI
{
    public partial interface IMusicDetectionClient
    {
        /// <summary>
        /// Detect AI-generated music<br/>
        /// Analyze a song or music track and classify it as AI-generated or human-produced.<br/>
        /// Supply audio via one of three intake methods:<br/>
        /// - **Direct file upload**: `multipart/form-data` with the file attached as `file`. Files must be 150 MB or smaller.<br/>
        /// - **Public URL**: `application/json` with a `url` field. Resemble downloads and stores the file before analysis.<br/>
        /// - **Secure upload token**: `application/json` with a `media_token` field obtained from `POST /secure_uploads`.<br/>
        /// Exactly one of `file`, `url`, or `media_token` must be provided per request. Only audio files are<br/>
        /// accepted.<br/>
        /// Processing is asynchronous by default: the response returns immediately with `status: processing`.<br/>
        /// Music detections are standard detections, so you can poll<br/>
        /// [`GET /detect/{uuid}`](/api-reference/deepfake-detection/get-detection) or supply a `callback_url` to<br/>
        /// be notified. Send the `Prefer: wait` header to block until the verdict is available and receive the<br/>
        /// completed item in the same response. Allow a generous client timeout when waiting, since the first<br/>
        /// request after a period of inactivity can take several minutes while the model warms up.<br/>
        /// Each successful analysis is billed as audio Deepfake Detection usage. Failed analyses are not billed.
        /// </summary>
        /// <param name="prefer"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.MusicDetectResponse> CreateMusicDetectionAsync(

            global::ResembleAI.CreateMusicDetectionRequest request,
            global::ResembleAI.DetectMusicPostParametersPrefer? prefer = default,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Detect AI-generated music<br/>
        /// Analyze a song or music track and classify it as AI-generated or human-produced.<br/>
        /// Supply audio via one of three intake methods:<br/>
        /// - **Direct file upload**: `multipart/form-data` with the file attached as `file`. Files must be 150 MB or smaller.<br/>
        /// - **Public URL**: `application/json` with a `url` field. Resemble downloads and stores the file before analysis.<br/>
        /// - **Secure upload token**: `application/json` with a `media_token` field obtained from `POST /secure_uploads`.<br/>
        /// Exactly one of `file`, `url`, or `media_token` must be provided per request. Only audio files are<br/>
        /// accepted.<br/>
        /// Processing is asynchronous by default: the response returns immediately with `status: processing`.<br/>
        /// Music detections are standard detections, so you can poll<br/>
        /// [`GET /detect/{uuid}`](/api-reference/deepfake-detection/get-detection) or supply a `callback_url` to<br/>
        /// be notified. Send the `Prefer: wait` header to block until the verdict is available and receive the<br/>
        /// completed item in the same response. Allow a generous client timeout when waiting, since the first<br/>
        /// request after a period of inactivity can take several minutes while the model warms up.<br/>
        /// Each successful analysis is billed as audio Deepfake Detection usage. Failed analyses are not billed.
        /// </summary>
        /// <param name="prefer"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AutoSDKHttpResponse<global::ResembleAI.MusicDetectResponse>> CreateMusicDetectionAsResponseAsync(

            global::ResembleAI.CreateMusicDetectionRequest request,
            global::ResembleAI.DetectMusicPostParametersPrefer? prefer = default,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Detect AI-generated music<br/>
        /// Analyze a song or music track and classify it as AI-generated or human-produced.<br/>
        /// Supply audio via one of three intake methods:<br/>
        /// - **Direct file upload**: `multipart/form-data` with the file attached as `file`. Files must be 150 MB or smaller.<br/>
        /// - **Public URL**: `application/json` with a `url` field. Resemble downloads and stores the file before analysis.<br/>
        /// - **Secure upload token**: `application/json` with a `media_token` field obtained from `POST /secure_uploads`.<br/>
        /// Exactly one of `file`, `url`, or `media_token` must be provided per request. Only audio files are<br/>
        /// accepted.<br/>
        /// Processing is asynchronous by default: the response returns immediately with `status: processing`.<br/>
        /// Music detections are standard detections, so you can poll<br/>
        /// [`GET /detect/{uuid}`](/api-reference/deepfake-detection/get-detection) or supply a `callback_url` to<br/>
        /// be notified. Send the `Prefer: wait` header to block until the verdict is available and receive the<br/>
        /// completed item in the same response. Allow a generous client timeout when waiting, since the first<br/>
        /// request after a period of inactivity can take several minutes while the model warms up.<br/>
        /// Each successful analysis is billed as audio Deepfake Detection usage. Failed analyses are not billed.
        /// </summary>
        /// <param name="prefer"></param>
        /// <param name="file">
        /// The audio file to analyze. Must be 150 MB or smaller.
        /// </param>
        /// <param name="filename">
        /// The audio file to analyze. Must be 150 MB or smaller.
        /// </param>
        /// <param name="name">
        /// Display name for the detection. Defaults to the source filename.
        /// </param>
        /// <param name="callbackUrl">
        /// POST destination for the result once processing finishes. The body matches the response of `GET /detect/{uuid}`.
        /// </param>
        /// <param name="visualize">
        /// Return a base64-encoded heatmap image in `metrics.image`.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="startRegion">
        /// Start of the segment to analyze, in seconds.
        /// </param>
        /// <param name="endRegion">
        /// End of the segment to analyze, in seconds.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.MusicDetectResponse> CreateMusicDetectionAsync(
            byte[] file,
            string filename,
            global::ResembleAI.DetectMusicPostParametersPrefer? prefer = default,
            string? name = default,
            string? callbackUrl = default,
            bool? visualize = default,
            double? startRegion = default,
            double? endRegion = default,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Detect AI-generated music<br/>
        /// Analyze a song or music track and classify it as AI-generated or human-produced.<br/>
        /// Supply audio via one of three intake methods:<br/>
        /// - **Direct file upload**: `multipart/form-data` with the file attached as `file`. Files must be 150 MB or smaller.<br/>
        /// - **Public URL**: `application/json` with a `url` field. Resemble downloads and stores the file before analysis.<br/>
        /// - **Secure upload token**: `application/json` with a `media_token` field obtained from `POST /secure_uploads`.<br/>
        /// Exactly one of `file`, `url`, or `media_token` must be provided per request. Only audio files are<br/>
        /// accepted.<br/>
        /// Processing is asynchronous by default: the response returns immediately with `status: processing`.<br/>
        /// Music detections are standard detections, so you can poll<br/>
        /// [`GET /detect/{uuid}`](/api-reference/deepfake-detection/get-detection) or supply a `callback_url` to<br/>
        /// be notified. Send the `Prefer: wait` header to block until the verdict is available and receive the<br/>
        /// completed item in the same response. Allow a generous client timeout when waiting, since the first<br/>
        /// request after a period of inactivity can take several minutes while the model warms up.<br/>
        /// Each successful analysis is billed as audio Deepfake Detection usage. Failed analyses are not billed.
        /// </summary>
        /// <param name="prefer"></param>
        /// <param name="file">
        /// The audio file to analyze. Must be 150 MB or smaller.
        /// </param>
        /// <param name="filename">
        /// The audio file to analyze. Must be 150 MB or smaller.
        /// </param>
        /// <param name="name">
        /// Display name for the detection. Defaults to the source filename.
        /// </param>
        /// <param name="callbackUrl">
        /// POST destination for the result once processing finishes. The body matches the response of `GET /detect/{uuid}`.
        /// </param>
        /// <param name="visualize">
        /// Return a base64-encoded heatmap image in `metrics.image`.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="startRegion">
        /// Start of the segment to analyze, in seconds.
        /// </param>
        /// <param name="endRegion">
        /// End of the segment to analyze, in seconds.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.MusicDetectResponse> CreateMusicDetectionAsync(
            global::System.IO.Stream file,
            string filename,
            global::ResembleAI.DetectMusicPostParametersPrefer? prefer = default,
            string? name = default,
            string? callbackUrl = default,
            bool? visualize = default,
            double? startRegion = default,
            double? endRegion = default,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Detect AI-generated music<br/>
        /// Analyze a song or music track and classify it as AI-generated or human-produced.<br/>
        /// Supply audio via one of three intake methods:<br/>
        /// - **Direct file upload**: `multipart/form-data` with the file attached as `file`. Files must be 150 MB or smaller.<br/>
        /// - **Public URL**: `application/json` with a `url` field. Resemble downloads and stores the file before analysis.<br/>
        /// - **Secure upload token**: `application/json` with a `media_token` field obtained from `POST /secure_uploads`.<br/>
        /// Exactly one of `file`, `url`, or `media_token` must be provided per request. Only audio files are<br/>
        /// accepted.<br/>
        /// Processing is asynchronous by default: the response returns immediately with `status: processing`.<br/>
        /// Music detections are standard detections, so you can poll<br/>
        /// [`GET /detect/{uuid}`](/api-reference/deepfake-detection/get-detection) or supply a `callback_url` to<br/>
        /// be notified. Send the `Prefer: wait` header to block until the verdict is available and receive the<br/>
        /// completed item in the same response. Allow a generous client timeout when waiting, since the first<br/>
        /// request after a period of inactivity can take several minutes while the model warms up.<br/>
        /// Each successful analysis is billed as audio Deepfake Detection usage. Failed analyses are not billed.
        /// </summary>
        /// <param name="prefer"></param>
        /// <param name="file">
        /// The audio file to analyze. Must be 150 MB or smaller.
        /// </param>
        /// <param name="filename">
        /// The audio file to analyze. Must be 150 MB or smaller.
        /// </param>
        /// <param name="name">
        /// Display name for the detection. Defaults to the source filename.
        /// </param>
        /// <param name="callbackUrl">
        /// POST destination for the result once processing finishes. The body matches the response of `GET /detect/{uuid}`.
        /// </param>
        /// <param name="visualize">
        /// Return a base64-encoded heatmap image in `metrics.image`.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="startRegion">
        /// Start of the segment to analyze, in seconds.
        /// </param>
        /// <param name="endRegion">
        /// End of the segment to analyze, in seconds.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AutoSDKHttpResponse<global::ResembleAI.MusicDetectResponse>> CreateMusicDetectionAsResponseAsync(
            global::System.IO.Stream file,
            string filename,
            global::ResembleAI.DetectMusicPostParametersPrefer? prefer = default,
            string? name = default,
            string? callbackUrl = default,
            bool? visualize = default,
            double? startRegion = default,
            double? endRegion = default,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}