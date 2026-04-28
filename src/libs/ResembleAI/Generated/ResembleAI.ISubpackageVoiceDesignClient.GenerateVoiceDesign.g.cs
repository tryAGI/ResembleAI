#nullable enable

namespace ResembleAI
{
    public partial interface ISubpackageVoiceDesignClient
    {
        /// <summary>
        /// Generate voice candidates<br/>
        /// Generate three voice candidates from a text prompt
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.VoiceDesignGenerateVoiceDesignResponse200> GenerateVoiceDesignAsync(

            global::ResembleAI.GenerateVoiceDesignRequest request,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate voice candidates<br/>
        /// Generate three voice candidates from a text prompt
        /// </summary>
        /// <param name="userPrompt">
        /// Description of desired voice
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.VoiceDesignGenerateVoiceDesignResponse200> GenerateVoiceDesignAsync(
            string userPrompt,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}