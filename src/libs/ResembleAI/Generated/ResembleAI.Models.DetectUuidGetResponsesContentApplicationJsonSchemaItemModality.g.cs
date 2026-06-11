
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// Which detection modality was requested for this detect. `all` when not specified<br/>
    /// (the default). For a single-modality video detect, the skipped component's metrics<br/>
    /// are absent (`metrics` for audio-only-skipped, `video_metrics` for video-only-skipped).
    /// </summary>
    public enum DetectUuidGetResponsesContentApplicationJsonSchemaItemModality
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
    public static class DetectUuidGetResponsesContentApplicationJsonSchemaItemModalityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DetectUuidGetResponsesContentApplicationJsonSchemaItemModality value)
        {
            return value switch
            {
                DetectUuidGetResponsesContentApplicationJsonSchemaItemModality.All => "all",
                DetectUuidGetResponsesContentApplicationJsonSchemaItemModality.Audio => "audio",
                DetectUuidGetResponsesContentApplicationJsonSchemaItemModality.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DetectUuidGetResponsesContentApplicationJsonSchemaItemModality? ToEnum(string value)
        {
            return value switch
            {
                "all" => DetectUuidGetResponsesContentApplicationJsonSchemaItemModality.All,
                "audio" => DetectUuidGetResponsesContentApplicationJsonSchemaItemModality.Audio,
                "video" => DetectUuidGetResponsesContentApplicationJsonSchemaItemModality.Video,
                _ => null,
            };
        }
    }
}