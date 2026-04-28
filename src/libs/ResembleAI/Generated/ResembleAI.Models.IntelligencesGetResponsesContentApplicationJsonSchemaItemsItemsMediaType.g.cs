
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// Type of media analyzed
    /// </summary>
    public enum IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsMediaType
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
    public static class IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsMediaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsMediaType value)
        {
            return value switch
            {
                IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsMediaType.Audio => "audio",
                IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsMediaType.Image => "image",
                IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsMediaType.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsMediaType? ToEnum(string value)
        {
            return value switch
            {
                "audio" => IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsMediaType.Audio,
                "image" => IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsMediaType.Image,
                "video" => IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsMediaType.Video,
                _ => null,
            };
        }
    }
}