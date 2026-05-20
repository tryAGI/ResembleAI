#nullable enable

namespace ResembleAI
{
    public partial interface ISubpackageRecordingsClient
    {
        /// <summary>
        /// Get recording<br/>
        /// Get recording details
        /// </summary>
        /// <param name="voiceUuid"></param>
        /// <param name="recordingId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.RecordingsGetRecordingResponse200> GetRecordingAsync(
            string voiceUuid,
            string recordingId,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get recording<br/>
        /// Get recording details
        /// </summary>
        /// <param name="voiceUuid"></param>
        /// <param name="recordingId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AutoSDKHttpResponse<global::ResembleAI.RecordingsGetRecordingResponse200>> GetRecordingAsResponseAsync(
            string voiceUuid,
            string recordingId,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}