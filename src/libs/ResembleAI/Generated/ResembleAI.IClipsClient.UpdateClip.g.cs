#nullable enable

namespace ResembleAI
{
    public partial interface IClipsClient
    {
        /// <summary>
        /// Update clip<br/>
        /// Update a clip
        /// </summary>
        /// <param name="projectUuid"></param>
        /// <param name="clipUuid"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.ClipsUpdateClipResponse200> UpdateClipAsync(
            string projectUuid,
            string clipUuid,

            global::ResembleAI.UpdateClipRequest request,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update clip<br/>
        /// Update a clip
        /// </summary>
        /// <param name="projectUuid"></param>
        /// <param name="clipUuid"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AutoSDKHttpResponse<global::ResembleAI.ClipsUpdateClipResponse200>> UpdateClipAsResponseAsync(
            string projectUuid,
            string clipUuid,

            global::ResembleAI.UpdateClipRequest request,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update clip<br/>
        /// Update a clip
        /// </summary>
        /// <param name="projectUuid"></param>
        /// <param name="clipUuid"></param>
        /// <param name="title"></param>
        /// <param name="body"></param>
        /// <param name="isArchived"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.ClipsUpdateClipResponse200> UpdateClipAsync(
            string projectUuid,
            string clipUuid,
            string? title = default,
            string? body = default,
            bool? isArchived = default,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}