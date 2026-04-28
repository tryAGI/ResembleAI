
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum AudioEnhancementsGetResponsesContentApplicationJsonSchemaItemsItemsEnhancementEngine
    {
        /// <summary>
        /// 
        /// </summary>
        V1,
        /// <summary>
        /// 
        /// </summary>
        V2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AudioEnhancementsGetResponsesContentApplicationJsonSchemaItemsItemsEnhancementEngineExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AudioEnhancementsGetResponsesContentApplicationJsonSchemaItemsItemsEnhancementEngine value)
        {
            return value switch
            {
                AudioEnhancementsGetResponsesContentApplicationJsonSchemaItemsItemsEnhancementEngine.V1 => "v1",
                AudioEnhancementsGetResponsesContentApplicationJsonSchemaItemsItemsEnhancementEngine.V2 => "v2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AudioEnhancementsGetResponsesContentApplicationJsonSchemaItemsItemsEnhancementEngine? ToEnum(string value)
        {
            return value switch
            {
                "v1" => AudioEnhancementsGetResponsesContentApplicationJsonSchemaItemsItemsEnhancementEngine.V1,
                "v2" => AudioEnhancementsGetResponsesContentApplicationJsonSchemaItemsItemsEnhancementEngine.V2,
                _ => null,
            };
        }
    }
}