#nullable enable

namespace ResembleAI
{
    public partial interface IBillingSubscriptionsClient
    {
        /// <summary>
        /// Get the current subscription<br/>
        /// Returns the current team's active, past-due, or delinquent subscription. Returns a null subscription when no customer-visible subscription exists.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.BillingSubscriptionResponse> GetBillingSubscriptionAsync(
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the current subscription<br/>
        /// Returns the current team's active, past-due, or delinquent subscription. Returns a null subscription when no customer-visible subscription exists.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AutoSDKHttpResponse<global::ResembleAI.BillingSubscriptionResponse>> GetBillingSubscriptionAsResponseAsync(
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}