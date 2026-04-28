
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum KnowledgeItemsGetParametersStatus
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
    public static class KnowledgeItemsGetParametersStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this KnowledgeItemsGetParametersStatus value)
        {
            return value switch
            {
                KnowledgeItemsGetParametersStatus.Failed => "failed",
                KnowledgeItemsGetParametersStatus.Pending => "pending",
                KnowledgeItemsGetParametersStatus.Processing => "processing",
                KnowledgeItemsGetParametersStatus.Ready => "ready",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static KnowledgeItemsGetParametersStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => KnowledgeItemsGetParametersStatus.Failed,
                "pending" => KnowledgeItemsGetParametersStatus.Pending,
                "processing" => KnowledgeItemsGetParametersStatus.Processing,
                "ready" => KnowledgeItemsGetParametersStatus.Ready,
                _ => null,
            };
        }
    }
}