
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// Null until the team's categories have been calibrated.
    /// </summary>
    public sealed partial class SignalCalibration
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("calibrated_at")]
        public global::System.DateTime? CalibratedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("overall_recall")]
        public double? OverallRecall { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("warnings")]
        public global::System.Collections.Generic.IList<global::ResembleAI.SignalCalibrationWarningsItems>? Warnings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SignalCalibration" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="calibratedAt"></param>
        /// <param name="overallRecall"></param>
        /// <param name="warnings"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SignalCalibration(
            string? status,
            global::System.DateTime? calibratedAt,
            double? overallRecall,
            global::System.Collections.Generic.IList<global::ResembleAI.SignalCalibrationWarningsItems>? warnings)
        {
            this.Status = status;
            this.CalibratedAt = calibratedAt;
            this.OverallRecall = overallRecall;
            this.Warnings = warnings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SignalCalibration" /> class.
        /// </summary>
        public SignalCalibration()
        {
        }

    }
}