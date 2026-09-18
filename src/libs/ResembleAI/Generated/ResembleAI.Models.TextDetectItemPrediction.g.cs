
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// Verdict for the passage. `uncertain` means the detector abstained rather than guessing (for example, too few words after normalization); abstained requests are not billed. Null while processing.
    /// </summary>
    public enum TextDetectItemPrediction
    {
        /// <summary>
        ///
        /// </summary>
        Ai,
        /// <summary>
        ///
        /// </summary>
        Human,
        /// <summary>
        ///
        /// </summary>
        Uncertain,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextDetectItemPredictionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextDetectItemPrediction value)
        {
            return value switch
            {
                TextDetectItemPrediction.Ai => "ai",
                TextDetectItemPrediction.Human => "human",
                TextDetectItemPrediction.Uncertain => "uncertain",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextDetectItemPrediction? ToEnum(string value)
        {
            return value switch
            {
                "ai" => TextDetectItemPrediction.Ai,
                "human" => TextDetectItemPrediction.Human,
                "uncertain" => TextDetectItemPrediction.Uncertain,
                _ => null,
            };
        }
    }
}