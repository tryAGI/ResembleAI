
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AudioEditListAudioEditsResponse200
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
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        public global::System.Collections.Generic.IList<global::ResembleAI.EditGetResponsesContentApplicationJsonSchemaItemsItems>? Items { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioEditListAudioEditsResponse200" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="page"></param>
        /// <param name="numPages"></param>
        /// <param name="pageSize"></param>
        /// <param name="items"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioEditListAudioEditsResponse200(
            bool? success,
            int? page,
            int? numPages,
            int? pageSize,
            global::System.Collections.Generic.IList<global::ResembleAI.EditGetResponsesContentApplicationJsonSchemaItemsItems>? items)
        {
            this.Success = success;
            this.Page = page;
            this.NumPages = numPages;
            this.PageSize = pageSize;
            this.Items = items;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioEditListAudioEditsResponse200" /> class.
        /// </summary>
        public AudioEditListAudioEditsResponse200()
        {
        }

    }
}