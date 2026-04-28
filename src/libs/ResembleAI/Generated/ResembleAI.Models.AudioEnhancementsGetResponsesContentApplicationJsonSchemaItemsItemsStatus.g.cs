
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum AudioEnhancementsGetResponsesContentApplicationJsonSchemaItemsItemsStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Pending,
        /// <summary>
        /// 
        /// </summary>
        Processing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AudioEnhancementsGetResponsesContentApplicationJsonSchemaItemsItemsStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AudioEnhancementsGetResponsesContentApplicationJsonSchemaItemsItemsStatus value)
        {
            return value switch
            {
                AudioEnhancementsGetResponsesContentApplicationJsonSchemaItemsItemsStatus.Completed => "completed",
                AudioEnhancementsGetResponsesContentApplicationJsonSchemaItemsItemsStatus.Failed => "failed",
                AudioEnhancementsGetResponsesContentApplicationJsonSchemaItemsItemsStatus.Pending => "pending",
                AudioEnhancementsGetResponsesContentApplicationJsonSchemaItemsItemsStatus.Processing => "processing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AudioEnhancementsGetResponsesContentApplicationJsonSchemaItemsItemsStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => AudioEnhancementsGetResponsesContentApplicationJsonSchemaItemsItemsStatus.Completed,
                "failed" => AudioEnhancementsGetResponsesContentApplicationJsonSchemaItemsItemsStatus.Failed,
                "pending" => AudioEnhancementsGetResponsesContentApplicationJsonSchemaItemsItemsStatus.Pending,
                "processing" => AudioEnhancementsGetResponsesContentApplicationJsonSchemaItemsItemsStatus.Processing,
                _ => null,
            };
        }
    }
}