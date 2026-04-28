
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum WatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMediaType
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
    public static class WatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMediaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMediaType value)
        {
            return value switch
            {
                WatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMediaType.Audio => "audio",
                WatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMediaType.Image => "image",
                WatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMediaType.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMediaType? ToEnum(string value)
        {
            return value switch
            {
                "audio" => WatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMediaType.Audio,
                "image" => WatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMediaType.Image,
                "video" => WatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMediaType.Video,
                _ => null,
            };
        }
    }
}