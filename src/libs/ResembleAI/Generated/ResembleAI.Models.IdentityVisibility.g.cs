
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum IdentityVisibility
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
    public static class IdentityVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IdentityVisibility value)
        {
            return value switch
            {
                IdentityVisibility.Global => "global",
                IdentityVisibility.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IdentityVisibility? ToEnum(string value)
        {
            return value switch
            {
                "global" => IdentityVisibility.Global,
                "team" => IdentityVisibility.Team,
                _ => null,
            };
        }
    }
}