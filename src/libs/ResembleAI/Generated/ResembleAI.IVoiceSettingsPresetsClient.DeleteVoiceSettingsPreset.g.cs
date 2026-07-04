#nullable enable

namespace ResembleAI
{
    public partial interface IVoiceSettingsPresetsClient
    {
        /// <summary>
        /// Delete voice settings preset<br/>
        /// Delete a preset
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.VoiceSettingsPresetsDeleteVoiceSettingsPresetResponse200> DeleteVoiceSettingsPresetAsync(
            string uuid,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete voice settings preset<br/>
        /// Delete a preset
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ResembleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ResembleAI.AutoSDKHttpResponse<global::ResembleAI.VoiceSettingsPresetsDeleteVoiceSettingsPresetResponse200>> DeleteVoiceSettingsPresetAsResponseAsync(
            string uuid,
            global::ResembleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}