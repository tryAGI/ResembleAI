#nullable enable

namespace ResembleAI
{
    public partial interface ISignalClient
    {
        /// <summary>
        /// Create custom category<br/>
        /// Create a custom fraud category from example phrases. Categories embed asynchronously:<br/>
        /// a new category starts at `pending`, moves to `embedding`, and becomes usable for<br/>
        /// scoring once its status is `ready`.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.SignalCustomCategoryResponse> CreateSignalCustomCategoryAsync(

            global::ResembleAI.SignalCustomCategoryCreateRequest request,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create custom category<br/>
        /// Create a custom fraud category from example phrases. Categories embed asynchronously:<br/>
        /// a new category starts at `pending`, moves to `embedding`, and becomes usable for<br/>
        /// scoring once its status is `ready`.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AutoSDKHttpResponse<global::ResembleAI.SignalCustomCategoryResponse>> CreateSignalCustomCategoryAsResponseAsync(

            global::ResembleAI.SignalCustomCategoryCreateRequest request,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create custom category<br/>
        /// Create a custom fraud category from example phrases. Categories embed asynchronously:<br/>
        /// a new category starts at `pending`, moves to `embedding`, and becomes usable for<br/>
        /// scoring once its status is `ready`.
        /// </summary>
        /// <param name="name">
        /// Category name. Must be unique within the team.
        /// </param>
        /// <param name="scenarios">
        /// Example phrases that define the pattern. Maximum 50 entries, each up to 2000 characters. A newline-separated string is also accepted.
        /// </param>
        /// <param name="description"></param>
        /// <param name="icon">
        /// Single emoji.
        /// </param>
        /// <param name="enabled">
        /// Default Value: true
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.SignalCustomCategoryResponse> CreateSignalCustomCategoryAsync(
            string name,
            global::System.Collections.Generic.IList<string> scenarios,
            string? description = default,
            string? icon = default,
            bool? enabled = default,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}