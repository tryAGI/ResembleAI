
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum KnowledgeItemsGetParametersSourceType
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
    public static class KnowledgeItemsGetParametersSourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this KnowledgeItemsGetParametersSourceType value)
        {
            return value switch
            {
                KnowledgeItemsGetParametersSourceType.Document => "document",
                KnowledgeItemsGetParametersSourceType.Text => "text",
                KnowledgeItemsGetParametersSourceType.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static KnowledgeItemsGetParametersSourceType? ToEnum(string value)
        {
            return value switch
            {
                "document" => KnowledgeItemsGetParametersSourceType.Document,
                "text" => KnowledgeItemsGetParametersSourceType.Text,
                "url" => KnowledgeItemsGetParametersSourceType.Url,
                _ => null,
            };
        }
    }
}