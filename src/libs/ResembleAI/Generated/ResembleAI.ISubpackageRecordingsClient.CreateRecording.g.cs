#nullable enable

namespace ResembleAI
{
    public partial interface ISubpackageRecordingsClient
    {
        /// <summary>
        /// Create recording<br/>
        /// Upload a new recording for voice training
        /// </summary>
        /// <param name="voiceUuid"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.RecordingsCreateRecordingResponse200> CreateRecordingAsync(
            string voiceUuid,

            global::ResembleAI.CreateRecordingRequest request,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create recording<br/>
        /// Upload a new recording for voice training
        /// </summary>
        /// <param name="voiceUuid"></param>
        /// <param name="file">
        /// Audio file (WAV recommended, 1-12 seconds)
        /// </param>
        /// <param name="filename">
        /// Audio file (WAV recommended, 1-12 seconds)
        /// </param>
        /// <param name="name">
        /// Display name
        /// </param>
        /// <param name="text">
        /// Transcript of the clip
        /// </param>
        /// <param name="emotion">
        /// Emotion label
        /// </param>
        /// <param name="isActive">
        /// Include in training
        /// </param>
        /// <param name="fill">
        /// Include for Resemble Fill
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.RecordingsCreateRecordingResponse200> CreateRecordingAsync(
            string voiceUuid,
            byte[] file,
            string filename,
            string name,
            string text,
            string emotion,
            bool isActive,
            bool? fill = default,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}