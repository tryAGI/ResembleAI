
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum SignalSubmissionInputModality
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
    public static class SignalSubmissionInputModalityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SignalSubmissionInputModality value)
        {
            return value switch
            {
                SignalSubmissionInputModality.Audio => "audio",
                SignalSubmissionInputModality.Image => "image",
                SignalSubmissionInputModality.Text => "text",
                SignalSubmissionInputModality.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SignalSubmissionInputModality? ToEnum(string value)
        {
            return value switch
            {
                "audio" => SignalSubmissionInputModality.Audio,
                "image" => SignalSubmissionInputModality.Image,
                "text" => SignalSubmissionInputModality.Text,
                "video" => SignalSubmissionInputModality.Video,
                _ => null,
            };
        }
    }
}