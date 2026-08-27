
#nullable enable

namespace ResembleAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class IdentityCreateIdentityRequest1
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("identity")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ResembleAI.IdentityPostRequestBodyContentApplicationJsonSchemaOneOf1Identity Identity { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IdentityCreateIdentityRequest1" /> class.
        /// </summary>
        /// <param name="identity"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IdentityCreateIdentityRequest1(
            global::ResembleAI.IdentityPostRequestBodyContentApplicationJsonSchemaOneOf1Identity identity)
        {
            this.Identity = identity ?? throw new global::System.ArgumentNullException(nameof(identity));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IdentityCreateIdentityRequest1" /> class.
        /// </summary>
        public IdentityCreateIdentityRequest1()
        {
        }

    }
}