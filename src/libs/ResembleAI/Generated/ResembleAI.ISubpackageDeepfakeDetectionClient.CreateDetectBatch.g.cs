#nullable enable

namespace ResembleAI
{
    public partial interface ISubpackageDeepfakeDetectionClient
    {
        /// <summary>
        /// Create a batch deepfake detection job<br/>
        /// Submit up to 50 files in a single request and process them as a single logical<br/>
        /// group. Returns HTTP 202 with a batch UUID; each file is analyzed in the<br/>
        /// background and individual results are available via `GET /detect/{uuid}` for<br/>
        /// each entry in `detect_uuids`.<br/>
        /// Two intake methods:<br/>
        /// - **Multiple media files** — repeated `files[]` form fields.<br/>
        /// - **Single zip archive** — a single `file` form field whose value is a `.zip`<br/>
        ///   containing the media files. Non-media entries are skipped.<br/>
        /// Provide one of `files[]` or `file=&lt;...&gt;.zip` per request. Synchronous mode<br/>
        /// (`Prefer: wait`) is not supported and returns 400 if sent.<br/>
        /// Constraints:<br/>
        /// - Maximum 50 files per batch.<br/>
        /// - Maximum 500 MB total upload size across all files.<br/>
        /// - Allowed file types match `POST /detect`'s direct-upload allowlist.<br/>
        /// - All-or-nothing billing: if the team's wallet cannot cover the projected cost<br/>
        ///   for every file, the request is rejected with 402 and no detects are created.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.DeepfakeDetectionCreateDetectBatchResponse202> CreateDetectBatchAsync(

            global::ResembleAI.CreateDetectBatchRequest request,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a batch deepfake detection job<br/>
        /// Submit up to 50 files in a single request and process them as a single logical<br/>
        /// group. Returns HTTP 202 with a batch UUID; each file is analyzed in the<br/>
        /// background and individual results are available via `GET /detect/{uuid}` for<br/>
        /// each entry in `detect_uuids`.<br/>
        /// Two intake methods:<br/>
        /// - **Multiple media files** — repeated `files[]` form fields.<br/>
        /// - **Single zip archive** — a single `file` form field whose value is a `.zip`<br/>
        ///   containing the media files. Non-media entries are skipped.<br/>
        /// Provide one of `files[]` or `file=&lt;...&gt;.zip` per request. Synchronous mode<br/>
        /// (`Prefer: wait`) is not supported and returns 400 if sent.<br/>
        /// Constraints:<br/>
        /// - Maximum 50 files per batch.<br/>
        /// - Maximum 500 MB total upload size across all files.<br/>
        /// - Allowed file types match `POST /detect`'s direct-upload allowlist.<br/>
        /// - All-or-nothing billing: if the team's wallet cannot cover the projected cost<br/>
        ///   for every file, the request is rejected with 402 and no detects are created.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AutoSDKHttpResponse<global::ResembleAI.DeepfakeDetectionCreateDetectBatchResponse202>> CreateDetectBatchAsResponseAsync(

