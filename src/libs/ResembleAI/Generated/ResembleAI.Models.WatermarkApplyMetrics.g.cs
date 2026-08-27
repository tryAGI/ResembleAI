
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// Apply metadata for image/video. Audio apply metrics are null.
    /// </summary>
    public sealed partial class WatermarkApplyMetrics
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strength")]
        public double? Strength { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_message")]
        public string? CustomMessage { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message_bits_length")]
        public int? MessageBitsLength { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WatermarkApplyMetrics" /> class.
        /// </summary>
        /// <param name="strength"></param>
        /// <param name="customMessage"></param>
        /// <param name="messageBitsLength"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WatermarkApplyMetrics(
            double? strength,
            string? customMessage,
            int? messageBitsLength)
        {
            this.Strength = strength;
            this.CustomMessage = customMessage;
            this.MessageBitsLength = messageBitsLength;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WatermarkApplyMetrics" /> class.
        /// </summary>
        public WatermarkApplyMetrics()
        {
        }

    }
}