
#nullable enable

namespace ResembleAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WatermarkApplyResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Success { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ResembleAI.WatermarkApplyItem Item { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WatermarkApplyResponse" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="item"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WatermarkApplyResponse(
            bool success,
            global::ResembleAI.WatermarkApplyItem item)
        {
            this.Success = success;
            this.Item = item ?? throw new global::System.ArgumentNullException(nameof(item));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WatermarkApplyResponse" /> class.
        /// </summary>
        public WatermarkApplyResponse()
        {
        }

    }
}