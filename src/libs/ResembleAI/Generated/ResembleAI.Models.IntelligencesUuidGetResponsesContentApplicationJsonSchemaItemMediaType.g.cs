
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// Type of media analyzed
    /// </summary>
    public enum IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemMediaType
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
    public static class IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemMediaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemMediaType value)
        {
            return value switch
            {
                IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemMediaType.Audio => "audio",
                IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemMediaType.Image => "image",
                IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemMediaType.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemMediaType? ToEnum(string value)
        {
            return value switch
            {
                "audio" => IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemMediaType.Audio,
                "image" => IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemMediaType.Image,
                "video" => IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemMediaType.Video,
                _ => null,
            };
        }
    }
}