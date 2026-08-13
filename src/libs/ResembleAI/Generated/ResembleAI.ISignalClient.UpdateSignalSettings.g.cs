#nullable enable

namespace ResembleAI
{
    public partial interface ISignalClient
    {
        /// <summary>
        /// Update team settings<br/>
        /// Update team-level Signal preferences.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.SignalSettingsResponse> UpdateSignalSettingsAsync(

            global::ResembleAI.SignalSettingsUpdateRequest request,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update team settings<br/>
        /// Update team-level Signal preferences.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AutoSDKHttpResponse<global::ResembleAI.SignalSettingsResponse>> UpdateSignalSettingsAsResponseAsync(

            global::ResembleAI.SignalSettingsUpdateRequest request,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update team settings<br/>
        /// Update team-level Signal preferences.
        /// </summary>
        /// <param name="useBuiltinCategories">
        /// When false, scoring uses only the team's custom categories.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.SignalSettingsResponse> UpdateSignalSettingsAsync(
            bool? useBuiltinCategories = default,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}