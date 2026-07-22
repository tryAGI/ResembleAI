
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// Default Value: person
    /// </summary>
    public enum IdentityPostRequestBodyContentApplicationJsonSchemaOneOf1IdentityIdentityType
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
    public static class IdentityPostRequestBodyContentApplicationJsonSchemaOneOf1IdentityIdentityTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IdentityPostRequestBodyContentApplicationJsonSchemaOneOf1IdentityIdentityType value)
        {
            return value switch
            {
                IdentityPostRequestBodyContentApplicationJsonSchemaOneOf1IdentityIdentityType.Brand => "brand",
                IdentityPostRequestBodyContentApplicationJsonSchemaOneOf1IdentityIdentityType.Person => "person",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IdentityPostRequestBodyContentApplicationJsonSchemaOneOf1IdentityIdentityType? ToEnum(string value)
        {
            return value switch
            {
                "brand" => IdentityPostRequestBodyContentApplicationJsonSchemaOneOf1IdentityIdentityType.Brand,
                "person" => IdentityPostRequestBodyContentApplicationJsonSchemaOneOf1IdentityIdentityType.Person,
                _ => null,
            };
        }
    }
}