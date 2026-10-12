
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// `fake` when the track is classified as AI-generated music, `real` when it is classified as human-produced.
    /// </summary>
    public enum MusicDetectMetricsLabel
    {
        /// <summary>
        ///
        /// </summary>
        Fake,
        /// <summary>
        ///
        /// </summary>
        Real,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MusicDetectMetricsLabelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MusicDetectMetricsLabel value)
        {
            return value switch
            {
                MusicDetectMetricsLabel.Fake => "fake",
                MusicDetectMetricsLabel.Real => "real",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MusicDetectMetricsLabel? ToEnum(string value)
        {
            return value switch
            {
                "fake" => MusicDetectMetricsLabel.Fake,
                "real" => MusicDetectMetricsLabel.Real,
                _ => null,
            };
        }
    }
}