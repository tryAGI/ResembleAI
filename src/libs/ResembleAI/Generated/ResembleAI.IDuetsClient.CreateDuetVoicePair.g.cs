#nullable enable

namespace ResembleAI
{
    public partial interface IDuetsClient
    {
        /// <summary>
        /// Create duet voice pair<br/>
        /// Create a voice pair for duet generation
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.DuetsCreateDuetVoicePairResponse200> CreateDuetVoicePairAsync(

            global::ResembleAI.CreateDuetVoicePairRequest request,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create duet voice pair<br/>
        /// Create a voice pair for duet generation
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AutoSDKHttpResponse<global::ResembleAI.DuetsCreateDuetVoicePairResponse200>> CreateDuetVoicePairAsResponseAsync(

            global::ResembleAI.CreateDuetVoicePairRequest request,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create duet voice pair<br/>
        /// Create a voice pair for duet generation
        /// </summary>
        /// <param name="voice1Id">
        /// ID of first voice
        /// </param>
        /// <param name="voice2Id">
        /// ID of second voice
        /// </param>
        /// <param name="name">
        /// Optional pair name
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.DuetsCreateDuetVoicePairResponse200> CreateDuetVoicePairAsync(
            int voice1Id,
            int voice2Id,
            string? name = default,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}