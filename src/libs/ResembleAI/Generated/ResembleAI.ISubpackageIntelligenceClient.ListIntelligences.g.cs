#nullable enable

namespace ResembleAI
{
    public partial interface ISubpackageIntelligenceClient
    {
        /// <summary>
        /// List intelligences<br/>
        /// Retrieve a paginated list of all intelligence reports for the authenticated user's team
        /// </summary>
        /// <param name="page"></param>
        /// <param name="pageSize">
        /// Default Value: 10
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.IntelligenceListIntelligencesResponse200> ListIntelligencesAsync(
            int page,
            int? pageSize = default,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}