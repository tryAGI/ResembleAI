
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum KnowledgeItemsUuidGetResponsesContentApplicationJsonSchemaItemSourceType
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
    public static class KnowledgeItemsUuidGetResponsesContentApplicationJsonSchemaItemSourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this KnowledgeItemsUuidGetResponsesContentApplicationJsonSchemaItemSourceType value)
        {
            return value switch
            {
                KnowledgeItemsUuidGetResponsesContentApplicationJsonSchemaItemSourceType.Document => "document",
                KnowledgeItemsUuidGetResponsesContentApplicationJsonSchemaItemSourceType.Text => "text",
                KnowledgeItemsUuidGetResponsesContentApplicationJsonSchemaItemSourceType.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static KnowledgeItemsUuidGetResponsesContentApplicationJsonSchemaItemSourceType? ToEnum(string value)
        {
            return value switch
            {
                "document" => KnowledgeItemsUuidGetResponsesContentApplicationJsonSchemaItemSourceType.Document,
                "text" => KnowledgeItemsUuidGetResponsesContentApplicationJsonSchemaItemSourceType.Text,
                "url" => KnowledgeItemsUuidGetResponsesContentApplicationJsonSchemaItemSourceType.Url,
                _ => null,
            };
        }
    }
}