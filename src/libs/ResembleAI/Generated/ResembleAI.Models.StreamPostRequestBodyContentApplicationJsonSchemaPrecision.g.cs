
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// Audio precision<br/>
    /// Default Value: PCM_32
    /// </summary>
    public enum StreamPostRequestBodyContentApplicationJsonSchemaPrecision
    {
        /// <summary>
        /// 
        /// </summary>
        Mulaw,
        /// <summary>
        /// 
        /// </summary>
        Pcm16,
        /// <summary>
        /// 
        /// </summary>
        Pcm24,
        /// <summary>
        /// 
        /// </summary>
        Pcm32,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StreamPostRequestBodyContentApplicationJsonSchemaPrecisionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StreamPostRequestBodyContentApplicationJsonSchemaPrecision value)
        {
            return value switch
            {
                StreamPostRequestBodyContentApplicationJsonSchemaPrecision.Mulaw => "MULAW",
                StreamPostRequestBodyContentApplicationJsonSchemaPrecision.Pcm16 => "PCM_16",
                StreamPostRequestBodyContentApplicationJsonSchemaPrecision.Pcm24 => "PCM_24",
                StreamPostRequestBodyContentApplicationJsonSchemaPrecision.Pcm32 => "PCM_32",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StreamPostRequestBodyContentApplicationJsonSchemaPrecision? ToEnum(string value)
        {
            return value switch
            {
                "MULAW" => StreamPostRequestBodyContentApplicationJsonSchemaPrecision.Mulaw,
                "PCM_16" => StreamPostRequestBodyContentApplicationJsonSchemaPrecision.Pcm16,
                "PCM_24" => StreamPostRequestBodyContentApplicationJsonSchemaPrecision.Pcm24,
                "PCM_32" => StreamPostRequestBodyContentApplicationJsonSchemaPrecision.Pcm32,
                _ => null,
            };
        }
    }
}