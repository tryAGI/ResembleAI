
#nullable enable

namespace ResembleAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SignalSettings
    {
        /// <summary>
        /// When false, scoring uses only the team's custom categories.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_builtin_categories")]
        public bool? UseBuiltinCategories { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SignalSettings" /> class.
        /// </summary>
        /// <param name="useBuiltinCategories">
        /// When false, scoring uses only the team's custom categories.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SignalSettings(
            bool? useBuiltinCategories)
        {
            this.UseBuiltinCategories = useBuiltinCategories;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SignalSettings" /> class.
        /// </summary>
        public SignalSettings()
        {
        }

    }
}