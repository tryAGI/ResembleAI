
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum IdentitySummaryVisibility
    {
        /// <summary>
        /// 
        /// </summary>
        Global,
        /// <summary>
        /// 
        /// </summary>
        Team,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IdentitySummaryVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IdentitySummaryVisibility value)
        {
            return value switch
            {
                IdentitySummaryVisibility.Global => "global",
                IdentitySummaryVisibility.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IdentitySummaryVisibility? ToEnum(string value)
        {
            return value switch
            {
                "global" => IdentitySummaryVisibility.Global,
                "team" => IdentitySummaryVisibility.Team,
                _ => null,
            };
        }
    }
}