
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// Which detection modality was requested. `all` when not specified.<br/>
    /// For a single-modality video detect, the skipped component's metrics are absent<br/>
    /// (`metrics` for audio-only-skipped, `video_metrics` for video-only-skipped), and the<br/>
    /// detect still reaches `completed` once the requested modality(ies) finish.
    /// </summary>
    public enum DetectPostResponsesContentApplicationJsonSchemaItemModality
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
    public static class DetectPostResponsesContentApplicationJsonSchemaItemModalityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DetectPostResponsesContentApplicationJsonSchemaItemModality value)
        {
            return value switch
            {
                DetectPostResponsesContentApplicationJsonSchemaItemModality.All => "all",
                DetectPostResponsesContentApplicationJsonSchemaItemModality.Audio => "audio",
                DetectPostResponsesContentApplicationJsonSchemaItemModality.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DetectPostResponsesContentApplicationJsonSchemaItemModality? ToEnum(string value)
        {
            return value switch
            {
                "all" => DetectPostResponsesContentApplicationJsonSchemaItemModality.All,
                "audio" => DetectPostResponsesContentApplicationJsonSchemaItemModality.Audio,
                "video" => DetectPostResponsesContentApplicationJsonSchemaItemModality.Video,
                _ => null,
            };
        }
    }
}