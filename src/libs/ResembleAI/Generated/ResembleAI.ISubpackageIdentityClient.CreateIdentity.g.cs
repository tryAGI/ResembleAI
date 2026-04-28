#nullable enable

namespace ResembleAI
{
    public partial interface ISubpackageIdentityClient
    {
        /// <summary>
        /// Create identity<br/>
        /// Create a new speaker identity
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.IdentityCreateIdentityResponse200> CreateIdentityAsync(

            global::ResembleAI.CreateIdentityRequest request,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create identity<br/>
        /// Create a new speaker identity
        /// </summary>
        /// <param name="audioUrl"></param>
        /// <param name="name"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.IdentityCreateIdentityResponse200> CreateIdentityAsync(
            string audioUrl,
            string? name = default,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}