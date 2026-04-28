#nullable enable

namespace ResembleAI
{
    public partial interface ISubpackageAccountClient
    {
        /// <summary>
        /// Get team<br/>
        /// Get specific team information
        /// </summary>
        /// <param name="teamUuid"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AccountGetTeamResponse200> GetTeamAsync(
            global::System.Guid teamUuid,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}