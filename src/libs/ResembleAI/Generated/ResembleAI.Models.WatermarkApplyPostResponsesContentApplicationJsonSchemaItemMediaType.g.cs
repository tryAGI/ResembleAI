
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// Detected media type of the source file.
    /// </summary>
    public enum WatermarkApplyPostResponsesContentApplicationJsonSchemaItemMediaType
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
    public static class WatermarkApplyPostResponsesContentApplicationJsonSchemaItemMediaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WatermarkApplyPostResponsesContentApplicationJsonSchemaItemMediaType value)
        {
            return value switch
            {
                WatermarkApplyPostResponsesContentApplicationJsonSchemaItemMediaType.Audio => "audio",
                WatermarkApplyPostResponsesContentApplicationJsonSchemaItemMediaType.Image => "image",
                WatermarkApplyPostResponsesContentApplicationJsonSchemaItemMediaType.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WatermarkApplyPostResponsesContentApplicationJsonSchemaItemMediaType? ToEnum(string value)
        {
            return value switch
            {
                "audio" => WatermarkApplyPostResponsesContentApplicationJsonSchemaItemMediaType.Audio,
                "image" => WatermarkApplyPostResponsesContentApplicationJsonSchemaItemMediaType.Image,
                "video" => WatermarkApplyPostResponsesContentApplicationJsonSchemaItemMediaType.Video,
                _ => null,
            };
        }
    }
}