
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AudioTimestamps
    {
        /// <summary>
        /// Grapheme characters
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("graph_chars")]
        public global::System.Collections.Generic.IList<string>? GraphChars { get; set; }

        /// <summary>
        /// Grapheme timestamps [start, end] in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("graph_times")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>? GraphTimes { get; set; }

        /// <summary>
        /// Phoneme characters
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phon_chars")]
        public global::System.Collections.Generic.IList<string>? PhonChars { get; set; }

        /// <summary>
        /// Phoneme timestamps [start, end] in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phon_times")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>? PhonTimes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioTimestamps" /> class.
        /// </summary>
        /// <param name="graphChars">
        /// Grapheme characters
        /// </param>
        /// <param name="graphTimes">
        /// Grapheme timestamps [start, end] in seconds
        /// </param>
        /// <param name="phonChars">
        /// Phoneme characters
        /// </param>
        /// <param name="phonTimes">
        /// Phoneme timestamps [start, end] in seconds
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioTimestamps(
            global::System.Collections.Generic.IList<string>? graphChars,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>? graphTimes,
            global::System.Collections.Generic.IList<string>? phonChars,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>? phonTimes)
        {
            this.GraphChars = graphChars;
            this.GraphTimes = graphTimes;
            this.PhonChars = phonChars;
            this.PhonTimes = phonTimes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioTimestamps" /> class.
        /// </summary>
        public AudioTimestamps()
        {
        }

    }
}