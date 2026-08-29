
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// What the model said, snapshotted when the feedback was submitted. `null` when the<br/>
    /// detection landed somewhere indeterminate. `should_be_neutral` and `should_be_non_ai`<br/>
    /// have no counterpart here — this field records only the two decided model outcomes.
    /// </summary>
    public sealed partial class DetectFeedbackVerdict2
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}