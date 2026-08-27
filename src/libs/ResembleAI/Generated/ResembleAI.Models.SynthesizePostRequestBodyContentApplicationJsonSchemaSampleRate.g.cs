
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// Audio sample rate in Hz
    /// </summary>
    public enum SynthesizePostRequestBodyContentApplicationJsonSchemaSampleRate
    {
        /// <summary>
        ///
        /// </summary>
        x16000,
        /// <summary>
        ///
        /// </summary>
        x22050,
        /// <summary>
        ///
        /// </summary>
        x32000,
        /// <summary>
        ///
        /// </summary>
        x44100,
        /// <summary>
        ///
        /// </summary>
        x48000,
        /// <summary>
        ///
        /// </summary>
        x8000,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SynthesizePostRequestBodyContentApplicationJsonSchemaSampleRateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SynthesizePostRequestBodyContentApplicationJsonSchemaSampleRate value)
        {
            return value switch
            {
                SynthesizePostRequestBodyContentApplicationJsonSchemaSampleRate.x16000 => "16000",
                SynthesizePostRequestBodyContentApplicationJsonSchemaSampleRate.x22050 => "22050",
                SynthesizePostRequestBodyContentApplicationJsonSchemaSampleRate.x32000 => "32000",
                SynthesizePostRequestBodyContentApplicationJsonSchemaSampleRate.x44100 => "44100",
                SynthesizePostRequestBodyContentApplicationJsonSchemaSampleRate.x48000 => "48000",
                SynthesizePostRequestBodyContentApplicationJsonSchemaSampleRate.x8000 => "8000",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SynthesizePostRequestBodyContentApplicationJsonSchemaSampleRate? ToEnum(string value)
        {
            return value switch
            {
                "16000" => SynthesizePostRequestBodyContentApplicationJsonSchemaSampleRate.x16000,
                "22050" => SynthesizePostRequestBodyContentApplicationJsonSchemaSampleRate.x22050,
                "32000" => SynthesizePostRequestBodyContentApplicationJsonSchemaSampleRate.x32000,
                "44100" => SynthesizePostRequestBodyContentApplicationJsonSchemaSampleRate.x44100,
                "48000" => SynthesizePostRequestBodyContentApplicationJsonSchemaSampleRate.x48000,
                "8000" => SynthesizePostRequestBodyContentApplicationJsonSchemaSampleRate.x8000,
                _ => null,
            };
        }
    }
}