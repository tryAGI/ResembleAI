
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// Any subset of the create parameters. Supplying `scenarios` replaces the existing set and re-triggers embedding.
    /// </summary>
    public sealed partial class SignalCustomCategoryUpdateRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scenarios")]
        public global::System.Collections.Generic.IList<string>? Scenarios { get; set; }

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
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SignalCustomCategoryUpdateRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="scenarios"></param>
        /// <param name="description"></param>
        /// <param name="icon"></param>
        /// <param name="enabled"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SignalCustomCategoryUpdateRequest(
            string? name,
            global::System.Collections.Generic.IList<string>? scenarios,
            string? description,
            string? icon,
            bool? enabled)
        {
            this.Name = name;
            this.Scenarios = scenarios;
            this.Description = description;
            this.Icon = icon;
            this.Enabled = enabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SignalCustomCategoryUpdateRequest" /> class.
        /// </summary>
        public SignalCustomCategoryUpdateRequest()
        {
        }

    }
}