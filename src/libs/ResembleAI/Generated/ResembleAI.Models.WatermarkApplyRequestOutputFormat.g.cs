
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// `default` returns WAV (audio), PNG (image), or MP4 (video). `source` returns the source's format (for example JPEG, AVIF, M4A, or MOV) when it can be reproduced, otherwise the default.<br/>
    /// Default Value: default
    /// </summary>
    public enum WatermarkApplyRequestOutputFormat
    {
        /// <summary>
        ///
        /// </summary>
        Default,
        /// <summary>
        ///
        /// </summary>
        Source,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WatermarkApplyRequestOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WatermarkApplyRequestOutputFormat value)
        {
            return value switch
            {
                WatermarkApplyRequestOutputFormat.Default => "default",
                WatermarkApplyRequestOutputFormat.Source => "source",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WatermarkApplyRequestOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "default" => WatermarkApplyRequestOutputFormat.Default,
                "source" => WatermarkApplyRequestOutputFormat.Source,
                _ => null,
            };
        }
    }
}