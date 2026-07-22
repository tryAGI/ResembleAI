
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IdentityPostRequestBodyContentApplicationJsonSchemaOneOf1Identity
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Default Value: person
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("identity_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ResembleAI.JsonConverters.IdentityPostRequestBodyContentApplicationJsonSchemaOneOf1IdentityIdentityTypeJsonConverter))]
        public global::ResembleAI.IdentityPostRequestBodyContentApplicationJsonSchemaOneOf1IdentityIdentityType? IdentityType { get; set; }

        /// <summary>
        /// Default Value: team
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visibility")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ResembleAI.JsonConverters.IdentityPostRequestBodyContentApplicationJsonSchemaOneOf1IdentityVisibilityJsonConverter))]
        public global::ResembleAI.IdentityPostRequestBodyContentApplicationJsonSchemaOneOf1IdentityVisibility? Visibility { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notes")]
        public string? Notes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_profile_id")]
        public string? VoiceProfileId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IdentityPostRequestBodyContentApplicationJsonSchemaOneOf1Identity" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="identityType">
        /// Default Value: person
        /// </param>
        /// <param name="visibility">
        /// Default Value: team
        /// </param>
        /// <param name="notes"></param>
        /// <param name="voiceProfileId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IdentityPostRequestBodyContentApplicationJsonSchemaOneOf1Identity(
            string name,
            global::ResembleAI.IdentityPostRequestBodyContentApplicationJsonSchemaOneOf1IdentityIdentityType? identityType,
            global::ResembleAI.IdentityPostRequestBodyContentApplicationJsonSchemaOneOf1IdentityVisibility? visibility,
            string? notes,
            string? voiceProfileId)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.IdentityType = identityType;
            this.Visibility = visibility;
            this.Notes = notes;
            this.VoiceProfileId = voiceProfileId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IdentityPostRequestBodyContentApplicationJsonSchemaOneOf1Identity" /> class.
        /// </summary>
        public IdentityPostRequestBodyContentApplicationJsonSchemaOneOf1Identity()
        {
        }

    }
}