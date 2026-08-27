
#nullable enable

namespace ResembleAI
{
    /// <summary>
    ///
    /// </summary>
    public enum AudioEnhancementsEnhancementUuidGetResponsesContentApplicationJsonSchemaStatus
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
    public static class AudioEnhancementsEnhancementUuidGetResponsesContentApplicationJsonSchemaStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AudioEnhancementsEnhancementUuidGetResponsesContentApplicationJsonSchemaStatus value)
        {
            return value switch
            {
                AudioEnhancementsEnhancementUuidGetResponsesContentApplicationJsonSchemaStatus.Completed => "completed",
                AudioEnhancementsEnhancementUuidGetResponsesContentApplicationJsonSchemaStatus.Failed => "failed",
                AudioEnhancementsEnhancementUuidGetResponsesContentApplicationJsonSchemaStatus.Pending => "pending",
                AudioEnhancementsEnhancementUuidGetResponsesContentApplicationJsonSchemaStatus.Processing => "processing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AudioEnhancementsEnhancementUuidGetResponsesContentApplicationJsonSchemaStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => AudioEnhancementsEnhancementUuidGetResponsesContentApplicationJsonSchemaStatus.Completed,
                "failed" => AudioEnhancementsEnhancementUuidGetResponsesContentApplicationJsonSchemaStatus.Failed,
                "pending" => AudioEnhancementsEnhancementUuidGetResponsesContentApplicationJsonSchemaStatus.Pending,
                "processing" => AudioEnhancementsEnhancementUuidGetResponsesContentApplicationJsonSchemaStatus.Processing,
                _ => null,
            };
        }
    }
}