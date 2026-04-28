
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum DetectUuidGetResponsesContentApplicationJsonSchemaItemMediaType
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
    public static class DetectUuidGetResponsesContentApplicationJsonSchemaItemMediaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DetectUuidGetResponsesContentApplicationJsonSchemaItemMediaType value)
        {
            return value switch
            {
                DetectUuidGetResponsesContentApplicationJsonSchemaItemMediaType.Audio => "audio",
                DetectUuidGetResponsesContentApplicationJsonSchemaItemMediaType.Image => "image",
                DetectUuidGetResponsesContentApplicationJsonSchemaItemMediaType.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DetectUuidGetResponsesContentApplicationJsonSchemaItemMediaType? ToEnum(string value)
        {
            return value switch
            {
                "audio" => DetectUuidGetResponsesContentApplicationJsonSchemaItemMediaType.Audio,
                "image" => DetectUuidGetResponsesContentApplicationJsonSchemaItemMediaType.Image,
                "video" => DetectUuidGetResponsesContentApplicationJsonSchemaItemMediaType.Video,
                _ => null,
            };
        }
    }
}