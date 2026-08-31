#nullable enable

namespace ResembleAI
{
    public partial interface IAudioEnhancementClient
    {
        /// <summary>
        /// Create audio enhancement<br/>
        /// Submit an audio file for enhancement. Processing happens asynchronously in the background.
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
        /// Submit an audio file for enhancement. Processing happens asynchronously in the background.
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
        /// Submit an audio file for enhancement. Processing happens asynchronously in the background.
        /// </summary>
        /// <param name="audioFile">
        /// Audio file to enhance (WAV, MP3, M4A, MP4, OGG, AAC, FLAC). Max 150 MB.
        /// </param>
        /// <param name="audioFilename">
        /// Audio file to enhance (WAV, MP3, M4A, MP4, OGG, AAC, FLAC). Max 150 MB.
        /// </param>
        /// <param name="removeNoise">
        /// Remove background noise.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="normalize">
        /// Normalize audio levels.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="studioSound">
        /// Apply studio-quality enhancement.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AudioEnhancementCreateAudioEnhancementResponse202> CreateAudioEnhancementAsync(
            byte[] audioFile,
            string audioFilename,
            bool? removeNoise = default,
            bool? normalize = default,
            bool? studioSound = default,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create audio enhancement<br/>
        /// Submit an audio file for enhancement. Processing happens asynchronously in the background.
        /// </summary>
        /// <param name="audioFile">
        /// Audio file to enhance (WAV, MP3, M4A, MP4, OGG, AAC, FLAC). Max 150 MB.
        /// </param>
        /// <param name="audioFilename">
        /// Audio file to enhance (WAV, MP3, M4A, MP4, OGG, AAC, FLAC). Max 150 MB.
        /// </param>
        /// <param name="removeNoise">
        /// Remove background noise.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="normalize">
        /// Normalize audio levels.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="studioSound">
        /// Apply studio-quality enhancement.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AudioEnhancementCreateAudioEnhancementResponse202> CreateAudioEnhancementAsync(
            global::System.IO.Stream audioFile,
            string audioFilename,
            bool? removeNoise = default,
            bool? normalize = default,
            bool? studioSound = default,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create audio enhancement<br/>
        /// Submit an audio file for enhancement. Processing happens asynchronously in the background.
        /// </summary>
        /// <param name="audioFile">
        /// Audio file to enhance (WAV, MP3, M4A, MP4, OGG, AAC, FLAC). Max 150 MB.
        /// </param>
        /// <param name="audioFilename">
        /// Audio file to enhance (WAV, MP3, M4A, MP4, OGG, AAC, FLAC). Max 150 MB.
        /// </param>
        /// <param name="removeNoise">
        /// Remove background noise.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="normalize">
        /// Normalize audio levels.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="studioSound">
        /// Apply studio-quality enhancement.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AutoSDKHttpResponse<global::ResembleAI.AudioEnhancementCreateAudioEnhancementResponse202>> CreateAudioEnhancementAsResponseAsync(
            global::System.IO.Stream audioFile,
            string audioFilename,
            bool? removeNoise = default,
            bool? normalize = default,
            bool? studioSound = default,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}