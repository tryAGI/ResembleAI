
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VoiceSettingsPresetsGetVoiceSettingsPresetResponse200
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        public bool? Success { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::ResembleAI.VoiceSettingsPresetsUuidGetResponsesContentApplicationJsonSchemaData? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceSettingsPresetsGetVoiceSettingsPresetResponse200" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="data"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoiceSettingsPresetsGetVoiceSettingsPresetResponse200(
            bool? success,
            global::ResembleAI.VoiceSettingsPresetsUuidGetResponsesContentApplicationJsonSchemaData? data)
        {
            this.Success = success;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceSettingsPresetsGetVoiceSettingsPresetResponse200" /> class.
        /// </summary>
        public VoiceSettingsPresetsGetVoiceSettingsPresetResponse200()
        {
        }
    }
}