#nullable enable

namespace ResembleAI
{
    public partial interface ISubpackageDuetsClient
    {
        /// <summary>
        /// Create custom duet voice<br/>
        /// Create a custom voice for duet generation
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.DuetsCreateDuetVoiceResponse200> CreateDuetVoiceAsync(

            global::ResembleAI.CreateDuetVoiceRequest request,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create custom duet voice<br/>
        /// Create a custom voice for duet generation
        /// </summary>
        /// <param name="name">
        /// Voice name
        /// </param>
        /// <param name="stylePrompt">
        /// Optional style prompt
        /// </param>
        /// <param name="audio">
        /// Audio file (MP3/WAV/M4A/OGG/AAC/FLAC max 10 MB)
        /// </param>
        /// <param name="audioname">
        /// Audio file (MP3/WAV/M4A/OGG/AAC/FLAC max 10 MB)
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.DuetsCreateDuetVoiceResponse200> CreateDuetVoiceAsync(
            string name,
            byte[] audio,
            string audioname,
            string? stylePrompt = default,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}