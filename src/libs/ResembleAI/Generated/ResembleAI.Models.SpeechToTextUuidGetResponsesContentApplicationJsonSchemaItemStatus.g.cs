
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum SpeechToTextUuidGetResponsesContentApplicationJsonSchemaItemStatus
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
    public static class SpeechToTextUuidGetResponsesContentApplicationJsonSchemaItemStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeechToTextUuidGetResponsesContentApplicationJsonSchemaItemStatus value)
        {
            return value switch
            {
                SpeechToTextUuidGetResponsesContentApplicationJsonSchemaItemStatus.Completed => "completed",
                SpeechToTextUuidGetResponsesContentApplicationJsonSchemaItemStatus.Failed => "failed",
                SpeechToTextUuidGetResponsesContentApplicationJsonSchemaItemStatus.Pending => "pending",
                SpeechToTextUuidGetResponsesContentApplicationJsonSchemaItemStatus.Processing => "processing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeechToTextUuidGetResponsesContentApplicationJsonSchemaItemStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => SpeechToTextUuidGetResponsesContentApplicationJsonSchemaItemStatus.Completed,
                "failed" => SpeechToTextUuidGetResponsesContentApplicationJsonSchemaItemStatus.Failed,
                "pending" => SpeechToTextUuidGetResponsesContentApplicationJsonSchemaItemStatus.Pending,
                "processing" => SpeechToTextUuidGetResponsesContentApplicationJsonSchemaItemStatus.Processing,
                _ => null,
            };
        }
    }
}