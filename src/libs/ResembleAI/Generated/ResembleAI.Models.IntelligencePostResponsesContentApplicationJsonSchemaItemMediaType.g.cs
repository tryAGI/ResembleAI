
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// Type of media analyzed
    /// </summary>
    public enum IntelligencePostResponsesContentApplicationJsonSchemaItemMediaType
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
    public static class IntelligencePostResponsesContentApplicationJsonSchemaItemMediaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IntelligencePostResponsesContentApplicationJsonSchemaItemMediaType value)
        {
            return value switch
            {
                IntelligencePostResponsesContentApplicationJsonSchemaItemMediaType.Audio => "audio",
                IntelligencePostResponsesContentApplicationJsonSchemaItemMediaType.Image => "image",
                IntelligencePostResponsesContentApplicationJsonSchemaItemMediaType.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IntelligencePostResponsesContentApplicationJsonSchemaItemMediaType? ToEnum(string value)
        {
            return value switch
            {
                "audio" => IntelligencePostResponsesContentApplicationJsonSchemaItemMediaType.Audio,
                "image" => IntelligencePostResponsesContentApplicationJsonSchemaItemMediaType.Image,
                "video" => IntelligencePostResponsesContentApplicationJsonSchemaItemMediaType.Video,
                _ => null,
            };
        }
    }
}