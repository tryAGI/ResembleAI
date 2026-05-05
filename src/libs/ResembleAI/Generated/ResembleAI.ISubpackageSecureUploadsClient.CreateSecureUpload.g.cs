#nullable enable

namespace ResembleAI
{
    public partial interface ISubpackageSecureUploadsClient
    {
        /// <summary>
        /// Upload media securely<br/>
        /// Upload a media file and receive a short-lived token that can be passed to<br/>
        /// downstream endpoints (such as `/detect` and `/intelligence`) in place of a<br/>
        /// public URL. The returned token is a JWT that expires 1 hour after issuance.<br/>
        /// Keeping uploads private avoids exposing source media on the open internet and<br/>
        /// means you do not need to host files yourself for jobs that only need the API<br/>
        /// to read them once.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.SecureUploadsCreateSecureUploadResponse200> CreateSecureUploadAsync(

            global::ResembleAI.CreateSecureUploadRequest request,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload media securely<br/>
        /// Upload a media file and receive a short-lived token that can be passed to<br/>
        /// downstream endpoints (such as `/detect` and `/intelligence`) in place of a<br/>
        /// public URL. The returned token is a JWT that expires 1 hour after issuance.<br/>
        /// Keeping uploads private avoids exposing source media on the open internet and<br/>
        /// means you do not need to host files yourself for jobs that only need the API<br/>
        /// to read them once.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AutoSDKHttpResponse<global::ResembleAI.SecureUploadsCreateSecureUploadResponse200>> CreateSecureUploadAsResponseAsync(

            global::ResembleAI.CreateSecureUploadRequest request,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload media securely<br/>
        /// Upload a media file and receive a short-lived token that can be passed to<br/>
        /// downstream endpoints (such as `/detect` and `/intelligence`) in place of a<br/>
        /// public URL. The returned token is a JWT that expires 1 hour after issuance.<br/>
        /// Keeping uploads private avoids exposing source media on the open internet and<br/>
        /// means you do not need to host files yourself for jobs that only need the API<br/>
        /// to read them once.
        /// </summary>
        /// <param name="file">
        /// The media file to upload (audio, image, or video).
        /// </param>
        /// <param name="filename">
        /// The media file to upload (audio, image, or video).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.SecureUploadsCreateSecureUploadResponse200> CreateSecureUploadAsync(
            byte[] file,
            string filename,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Upload media securely<br/>
        /// Upload a media file and receive a short-lived token that can be passed to<br/>
        /// downstream endpoints (such as `/detect` and `/intelligence`) in place of a<br/>
        /// public URL. The returned token is a JWT that expires 1 hour after issuance.<br/>
        /// Keeping uploads private avoids exposing source media on the open internet and<br/>
        /// means you do not need to host files yourself for jobs that only need the API<br/>
        /// to read them once.
        /// </summary>
        /// <param name="file">
        /// The media file to upload (audio, image, or video).
        /// </param>
        /// <param name="filename">
        /// The media file to upload (audio, image, or video).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.SecureUploadsCreateSecureUploadResponse200> CreateSecureUploadAsync(
            global::System.IO.Stream file,
            string filename,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload media securely<br/>
        /// Upload a media file and receive a short-lived token that can be passed to<br/>
        /// downstream endpoints (such as `/detect` and `/intelligence`) in place of a<br/>
        /// public URL. The returned token is a JWT that expires 1 hour after issuance.<br/>
        /// Keeping uploads private avoids exposing source media on the open internet and<br/>
        /// means you do not need to host files yourself for jobs that only need the API<br/>
        /// to read them once.
        /// </summary>
        /// <param name="file">
        /// The media file to upload (audio, image, or video).
        /// </param>
        /// <param name="filename">
        /// The media file to upload (audio, image, or video).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AutoSDKHttpResponse<global::ResembleAI.SecureUploadsCreateSecureUploadResponse200>> CreateSecureUploadAsResponseAsync(
            global::System.IO.Stream file,
            string filename,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}