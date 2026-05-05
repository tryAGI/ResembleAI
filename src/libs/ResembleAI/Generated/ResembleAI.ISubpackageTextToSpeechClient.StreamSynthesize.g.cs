#nullable enable

namespace ResembleAI
{
    public partial interface ISubpackageTextToSpeechClient
    {
        /// <summary>
        /// Streaming text-to-speech synthesis (HTTP)<br/>
        /// Stream audio as it's generated. Returns chunked WAV data for progressive playback.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> StreamSynthesizeAsync(

            global::ResembleAI.StreamSynthesizeRequest request,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Streaming text-to-speech synthesis (HTTP)<br/>
        /// Stream audio as it's generated. Returns chunked WAV data for progressive playback.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> StreamSynthesizeAsStreamAsync(

            global::ResembleAI.StreamSynthesizeRequest request,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Streaming text-to-speech synthesis (HTTP)<br/>
        /// Stream audio as it's generated. Returns chunked WAV data for progressive playback.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AutoSDKHttpResponse<byte[]>> StreamSynthesizeAsResponseAsync(

            global::ResembleAI.StreamSynthesizeRequest request,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Streaming text-to-speech synthesis (HTTP)<br/>
        /// Stream audio as it's generated. Returns chunked WAV data for progressive playback.
        /// </summary>
        /// <param name="voiceUuid">
        /// Voice UUID to use for synthesis
        /// </param>
        /// <param name="data">
        /// Text or SSML to synthesize (max 2000 characters)
        /// </param>
        /// <param name="projectUuid">
        /// Optional project UUID to store the clip
        /// </param>
        /// <param name="model">
        /// Model to use for synthesis. Pass `chatterbox-turbo` to use the Turbo model for lower latency and paralinguistic tag support. If not specified, defaults to Chatterbox or Chatterbox Multilingual based on the voice. Note - Chatterbox-Turbo is supported by all Rapid English voices and Pre Built Library voices.
        /// </param>
        /// <param name="precision">
        /// Audio precision<br/>
        /// Default Value: PCM_32
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
        global::System.Threading.Tasks.Task<byte[]> StreamSynthesizeAsync(
            string voiceUuid,
            string data,
            string? projectUuid = default,
            string? model = default,
            global::ResembleAI.StreamPostRequestBodyContentApplicationJsonSchemaPrecision? precision = default,
            global::ResembleAI.StreamPostRequestBodyContentApplicationJsonSchemaSampleRate? sampleRate = default,
            bool? useHd = default,
            bool? applyCustomPronunciations = default,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}