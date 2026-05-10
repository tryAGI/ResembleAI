
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateVoiceSettingsPresetRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pace")]
        public double? Pace { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pitch")]
        public double? Pitch { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("useHd")]
        public bool? UseHd { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exaggeration")]
        public double? Exaggeration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateVoiceSettingsPresetRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="pace"></param>
        /// <param name="temperature"></param>
        /// <param name="pitch"></param>
        /// <param name="useHd"></param>
        /// <param name="exaggeration"></param>
        /// <param name="description"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateVoiceSettingsPresetRequest(
            string? name,
            double? pace,
            double? temperature,
            double? pitch,
            bool? useHd,
            double? exaggeration,
            string? description)
        {
            this.Name = name;
            this.Pace = pace;
            this.Temperature = temperature;
            this.Pitch = pitch;
            this.UseHd = useHd;
            this.Exaggeration = exaggeration;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateVoiceSettingsPresetRequest" /> class.
        /// </summary>
        public UpdateVoiceSettingsPresetRequest()
        {
        }

    }
}