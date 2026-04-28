#nullable enable

namespace ResembleAI
{
    public partial interface ISubpackageCustomPronunciationsClient
    {
        /// <summary>
        /// Bulk create pronunciations from ZIP<br/>
        /// Upload multiple pronunciations at once. Each audio file in the ZIP becomes a pronunciation — the filename (without extension) is used as the word.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.CustomPronunciationsBulkCreatePronunciationsResponse201> BulkCreatePronunciationsAsync(

            global::ResembleAI.BulkCreatePronunciationsRequest request,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Bulk create pronunciations from ZIP<br/>
        /// Upload multiple pronunciations at once. Each audio file in the ZIP becomes a pronunciation — the filename (without extension) is used as the word.
        /// </summary>
        /// <param name="zip">
        /// ZIP file containing audio files. Max 50 files, max 100MB total.
        /// </param>
        /// <param name="zipname">
        /// ZIP file containing audio files. Max 50 files, max 100MB total.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.CustomPronunciationsBulkCreatePronunciationsResponse201> BulkCreatePronunciationsAsync(
            byte[] zip,
            string zipname,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}