
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// Current status of the question
    /// </summary>
    public enum DetectsUuidIntelligenceQuestionUuidGetResponsesContentApplicationJsonSchemaItemStatus
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
    public static class DetectsUuidIntelligenceQuestionUuidGetResponsesContentApplicationJsonSchemaItemStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DetectsUuidIntelligenceQuestionUuidGetResponsesContentApplicationJsonSchemaItemStatus value)
        {
            return value switch
            {
                DetectsUuidIntelligenceQuestionUuidGetResponsesContentApplicationJsonSchemaItemStatus.Completed => "completed",
                DetectsUuidIntelligenceQuestionUuidGetResponsesContentApplicationJsonSchemaItemStatus.Failed => "failed",
                DetectsUuidIntelligenceQuestionUuidGetResponsesContentApplicationJsonSchemaItemStatus.Pending => "pending",
                DetectsUuidIntelligenceQuestionUuidGetResponsesContentApplicationJsonSchemaItemStatus.Processing => "processing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DetectsUuidIntelligenceQuestionUuidGetResponsesContentApplicationJsonSchemaItemStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => DetectsUuidIntelligenceQuestionUuidGetResponsesContentApplicationJsonSchemaItemStatus.Completed,
                "failed" => DetectsUuidIntelligenceQuestionUuidGetResponsesContentApplicationJsonSchemaItemStatus.Failed,
                "pending" => DetectsUuidIntelligenceQuestionUuidGetResponsesContentApplicationJsonSchemaItemStatus.Pending,
                "processing" => DetectsUuidIntelligenceQuestionUuidGetResponsesContentApplicationJsonSchemaItemStatus.Processing,
                _ => null,
            };
        }
    }
}