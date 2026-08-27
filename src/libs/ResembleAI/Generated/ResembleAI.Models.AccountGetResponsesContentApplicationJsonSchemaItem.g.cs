
#nullable enable

namespace ResembleAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AccountGetResponsesContentApplicationJsonSchemaItem
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_name")]
        public string? FirstName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_name")]
        public string? LastName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teams")]
        public int? Teams { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountGetResponsesContentApplicationJsonSchemaItem" /> class.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="createdAt"></param>
        /// <param name="teams"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AccountGetResponsesContentApplicationJsonSchemaItem(
            string? email,
            string? firstName,
            string? lastName,
            global::System.DateTime? createdAt,
            int? teams)
        {
            this.Email = email;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.CreatedAt = createdAt;
            this.Teams = teams;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountGetResponsesContentApplicationJsonSchemaItem" /> class.
        /// </summary>
        public AccountGetResponsesContentApplicationJsonSchemaItem()
        {
        }

    }
}