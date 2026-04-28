
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum WatermarkDetectPostParametersPrefer
    {
        /// <summary>
        /// 
        /// </summary>
        Wait,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WatermarkDetectPostParametersPreferExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WatermarkDetectPostParametersPrefer value)
        {
            return value switch
            {
                WatermarkDetectPostParametersPrefer.Wait => "wait",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WatermarkDetectPostParametersPrefer? ToEnum(string value)
        {
            return value switch
            {
                "wait" => WatermarkDetectPostParametersPrefer.Wait,
                _ => null,
            };
        }
    }
}