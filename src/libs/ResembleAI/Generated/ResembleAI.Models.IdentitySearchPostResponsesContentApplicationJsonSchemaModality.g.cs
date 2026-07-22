
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum IdentitySearchPostResponsesContentApplicationJsonSchemaModality
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
    public static class IdentitySearchPostResponsesContentApplicationJsonSchemaModalityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IdentitySearchPostResponsesContentApplicationJsonSchemaModality value)
        {
            return value switch
            {
                IdentitySearchPostResponsesContentApplicationJsonSchemaModality.Audio => "audio",
                IdentitySearchPostResponsesContentApplicationJsonSchemaModality.Image => "image",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IdentitySearchPostResponsesContentApplicationJsonSchemaModality? ToEnum(string value)
        {
            return value switch
            {
                "audio" => IdentitySearchPostResponsesContentApplicationJsonSchemaModality.Audio,
                "image" => IdentitySearchPostResponsesContentApplicationJsonSchemaModality.Image,
                _ => null,
            };
        }
    }
}