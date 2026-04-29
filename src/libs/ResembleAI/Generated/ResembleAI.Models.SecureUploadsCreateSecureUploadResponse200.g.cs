
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SecureUploadsCreateSecureUploadResponse200
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        public bool? Success { get; set; }

        /// <summary>
        /// JWT referencing the uploaded file. Valid for 1 hour. Pass this value as `media_token` on downstream requests.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        public string? Token { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SecureUploadsCreateSecureUploadResponse200" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="token">
        /// JWT referencing the uploaded file. Valid for 1 hour. Pass this value as `media_token` on downstream requests.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SecureUploadsCreateSecureUploadResponse200(
            bool? success,
            string? token)
        {
            this.Success = success;
            this.Token = token;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecureUploadsCreateSecureUploadResponse200" /> class.
        /// </summary>
        public SecureUploadsCreateSecureUploadResponse200()
        {
        }
    }
}