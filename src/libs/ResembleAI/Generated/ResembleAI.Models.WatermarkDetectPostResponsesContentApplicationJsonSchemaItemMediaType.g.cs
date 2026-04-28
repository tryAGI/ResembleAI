
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum WatermarkDetectPostResponsesContentApplicationJsonSchemaItemMediaType
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
    public static class WatermarkDetectPostResponsesContentApplicationJsonSchemaItemMediaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WatermarkDetectPostResponsesContentApplicationJsonSchemaItemMediaType value)
        {
            return value switch
            {
                WatermarkDetectPostResponsesContentApplicationJsonSchemaItemMediaType.Audio => "audio",
                WatermarkDetectPostResponsesContentApplicationJsonSchemaItemMediaType.Image => "image",
                WatermarkDetectPostResponsesContentApplicationJsonSchemaItemMediaType.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WatermarkDetectPostResponsesContentApplicationJsonSchemaItemMediaType? ToEnum(string value)
        {
            return value switch
            {
                "audio" => WatermarkDetectPostResponsesContentApplicationJsonSchemaItemMediaType.Audio,
                "image" => WatermarkDetectPostResponsesContentApplicationJsonSchemaItemMediaType.Image,
                "video" => WatermarkDetectPostResponsesContentApplicationJsonSchemaItemMediaType.Video,
                _ => null,
            };
        }
    }
}