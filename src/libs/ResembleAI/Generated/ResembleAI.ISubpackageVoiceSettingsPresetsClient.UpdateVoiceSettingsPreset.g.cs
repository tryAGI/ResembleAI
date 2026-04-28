#nullable enable

namespace ResembleAI
{
    public partial interface ISubpackageVoiceSettingsPresetsClient
    {
        /// <summary>
        /// Update voice settings preset<br/>
        /// Update a preset
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.VoiceSettingsPresetsUpdateVoiceSettingsPresetResponse200> UpdateVoiceSettingsPresetAsync(
            string uuid,

            global::ResembleAI.UpdateVoiceSettingsPresetRequest request,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update voice settings preset<br/>
        /// Update a preset
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="name"></param>
        /// <param name="pace"></param>
        /// <param name="temperature"></param>
        /// <param name="pitch"></param>
        /// <param name="useHd"></param>
        /// <param name="exaggeration"></param>
        /// <param name="description"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.VoiceSettingsPresetsUpdateVoiceSettingsPresetResponse200> UpdateVoiceSettingsPresetAsync(
            string uuid,
            string? name = default,
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