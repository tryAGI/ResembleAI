
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// Identity summary returned by the list and simple-create endpoints
    /// </summary>
    public sealed partial class IdentitySummary
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uuid")]
        public string? Uuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// URL of the first voice sample, if any
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_url")]
        public string? AudioUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visibility")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ResembleAI.JsonConverters.IdentitySummaryVisibilityJsonConverter))]
        public global::ResembleAI.IdentitySummaryVisibility? Visibility { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("identity_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ResembleAI.JsonConverters.IdentitySummaryIdentityTypeJsonConverter))]
        public global::ResembleAI.IdentitySummaryIdentityType? IdentityType { get; set; }

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_count")]
        public int? ProjectCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IdentitySummary" /> class.
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="name"></param>
        /// <param name="createdAt"></param>
        /// <param name="audioUrl">
        /// URL of the first voice sample, if any
        /// </param>
        /// <param name="visibility"></param>
        /// <param name="identityType"></param>
        /// <param name="notes"></param>
        /// <param name="voiceProfileId"></param>
        /// <param name="updatedAt"></param>
        /// <param name="projectCount"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IdentitySummary(
            string? uuid,
            string? name,
            global::System.DateTime? createdAt,
            string? audioUrl,
            global::ResembleAI.IdentitySummaryVisibility? visibility,
            global::ResembleAI.IdentitySummaryIdentityType? identityType,
            string? notes,
            string? voiceProfileId,
            global::System.DateTime? updatedAt,
            int? projectCount)
        {
            this.Uuid = uuid;
            this.Name = name;
            this.CreatedAt = createdAt;
            this.AudioUrl = audioUrl;
            this.Visibility = visibility;
            this.IdentityType = identityType;
            this.Notes = notes;
            this.VoiceProfileId = voiceProfileId;
            this.UpdatedAt = updatedAt;
            this.ProjectCount = projectCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IdentitySummary" /> class.
        /// </summary>
        public IdentitySummary()
        {
        }

    }
}