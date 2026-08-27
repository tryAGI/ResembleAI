
#nullable enable

namespace ResembleAI
{
    /// <summary>
    ///
    /// </summary>
    public enum IdentityUuidAttachmentsPostRequestBodyContentMultipartFormDataSchemaModality
    {
        /// <summary>
        ///
        /// </summary>
        Face,
        /// <summary>
        ///
        /// </summary>
        Video,
        /// <summary>
        ///
        /// </summary>
        Voice,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IdentityUuidAttachmentsPostRequestBodyContentMultipartFormDataSchemaModalityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IdentityUuidAttachmentsPostRequestBodyContentMultipartFormDataSchemaModality value)
        {
            return value switch
            {
                IdentityUuidAttachmentsPostRequestBodyContentMultipartFormDataSchemaModality.Face => "face",
                IdentityUuidAttachmentsPostRequestBodyContentMultipartFormDataSchemaModality.Video => "video",
                IdentityUuidAttachmentsPostRequestBodyContentMultipartFormDataSchemaModality.Voice => "voice",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IdentityUuidAttachmentsPostRequestBodyContentMultipartFormDataSchemaModality? ToEnum(string value)
        {
            return value switch
            {
                "face" => IdentityUuidAttachmentsPostRequestBodyContentMultipartFormDataSchemaModality.Face,
                "video" => IdentityUuidAttachmentsPostRequestBodyContentMultipartFormDataSchemaModality.Video,
                "voice" => IdentityUuidAttachmentsPostRequestBodyContentMultipartFormDataSchemaModality.Voice,
                _ => null,
            };
        }
    }
}