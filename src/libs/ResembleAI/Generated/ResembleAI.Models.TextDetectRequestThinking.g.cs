
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// How much reasoning effort the detector spends on the passage. Higher levels can improve accuracy on ambiguous text at the cost of latency.<br/>
    /// Default Value: low
    /// </summary>
    public enum TextDetectRequestThinking
    {
        /// <summary>
        ///
        /// </summary>
        High,
        /// <summary>
        ///
        /// </summary>
        Low,
        /// <summary>
        ///
        /// </summary>
        Medium,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextDetectRequestThinkingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextDetectRequestThinking value)
        {
            return value switch
            {
                TextDetectRequestThinking.High => "high",
                TextDetectRequestThinking.Low => "low",
                TextDetectRequestThinking.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextDetectRequestThinking? ToEnum(string value)
        {
            return value switch
            {
                "high" => TextDetectRequestThinking.High,
                "low" => TextDetectRequestThinking.Low,
                "medium" => TextDetectRequestThinking.Medium,
                _ => null,
            };
        }
    }
}