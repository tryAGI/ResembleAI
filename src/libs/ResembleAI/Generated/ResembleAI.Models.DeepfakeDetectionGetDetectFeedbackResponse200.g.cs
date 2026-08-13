
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeepfakeDetectionGetDetectFeedbackResponse200
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        public bool? Success { get; set; }

        /// <summary>
        /// A reviewer's answer about a detection verdict, stored with a snapshot of what the<br/>
        /// model said at the time the answer was submitted. Returned by<br/>
        /// `POST /detect/{uuid}/feedback` and `GET /detect/{uuid}/feedback`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item")]
        public global::ResembleAI.DetectFeedback? Item { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeepfakeDetectionGetDetectFeedbackResponse200" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="item">
        /// A reviewer's answer about a detection verdict, stored with a snapshot of what the<br/>
        /// model said at the time the answer was submitted. Returned by<br/>
        /// `POST /detect/{uuid}/feedback` and `GET /detect/{uuid}/feedback`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeepfakeDetectionGetDetectFeedbackResponse200(
            bool? success,
            global::ResembleAI.DetectFeedback? item)
        {
            this.Success = success;
            this.Item = item;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeepfakeDetectionGetDetectFeedbackResponse200" /> class.
        /// </summary>
        public DeepfakeDetectionGetDetectFeedbackResponse200()
        {
        }

    }
}