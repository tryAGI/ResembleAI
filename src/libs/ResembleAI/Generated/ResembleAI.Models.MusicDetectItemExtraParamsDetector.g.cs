
#nullable enable

namespace ResembleAI
{
    /// <summary>
    ///
    /// </summary>
    public enum MusicDetectItemExtraParamsDetector
    {
        /// <summary>
        ///
        /// </summary>
        Music,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MusicDetectItemExtraParamsDetectorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MusicDetectItemExtraParamsDetector value)
        {
            return value switch
            {
                MusicDetectItemExtraParamsDetector.Music => "music",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MusicDetectItemExtraParamsDetector? ToEnum(string value)
        {
            return value switch
            {
                "music" => MusicDetectItemExtraParamsDetector.Music,
                _ => null,
            };
        }
    }
}