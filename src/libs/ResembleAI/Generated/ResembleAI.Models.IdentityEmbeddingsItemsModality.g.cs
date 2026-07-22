
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum IdentityEmbeddingsItemsModality
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
    public static class IdentityEmbeddingsItemsModalityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IdentityEmbeddingsItemsModality value)
        {
            return value switch
            {
                IdentityEmbeddingsItemsModality.Face => "face",
                IdentityEmbeddingsItemsModality.Video => "video",
                IdentityEmbeddingsItemsModality.Voice => "voice",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IdentityEmbeddingsItemsModality? ToEnum(string value)
        {
            return value switch
            {
                "face" => IdentityEmbeddingsItemsModality.Face,
                "video" => IdentityEmbeddingsItemsModality.Video,
                "voice" => IdentityEmbeddingsItemsModality.Voice,
                _ => null,
            };
        }
    }
}