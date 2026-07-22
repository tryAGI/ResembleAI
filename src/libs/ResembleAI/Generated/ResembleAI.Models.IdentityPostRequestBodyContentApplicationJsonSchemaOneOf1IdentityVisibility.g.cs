
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// Default Value: team
    /// </summary>
    public enum IdentityPostRequestBodyContentApplicationJsonSchemaOneOf1IdentityVisibility
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
    public static class IdentityPostRequestBodyContentApplicationJsonSchemaOneOf1IdentityVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IdentityPostRequestBodyContentApplicationJsonSchemaOneOf1IdentityVisibility value)
        {
            return value switch
            {
                IdentityPostRequestBodyContentApplicationJsonSchemaOneOf1IdentityVisibility.Global => "global",
                IdentityPostRequestBodyContentApplicationJsonSchemaOneOf1IdentityVisibility.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IdentityPostRequestBodyContentApplicationJsonSchemaOneOf1IdentityVisibility? ToEnum(string value)
        {
            return value switch
            {
                "global" => IdentityPostRequestBodyContentApplicationJsonSchemaOneOf1IdentityVisibility.Global,
                "team" => IdentityPostRequestBodyContentApplicationJsonSchemaOneOf1IdentityVisibility.Team,
                _ => null,
            };
        }
    }
}