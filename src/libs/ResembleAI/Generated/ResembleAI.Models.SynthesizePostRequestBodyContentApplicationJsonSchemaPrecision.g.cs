
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// Audio precision for WAV output<br/>
    /// Default Value: PCM_32
    /// </summary>
    public enum SynthesizePostRequestBodyContentApplicationJsonSchemaPrecision
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
    public static class SynthesizePostRequestBodyContentApplicationJsonSchemaPrecisionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SynthesizePostRequestBodyContentApplicationJsonSchemaPrecision value)
        {
            return value switch
            {
                SynthesizePostRequestBodyContentApplicationJsonSchemaPrecision.Mulaw => "MULAW",
                SynthesizePostRequestBodyContentApplicationJsonSchemaPrecision.Pcm16 => "PCM_16",
                SynthesizePostRequestBodyContentApplicationJsonSchemaPrecision.Pcm24 => "PCM_24",
                SynthesizePostRequestBodyContentApplicationJsonSchemaPrecision.Pcm32 => "PCM_32",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SynthesizePostRequestBodyContentApplicationJsonSchemaPrecision? ToEnum(string value)
        {
            return value switch
            {
                "MULAW" => SynthesizePostRequestBodyContentApplicationJsonSchemaPrecision.Mulaw,
                "PCM_16" => SynthesizePostRequestBodyContentApplicationJsonSchemaPrecision.Pcm16,
                "PCM_24" => SynthesizePostRequestBodyContentApplicationJsonSchemaPrecision.Pcm24,
                "PCM_32" => SynthesizePostRequestBodyContentApplicationJsonSchemaPrecision.Pcm32,
                _ => null,
            };
        }
    }
}