
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// Media type of the detect.
    /// </summary>
    public enum DetectFeedbackMediaType
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
        Text,
        /// <summary>
        /// 
        /// </summary>
        Video,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DetectFeedbackMediaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DetectFeedbackMediaType value)
        {
            return value switch
            {
                DetectFeedbackMediaType.Audio => "audio",
                DetectFeedbackMediaType.Image => "image",
                DetectFeedbackMediaType.Text => "text",
                DetectFeedbackMediaType.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DetectFeedbackMediaType? ToEnum(string value)
        {
            return value switch
            {
                "audio" => DetectFeedbackMediaType.Audio,
                "image" => DetectFeedbackMediaType.Image,
                "text" => DetectFeedbackMediaType.Text,
                "video" => DetectFeedbackMediaType.Video,
                _ => null,
            };
        }
    }
}