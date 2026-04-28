
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// Default Value: professional
    /// </summary>
    public enum VoicesPostRequestBodyContentApplicationJsonSchemaVoiceType
    {
        /// <summary>
        /// 
        /// </summary>
        Professional,
        /// <summary>
        /// 
        /// </summary>
        Rapid,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VoicesPostRequestBodyContentApplicationJsonSchemaVoiceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VoicesPostRequestBodyContentApplicationJsonSchemaVoiceType value)
        {
            return value switch
            {
                VoicesPostRequestBodyContentApplicationJsonSchemaVoiceType.Professional => "professional",
                VoicesPostRequestBodyContentApplicationJsonSchemaVoiceType.Rapid => "rapid",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VoicesPostRequestBodyContentApplicationJsonSchemaVoiceType? ToEnum(string value)
        {
            return value switch
            {
                "professional" => VoicesPostRequestBodyContentApplicationJsonSchemaVoiceType.Professional,
                "rapid" => VoicesPostRequestBodyContentApplicationJsonSchemaVoiceType.Rapid,
                _ => null,
            };
        }
    }
}