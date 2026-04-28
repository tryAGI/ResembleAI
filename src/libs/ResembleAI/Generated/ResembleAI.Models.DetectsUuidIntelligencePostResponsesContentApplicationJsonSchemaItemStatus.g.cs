
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// Current status of the question
    /// </summary>
    public enum DetectsUuidIntelligencePostResponsesContentApplicationJsonSchemaItemStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DetectsUuidIntelligencePostResponsesContentApplicationJsonSchemaItemStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DetectsUuidIntelligencePostResponsesContentApplicationJsonSchemaItemStatus value)
        {
            return value switch
            {
                DetectsUuidIntelligencePostResponsesContentApplicationJsonSchemaItemStatus.Completed => "completed",
                DetectsUuidIntelligencePostResponsesContentApplicationJsonSchemaItemStatus.Failed => "failed",
                DetectsUuidIntelligencePostResponsesContentApplicationJsonSchemaItemStatus.Pending => "pending",
                DetectsUuidIntelligencePostResponsesContentApplicationJsonSchemaItemStatus.Processing => "processing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DetectsUuidIntelligencePostResponsesContentApplicationJsonSchemaItemStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => DetectsUuidIntelligencePostResponsesContentApplicationJsonSchemaItemStatus.Completed,
                "failed" => DetectsUuidIntelligencePostResponsesContentApplicationJsonSchemaItemStatus.Failed,
                "pending" => DetectsUuidIntelligencePostResponsesContentApplicationJsonSchemaItemStatus.Pending,
                "processing" => DetectsUuidIntelligencePostResponsesContentApplicationJsonSchemaItemStatus.Processing,
                _ => null,
            };
        }
    }
}