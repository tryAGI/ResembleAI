#nullable enable

namespace ResembleAI
{
    public partial interface IBillingSubscriptionsClient
    {
        /// <summary>
        /// Update subscription product quantities<br/>
        /// Updates one or more adjustable subscription products atomically. Each `new_quantity` is the desired absolute total, not an increment. A product is adjustable when its category is `subscription` and its `plan_product.allow_additional_usage` value is true. Quantities must remain within the plan's minimum and maximum and cannot be reduced below `consumed_quantity`.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.BillingSubscriptionResponse> UpdateBillingSubscriptionProductsAsync(

            global::ResembleAI.BillingUpdateProductsRequest request,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update subscription product quantities<br/>
        /// Updates one or more adjustable subscription products atomically. Each `new_quantity` is the desired absolute total, not an increment. A product is adjustable when its category is `subscription` and its `plan_product.allow_additional_usage` value is true. Quantities must remain within the plan's minimum and maximum and cannot be reduced below `consumed_quantity`.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AutoSDKHttpResponse<global::ResembleAI.BillingSubscriptionResponse>> UpdateBillingSubscriptionProductsAsResponseAsync(

            global::ResembleAI.BillingUpdateProductsRequest request,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update subscription product quantities<br/>
        /// Updates one or more adjustable subscription products atomically. Each `new_quantity` is the desired absolute total, not an increment. A product is adjustable when its category is `subscription` and its `plan_product.allow_additional_usage` value is true. Quantities must remain within the plan's minimum and maximum and cannot be reduced below `consumed_quantity`.
        /// </summary>
        /// <param name="changes"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.BillingSubscriptionResponse> UpdateBillingSubscriptionProductsAsync(
            global::System.Collections.Generic.IList<global::ResembleAI.BillingProductQuantityChange> changes,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}