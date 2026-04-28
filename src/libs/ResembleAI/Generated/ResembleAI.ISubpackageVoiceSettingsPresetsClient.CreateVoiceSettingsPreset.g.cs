#nullable enable

namespace ResembleAI
{
    public partial interface ISubpackageVoiceSettingsPresetsClient
    {
        /// <summary>
        /// Create voice settings preset<br/>
        /// Create a new voice settings preset (max 5 per user)
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.VoiceSettingsPresetsCreateVoiceSettingsPresetResponse201> CreateVoiceSettingsPresetAsync(

            global::ResembleAI.CreateVoiceSettingsPresetRequest request,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create voice settings preset<br/>
        /// Create a new voice settings preset (max 5 per user)
        /// </summary>
        /// <param name="name">
        /// Preset name (unique, max 30 characters)
        /// </param>
        /// <param name="pace">
        /// Speech pace/speed<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="temperature">
        /// Voice variation<br/>
        /// Default Value: 0.8F
        /// </param>
        /// <param name="pitch">
        /// Voice pitch adjustment<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="useHd">
        /// Use HD quality<br/>
        /// Default Value: false
        /// </param>
        /// <param name="exaggeration">
        /// Emotional exaggeration<br/>
        /// Default Value: 0.5F
        /// </param>
        /// <param name="description">
        /// Voice style prompt
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.VoiceSettingsPresetsCreateVoiceSettingsPresetResponse201> CreateVoiceSettingsPresetAsync(
            string name,
            double? pace = default,
            double? temperature = default,
            double? pitch = default,
            bool? useHd = default,
            double? exaggeration = default,
            string? description = default,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}