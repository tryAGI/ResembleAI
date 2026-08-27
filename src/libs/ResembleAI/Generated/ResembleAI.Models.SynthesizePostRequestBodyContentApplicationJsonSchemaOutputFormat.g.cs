
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// Audio output format<br/>
    /// Default Value: wav
    /// </summary>
    public enum SynthesizePostRequestBodyContentApplicationJsonSchemaOutputFormat
    {
        /// <summary>
        ///
        /// </summary>
        Mp3,
        /// <summary>
        ///
        /// </summary>
        Wav,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SynthesizePostRequestBodyContentApplicationJsonSchemaOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SynthesizePostRequestBodyContentApplicationJsonSchemaOutputFormat value)
        {
            return value switch
            {
                SynthesizePostRequestBodyContentApplicationJsonSchemaOutputFormat.Mp3 => "mp3",
                SynthesizePostRequestBodyContentApplicationJsonSchemaOutputFormat.Wav => "wav",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SynthesizePostRequestBodyContentApplicationJsonSchemaOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "mp3" => SynthesizePostRequestBodyContentApplicationJsonSchemaOutputFormat.Mp3,
                "wav" => SynthesizePostRequestBodyContentApplicationJsonSchemaOutputFormat.Wav,
                _ => null,
            };
        }
    }
}