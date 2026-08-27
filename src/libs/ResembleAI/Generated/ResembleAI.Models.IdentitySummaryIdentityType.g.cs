
#nullable enable

namespace ResembleAI
{
    /// <summary>
    ///
    /// </summary>
    public enum IdentitySummaryIdentityType
    {
        /// <summary>
        ///
        /// </summary>
        Brand,
        /// <summary>
        ///
        /// </summary>
        Person,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IdentitySummaryIdentityTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IdentitySummaryIdentityType value)
        {
            return value switch
            {
                IdentitySummaryIdentityType.Brand => "brand",
                IdentitySummaryIdentityType.Person => "person",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IdentitySummaryIdentityType? ToEnum(string value)
        {
            return value switch
            {
                "brand" => IdentitySummaryIdentityType.Brand,
                "person" => IdentitySummaryIdentityType.Person,
                _ => null,
            };
        }
    }
}