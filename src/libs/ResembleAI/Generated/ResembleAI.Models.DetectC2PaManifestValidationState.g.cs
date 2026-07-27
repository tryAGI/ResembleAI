
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// Verification state. `NotPresent` means no embedded Content Credentials were found; `Unavailable` means verification could not complete.
    /// </summary>
    public enum DetectC2PaManifestValidationState
    {
        /// <summary>
        /// 
        /// </summary>
        NotPresent,
        /// <summary>
        /// 
        /// </summary>
        Unavailable,
        /// <summary>
        /// 
        /// </summary>
        Valid,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DetectC2PaManifestValidationStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DetectC2PaManifestValidationState value)
        {
            return value switch
            {
                DetectC2PaManifestValidationState.NotPresent => "NotPresent",
                DetectC2PaManifestValidationState.Unavailable => "Unavailable",
                DetectC2PaManifestValidationState.Valid => "Valid",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DetectC2PaManifestValidationState? ToEnum(string value)
        {
            return value switch
            {
                "NotPresent" => DetectC2PaManifestValidationState.NotPresent,
                "Unavailable" => DetectC2PaManifestValidationState.Unavailable,
                "Valid" => DetectC2PaManifestValidationState.Valid,
                _ => null,
            };
        }
    }
}