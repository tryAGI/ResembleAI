
#nullable enable

namespace ResembleAI
{
    /// <summary>
    ///
    /// </summary>
    public enum WatermarkApplyPostParametersPrefer
    {
        /// <summary>
        ///
        /// </summary>
        Wait,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WatermarkApplyPostParametersPreferExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WatermarkApplyPostParametersPrefer value)
        {
            return value switch
            {
                WatermarkApplyPostParametersPrefer.Wait => "wait",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WatermarkApplyPostParametersPrefer? ToEnum(string value)
        {
            return value switch
            {
                "wait" => WatermarkApplyPostParametersPrefer.Wait,
                _ => null,
            };
        }
    }
}