
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// Audio sample rate in Hz
    /// </summary>
    public enum StreamPostRequestBodyContentApplicationJsonSchemaSampleRate
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
    public static class StreamPostRequestBodyContentApplicationJsonSchemaSampleRateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StreamPostRequestBodyContentApplicationJsonSchemaSampleRate value)
        {
            return value switch
            {
                StreamPostRequestBodyContentApplicationJsonSchemaSampleRate.x16000 => "16000",
                StreamPostRequestBodyContentApplicationJsonSchemaSampleRate.x22050 => "22050",
                StreamPostRequestBodyContentApplicationJsonSchemaSampleRate.x32000 => "32000",
                StreamPostRequestBodyContentApplicationJsonSchemaSampleRate.x44100 => "44100",
                StreamPostRequestBodyContentApplicationJsonSchemaSampleRate.x48000 => "48000",
                StreamPostRequestBodyContentApplicationJsonSchemaSampleRate.x8000 => "8000",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StreamPostRequestBodyContentApplicationJsonSchemaSampleRate? ToEnum(string value)
        {
            return value switch
            {
                "16000" => StreamPostRequestBodyContentApplicationJsonSchemaSampleRate.x16000,
                "22050" => StreamPostRequestBodyContentApplicationJsonSchemaSampleRate.x22050,
                "32000" => StreamPostRequestBodyContentApplicationJsonSchemaSampleRate.x32000,
                "44100" => StreamPostRequestBodyContentApplicationJsonSchemaSampleRate.x44100,
                "48000" => StreamPostRequestBodyContentApplicationJsonSchemaSampleRate.x48000,
                "8000" => StreamPostRequestBodyContentApplicationJsonSchemaSampleRate.x8000,
                _ => null,
            };
        }
    }
}