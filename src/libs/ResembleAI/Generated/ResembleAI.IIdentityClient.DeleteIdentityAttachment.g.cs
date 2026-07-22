#nullable enable

namespace ResembleAI
{
    public partial interface IIdentityClient
    {
        /// <summary>
        /// Remove reference media<br/>
        /// Detach a reference media file from an identity. The affected modality's embedding recomputes without the removed file.
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="attachmentId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.IdentityDeleteIdentityAttachmentResponse204> DeleteIdentityAttachmentAsync(
            string uuid,
            int attachmentId,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remove reference media<br/>
        /// Detach a reference media file from an identity. The affected modality's embedding recomputes without the removed file.
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="attachmentId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AutoSDKHttpResponse<global::ResembleAI.IdentityDeleteIdentityAttachmentResponse204>> DeleteIdentityAttachmentAsResponseAsync(
            string uuid,
            int attachmentId,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}