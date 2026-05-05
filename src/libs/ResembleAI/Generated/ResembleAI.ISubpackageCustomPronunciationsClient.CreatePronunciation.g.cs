#nullable enable

namespace ResembleAI
{
    public partial interface ISubpackageCustomPronunciationsClient
    {
        /// <summary>
        /// Create custom pronunciation<br/>
        /// Upload a single pronunciation with a reference audio file.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.CustomPronunciationsCreatePronunciationResponse201> CreatePronunciationAsync(

            global::ResembleAI.CreatePronunciationRequest request,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create custom pronunciation<br/>
        /// Upload a single pronunciation with a reference audio file.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AutoSDKHttpResponse<global::ResembleAI.CustomPronunciationsCreatePronunciationResponse201>> CreatePronunciationAsResponseAsync(

            global::ResembleAI.CreatePronunciationRequest request,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create custom pronunciation<br/>
        /// Upload a single pronunciation with a reference audio file.
        /// </summary>
        /// <param name="word">
        /// The word or phrase (2-100 characters). Letters, accented characters, apostrophes, hyphens, and spaces only.
        /// </param>
        /// <param name="audio">
        /// Reference audio file (wav, flac, mp3, m4a, ogg, webm, aac). Duration 200ms-10s. Max 10MB.
        /// </param>
        /// <param name="audioname">
        /// Reference audio file (wav, flac, mp3, m4a, ogg, webm, aac). Duration 200ms-10s. Max 10MB.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.CustomPronunciationsCreatePronunciationResponse201> CreatePronunciationAsync(
            string word,
            byte[] audio,
            string audioname,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create custom pronunciation<br/>
        /// Upload a single pronunciation with a reference audio file.
        /// </summary>
        /// <param name="word">
        /// The word or phrase (2-100 characters). Letters, accented characters, apostrophes, hyphens, and spaces only.
        /// </param>
        /// <param name="audio">
        /// Reference audio file (wav, flac, mp3, m4a, ogg, webm, aac). Duration 200ms-10s. Max 10MB.
        /// </param>
        /// <param name="audioname">
        /// Reference audio file (wav, flac, mp3, m4a, ogg, webm, aac). Duration 200ms-10s. Max 10MB.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.CustomPronunciationsCreatePronunciationResponse201> CreatePronunciationAsync(
            string word,
            global::System.IO.Stream audio,
            string audioname,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create custom pronunciation<br/>
        /// Upload a single pronunciation with a reference audio file.
        /// </summary>
        /// <param name="word">
        /// The word or phrase (2-100 characters). Letters, accented characters, apostrophes, hyphens, and spaces only.
        /// </param>
        /// <param name="audio">
        /// Reference audio file (wav, flac, mp3, m4a, ogg, webm, aac). Duration 200ms-10s. Max 10MB.
        /// </param>
        /// <param name="audioname">
        /// Reference audio file (wav, flac, mp3, m4a, ogg, webm, aac). Duration 200ms-10s. Max 10MB.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AutoSDKHttpResponse<global::ResembleAI.CustomPronunciationsCreatePronunciationResponse201>> CreatePronunciationAsResponseAsync(
            string word,
            global::System.IO.Stream audio,
            string audioname,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}