
#nullable enable

namespace ResembleAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DuetsListDuetVoicesResponse200
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        public bool? Success { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        public global::System.Collections.Generic.IList<global::ResembleAI.DuetVoicesGetResponsesContentApplicationJsonSchemaItemsItems>? Items { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DuetsListDuetVoicesResponse200" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="items"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DuetsListDuetVoicesResponse200(
            bool? success,
            global::System.Collections.Generic.IList<global::ResembleAI.DuetVoicesGetResponsesContentApplicationJsonSchemaItemsItems>? items)
        {
            this.Success = success;
            this.Items = items;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DuetsListDuetVoicesResponse200" /> class.
        /// </summary>
        public DuetsListDuetVoicesResponse200()
        {
        }

    }
}