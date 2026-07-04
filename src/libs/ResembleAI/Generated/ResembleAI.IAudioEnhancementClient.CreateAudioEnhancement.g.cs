#nullable enable

namespace ResembleAI
{
    public partial interface IAudioEnhancementClient
    {
        /// <summary>
        /// Create audio enhancement<br/>
        /// Submit an audio file for enhancement. Processing happens asynchronously in the background.<br/>
        /// The API defaults to the v2 enhancement engine. The v1 engine is legacy and will be sunset in a future release.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AudioEnhancementCreateAudioEnhancementResponse202> CreateAudioEnhancementAsync(

            global::ResembleAI.CreateAudioEnhancementRequest request,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create audio enhancement<br/>
        /// Submit an audio file for enhancement. Processing happens asynchronously in the background.<br/>
        /// The API defaults to the v2 enhancement engine. The v1 engine is legacy and will be sunset in a future release.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AutoSDKHttpResponse<global::ResembleAI.AudioEnhancementCreateAudioEnhancementResponse202>> CreateAudioEnhancementAsResponseAsync(

            global::ResembleAI.CreateAudioEnhancementRequest request,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create audio enhancement<br/>
        /// Submit an audio file for enhancement. Processing happens asynchronously in the background.<br/>
        /// The API defaults to the v2 enhancement engine. The v1 engine is legacy and will be sunset in a future release.
        /// </summary>
        /// <param name="audioFile">
        /// Audio file to enhance (WAV, MP3, M4A, MP4, OGG, AAC, FLAC). Max 150 MB.
        /// </param>
        /// <param name="audioFilename">
        /// Audio file to enhance (WAV, MP3, M4A, MP4, OGG, AAC, FLAC). Max 150 MB.
        /// </param>
        /// <param name="enhancementEngine">
        /// Enhancement engine to use. Default is v2.<br/>
        /// Default Value: v2
        /// </param>
        /// <param name="removeNoise">
        /// Remove background noise. Engine v2 only.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="normalize">
        /// Normalize audio levels. Engine v2 only.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="studioSound">
        /// Apply studio-quality enhancement. Engine v2 only.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="enhancementLevel">
        /// Enhancement intensity (0.0 to 1.0). Engine v1 only (legacy).
        /// </param>
        /// <param name="loudnessTargetLevel">
        /// Target loudness in LUFS. Engine v1 only (legacy).<br/>
        /// Default Value: -14
        /// </param>
        /// <param name="loudnessPeakLimit">
        /// Peak limit in dBTP. Engine v1 only (legacy).<br/>
        /// Default Value: -1
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AudioEnhancementCreateAudioEnhancementResponse202> CreateAudioEnhancementAsync(
            byte[] audioFile,
            string audioFilename,
            global::ResembleAI.AudioEnhancementsPostRequestBodyContentMultipartFormDataSchemaEnhancementEngine? enhancementEngine = default,
            bool? removeNoise = default,
            bool? normalize = default,
            bool? studioSound = default,
            double? enhancementLevel = default,
            int? loudnessTargetLevel = default,
            int? loudnessPeakLimit = default,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create audio enhancement<br/>
        /// Submit an audio file for enhancement. Processing happens asynchronously in the background.<br/>
        /// The API defaults to the v2 enhancement engine. The v1 engine is legacy and will be sunset in a future release.
        /// </summary>
        /// <param name="audioFile">
        /// Audio file to enhance (WAV, MP3, M4A, MP4, OGG, AAC, FLAC). Max 150 MB.
        /// </param>
        /// <param name="audioFilename">
        /// Audio file to enhance (WAV, MP3, M4A, MP4, OGG, AAC, FLAC). Max 150 MB.
        /// </param>
        /// <param name="enhancementEngine">
        /// Enhancement engine to use. Default is v2.<br/>
        /// Default Value: v2
        /// </param>
        /// <param name="removeNoise">
        /// Remove background noise. Engine v2 only.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="normalize">
        /// Normalize audio levels. Engine v2 only.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="studioSound">
        /// Apply studio-quality enhancement. Engine v2 only.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="enhancementLevel">
        /// Enhancement intensity (0.0 to 1.0). Engine v1 only (legacy).
        /// </param>
        /// <param name="loudnessTargetLevel">
        /// Target loudness in LUFS. Engine v1 only (legacy).<br/>
        /// Default Value: -14
        /// </param>
        /// <param name="loudnessPeakLimit">
        /// Peak limit in dBTP. Engine v1 only (legacy).<br/>
        /// Default Value: -1
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AudioEnhancementCreateAudioEnhancementResponse202> CreateAudioEnhancementAsync(
            global::System.IO.Stream audioFile,
            string audioFilename,
            global::ResembleAI.AudioEnhancementsPostRequestBodyContentMultipartFormDataSchemaEnhancementEngine? enhancementEngine = default,
            bool? removeNoise = default,
            bool? normalize = default,
            bool? studioSound = default,
            double? enhancementLevel = default,
            int? loudnessTargetLevel = default,
            int? loudnessPeakLimit = default,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create audio enhancement<br/>
        /// Submit an audio file for enhancement. Processing happens asynchronously in the background.<br/>
        /// The API defaults to the v2 enhancement engine. The v1 engine is legacy and will be sunset in a future release.
        /// </summary>
        /// <param name="audioFile">
        /// Audio file to enhance (WAV, MP3, M4A, MP4, OGG, AAC, FLAC). Max 150 MB.
        /// </param>
        /// <param name="audioFilename">
        /// Audio file to enhance (WAV, MP3, M4A, MP4, OGG, AAC, FLAC). Max 150 MB.
        /// </param>
        /// <param name="enhancementEngine">
        /// Enhancement engine to use. Default is v2.<br/>
        /// Default Value: v2
        /// </param>
        /// <param name="removeNoise">
        /// Remove background noise. Engine v2 only.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="normalize">
        /// Normalize audio levels. Engine v2 only.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="studioSound">
        /// Apply studio-quality enhancement. Engine v2 only.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="enhancementLevel">
        /// Enhancement intensity (0.0 to 1.0). Engine v1 only (legacy).
        /// </param>
        /// <param name="loudnessTargetLevel">
        /// Target loudness in LUFS. Engine v1 only (legacy).<br/>
        /// Default Value: -14
        /// </param>
        /// <param name="loudnessPeakLimit">
        /// Peak limit in dBTP. Engine v1 only (legacy).<br/>
        /// Default Value: -1
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AutoSDKHttpResponse<global::ResembleAI.AudioEnhancementCreateAudioEnhancementResponse202>> CreateAudioEnhancementAsResponseAsync(
            global::System.IO.Stream audioFile,
            string audioFilename,
            global::ResembleAI.AudioEnhancementsPostRequestBodyContentMultipartFormDataSchemaEnhancementEngine? enhancementEngine = default,
            bool? removeNoise = default,
            bool? normalize = default,
            bool? studioSound = default,
            double? enhancementLevel = default,
            int? loudnessTargetLevel = default,
            int? loudnessPeakLimit = default,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}