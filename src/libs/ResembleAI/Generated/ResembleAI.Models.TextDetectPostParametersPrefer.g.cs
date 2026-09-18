
#nullable enable

namespace ResembleAI
{
    /// <summary>
    ///
    /// </summary>
    public enum TextDetectPostParametersPrefer
    {
        /// <summary>
        ///
        /// </summary>
        Wait,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextDetectPostParametersPreferExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextDetectPostParametersPrefer value)
        {
            return value switch
            {
                TextDetectPostParametersPrefer.Wait => "wait",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextDetectPostParametersPrefer? ToEnum(string value)
        {
            return value switch
            {
                "wait" => TextDetectPostParametersPrefer.Wait,
                _ => null,
            };
        }
    }
}