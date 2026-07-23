
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum WatermarkDetectItemMediaType
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
    public static class WatermarkDetectItemMediaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WatermarkDetectItemMediaType value)
        {
            return value switch
            {
                WatermarkDetectItemMediaType.Audio => "audio",
                WatermarkDetectItemMediaType.Image => "image",
                WatermarkDetectItemMediaType.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WatermarkDetectItemMediaType? ToEnum(string value)
        {
            return value switch
            {
                "audio" => WatermarkDetectItemMediaType.Audio,
                "image" => WatermarkDetectItemMediaType.Image,
                "video" => WatermarkDetectItemMediaType.Video,
                _ => null,
            };
        }
    }
}