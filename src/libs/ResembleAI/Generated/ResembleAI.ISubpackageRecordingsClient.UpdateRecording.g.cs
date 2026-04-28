#nullable enable

namespace ResembleAI
{
    public partial interface ISubpackageRecordingsClient
    {
        /// <summary>
        /// Update recording<br/>
        /// Update a recording
        /// </summary>
        /// <param name="voiceUuid"></param>
        /// <param name="recordingId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.RecordingsUpdateRecordingResponse200> UpdateRecordingAsync(
            string voiceUuid,
            string recordingId,

            global::ResembleAI.UpdateRecordingRequest request,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update recording<br/>
        /// Update a recording
        /// </summary>
        /// <param name="voiceUuid"></param>
        /// <param name="recordingId"></param>
        /// <param name="name"></param>
        /// <param name="text"></param>
        /// <param name="emotion"></param>
        /// <param name="isActive"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.RecordingsUpdateRecordingResponse200> UpdateRecordingAsync(
            string voiceUuid,
            string recordingId,
            string? name = default,
            string? text = default,
            string? emotion = default,
            bool? isActive = default,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}