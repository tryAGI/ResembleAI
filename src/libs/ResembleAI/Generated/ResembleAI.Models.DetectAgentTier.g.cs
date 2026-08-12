
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// Managed investigation depth. Informational and read-only.
    /// </summary>
    public enum DetectAgentTier
    {
        /// <summary>
        /// 
        /// </summary>
        Forensic,
        /// <summary>
        /// 
        /// </summary>
        Investigation,
        /// <summary>
        /// 
        /// </summary>
        Triage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DetectAgentTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DetectAgentTier value)
        {
            return value switch
            {
                DetectAgentTier.Forensic => "forensic",
                DetectAgentTier.Investigation => "investigation",
                DetectAgentTier.Triage => "triage",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DetectAgentTier? ToEnum(string value)
        {
            return value switch
            {
                "forensic" => DetectAgentTier.Forensic,
                "investigation" => DetectAgentTier.Investigation,
                "triage" => DetectAgentTier.Triage,
                _ => null,
            };
        }
    }
}