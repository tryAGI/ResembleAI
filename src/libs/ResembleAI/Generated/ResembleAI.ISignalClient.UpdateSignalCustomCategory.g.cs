#nullable enable

namespace ResembleAI
{
    public partial interface ISignalClient
    {
        /// <summary>
        /// Update custom category<br/>
        /// Update a custom category. Supplying `scenarios` replaces the existing example phrases and re-triggers embedding.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.SignalCustomCategoryResponse> UpdateSignalCustomCategoryAsync(
            int id,

            global::ResembleAI.SignalCustomCategoryUpdateRequest request,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update custom category<br/>
        /// Update a custom category. Supplying `scenarios` replaces the existing example phrases and re-triggers embedding.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AutoSDKHttpResponse<global::ResembleAI.SignalCustomCategoryResponse>> UpdateSignalCustomCategoryAsResponseAsync(
            int id,

            global::ResembleAI.SignalCustomCategoryUpdateRequest request,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update custom category<br/>
        /// Update a custom category. Supplying `scenarios` replaces the existing example phrases and re-triggers embedding.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="scenarios"></param>
        /// <param name="description"></param>
        /// <param name="icon"></param>
        /// <param name="enabled"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.SignalCustomCategoryResponse> UpdateSignalCustomCategoryAsync(
            int id,
            string? name = default,
            global::System.Collections.Generic.IList<string>? scenarios = default,
            string? description = default,
            string? icon = default,
            bool? enabled = default,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}