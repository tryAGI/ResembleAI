#nullable enable

namespace ResembleAI
{
    public partial interface ISubpackageRecordingsClient
    {
        /// <summary>
        /// Delete recording<br/>
        /// Delete a recording
        /// </summary>
        /// <param name="voiceUuid"></param>
        /// <param name="recordingId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.RecordingsDeleteRecordingResponse200> DeleteRecordingAsync(
            string voiceUuid,
            string recordingId,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete recording<br/>
        /// Delete a recording
        /// </summary>
        /// <param name="voiceUuid"></param>
        /// <param name="recordingId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AutoSDKHttpResponse<global::ResembleAI.RecordingsDeleteRecordingResponse200>> DeleteRecordingAsResponseAsync(
            string voiceUuid,
            string recordingId,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}