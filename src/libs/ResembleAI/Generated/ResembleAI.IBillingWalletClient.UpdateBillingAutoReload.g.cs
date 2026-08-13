#nullable enable

namespace ResembleAI
{
    public partial interface IBillingWalletClient
    {
        /// <summary>
        /// Update auto-reload settings<br/>
        /// Enables, disables, or changes wallet auto-reload. Amounts are expressed in cents and must comply with the limits returned by the GET operation.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.BillingWalletUpdateBillingAutoReloadResponse200> UpdateBillingAutoReloadAsync(

            global::ResembleAI.BillingUpdateAutoReloadRequest request,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update auto-reload settings<br/>
        /// Enables, disables, or changes wallet auto-reload. Amounts are expressed in cents and must comply with the limits returned by the GET operation.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AutoSDKHttpResponse<global::ResembleAI.BillingWalletUpdateBillingAutoReloadResponse200>> UpdateBillingAutoReloadAsResponseAsync(

            global::ResembleAI.BillingUpdateAutoReloadRequest request,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update auto-reload settings<br/>
        /// Enables, disables, or changes wallet auto-reload. Amounts are expressed in cents and must comply with the limits returned by the GET operation.
        /// </summary>
        /// <param name="enabled"></param>
        /// <param name="reloadAmountCents"></param>
        /// <param name="minimumBalanceThresholdCents"></param>
        /// <param name="maximumMonthlySpendCents"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.BillingWalletUpdateBillingAutoReloadResponse200> UpdateBillingAutoReloadAsync(
            bool enabled,
            int reloadAmountCents,
            int minimumBalanceThresholdCents,
            int maximumMonthlySpendCents,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}