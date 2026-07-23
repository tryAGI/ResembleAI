
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum WatermarkAudioModelResultStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Succeeded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WatermarkAudioModelResultStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WatermarkAudioModelResultStatus value)
        {
            return value switch
            {
                WatermarkAudioModelResultStatus.Failed => "failed",
                WatermarkAudioModelResultStatus.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WatermarkAudioModelResultStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => WatermarkAudioModelResultStatus.Failed,
                "succeeded" => WatermarkAudioModelResultStatus.Succeeded,
                _ => null,
            };
        }
    }
}