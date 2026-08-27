
#nullable enable

namespace ResembleAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BulkCreatePronunciationsRequest
    {
        /// <summary>
        /// ZIP file containing audio files. Max 50 files, max 100MB total.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("zip")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] Zip { get; set; }

        /// <summary>
        /// ZIP file containing audio files. Max 50 files, max 100MB total.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("zipname")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Zipname { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkCreatePronunciationsRequest" /> class.
        /// </summary>
        /// <param name="zip">
        /// ZIP file containing audio files. Max 50 files, max 100MB total.
        /// </param>
        /// <param name="zipname">
        /// ZIP file containing audio files. Max 50 files, max 100MB total.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BulkCreatePronunciationsRequest(
            byte[] zip,
            string zipname)
        {
            this.Zip = zip ?? throw new global::System.ArgumentNullException(nameof(zip));
            this.Zipname = zipname ?? throw new global::System.ArgumentNullException(nameof(zipname));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkCreatePronunciationsRequest" /> class.
        /// </summary>
        public BulkCreatePronunciationsRequest()
        {
        }

    }
}