
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SignalCustomCategoryCreateRequest
    {
        /// <summary>
        /// Category name. Must be unique within the team.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Example phrases that define the pattern. Maximum 50 entries, each up to 2000 characters. A newline-separated string is also accepted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scenarios")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Scenarios { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Single emoji.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("icon")]
        public string? Icon { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SignalCustomCategoryCreateRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Category name. Must be unique within the team.
        /// </param>
        /// <param name="scenarios">
        /// Example phrases that define the pattern. Maximum 50 entries, each up to 2000 characters. A newline-separated string is also accepted.
        /// </param>
        /// <param name="description"></param>
        /// <param name="icon">
        /// Single emoji.
        /// </param>
        /// <param name="enabled">
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SignalCustomCategoryCreateRequest(
            string name,
            global::System.Collections.Generic.IList<string> scenarios,
            string? description,
            string? icon,
            bool? enabled)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Scenarios = scenarios ?? throw new global::System.ArgumentNullException(nameof(scenarios));
            this.Description = description;
            this.Icon = icon;
            this.Enabled = enabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SignalCustomCategoryCreateRequest" /> class.
        /// </summary>
        public SignalCustomCategoryCreateRequest()
        {
        }

    }
}