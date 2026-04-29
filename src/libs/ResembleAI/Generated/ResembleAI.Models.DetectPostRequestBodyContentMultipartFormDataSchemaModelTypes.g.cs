
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// Use talking_head for face-swaps
    /// </summary>
    public enum DetectPostRequestBodyContentMultipartFormDataSchemaModelTypes
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
    public static class DetectPostRequestBodyContentMultipartFormDataSchemaModelTypesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DetectPostRequestBodyContentMultipartFormDataSchemaModelTypes value)
        {
            return value switch
            {
                DetectPostRequestBodyContentMultipartFormDataSchemaModelTypes.Image => "image",
                DetectPostRequestBodyContentMultipartFormDataSchemaModelTypes.TalkingHead => "talking_head",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DetectPostRequestBodyContentMultipartFormDataSchemaModelTypes? ToEnum(string value)
        {
            return value switch
            {
                "image" => DetectPostRequestBodyContentMultipartFormDataSchemaModelTypes.Image,
                "talking_head" => DetectPostRequestBodyContentMultipartFormDataSchemaModelTypes.TalkingHead,
                _ => null,
            };
        }
    }
}