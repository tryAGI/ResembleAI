
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IdentitySearchPostResponsesContentApplicationJsonSchemaItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distance")]
        public double? Distance { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score_type")]
        public string? ScoreType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IdentitySearchPostResponsesContentApplicationJsonSchemaItem" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="distance"></param>
        /// <param name="scoreType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IdentitySearchPostResponsesContentApplicationJsonSchemaItem(
            string? name,
            double? distance,
            string? scoreType)
        {
            this.Name = name;
            this.Distance = distance;
            this.ScoreType = scoreType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IdentitySearchPostResponsesContentApplicationJsonSchemaItem" /> class.
        /// </summary>
        public IdentitySearchPostResponsesContentApplicationJsonSchemaItem()
        {
        }

    }
}