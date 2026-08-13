
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SignalCustomCategory
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("icon")]
        public string? Icon { get; set; }

        /// <summary>
        /// Whether the category is included in scoring.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ResembleAI.JsonConverters.SignalCustomCategoryStatusJsonConverter))]
        public global::ResembleAI.SignalCustomCategoryStatus? Status { get; set; }

        /// <summary>
        /// Error message when `status` is `failed`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embed_error")]
        public string? EmbedError { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedded_at")]
        public global::System.DateTime? EmbeddedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scenario_count")]
        public int? ScenarioCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding_model_version")]
        public string? EmbeddingModelVersion { get; set; }

        /// <summary>
        /// Calibration warnings where this category was confused with another.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("overlaps")]
        public global::System.Collections.Generic.IList<global::ResembleAI.SignalCustomCategoryOverlapsItems>? Overlaps { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scenarios")]
        public global::System.Collections.Generic.IList<global::ResembleAI.SignalScenario>? Scenarios { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SignalCustomCategory" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="icon"></param>
        /// <param name="enabled">
        /// Whether the category is included in scoring.
        /// </param>
        /// <param name="status"></param>
        /// <param name="embedError">
        /// Error message when `status` is `failed`.
        /// </param>
        /// <param name="embeddedAt"></param>
        /// <param name="scenarioCount"></param>
        /// <param name="embeddingModelVersion"></param>
        /// <param name="overlaps">
        /// Calibration warnings where this category was confused with another.
        /// </param>
        /// <param name="scenarios"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SignalCustomCategory(
            int? id,
            string? name,
            string? description,
            string? icon,
            bool? enabled,
            global::ResembleAI.SignalCustomCategoryStatus? status,
            string? embedError,
            global::System.DateTime? embeddedAt,
            int? scenarioCount,
            string? embeddingModelVersion,
            global::System.Collections.Generic.IList<global::ResembleAI.SignalCustomCategoryOverlapsItems>? overlaps,
            global::System.Collections.Generic.IList<global::ResembleAI.SignalScenario>? scenarios)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.Icon = icon;
            this.Enabled = enabled;
            this.Status = status;
            this.EmbedError = embedError;
            this.EmbeddedAt = embeddedAt;
            this.ScenarioCount = scenarioCount;
            this.EmbeddingModelVersion = embeddingModelVersion;
            this.Overlaps = overlaps;
            this.Scenarios = scenarios;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SignalCustomCategory" /> class.
        /// </summary>
        public SignalCustomCategory()
        {
        }

    }
}