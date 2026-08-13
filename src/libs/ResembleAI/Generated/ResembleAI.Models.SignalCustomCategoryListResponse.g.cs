
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SignalCustomCategoryListResponse
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
        [global::System.Text.Json.Serialization.JsonPropertyName("settings")]
        public global::ResembleAI.SignalSettings? Settings { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("built_in_categories")]
        public global::System.Collections.Generic.IList<global::ResembleAI.SignalBuiltInCategory>? BuiltInCategories { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_categories")]
        public global::System.Collections.Generic.IList<global::ResembleAI.SignalCustomCategory>? CustomCategories { get; set; }

        /// <summary>
        /// Null until the team's categories have been calibrated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("calibration")]
        public global::ResembleAI.SignalCalibration? Calibration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SignalCustomCategoryListResponse" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="settings"></param>
        /// <param name="builtInCategories"></param>
        /// <param name="customCategories"></param>
        /// <param name="calibration">
        /// Null until the team's categories have been calibrated.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SignalCustomCategoryListResponse(
            bool success,
            global::ResembleAI.SignalSettings? settings,
            global::System.Collections.Generic.IList<global::ResembleAI.SignalBuiltInCategory>? builtInCategories,
            global::System.Collections.Generic.IList<global::ResembleAI.SignalCustomCategory>? customCategories,
            global::ResembleAI.SignalCalibration? calibration)
        {
            this.Success = success;
            this.Settings = settings;
            this.BuiltInCategories = builtInCategories;
            this.CustomCategories = customCategories;
            this.Calibration = calibration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SignalCustomCategoryListResponse" /> class.
        /// </summary>
        public SignalCustomCategoryListResponse()
        {
        }

    }
}