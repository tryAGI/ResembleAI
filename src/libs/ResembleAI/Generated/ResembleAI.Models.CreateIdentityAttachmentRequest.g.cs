
#nullable enable

namespace ResembleAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateIdentityAttachmentRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modality")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ResembleAI.JsonConverters.IdentityUuidAttachmentsPostRequestBodyContentMultipartFormDataSchemaModalityJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ResembleAI.IdentityUuidAttachmentsPostRequestBodyContentMultipartFormDataSchemaModality Modality { get; set; }

        /// <summary>
        /// The media file to attach
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] File { get; set; }

        /// <summary>
        /// The media file to attach
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filename { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateIdentityAttachmentRequest" /> class.
        /// </summary>
        /// <param name="modality"></param>
        /// <param name="file">
        /// The media file to attach
        /// </param>
        /// <param name="filename">
        /// The media file to attach
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateIdentityAttachmentRequest(
            global::ResembleAI.IdentityUuidAttachmentsPostRequestBodyContentMultipartFormDataSchemaModality modality,
            byte[] file,
            string filename)
        {
            this.Modality = modality;
            this.File = file ?? throw new global::System.ArgumentNullException(nameof(file));
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateIdentityAttachmentRequest" /> class.
        /// </summary>
        public CreateIdentityAttachmentRequest()
        {
        }

    }
}