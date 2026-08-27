
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// Video only. Selects which detection components run for a video file:<br/>
    /// `audio` (audio track only), `video` (visual frames only), or `all` (both — the default).<br/>
    /// Ignored for audio and image inputs. Invalid values are rejected with HTTP 400.<br/>
    /// Default Value: all
    /// </summary>
    public enum DetectPostRequestBodyContentMultipartFormDataSchemaModality
    {
        /// <summary>
        ///
        /// </summary>
        All,
        /// <summary>
        ///
        /// </summary>
        Audio,
        /// <summary>
        ///
        /// </summary>
        Video,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DetectPostRequestBodyContentMultipartFormDataSchemaModalityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DetectPostRequestBodyContentMultipartFormDataSchemaModality value)
        {
            return value switch
            {
                DetectPostRequestBodyContentMultipartFormDataSchemaModality.All => "all",
                DetectPostRequestBodyContentMultipartFormDataSchemaModality.Audio => "audio",
                DetectPostRequestBodyContentMultipartFormDataSchemaModality.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DetectPostRequestBodyContentMultipartFormDataSchemaModality? ToEnum(string value)
        {
            return value switch
            {
                "all" => DetectPostRequestBodyContentMultipartFormDataSchemaModality.All,
                "audio" => DetectPostRequestBodyContentMultipartFormDataSchemaModality.Audio,
                "video" => DetectPostRequestBodyContentMultipartFormDataSchemaModality.Video,
                _ => null,
            };
        }
    }
}