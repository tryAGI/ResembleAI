#nullable enable

namespace ResembleAI
{
    public partial interface IIdentityClient
    {
        /// <summary>
        /// Add reference media<br/>
        /// Attach a reference media file (voice sample, face photo, or reference video) to an identity. The modality's embedding recomputes asynchronously; the media becomes searchable once its embedding status is ready.
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.Identity> CreateIdentityAttachmentAsync(
            string uuid,

            global::ResembleAI.CreateIdentityAttachmentRequest request,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add reference media<br/>
        /// Attach a reference media file (voice sample, face photo, or reference video) to an identity. The modality's embedding recomputes asynchronously; the media becomes searchable once its embedding status is ready.
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AutoSDKHttpResponse<global::ResembleAI.Identity>> CreateIdentityAttachmentAsResponseAsync(
            string uuid,

            global::ResembleAI.CreateIdentityAttachmentRequest request,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add reference media<br/>
        /// Attach a reference media file (voice sample, face photo, or reference video) to an identity. The modality's embedding recomputes asynchronously; the media becomes searchable once its embedding status is ready.
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="modality"></param>
        /// <param name="file">
        /// The media file to attach
        /// </param>
        /// <param name="filename">
        /// The media file to attach
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.Identity> CreateIdentityAttachmentAsync(
            string uuid,
            global::ResembleAI.IdentityUuidAttachmentsPostRequestBodyContentMultipartFormDataSchemaModality modality,
            byte[] file,
            string filename,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Add reference media<br/>
        /// Attach a reference media file (voice sample, face photo, or reference video) to an identity. The modality's embedding recomputes asynchronously; the media becomes searchable once its embedding status is ready.
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="modality"></param>
        /// <param name="file">
        /// The media file to attach
        /// </param>
        /// <param name="filename">
        /// The media file to attach
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.Identity> CreateIdentityAttachmentAsync(
            string uuid,
            global::ResembleAI.IdentityUuidAttachmentsPostRequestBodyContentMultipartFormDataSchemaModality modality,
            global::System.IO.Stream file,
            string filename,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add reference media<br/>
        /// Attach a reference media file (voice sample, face photo, or reference video) to an identity. The modality's embedding recomputes asynchronously; the media becomes searchable once its embedding status is ready.
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="modality"></param>
        /// <param name="file">
        /// The media file to attach
        /// </param>
        /// <param name="filename">
        /// The media file to attach
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AutoSDKHttpResponse<global::ResembleAI.Identity>> CreateIdentityAttachmentAsResponseAsync(
            string uuid,
            global::ResembleAI.IdentityUuidAttachmentsPostRequestBodyContentMultipartFormDataSchemaModality modality,
            global::System.IO.Stream file,
            string filename,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}