
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// Inferred from the media's content type when omitted (defaults to audio)
    /// </summary>
    public enum IdentitySearchPostRequestBodyContentApplicationJsonSchemaModality
    {
        /// <summary>
        /// 
        /// </summary>
        Audio,
        /// <summary>
        /// 
        /// </summary>
        Image,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IdentitySearchPostRequestBodyContentApplicationJsonSchemaModalityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IdentitySearchPostRequestBodyContentApplicationJsonSchemaModality value)
        {
            return value switch
            {
                IdentitySearchPostRequestBodyContentApplicationJsonSchemaModality.Audio => "audio",
                IdentitySearchPostRequestBodyContentApplicationJsonSchemaModality.Image => "image",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IdentitySearchPostRequestBodyContentApplicationJsonSchemaModality? ToEnum(string value)
        {
            return value switch
            {
                "audio" => IdentitySearchPostRequestBodyContentApplicationJsonSchemaModality.Audio,
                "image" => IdentitySearchPostRequestBodyContentApplicationJsonSchemaModality.Image,
                _ => null,
            };
        }
    }
}