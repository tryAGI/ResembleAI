
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// A Resemble-managed Detect Agent available to the authenticated team.
    /// </summary>
    public sealed partial class DetectAgent
    {
        /// <summary>
        /// Stable Detect Agent identifier. Currently the same as `uuid` and `preset_id`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Stable identifier used by the run and history endpoints.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uuid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Uuid { get; set; }

        /// <summary>
        /// Resemble-managed Detect Agent identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preset_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PresetId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Verification workflow handled by the Detect Agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Managed investigation depth. Informational and read-only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tier")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ResembleAI.JsonConverters.DetectAgentTierJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ResembleAI.DetectAgentTier Tier { get; set; }

        /// <summary>
        /// Read-only preview of patterns learned from previous investigations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memory_preview")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MemoryPreview { get; set; }

        /// <summary>
        /// Read-only feature flags for a managed Detect Agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("capabilities")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ResembleAI.DetectAgentCapabilities Capabilities { get; set; }

        /// <summary>
        /// Short description derived from the Detect Agent's managed instructions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tagline")]
        public string? Tagline { get; set; }

        /// <summary>
        /// Whether this team has initialized backing state for the Detect Agent by running it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("activated")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Activated { get; set; }

        /// <summary>
        /// Team backing-state creation time, or null before the first investigation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Team backing-state update time, or null before the first investigation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DetectAgent" /> class.
        /// </summary>
        /// <param name="id">
        /// Stable Detect Agent identifier. Currently the same as `uuid` and `preset_id`.
        /// </param>
        /// <param name="uuid">
        /// Stable identifier used by the run and history endpoints.
        /// </param>
        /// <param name="presetId">
        /// Resemble-managed Detect Agent identifier.
        /// </param>
        /// <param name="name"></param>
        /// <param name="tier">
        /// Managed investigation depth. Informational and read-only.
        /// </param>
        /// <param name="memoryPreview">
        /// Read-only preview of patterns learned from previous investigations.
        /// </param>
        /// <param name="capabilities">
        /// Read-only feature flags for a managed Detect Agent.
        /// </param>
        /// <param name="activated">
        /// Whether this team has initialized backing state for the Detect Agent by running it.
        /// </param>
        /// <param name="description">
        /// Verification workflow handled by the Detect Agent.
        /// </param>
        /// <param name="tagline">
        /// Short description derived from the Detect Agent's managed instructions.
        /// </param>
        /// <param name="createdAt">
        /// Team backing-state creation time, or null before the first investigation.
        /// </param>
        /// <param name="updatedAt">
        /// Team backing-state update time, or null before the first investigation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DetectAgent(
            string id,
            string uuid,
            string presetId,
            string name,
            global::ResembleAI.DetectAgentTier tier,
            string memoryPreview,
            global::ResembleAI.DetectAgentCapabilities capabilities,
            bool activated,
            string? description,
            string? tagline,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Uuid = uuid ?? throw new global::System.ArgumentNullException(nameof(uuid));
            this.PresetId = presetId ?? throw new global::System.ArgumentNullException(nameof(presetId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Tier = tier;
            this.MemoryPreview = memoryPreview ?? throw new global::System.ArgumentNullException(nameof(memoryPreview));
            this.Capabilities = capabilities ?? throw new global::System.ArgumentNullException(nameof(capabilities));
            this.Tagline = tagline;
            this.Activated = activated;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DetectAgent" /> class.
        /// </summary>
        public DetectAgent()
        {
        }

    }
}