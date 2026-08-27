
#nullable enable

namespace ResembleAI
{
    /// <summary>
    ///
    /// </summary>
    public enum AudioEnhancementsPostResponsesContentApplicationJsonSchemaStatus
    {
        /// <summary>
        ///
        /// </summary>
        Pending,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AudioEnhancementsPostResponsesContentApplicationJsonSchemaStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AudioEnhancementsPostResponsesContentApplicationJsonSchemaStatus value)
        {
            return value switch
            {
                AudioEnhancementsPostResponsesContentApplicationJsonSchemaStatus.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AudioEnhancementsPostResponsesContentApplicationJsonSchemaStatus? ToEnum(string value)
        {
            return value switch
            {
                "pending" => AudioEnhancementsPostResponsesContentApplicationJsonSchemaStatus.Pending,
                _ => null,
            };
        }
    }
}