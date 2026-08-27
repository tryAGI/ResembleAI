
#nullable enable

namespace ResembleAI
{
    /// <summary>
    ///
    /// </summary>
    public enum SpeechToTextPostResponsesContentApplicationJsonSchemaItemStatus
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
    public static class SpeechToTextPostResponsesContentApplicationJsonSchemaItemStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeechToTextPostResponsesContentApplicationJsonSchemaItemStatus value)
        {
            return value switch
            {
                SpeechToTextPostResponsesContentApplicationJsonSchemaItemStatus.Completed => "completed",
                SpeechToTextPostResponsesContentApplicationJsonSchemaItemStatus.Failed => "failed",
                SpeechToTextPostResponsesContentApplicationJsonSchemaItemStatus.Pending => "pending",
                SpeechToTextPostResponsesContentApplicationJsonSchemaItemStatus.Processing => "processing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeechToTextPostResponsesContentApplicationJsonSchemaItemStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => SpeechToTextPostResponsesContentApplicationJsonSchemaItemStatus.Completed,
                "failed" => SpeechToTextPostResponsesContentApplicationJsonSchemaItemStatus.Failed,
                "pending" => SpeechToTextPostResponsesContentApplicationJsonSchemaItemStatus.Pending,
                "processing" => SpeechToTextPostResponsesContentApplicationJsonSchemaItemStatus.Processing,
                _ => null,
            };
        }
    }
}