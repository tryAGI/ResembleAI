
#nullable enable

namespace ResembleAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DetectVideoAttackTypeItems
    {
        /// <summary>
        /// Attack type code
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Code { get; set; }

        /// <summary>
        /// Human-readable attack type name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Probability of this attack type, given that the result is fake
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prob")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Prob { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DetectVideoAttackTypeItems" /> class.
        /// </summary>
        /// <param name="code">
        /// Attack type code
        /// </param>
        /// <param name="name">
        /// Human-readable attack type name
        /// </param>
        /// <param name="prob">
        /// Probability of this attack type, given that the result is fake
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DetectVideoAttackTypeItems(
            string code,
            string name,
            double prob)
        {
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Prob = prob;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DetectVideoAttackTypeItems" /> class.
        /// </summary>
        public DetectVideoAttackTypeItems()
        {
        }

    }
}