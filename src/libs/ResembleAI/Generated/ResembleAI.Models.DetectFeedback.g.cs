
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// A reviewer's answer about a detection verdict, stored with a snapshot of what the<br/>
    /// model said at the time the answer was submitted. Returned by<br/>
    /// `POST /detect/{uuid}/feedback` and `GET /detect/{uuid}/feedback`.
    /// </summary>
    public sealed partial class DetectFeedback
    {
        /// <summary>
        /// The detect this answer is attached to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detect_uuid")]
        public string? DetectUuid { get; set; }

        /// <summary>
        /// What the verdict should have been.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ResembleAI.JsonConverters.DetectFeedbackTypeJsonConverter))]
        public global::ResembleAI.DetectFeedbackType? Type { get; set; }

        /// <summary>
        /// Derived from `type` — `correct` is `up`, everything else is `down`. Never independent of `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vote")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ResembleAI.JsonConverters.DetectFeedbackVoteJsonConverter))]
        public global::ResembleAI.DetectFeedbackVote? Vote { get; set; }

        /// <summary>
        /// What the model said, snapshotted when the feedback was submitted. `null` when the<br/>
        /// detection landed somewhere indeterminate. `should_be_neutral` and `should_be_non_ai`<br/>
        /// have no counterpart here — this field records only the two decided model outcomes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verdict")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ResembleAI.JsonConverters.OneOfJsonConverter<global::ResembleAI.DetectFeedbackVerdict?, object>))]
        public global::ResembleAI.OneOf<global::ResembleAI.DetectFeedbackVerdict?, object>? Verdict { get; set; }

        /// <summary>
        /// The model's headline confidence, 0.0–1.0, or `null`. For video, the higher of the<br/>
        /// audio and video confidences.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        public double? Score { get; set; }

        /// <summary>
        /// Media type of the detect.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ResembleAI.JsonConverters.DetectFeedbackMediaTypeJsonConverter))]
        public global::ResembleAI.DetectFeedbackMediaType? MediaType { get; set; }

        /// <summary>
        /// The reviewer's free-text comment, or `null`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comment")]
        public string? Comment { get; set; }

        /// <summary>
        /// Credits awarded for this answer. Written by Resemble, never by the submitter; `0` on a fresh row.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credit")]
        public int? Credit { get; set; }

        /// <summary>
        /// Attribution string recorded for this answer. Defaults to `api`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        public string? Source { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Moves when the answer is revised; `created_at` does not.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DetectFeedback" /> class.
        /// </summary>
        /// <param name="detectUuid">
        /// The detect this answer is attached to.
        /// </param>
        /// <param name="type">
        /// What the verdict should have been.
        /// </param>
        /// <param name="vote">
        /// Derived from `type` — `correct` is `up`, everything else is `down`. Never independent of `type`.
        /// </param>
        /// <param name="verdict">
        /// What the model said, snapshotted when the feedback was submitted. `null` when the<br/>
        /// detection landed somewhere indeterminate. `should_be_neutral` and `should_be_non_ai`<br/>
        /// have no counterpart here — this field records only the two decided model outcomes.
        /// </param>
        /// <param name="score">
        /// The model's headline confidence, 0.0–1.0, or `null`. For video, the higher of the<br/>
        /// audio and video confidences.
        /// </param>
        /// <param name="mediaType">
        /// Media type of the detect.
        /// </param>
        /// <param name="comment">
        /// The reviewer's free-text comment, or `null`.
        /// </param>
        /// <param name="credit">
        /// Credits awarded for this answer. Written by Resemble, never by the submitter; `0` on a fresh row.
        /// </param>
        /// <param name="source">
        /// Attribution string recorded for this answer. Defaults to `api`.
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt">
        /// Moves when the answer is revised; `created_at` does not.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DetectFeedback(
            string? detectUuid,
            global::ResembleAI.DetectFeedbackType? type,
            global::ResembleAI.DetectFeedbackVote? vote,
            global::ResembleAI.OneOf<global::ResembleAI.DetectFeedbackVerdict?, object>? verdict,
            double? score,
            global::ResembleAI.DetectFeedbackMediaType? mediaType,
            string? comment,
            int? credit,
            string? source,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt)
        {
            this.DetectUuid = detectUuid;
            this.Type = type;
            this.Vote = vote;
            this.Verdict = verdict;
            this.Score = score;
            this.MediaType = mediaType;
            this.Comment = comment;
            this.Credit = credit;
            this.Source = source;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DetectFeedback" /> class.
        /// </summary>
        public DetectFeedback()
        {
        }

    }
}