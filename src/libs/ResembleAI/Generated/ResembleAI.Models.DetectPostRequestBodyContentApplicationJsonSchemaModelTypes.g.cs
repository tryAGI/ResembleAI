
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// Use talking_head for face-swaps
    /// </summary>
    public enum DetectPostRequestBodyContentApplicationJsonSchemaModelTypes
    {
        /// <summary>
        /// 
        /// </summary>
        Image,
        /// <summary>
        /// 
        /// </summary>
        TalkingHead,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DetectPostRequestBodyContentApplicationJsonSchemaModelTypesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DetectPostRequestBodyContentApplicationJsonSchemaModelTypes value)
        {
            return value switch
            {
                DetectPostRequestBodyContentApplicationJsonSchemaModelTypes.Image => "image",
                DetectPostRequestBodyContentApplicationJsonSchemaModelTypes.TalkingHead => "talking_head",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DetectPostRequestBodyContentApplicationJsonSchemaModelTypes? ToEnum(string value)
        {
            return value switch
            {
                "image" => DetectPostRequestBodyContentApplicationJsonSchemaModelTypes.Image,
                "talking_head" => DetectPostRequestBodyContentApplicationJsonSchemaModelTypes.TalkingHead,
                _ => null,
            };
        }
    }
}