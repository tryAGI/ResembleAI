
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum WatermarkApplyUuidResultGetResponsesContentApplicationJsonSchemaItemMediaType
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
    public static class WatermarkApplyUuidResultGetResponsesContentApplicationJsonSchemaItemMediaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WatermarkApplyUuidResultGetResponsesContentApplicationJsonSchemaItemMediaType value)
        {
            return value switch
            {
                WatermarkApplyUuidResultGetResponsesContentApplicationJsonSchemaItemMediaType.Audio => "audio",
                WatermarkApplyUuidResultGetResponsesContentApplicationJsonSchemaItemMediaType.Image => "image",
                WatermarkApplyUuidResultGetResponsesContentApplicationJsonSchemaItemMediaType.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WatermarkApplyUuidResultGetResponsesContentApplicationJsonSchemaItemMediaType? ToEnum(string value)
        {
            return value switch
            {
                "audio" => WatermarkApplyUuidResultGetResponsesContentApplicationJsonSchemaItemMediaType.Audio,
                "image" => WatermarkApplyUuidResultGetResponsesContentApplicationJsonSchemaItemMediaType.Image,
                "video" => WatermarkApplyUuidResultGetResponsesContentApplicationJsonSchemaItemMediaType.Video,
                _ => null,
            };
        }
    }
}