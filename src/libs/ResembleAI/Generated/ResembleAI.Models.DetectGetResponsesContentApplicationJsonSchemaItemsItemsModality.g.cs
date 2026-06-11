
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// Which detection modality was requested. `all` when not specified (the default). Only meaningful for video detects.
    /// </summary>
    public enum DetectGetResponsesContentApplicationJsonSchemaItemsItemsModality
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
    public static class DetectGetResponsesContentApplicationJsonSchemaItemsItemsModalityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DetectGetResponsesContentApplicationJsonSchemaItemsItemsModality value)
        {
            return value switch
            {
                DetectGetResponsesContentApplicationJsonSchemaItemsItemsModality.All => "all",
                DetectGetResponsesContentApplicationJsonSchemaItemsItemsModality.Audio => "audio",
                DetectGetResponsesContentApplicationJsonSchemaItemsItemsModality.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DetectGetResponsesContentApplicationJsonSchemaItemsItemsModality? ToEnum(string value)
        {
            return value switch
            {
                "all" => DetectGetResponsesContentApplicationJsonSchemaItemsItemsModality.All,
                "audio" => DetectGetResponsesContentApplicationJsonSchemaItemsItemsModality.Audio,
                "video" => DetectGetResponsesContentApplicationJsonSchemaItemsItemsModality.Video,
                _ => null,
            };
        }
    }
}