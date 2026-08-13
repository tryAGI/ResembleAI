
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SignalSubmission
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_modality")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ResembleAI.JsonConverters.SignalSubmissionInputModalityJsonConverter))]
        public global::ResembleAI.SignalSubmissionInputModality? InputModality { get; set; }

        /// <summary>
        /// Original filename for file submissions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// MIME type for file submissions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_type")]
        public string? ContentType { get; set; }

        /// <summary>
        /// Truncated copy of the submitted text. Null for file submissions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_preview")]
        public string? TextPreview { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verdict")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ResembleAI.JsonConverters.SignalSubmissionVerdictJsonConverter))]
        public global::ResembleAI.SignalSubmissionVerdict? Verdict { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_category")]
        public global::ResembleAI.SignalCategoryScore? TopCategory { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("benign_score")]
        public double? BenignScore { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("margin_over_second")]
        public double? MarginOverSecond { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response")]
        public global::ResembleAI.SignalScoreItem? Response { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SignalSubmission" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="inputModality"></param>
        /// <param name="filename">
        /// Original filename for file submissions.
        /// </param>
        /// <param name="contentType">
        /// MIME type for file submissions.
        /// </param>
        /// <param name="textPreview">
        /// Truncated copy of the submitted text. Null for file submissions.
        /// </param>
        /// <param name="verdict"></param>
        /// <param name="topCategory"></param>
        /// <param name="benignScore"></param>
        /// <param name="marginOverSecond"></param>
        /// <param name="response"></param>
        /// <param name="createdAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SignalSubmission(
            int? id,
            global::ResembleAI.SignalSubmissionInputModality? inputModality,
            string? filename,
            string? contentType,
            string? textPreview,
            global::ResembleAI.SignalSubmissionVerdict? verdict,
            global::ResembleAI.SignalCategoryScore? topCategory,
            double? benignScore,
            double? marginOverSecond,
            global::ResembleAI.SignalScoreItem? response,
            global::System.DateTime? createdAt)
        {
            this.Id = id;
            this.InputModality = inputModality;
            this.Filename = filename;
            this.ContentType = contentType;
            this.TextPreview = textPreview;
            this.Verdict = verdict;
            this.TopCategory = topCategory;
            this.BenignScore = benignScore;
            this.MarginOverSecond = marginOverSecond;
            this.Response = response;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SignalSubmission" /> class.
        /// </summary>
        public SignalSubmission()
        {
        }

    }
}