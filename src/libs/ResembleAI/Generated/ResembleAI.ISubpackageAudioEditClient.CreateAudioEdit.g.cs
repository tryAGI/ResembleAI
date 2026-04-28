#nullable enable

namespace ResembleAI
{
    public partial interface ISubpackageAudioEditClient
    {
        /// <summary>
        /// Create audio edit<br/>
        /// Edit audio segments using voice synthesis
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AudioEditCreateAudioEditResponse200> CreateAudioEditAsync(

            global::ResembleAI.CreateAudioEditRequest request,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create audio edit<br/>
        /// Edit audio segments using voice synthesis
        /// </summary>
        /// <param name="inputAudio">
        /// WAV, MP3, M4A, or WMA file (&lt; 20 seconds)
        /// </param>
        /// <param name="inputAudioname">
        /// WAV, MP3, M4A, or WMA file (&lt; 20 seconds)
        /// </param>
        /// <param name="originalTranscript">
        /// Accurate transcript of the uploaded audio
        /// </param>
        /// <param name="targetTranscript">
        /// Desired replacement text
        /// </param>
        /// <param name="voiceUuid">
        /// Voice used to render the edited segment
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AudioEditCreateAudioEditResponse200> CreateAudioEditAsync(
            byte[] inputAudio,
            string inputAudioname,
            string originalTranscript,
            string targetTranscript,
            string voiceUuid,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}