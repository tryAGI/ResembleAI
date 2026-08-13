#nullable enable

namespace ResembleAI
{
    public partial interface IBillingWalletClient
    {
        /// <summary>
        /// List wallet transactions<br/>
        /// Returns wallet transactions newest first. Use page and per_page for paginated results, or limit for an unpaginated recent subset.
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 10
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.BillingTransactionsResponse> ListBillingWalletTransactionsAsync(
            int? limit = default,
            int? page = default,
            int? perPage = default,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List wallet transactions<br/>
        /// Returns wallet transactions newest first. Use page and per_page for paginated results, or limit for an unpaginated recent subset.
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 10
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AutoSDKHttpResponse<global::ResembleAI.BillingTransactionsResponse>> ListBillingWalletTransactionsAsResponseAsync(
            int? limit = default,
            int? page = default,
            int? perPage = default,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}