
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum SignalScoreItemInputModality
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
    public static class SignalScoreItemInputModalityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SignalScoreItemInputModality value)
        {
            return value switch
            {
                SignalScoreItemInputModality.Audio => "audio",
                SignalScoreItemInputModality.Image => "image",
                SignalScoreItemInputModality.Text => "text",
                SignalScoreItemInputModality.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SignalScoreItemInputModality? ToEnum(string value)
        {
            return value switch
            {
                "audio" => SignalScoreItemInputModality.Audio,
                "image" => SignalScoreItemInputModality.Image,
                "text" => SignalScoreItemInputModality.Text,
                "video" => SignalScoreItemInputModality.Video,
                _ => null,
            };
        }
    }
}