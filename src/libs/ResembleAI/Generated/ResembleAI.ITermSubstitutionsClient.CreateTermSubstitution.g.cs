#nullable enable

namespace ResembleAI
{
    public partial interface ITermSubstitutionsClient
    {
        /// <summary>
        /// Create term substitution<br/>
        /// Create a new pronunciation substitution
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.TermSubstitutionsCreateTermSubstitutionResponse200> CreateTermSubstitutionAsync(

            global::ResembleAI.CreateTermSubstitutionRequest request,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create term substitution<br/>
        /// Create a new pronunciation substitution
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AutoSDKHttpResponse<global::ResembleAI.TermSubstitutionsCreateTermSubstitutionResponse200>> CreateTermSubstitutionAsResponseAsync(

            global::ResembleAI.CreateTermSubstitutionRequest request,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create term substitution<br/>
        /// Create a new pronunciation substitution
        /// </summary>
        /// <param name="originalText">
        /// Original text to substitute
        /// </param>
        /// <param name="replacementText">
        /// Replacement pronunciation
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.TermSubstitutionsCreateTermSubstitutionResponse200> CreateTermSubstitutionAsync(
            string originalText,
            string replacementText,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}