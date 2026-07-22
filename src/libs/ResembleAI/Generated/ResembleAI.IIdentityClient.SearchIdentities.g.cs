#nullable enable

namespace ResembleAI
{
    public partial interface IIdentityClient
    {
        /// <summary>
        /// Search identities<br/>
        /// Search the team's identities (plus global identities) for matches against a media sample. Supports audio (voice matching) and image (face/visual matching); video is not yet supported for synchronous search.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.IdentitySearchIdentitiesResponse200> SearchIdentitiesAsync(

            global::ResembleAI.SearchIdentitiesRequest request,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Search identities<br/>
        /// Search the team's identities (plus global identities) for matches against a media sample. Supports audio (voice matching) and image (face/visual matching); video is not yet supported for synchronous search.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AutoSDKHttpResponse<global::ResembleAI.IdentitySearchIdentitiesResponse200>> SearchIdentitiesAsResponseAsync(

            global::ResembleAI.SearchIdentitiesRequest request,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Search identities<br/>
        /// Search the team's identities (plus global identities) for matches against a media sample. Supports audio (voice matching) and image (face/visual matching); video is not yet supported for synchronous search.
        /// </summary>
        /// <param name="url">
        /// URL to the media sample (one of url, file, signed_id is required)
        /// </param>
        /// <param name="signedId">
        /// Signed ID from a secure upload
        /// </param>
        /// <param name="modality">
        /// Inferred from the media's content type when omitted (defaults to audio)
        /// </param>
        /// <param name="topK">
        /// Default Value: 1
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.IdentitySearchIdentitiesResponse200> SearchIdentitiesAsync(
            string? url = default,
            string? signedId = default,
            global::ResembleAI.IdentitySearchPostRequestBodyContentApplicationJsonSchemaModality? modality = default,
            int? topK = default,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}