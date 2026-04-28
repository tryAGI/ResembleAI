#nullable enable

namespace ResembleAI
{
    public partial interface ISubpackageTermSubstitutionsClient
    {
        /// <summary>
        /// Delete term substitution<br/>
        /// Delete a term substitution
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.TermSubstitutionsDeleteTermSubstitutionResponse200> DeleteTermSubstitutionAsync(
            int id,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}