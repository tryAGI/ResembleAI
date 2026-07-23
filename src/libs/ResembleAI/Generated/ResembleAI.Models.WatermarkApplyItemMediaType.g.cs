
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// Detected media type of the source file.
    /// </summary>
    public enum WatermarkApplyItemMediaType
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
    public static class WatermarkApplyItemMediaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WatermarkApplyItemMediaType value)
        {
            return value switch
            {
                WatermarkApplyItemMediaType.Audio => "audio",
                WatermarkApplyItemMediaType.Image => "image",
                WatermarkApplyItemMediaType.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WatermarkApplyItemMediaType? ToEnum(string value)
        {
            return value switch
            {
                "audio" => WatermarkApplyItemMediaType.Audio,
                "image" => WatermarkApplyItemMediaType.Image,
                "video" => WatermarkApplyItemMediaType.Video,
                _ => null,
            };
        }
    }
}