
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDetectFeedbackRequest
    {
        /// <summary>
        /// What the verdict should have been.<br/>
        ///   - `correct` — the verdict was right.<br/>
        ///   - `should_be_ai_generated` — we said authentic; it is AI-generated.<br/>
        ///   - `should_be_authentic` — we said AI-generated; it is genuine and unaltered.<br/>
        ///   - `should_be_non_ai` — no model generated it, but it may still be edited, spliced, or a human impersonation.<br/>
        ///   - `should_be_neutral` — neither call is right; the media is genuinely ambiguous.<br/>
        ///   - `skipped` — the verdict was wrong, but the reviewer didn't say how.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ResembleAI.JsonConverters.DetectUuidFeedbackPostRequestBodyContentApplicationJsonSchemaTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ResembleAI.DetectUuidFeedbackPostRequestBodyContentApplicationJsonSchemaType Type { get; set; }

        /// <summary>
        /// Free text, up to 1000 characters. Trimmed; blank becomes `null`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comment")]
        public string? Comment { get; set; }

        /// <summary>
        /// Where the answer came from. Use a stable, aggregatable value such as a product<br/>
        /// or queue name — not a per-request identifier. Truncated to 64 characters<br/>
        /// rather than rejected.<br/>
        /// Default Value: api
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        public string? Source { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDetectFeedbackRequest" /> class.
        /// </summary>
        /// <param name="type">
        /// What the verdict should have been.<br/>
        ///   - `correct` — the verdict was right.<br/>
        ///   - `should_be_ai_generated` — we said authentic; it is AI-generated.<br/>
        ///   - `should_be_authentic` — we said AI-generated; it is genuine and unaltered.<br/>
        ///   - `should_be_non_ai` — no model generated it, but it may still be edited, spliced, or a human impersonation.<br/>
        ///   - `should_be_neutral` — neither call is right; the media is genuinely ambiguous.<br/>
        ///   - `skipped` — the verdict was wrong, but the reviewer didn't say how.
        /// </param>
        /// <param name="comment">
        /// Free text, up to 1000 characters. Trimmed; blank becomes `null`.
        /// </param>
        /// <param name="source">
        /// Where the answer came from. Use a stable, aggregatable value such as a product<br/>
        /// or queue name — not a per-request identifier. Truncated to 64 characters<br/>
        /// rather than rejected.<br/>
        /// Default Value: api
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDetectFeedbackRequest(
            global::ResembleAI.DetectUuidFeedbackPostRequestBodyContentApplicationJsonSchemaType type,
            string? comment,
            string? source)
        {
            this.Type = type;
            this.Comment = comment;
            this.Source = source;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDetectFeedbackRequest" /> class.
        /// </summary>
        public CreateDetectFeedbackRequest()
        {
        }

    }
}