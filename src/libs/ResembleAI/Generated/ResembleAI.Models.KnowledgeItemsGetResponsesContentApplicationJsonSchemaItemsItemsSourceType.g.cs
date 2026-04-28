
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum KnowledgeItemsGetResponsesContentApplicationJsonSchemaItemsItemsSourceType
    {
        /// <summary>
        /// 
        /// </summary>
        Document,
        /// <summary>
        /// 
        /// </summary>
        Text,
        /// <summary>
        /// 
        /// </summary>
        Url,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class KnowledgeItemsGetResponsesContentApplicationJsonSchemaItemsItemsSourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this KnowledgeItemsGetResponsesContentApplicationJsonSchemaItemsItemsSourceType value)
        {
            return value switch
            {
                KnowledgeItemsGetResponsesContentApplicationJsonSchemaItemsItemsSourceType.Document => "document",
                KnowledgeItemsGetResponsesContentApplicationJsonSchemaItemsItemsSourceType.Text => "text",
                KnowledgeItemsGetResponsesContentApplicationJsonSchemaItemsItemsSourceType.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static KnowledgeItemsGetResponsesContentApplicationJsonSchemaItemsItemsSourceType? ToEnum(string value)
        {
            return value switch
            {
                "document" => KnowledgeItemsGetResponsesContentApplicationJsonSchemaItemsItemsSourceType.Document,
                "text" => KnowledgeItemsGetResponsesContentApplicationJsonSchemaItemsItemsSourceType.Text,
                "url" => KnowledgeItemsGetResponsesContentApplicationJsonSchemaItemsItemsSourceType.Url,
                _ => null,
            };
        }
    }
}