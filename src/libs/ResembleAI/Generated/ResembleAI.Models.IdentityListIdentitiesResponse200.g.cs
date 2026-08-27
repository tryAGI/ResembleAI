
#nullable enable

namespace ResembleAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class IdentityListIdentitiesResponse200
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        public bool? Success { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page")]
        public int? Page { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_pages")]
        public int? NumPages { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_size")]
        public int? PageSize { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_count")]
        public int? TotalCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        public global::System.Collections.Generic.IList<global::ResembleAI.IdentitySummary>? Items { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IdentityListIdentitiesResponse200" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="page"></param>
        /// <param name="numPages"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <param name="items"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IdentityListIdentitiesResponse200(
            bool? success,
            int? page,
            int? numPages,
            int? pageSize,
            int? totalCount,
            global::System.Collections.Generic.IList<global::ResembleAI.IdentitySummary>? items)
        {
            this.Success = success;
            this.Page = page;
            this.NumPages = numPages;
            this.PageSize = pageSize;
            this.TotalCount = totalCount;
            this.Items = items;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IdentityListIdentitiesResponse200" /> class.
        /// </summary>
        public IdentityListIdentitiesResponse200()
        {
        }

    }
}