#nullable enable

namespace ResembleAI
{
    public partial interface IDetectAgentsClient
    {
        /// <summary>
        /// Run investigation<br/>
        /// Run a managed Detect Agent against uploaded media or a public URL.<br/>
        /// The response is a live Server-Sent Events stream. The first `run_started`<br/>
        /// event contains the persisted run identifier.
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> RunDetectAgentInvestigationAsync(
            string uuid,

            global::ResembleAI.RunDetectAgentInvestigationRequest request,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Run investigation<br/>
        /// Run a managed Detect Agent against uploaded media or a public URL.<br/>
        /// The response is a live Server-Sent Events stream. The first `run_started`<br/>
        /// event contains the persisted run identifier.
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AutoSDKHttpResponse<string>> RunDetectAgentInvestigationAsResponseAsync(
            string uuid,

            global::ResembleAI.RunDetectAgentInvestigationRequest request,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Run investigation<br/>
        /// Run a managed Detect Agent against uploaded media or a public URL.<br/>
        /// The response is a live Server-Sent Events stream. The first `run_started`<br/>
        /// event contains the persisted run identifier.
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="file">
        /// Primary media to analyze. Required when `url` is omitted.
        /// </param>
        /// <param name="filename">
        /// Primary media to analyze. Required when `url` is omitted.
        /// </param>
        /// <param name="url">
        /// Public media URL to analyze. Required when `file` is omitted.
        /// </param>
        /// <param name="query">
        /// Question or investigation objective.
        /// </param>
        /// <param name="evidence">
        /// Supporting evidence files. Repeat this field for multiple files.
        /// </param>
        /// <param name="checkUrls">
        /// Additional URLs for the Detect Agent to check.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> RunDetectAgentInvestigationAsync(
            string uuid,
            byte[]? file = default,
            string? filename = default,
            string? url = default,
            string? query = default,
            global::System.Collections.Generic.IList<byte[]>? evidence = default,
            string? checkUrls = default,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}