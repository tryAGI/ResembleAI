
#nullable enable

namespace ResembleAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SignalBuiltInCategory
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
        [global::System.Text.Json.Serialization.JsonPropertyName("icon")]
        public string? Icon { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scenario_count")]
        public int? ScenarioCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("example_texts")]
        public global::System.Collections.Generic.IList<string>? ExampleTexts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SignalBuiltInCategory" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="icon"></param>
        /// <param name="scenarioCount"></param>
        /// <param name="exampleTexts"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SignalBuiltInCategory(
            int? id,
            string? name,
            string? icon,
            int? scenarioCount,
            global::System.Collections.Generic.IList<string>? exampleTexts)
        {
            this.Id = id;
            this.Name = name;
            this.Icon = icon;
            this.ScenarioCount = scenarioCount;
            this.ExampleTexts = exampleTexts;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SignalBuiltInCategory" /> class.
        /// </summary>
        public SignalBuiltInCategory()
        {
        }

    }
}