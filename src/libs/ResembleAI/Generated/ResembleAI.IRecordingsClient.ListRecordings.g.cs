#nullable enable

namespace ResembleAI
{
    public partial interface IRecordingsClient
    {
        /// <summary>
        /// List recordings<br/>
        /// List all recordings for a voice
        /// </summary>
        /// <param name="voiceUuid"></param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="pageSize">
        /// Default Value: 10
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.RecordingsListRecordingsResponse200> ListRecordingsAsync(
            string voiceUuid,
            int page,
            int? pageSize = default,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List recordings<br/>
        /// List all recordings for a voice
        /// </summary>
        /// <param name="voiceUuid"></param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="pageSize">
        /// Default Value: 10
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AutoSDKHttpResponse<global::ResembleAI.RecordingsListRecordingsResponse200>> ListRecordingsAsResponseAsync(
            string voiceUuid,
            int page,
            int? pageSize = default,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}