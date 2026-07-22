
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// A multimodal identity profile
    /// </summary>
    public sealed partial class Identity
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
        [global::System.Text.Json.Serialization.JsonPropertyName("identity_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ResembleAI.JsonConverters.IdentityIdentityTypeJsonConverter))]
        public global::ResembleAI.IdentityIdentityType? IdentityType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visibility")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ResembleAI.JsonConverters.IdentityVisibilityJsonConverter))]
        public global::ResembleAI.IdentityVisibility? Visibility { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_samples")]
        public global::System.Collections.Generic.IList<global::ResembleAI.IdentityAttachment>? VoiceSamples { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("face_photos")]
        public global::System.Collections.Generic.IList<global::ResembleAI.IdentityAttachment>? FacePhotos { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_videos")]
        public global::System.Collections.Generic.IList<global::ResembleAI.IdentityAttachment>? ReferenceVideos { get; set; }

        /// <summary>
        /// Per-modality embedding processing status
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embeddings")]
        public global::System.Collections.Generic.IList<global::ResembleAI.IdentityEmbeddingsItems>? Embeddings { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projects")]
        public global::System.Collections.Generic.IList<global::ResembleAI.IdentityProjectsItems>? Projects { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Identity" /> class.
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="name"></param>
        /// <param name="identityType"></param>
        /// <param name="visibility"></param>
        /// <param name="notes"></param>
        /// <param name="voiceProfileId"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="projectCount"></param>
        /// <param name="voiceSamples"></param>
        /// <param name="facePhotos"></param>
        /// <param name="referenceVideos"></param>
        /// <param name="embeddings">
        /// Per-modality embedding processing status
        /// </param>
        /// <param name="projects"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Identity(
            string? uuid,
            string? name,
            global::ResembleAI.IdentityIdentityType? identityType,
            global::ResembleAI.IdentityVisibility? visibility,
            string? notes,
            string? voiceProfileId,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            int? projectCount,
            global::System.Collections.Generic.IList<global::ResembleAI.IdentityAttachment>? voiceSamples,
            global::System.Collections.Generic.IList<global::ResembleAI.IdentityAttachment>? facePhotos,
            global::System.Collections.Generic.IList<global::ResembleAI.IdentityAttachment>? referenceVideos,
            global::System.Collections.Generic.IList<global::ResembleAI.IdentityEmbeddingsItems>? embeddings,
            global::System.Collections.Generic.IList<global::ResembleAI.IdentityProjectsItems>? projects)
        {
            this.Uuid = uuid;
            this.Name = name;
            this.IdentityType = identityType;
            this.Visibility = visibility;
            this.Notes = notes;
            this.VoiceProfileId = voiceProfileId;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.ProjectCount = projectCount;
            this.VoiceSamples = voiceSamples;
            this.FacePhotos = facePhotos;
            this.ReferenceVideos = referenceVideos;
            this.Embeddings = embeddings;
            this.Projects = projects;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Identity" /> class.
        /// </summary>
        public Identity()
        {
        }

    }
}