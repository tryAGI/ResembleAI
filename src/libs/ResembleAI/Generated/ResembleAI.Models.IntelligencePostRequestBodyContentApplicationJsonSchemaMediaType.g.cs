
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// Explicit media type (auto-detected if not provided)
    /// </summary>
    public enum IntelligencePostRequestBodyContentApplicationJsonSchemaMediaType
    {
        /// <summary>
        /// 
        /// </summary>
        Audio,
        /// <summary>
        /// 
        /// </summary>
        Image,
        /// <summary>
        /// 
        /// </summary>
        Video,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IntelligencePostRequestBodyContentApplicationJsonSchemaMediaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IntelligencePostRequestBodyContentApplicationJsonSchemaMediaType value)
        {
            return value switch
            {
                IntelligencePostRequestBodyContentApplicationJsonSchemaMediaType.Audio => "audio",
                IntelligencePostRequestBodyContentApplicationJsonSchemaMediaType.Image => "image",
                IntelligencePostRequestBodyContentApplicationJsonSchemaMediaType.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IntelligencePostRequestBodyContentApplicationJsonSchemaMediaType? ToEnum(string value)
        {
            return value switch
            {
                "audio" => IntelligencePostRequestBodyContentApplicationJsonSchemaMediaType.Audio,
                "image" => IntelligencePostRequestBodyContentApplicationJsonSchemaMediaType.Image,
                "video" => IntelligencePostRequestBodyContentApplicationJsonSchemaMediaType.Video,
                _ => null,
            };
        }
    }
}