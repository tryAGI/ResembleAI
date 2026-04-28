
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum KnowledgeItemsGetResponsesContentApplicationJsonSchemaItemsItemsStatus
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
    public static class KnowledgeItemsGetResponsesContentApplicationJsonSchemaItemsItemsStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this KnowledgeItemsGetResponsesContentApplicationJsonSchemaItemsItemsStatus value)
        {
            return value switch
            {
                KnowledgeItemsGetResponsesContentApplicationJsonSchemaItemsItemsStatus.Failed => "failed",
                KnowledgeItemsGetResponsesContentApplicationJsonSchemaItemsItemsStatus.Pending => "pending",
                KnowledgeItemsGetResponsesContentApplicationJsonSchemaItemsItemsStatus.Processing => "processing",
                KnowledgeItemsGetResponsesContentApplicationJsonSchemaItemsItemsStatus.Ready => "ready",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static KnowledgeItemsGetResponsesContentApplicationJsonSchemaItemsItemsStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => KnowledgeItemsGetResponsesContentApplicationJsonSchemaItemsItemsStatus.Failed,
                "pending" => KnowledgeItemsGetResponsesContentApplicationJsonSchemaItemsItemsStatus.Pending,
                "processing" => KnowledgeItemsGetResponsesContentApplicationJsonSchemaItemsItemsStatus.Processing,
                "ready" => KnowledgeItemsGetResponsesContentApplicationJsonSchemaItemsItemsStatus.Ready,
                _ => null,
            };
        }
    }
}