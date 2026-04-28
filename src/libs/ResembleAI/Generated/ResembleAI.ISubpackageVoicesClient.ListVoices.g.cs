#nullable enable

namespace ResembleAI
{
    public partial interface ISubpackageVoicesClient
    {
        /// <summary>
        /// List voices<br/>
        /// Retrieve voice metadata
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="pageSize">
        /// Default Value: 10
        /// </param>
        /// <param name="advanced">
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.VoicesListVoicesResponse200> ListVoicesAsync(
            int page,
            int? pageSize = default,
            bool? advanced = default,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}