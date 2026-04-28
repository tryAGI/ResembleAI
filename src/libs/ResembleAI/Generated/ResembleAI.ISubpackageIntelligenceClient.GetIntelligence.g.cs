#nullable enable

namespace ResembleAI
{
    public partial interface ISubpackageIntelligenceClient
    {
        /// <summary>
        /// Get intelligence<br/>
        /// Retrieve a single intelligence report by its UUID
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.IntelligenceGetIntelligenceResponse200> GetIntelligenceAsync(
            string uuid,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}