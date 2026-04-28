
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// Type of knowledge source
    /// </summary>
    public enum KnowledgeItemsPostRequestBodyContentApplicationJsonSchemaSourceType
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
    public static class KnowledgeItemsPostRequestBodyContentApplicationJsonSchemaSourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this KnowledgeItemsPostRequestBodyContentApplicationJsonSchemaSourceType value)
        {
            return value switch
            {
                KnowledgeItemsPostRequestBodyContentApplicationJsonSchemaSourceType.Document => "document",
                KnowledgeItemsPostRequestBodyContentApplicationJsonSchemaSourceType.Text => "text",
                KnowledgeItemsPostRequestBodyContentApplicationJsonSchemaSourceType.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static KnowledgeItemsPostRequestBodyContentApplicationJsonSchemaSourceType? ToEnum(string value)
        {
            return value switch
            {
                "document" => KnowledgeItemsPostRequestBodyContentApplicationJsonSchemaSourceType.Document,
                "text" => KnowledgeItemsPostRequestBodyContentApplicationJsonSchemaSourceType.Text,
                "url" => KnowledgeItemsPostRequestBodyContentApplicationJsonSchemaSourceType.Url,
                _ => null,
            };
        }
    }
}