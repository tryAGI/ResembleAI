
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum KnowledgeItemsUuidGetResponsesContentApplicationJsonSchemaItemStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Pending,
        /// <summary>
        /// 
        /// </summary>
        Processing,
        /// <summary>
        /// 
        /// </summary>
        Ready,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class KnowledgeItemsUuidGetResponsesContentApplicationJsonSchemaItemStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this KnowledgeItemsUuidGetResponsesContentApplicationJsonSchemaItemStatus value)
        {
            return value switch
            {
                KnowledgeItemsUuidGetResponsesContentApplicationJsonSchemaItemStatus.Failed => "failed",
                KnowledgeItemsUuidGetResponsesContentApplicationJsonSchemaItemStatus.Pending => "pending",
                KnowledgeItemsUuidGetResponsesContentApplicationJsonSchemaItemStatus.Processing => "processing",
                KnowledgeItemsUuidGetResponsesContentApplicationJsonSchemaItemStatus.Ready => "ready",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static KnowledgeItemsUuidGetResponsesContentApplicationJsonSchemaItemStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => KnowledgeItemsUuidGetResponsesContentApplicationJsonSchemaItemStatus.Failed,
                "pending" => KnowledgeItemsUuidGetResponsesContentApplicationJsonSchemaItemStatus.Pending,
                "processing" => KnowledgeItemsUuidGetResponsesContentApplicationJsonSchemaItemStatus.Processing,
                "ready" => KnowledgeItemsUuidGetResponsesContentApplicationJsonSchemaItemStatus.Ready,
                _ => null,
            };
        }
    }
}