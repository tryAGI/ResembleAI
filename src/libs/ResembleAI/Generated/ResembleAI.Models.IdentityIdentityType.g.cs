
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum IdentityIdentityType
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
    public static class IdentityIdentityTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IdentityIdentityType value)
        {
            return value switch
            {
                IdentityIdentityType.Brand => "brand",
                IdentityIdentityType.Person => "person",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IdentityIdentityType? ToEnum(string value)
        {
            return value switch
            {
                "brand" => IdentityIdentityType.Brand,
                "person" => IdentityIdentityType.Person,
                _ => null,
            };
        }
    }
}