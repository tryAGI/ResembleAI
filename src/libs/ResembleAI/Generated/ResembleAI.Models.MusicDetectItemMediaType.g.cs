
#nullable enable

namespace ResembleAI
{
    /// <summary>
    ///
    /// </summary>
    public enum MusicDetectItemMediaType
    {
        /// <summary>
        ///
        /// </summary>
        Audio,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MusicDetectItemMediaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MusicDetectItemMediaType value)
        {
            return value switch
            {
                MusicDetectItemMediaType.Audio => "audio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MusicDetectItemMediaType? ToEnum(string value)
        {
            return value switch
            {
                "audio" => MusicDetectItemMediaType.Audio,
                _ => null,
            };
        }
    }
}