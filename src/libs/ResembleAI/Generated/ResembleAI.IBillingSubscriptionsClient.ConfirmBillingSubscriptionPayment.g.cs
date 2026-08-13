#nullable enable

namespace ResembleAI
{
    public partial interface IBillingSubscriptionsClient
    {
        /// <summary>
        /// Confirm a subscription payment<br/>
        /// Synchronizes the subscription after the customer completes the additional payment authentication requested by a quantity or plan change.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.BillingSubscriptionResponse> ConfirmBillingSubscriptionPaymentAsync(

            global::ResembleAI.BillingConfirmPaymentRequest request,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Confirm a subscription payment<br/>
        /// Synchronizes the subscription after the customer completes the additional payment authentication requested by a quantity or plan change.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AutoSDKHttpResponse<global::ResembleAI.BillingSubscriptionResponse>> ConfirmBillingSubscriptionPaymentAsResponseAsync(

            global::ResembleAI.BillingConfirmPaymentRequest request,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Confirm a subscription payment<br/>
        /// Synchronizes the subscription after the customer completes the additional payment authentication requested by a quantity or plan change.
        /// </summary>
        /// <param name="paymentIntentId">
        /// Payment intent identifier completed by the customer.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.BillingSubscriptionResponse> ConfirmBillingSubscriptionPaymentAsync(
            string paymentIntentId,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}