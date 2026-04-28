
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// Enhancement engine to use. Default is v2.<br/>
    /// Default Value: v2
    /// </summary>
    public enum AudioEnhancementsPostRequestBodyContentMultipartFormDataSchemaEnhancementEngine
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
    public static class AudioEnhancementsPostRequestBodyContentMultipartFormDataSchemaEnhancementEngineExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AudioEnhancementsPostRequestBodyContentMultipartFormDataSchemaEnhancementEngine value)
        {
            return value switch
            {
                AudioEnhancementsPostRequestBodyContentMultipartFormDataSchemaEnhancementEngine.V1 => "v1",
                AudioEnhancementsPostRequestBodyContentMultipartFormDataSchemaEnhancementEngine.V2 => "v2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AudioEnhancementsPostRequestBodyContentMultipartFormDataSchemaEnhancementEngine? ToEnum(string value)
        {
            return value switch
            {
                "v1" => AudioEnhancementsPostRequestBodyContentMultipartFormDataSchemaEnhancementEngine.V1,
                "v2" => AudioEnhancementsPostRequestBodyContentMultipartFormDataSchemaEnhancementEngine.V2,
                _ => null,
            };
        }
    }
}