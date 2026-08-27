
#nullable enable

namespace ResembleAI
{
    /// <summary>
    ///
    /// </summary>
    public enum DetectGetResponsesContentApplicationJsonSchemaItemsItemsMediaType
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
    public static class DetectGetResponsesContentApplicationJsonSchemaItemsItemsMediaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DetectGetResponsesContentApplicationJsonSchemaItemsItemsMediaType value)
        {
            return value switch
            {
                DetectGetResponsesContentApplicationJsonSchemaItemsItemsMediaType.Audio => "audio",
                DetectGetResponsesContentApplicationJsonSchemaItemsItemsMediaType.Image => "image",
                DetectGetResponsesContentApplicationJsonSchemaItemsItemsMediaType.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DetectGetResponsesContentApplicationJsonSchemaItemsItemsMediaType? ToEnum(string value)
        {
            return value switch
            {
                "audio" => DetectGetResponsesContentApplicationJsonSchemaItemsItemsMediaType.Audio,
                "image" => DetectGetResponsesContentApplicationJsonSchemaItemsItemsMediaType.Image,
                "video" => DetectGetResponsesContentApplicationJsonSchemaItemsItemsMediaType.Video,
                _ => null,
            };
        }
    }
}