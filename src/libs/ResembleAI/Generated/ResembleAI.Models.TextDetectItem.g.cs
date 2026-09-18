
#nullable enable

namespace ResembleAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TextDetectItem
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uuid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Uuid { get; set; }

        /// <summary>
        /// `processing` until inference returns, `completed` once `prediction` and `confidence` are populated, or `failed` if the analysis errored.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ResembleAI.JsonConverters.TextDetectItemStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ResembleAI.TextDetectItemStatus Status { get; set; }

        /// <summary>
        /// Verdict for the passage. `uncertain` means the detector abstained rather than guessing (for example, too few words after normalization); abstained requests are not billed. Null while processing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prediction")]
        public global::ResembleAI.TextDetectItemPrediction? Prediction { get; set; }

        /// <summary>
        /// Confidence in the reported `prediction`, from 0 to 1. Null while processing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        public double? Confidence { get; set; }

        /// <summary>
        /// The submitted text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_content")]
        public string? TextContent { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextDetectItem" /> class.
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="status">
        /// `processing` until inference returns, `completed` once `prediction` and `confidence` are populated, or `failed` if the analysis errored.
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="prediction">
        /// Verdict for the passage. `uncertain` means the detector abstained rather than guessing (for example, too few words after normalization); abstained requests are not billed. Null while processing.
        /// </param>
        /// <param name="confidence">
        /// Confidence in the reported `prediction`, from 0 to 1. Null while processing.
        /// </param>
        /// <param name="textContent">
        /// The submitted text.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextDetectItem(
            string uuid,
            global::ResembleAI.TextDetectItemStatus status,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::ResembleAI.TextDetectItemPrediction? prediction,
            double? confidence,
            string? textContent)
        {
            this.Uuid = uuid ?? throw new global::System.ArgumentNullException(nameof(uuid));
            this.Status = status;
            this.Prediction = prediction;
            this.Confidence = confidence;
            this.TextContent = textContent;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextDetectItem" /> class.
        /// </summary>
        public TextDetectItem()
        {
        }

    }
}