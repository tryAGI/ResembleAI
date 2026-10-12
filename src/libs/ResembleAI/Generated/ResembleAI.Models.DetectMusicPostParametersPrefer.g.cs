
#nullable enable

namespace ResembleAI
{
    /// <summary>
    ///
    /// </summary>
    public enum DetectMusicPostParametersPrefer
    {
        /// <summary>
        ///
        /// </summary>
        Wait,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DetectMusicPostParametersPreferExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DetectMusicPostParametersPrefer value)
        {
            return value switch
            {
                DetectMusicPostParametersPrefer.Wait => "wait",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DetectMusicPostParametersPrefer? ToEnum(string value)
        {
            return value switch
            {
                "wait" => DetectMusicPostParametersPrefer.Wait,
                _ => null,
            };
        }
    }
}