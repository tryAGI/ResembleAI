#nullable enable

namespace ResembleAI
{
    public partial interface IBillingWalletClient
    {
        /// <summary>
        /// Get auto-reload settings<br/>
        /// Returns the current team's auto-reload configuration, whether a payment method is available, and the supported reload range.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.BillingAutoReloadResponse> GetBillingAutoReloadAsync(
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get auto-reload settings<br/>
        /// Returns the current team's auto-reload configuration, whether a payment method is available, and the supported reload range.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AutoSDKHttpResponse<global::ResembleAI.BillingAutoReloadResponse>> GetBillingAutoReloadAsResponseAsync(
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}