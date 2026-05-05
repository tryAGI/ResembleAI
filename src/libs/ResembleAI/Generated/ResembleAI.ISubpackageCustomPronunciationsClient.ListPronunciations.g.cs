#nullable enable

namespace ResembleAI
{
    public partial interface ISubpackageCustomPronunciationsClient
    {
        /// <summary>
        /// List custom pronunciations<br/>
        /// Retrieve all custom pronunciations for your team, with optional filters.
        /// </summary>
        /// <param name="language"></param>
        /// <param name="domain"></param>
        /// <param name="status"></param>
        /// <param name="active"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.CustomPronunciationsListPronunciationsResponse200> ListPronunciationsAsync(
            string? language = default,
            string? domain = default,
            global::ResembleAI.PronunciationsGetParametersStatus? status = default,
            bool? active = default,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List custom pronunciations<br/>
        /// Retrieve all custom pronunciations for your team, with optional filters.
        /// </summary>
        /// <param name="language"></param>
        /// <param name="domain"></param>
        /// <param name="status"></param>
        /// <param name="active"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AutoSDKHttpResponse<global::ResembleAI.CustomPronunciationsListPronunciationsResponse200>> ListPronunciationsAsResponseAsync(
            string? language = default,
            string? domain = default,
            global::ResembleAI.PronunciationsGetParametersStatus? status = default,
            bool? active = default,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}