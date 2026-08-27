
#nullable enable

namespace ResembleAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SignalScenario
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Whether this example has finished embedding.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedded")]
        public bool? Embedded { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SignalScenario" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="text"></param>
        /// <param name="embedded">
        /// Whether this example has finished embedding.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SignalScenario(
            int? id,
            string? text,
            bool? embedded)
        {
            this.Id = id;
            this.Text = text;
            this.Embedded = embedded;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SignalScenario" /> class.
        /// </summary>
        public SignalScenario()
        {
        }

    }
}