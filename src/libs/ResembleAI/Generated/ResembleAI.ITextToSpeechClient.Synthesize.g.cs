#nullable enable

namespace ResembleAI
{
    public partial interface ITextToSpeechClient
    {
        /// <summary>
        /// Synchronous text-to-speech synthesis<br/>
        /// Generate speech synchronously from text or SSML. Returns complete audio as base64. The model associated with the voice is selected automatically.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.TextToSpeechSynthesizeResponse200> SynthesizeAsync(

            global::ResembleAI.SynthesizeRequest request,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Synchronous text-to-speech synthesis<br/>
        /// Generate speech synchronously from text or SSML. Returns complete audio as base64. The model associated with the voice is selected automatically.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AutoSDKHttpResponse<global::ResembleAI.TextToSpeechSynthesizeResponse200>> SynthesizeAsResponseAsync(

            global::ResembleAI.SynthesizeRequest request,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Synchronous text-to-speech synthesis<br/>
        /// Generate speech synchronously from text or SSML. Returns complete audio as base64. The model associated with the voice is selected automatically.
        /// </summary>
        /// <param name="voiceUuid">
        /// Voice UUID to use for synthesis
        /// </param>
        /// <param name="projectUuid">
        /// Optional project UUID to store the clip
        /// </param>
        /// <param name="title">
        /// Optional title for the generated clip
        /// </param>
        /// <param name="data">
        /// Text or SSML to synthesize (max 3,000 characters)
        /// </param>
        /// <param name="precision">
        /// Audio precision for WAV output<br/>
        /// Default Value: PCM_32
        /// </param>
        /// <param name="outputFormat">
        /// Audio output format<br/>
        /// Default Value: wav
        /// </param>
        /// <param name="sampleRate">
        /// Audio sample rate in Hz
        /// </param>
        /// <param name="useHd">
        /// Enable HD synthesis with small latency trade-off<br/>
        /// Default Value: false
        /// </param>
        /// <param name="applyCustomPronunciations">
        /// When true, automatically applies your team's custom pronunciations to matching words in the input text. Defaults to false.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.TextToSpeechSynthesizeResponse200> SynthesizeAsync(
            string voiceUuid,
            string data,
            string? projectUuid = default,
            string? title = default,
            global::ResembleAI.SynthesizePostRequestBodyContentApplicationJsonSchemaPrecision? precision = default,
            global::ResembleAI.SynthesizePostRequestBodyContentApplicationJsonSchemaOutputFormat? outputFormat = default,
            global::ResembleAI.SynthesizePostRequestBodyContentApplicationJsonSchemaSampleRate? sampleRate = default,
            bool? useHd = default,
            bool? applyCustomPronunciations = default,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}