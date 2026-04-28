
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateVoiceSettingsPresetRequest
    {
        /// <summary>
        /// Preset name (unique, max 30 characters)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Speech pace/speed<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pace")]
        public double? Pace { get; set; }

        /// <summary>
        /// Voice variation<br/>
        /// Default Value: 0.8F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// Voice pitch adjustment<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pitch")]
        public double? Pitch { get; set; }

        /// <summary>
        /// Use HD quality<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("useHd")]
        public bool? UseHd { get; set; }

        /// <summary>
        /// Emotional exaggeration<br/>
        /// Default Value: 0.5F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exaggeration")]
        public double? Exaggeration { get; set; }

        /// <summary>
        /// Voice style prompt
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVoiceSettingsPresetRequest" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateVoiceSettingsPresetRequest(
            string name,
            double? pace,
            double? temperature,
            double? pitch,
            bool? useHd,
            double? exaggeration,
            string? description)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Pace = pace;
            this.Temperature = temperature;
            this.Pitch = pitch;
            this.UseHd = useHd;
            this.Exaggeration = exaggeration;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVoiceSettingsPresetRequest" /> class.
        /// </summary>
        public CreateVoiceSettingsPresetRequest()
        {
        }
    }
}