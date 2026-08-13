#nullable enable

namespace ResembleAI
{
    public partial interface ISignalClient
    {
        /// <summary>
        /// List custom categories<br/>
        /// Retrieve the team's Signal settings, the built-in categories, the team's custom categories with their example phrases, and calibration status.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.SignalCustomCategoryListResponse> ListSignalCustomCategoriesAsync(
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List custom categories<br/>
        /// Retrieve the team's Signal settings, the built-in categories, the team's custom categories with their example phrases, and calibration status.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AutoSDKHttpResponse<global::ResembleAI.SignalCustomCategoryListResponse>> ListSignalCustomCategoriesAsResponseAsync(
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}