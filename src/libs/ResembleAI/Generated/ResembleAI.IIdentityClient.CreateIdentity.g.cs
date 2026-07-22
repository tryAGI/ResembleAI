#nullable enable

namespace ResembleAI
{
    public partial interface IIdentityClient
    {
        /// <summary>
        /// Create identity<br/>
        /// Create a new identity profile. Two request forms are supported: the simple audio-only form (flat `name` + one audio source; creates a team-visible person identity and enrolls the voice immediately) and the multimodal form (a nested `identity` object with full control over type and visibility).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.IdentityCreateIdentityResponse200> CreateIdentityAsync(

            global::ResembleAI.IdentityCreateIdentityRequest request,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create identity<br/>
        /// Create a new identity profile. Two request forms are supported: the simple audio-only form (flat `name` + one audio source; creates a team-visible person identity and enrolls the voice immediately) and the multimodal form (a nested `identity` object with full control over type and visibility).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AutoSDKHttpResponse<global::ResembleAI.IdentityCreateIdentityResponse200>> CreateIdentityAsResponseAsync(

            global::ResembleAI.IdentityCreateIdentityRequest request,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create identity<br/>
        /// Create a new identity profile. Two request forms are supported: the simple audio-only form (flat `name` + one audio source; creates a team-visible person identity and enrolls the voice immediately) and the multimodal form (a nested `identity` object with full control over type and visibility).
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.IdentityCreateIdentityResponse200> CreateIdentityAsync(
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}