            global::ResembleAI.CreateDetectBatchRequest request,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a batch deepfake detection job<br/>
        /// Submit up to 50 files in a single request and process them as a single logical<br/>
        /// group. Returns HTTP 202 with a batch UUID; each file is analyzed in the<br/>
        /// background and individual results are available via `GET /detect/{uuid}` for<br/>
        /// each entry in `detect_uuids`.<br/>
        /// Two intake methods:<br/>
        /// - **Multiple media files** — repeated `files[]` form fields.<br/>
        /// - **Single zip archive** — a single `file` form field whose value is a `.zip`<br/>
        ///   containing the media files. Non-media entries are skipped.<br/>
        /// Provide one of `files[]` or `file=&lt;...&gt;.zip` per request. Synchronous mode<br/>
        /// (`Prefer: wait`) is not supported and returns 400 if sent.<br/>
        /// Constraints:<br/>
        /// - Maximum 50 files per batch.<br/>
        /// - Maximum 500 MB total upload size across all files.<br/>
        /// - Allowed file types match `POST /detect`'s direct-upload allowlist.<br/>
        /// - All-or-nothing billing: if the team's wallet cannot cover the projected cost<br/>
        ///   for every file, the request is rejected with 402 and no detects are created.
        /// </summary>
        /// <param name="files">
        /// One or more media files. Repeat the `files[]` field for each file. Mutually exclusive with `file`.
        /// </param>
        /// <param name="file">
        /// A single `.zip` archive containing media files. Mutually exclusive with `files[]`.
        /// </param>
        /// <param name="filename">
        /// A single `.zip` archive containing media files. Mutually exclusive with `files[]`.
        /// </param>
        /// <param name="callbackUrl">
        /// POST destination invoked when the batch reaches a terminal state.
        /// </param>
        /// <param name="intelligence">
        /// Run multimodal intelligence on every file in the batch.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="searchIdentity">
        /// Run identity search against the team's saved identities (audio/video only).<br/>
        /// Default Value: false
        /// </param>
        /// <param name="visualize">
        /// Generate visualization artifacts.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="audioSourceTracingEnabled">
        /// Enable audio source tracing on each audio file.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="frameLength">
        /// Window size in seconds (audio/video).
        /// </param>
        /// <param name="startRegion">
        /// Start of segment to analyze (seconds).
        /// </param>
        /// <param name="endRegion">
        /// End of segment to analyze (seconds).
        /// </param>
        /// <param name="maxVideoSecs">
        /// Cap processed video duration.
        /// </param>
        /// <param name="useLlm">
        /// Use LLM-assisted video analysis.
        /// </param>
        /// <param name="zeroRetentionMode">
        /// Enable Zero Retention Mode for every file in the batch.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.DeepfakeDetectionCreateDetectBatchResponse202> CreateDetectBatchAsync(
            global::System.Collections.Generic.IList<byte[]>? files = default,
            byte[]? file = default,
            string? filename = default,
            string? callbackUrl = default,
            bool? intelligence = default,
            bool? searchIdentity = default,
            bool? visualize = default,
            bool? audioSourceTracingEnabled = default,
            int? frameLength = default,
            double? startRegion = default,
            double? endRegion = default,
            double? maxVideoSecs = default,
            bool? useLlm = default,
            bool? zeroRetentionMode = default,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a batch deepfake detection job<br/>
        /// Submit up to 50 files in a single request and process them as a single logical<br/>
        /// group. Returns HTTP 202 with a batch UUID; each file is analyzed in the<br/>
        /// background and individual results are available via `GET /detect/{uuid}` for<br/>
        /// each entry in `detect_uuids`.<br/>
        /// Two intake methods:<br/>
        /// - **Multiple media files** — repeated `files[]` form fields.<br/>
        /// - **Single zip archive** — a single `file` form field whose value is a `.zip`<br/>
        ///   containing the media files. Non-media entries are skipped.<br/>
        /// Provide one of `files[]` or `file=&lt;...&gt;.zip` per request. Synchronous mode<br/>
        /// (`Prefer: wait`) is not supported and returns 400 if sent.<br/>
        /// Constraints:<br/>
        /// - Maximum 50 files per batch.<br/>
        /// - Maximum 500 MB total upload size across all files.<br/>
        /// - Allowed file types match `POST /detect`'s direct-upload allowlist.<br/>
        /// - All-or-nothing billing: if the team's wallet cannot cover the projected cost<br/>
        ///   for every file, the request is rejected with 402 and no detects are created.
        /// </summary>
        /// <param name="files">
        /// One or more media files. Repeat the `files[]` field for each file. Mutually exclusive with `file`.
        /// </param>
        /// <param name="filesFileNames">
        /// Optional file names to use for the multipart 'files[]' file parts.
        /// </param>
        /// <param name="file">
        /// A single `.zip` archive containing media files. Mutually exclusive with `files[]`.
        /// </param>
        /// <param name="filename">
        /// A single `.zip` archive containing media files. Mutually exclusive with `files[]`.
        /// </param>
        /// <param name="callbackUrl">
        /// POST destination invoked when the batch reaches a terminal state.
        /// </param>
        /// <param name="intelligence">
        /// Run multimodal intelligence on every file in the batch.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="searchIdentity">
        /// Run identity search against the team's saved identities (audio/video only).<br/>
        /// Default Value: false
        /// </param>
        /// <param name="visualize">
        /// Generate visualization artifacts.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="audioSourceTracingEnabled">
        /// Enable audio source tracing on each audio file.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="frameLength">
        /// Window size in seconds (audio/video).
        /// </param>
        /// <param name="startRegion">
        /// Start of segment to analyze (seconds).
        /// </param>
        /// <param name="endRegion">
        /// End of segment to analyze (seconds).
        /// </param>
        /// <param name="maxVideoSecs">
        /// Cap processed video duration.
        /// </param>
        /// <param name="useLlm">
        /// Use LLM-assisted video analysis.
        /// </param>
        /// <param name="zeroRetentionMode">
        /// Enable Zero Retention Mode for every file in the batch.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.DeepfakeDetectionCreateDetectBatchResponse202> CreateDetectBatchAsync(
            global::System.Collections.Generic.IReadOnlyList<global::System.IO.Stream>? files = default,
            global::System.Collections.Generic.IReadOnlyList<string>? filesFileNames = default,
            global::System.IO.Stream? file = default,
            string? filename = default,
            string? callbackUrl = default,
            bool? intelligence = default,
            bool? searchIdentity = default,
            bool? visualize = default,
            bool? audioSourceTracingEnabled = default,
            int? frameLength = default,
            double? startRegion = default,
            double? endRegion = default,
            double? maxVideoSecs = default,
            bool? useLlm = default,
            bool? zeroRetentionMode = default,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a batch deepfake detection job<br/>
        /// Submit up to 50 files in a single request and process them as a single logical<br/>
        /// group. Returns HTTP 202 with a batch UUID; each file is analyzed in the<br/>
        /// background and individual results are available via `GET /detect/{uuid}` for<br/>
        /// each entry in `detect_uuids`.<br/>
        /// Two intake methods:<br/>
        /// - **Multiple media files** — repeated `files[]` form fields.<br/>
        /// - **Single zip archive** — a single `file` form field whose value is a `.zip`<br/>
        ///   containing the media files. Non-media entries are skipped.<br/>
        /// Provide one of `files[]` or `file=&lt;...&gt;.zip` per request. Synchronous mode<br/>
        /// (`Prefer: wait`) is not supported and returns 400 if sent.<br/>
        /// Constraints:<br/>
        /// - Maximum 50 files per batch.<br/>
        /// - Maximum 500 MB total upload size across all files.<br/>
        /// - Allowed file types match `POST /detect`'s direct-upload allowlist.<br/>
        /// - All-or-nothing billing: if the team's wallet cannot cover the projected cost<br/>
        ///   for every file, the request is rejected with 402 and no detects are created.
        /// </summary>
        /// <param name="files">
        /// One or more media files. Repeat the `files[]` field for each file. Mutually exclusive with `file`.
        /// </param>
        /// <param name="filesFileNames">
        /// Optional file names to use for the multipart 'files[]' file parts.
        /// </param>
        /// <param name="file">
        /// A single `.zip` archive containing media files. Mutually exclusive with `files[]`.
        /// </param>
        /// <param name="filename">
        /// A single `.zip` archive containing media files. Mutually exclusive with `files[]`.
        /// </param>
        /// <param name="callbackUrl">
        /// POST destination invoked when the batch reaches a terminal state.
        /// </param>
        /// <param name="intelligence">
        /// Run multimodal intelligence on every file in the batch.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="searchIdentity">
        /// Run identity search against the team's saved identities (audio/video only).<br/>
        /// Default Value: false
        /// </param>
        /// <param name="visualize">
        /// Generate visualization artifacts.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="audioSourceTracingEnabled">
        /// Enable audio source tracing on each audio file.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="frameLength">
        /// Window size in seconds (audio/video).
        /// </param>
        /// <param name="startRegion">
        /// Start of segment to analyze (seconds).
        /// </param>
        /// <param name="endRegion">
        /// End of segment to analyze (seconds).
        /// </param>
        /// <param name="maxVideoSecs">
        /// Cap processed video duration.
        /// </param>
        /// <param name="useLlm">
        /// Use LLM-assisted video analysis.
        /// </param>
        /// <param name="zeroRetentionMode">
        /// Enable Zero Retention Mode for every file in the batch.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AutoSDKHttpResponse<global::ResembleAI.DeepfakeDetectionCreateDetectBatchResponse202>> CreateDetectBatchAsResponseAsync(
            global::System.Collections.Generic.IReadOnlyList<global::System.IO.Stream>? files = default,
            global::System.Collections.Generic.IReadOnlyList<string>? filesFileNames = default,
            global::System.IO.Stream? file = default,
            string? filename = default,
            string? callbackUrl = default,
            bool? intelligence = default,
            bool? searchIdentity = default,
            bool? visualize = default,
            bool? audioSourceTracingEnabled = default,
            int? frameLength = default,
            double? startRegion = default,
            double? endRegion = default,
            double? maxVideoSecs = default,
            bool? useLlm = default,
            bool? zeroRetentionMode = default,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}