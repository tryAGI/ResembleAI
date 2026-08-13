#nullable enable

namespace ResembleAI
{
    public partial interface IBillingSubscriptionsClient
    {
        /// <summary>
        /// Change the current subscription plan<br/>
        /// Changes a self-serve subscription to another active plan with proration. Optional product quantities are absolute quantities on the destination plan.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.BillingSubscriptionResponse> ChangeBillingPlanAsync(

            global::ResembleAI.BillingChangePlanRequest request,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Change the current subscription plan<br/>
        /// Changes a self-serve subscription to another active plan with proration. Optional product quantities are absolute quantities on the destination plan.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AutoSDKHttpResponse<global::ResembleAI.BillingSubscriptionResponse>> ChangeBillingPlanAsResponseAsync(

            global::ResembleAI.BillingChangePlanRequest request,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Change the current subscription plan<br/>
        /// Changes a self-serve subscription to another active plan with proration. Optional product quantities are absolute quantities on the destination plan.
        /// </summary>
        /// <param name="planSlug"></param>
        /// <param name="productQuantities">
        /// Optional map of product slugs to desired quantities on the new plan.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.BillingSubscriptionResponse> ChangeBillingPlanAsync(
            string planSlug,
            global::System.Collections.Generic.Dictionary<string, double>? productQuantities = default,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}