
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// A reference media file attached to an identity
    /// </summary>
    public sealed partial class IdentityAttachment
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("byte_size")]
        public int? ByteSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_type")]
        public string? ContentType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IdentityAttachment" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="filename"></param>
        /// <param name="byteSize"></param>
        /// <param name="contentType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IdentityAttachment(
            int? id,
            string? filename,
            int? byteSize,
            string? contentType)
        {
            this.Id = id;
            this.Filename = filename;
            this.ByteSize = byteSize;
            this.ContentType = contentType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IdentityAttachment" /> class.
        /// </summary>
        public IdentityAttachment()
        {
        }

    }
}