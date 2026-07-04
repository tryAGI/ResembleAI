#nullable enable

namespace ResembleAI
{
    public partial interface IVoiceDesignClient
    {
        /// <summary>
        /// Create voice from candidate<br/>
        /// Create a voice from a voice design candidate
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.VoiceDesignCreateVoiceFromCandidateResponse200> CreateVoiceFromCandidateAsync(

            global::ResembleAI.CreateVoiceFromCandidateRequest request,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create voice from candidate<br/>
        /// Create a voice from a voice design candidate
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AutoSDKHttpResponse<global::ResembleAI.VoiceDesignCreateVoiceFromCandidateResponse200>> CreateVoiceFromCandidateAsResponseAsync(

            global::ResembleAI.CreateVoiceFromCandidateRequest request,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create voice from candidate<br/>
        /// Create a voice from a voice design candidate
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="voiceSampleIndex"></param>
        /// <param name="name"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.VoiceDesignCreateVoiceFromCandidateResponse200> CreateVoiceFromCandidateAsync(
            string uuid,
            int voiceSampleIndex,
            string name,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}