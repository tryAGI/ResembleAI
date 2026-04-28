
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum PhoneNumbersPostRequestBodyContentApplicationJsonSchemaProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Twilio,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PhoneNumbersPostRequestBodyContentApplicationJsonSchemaProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PhoneNumbersPostRequestBodyContentApplicationJsonSchemaProvider value)
        {
            return value switch
            {
                PhoneNumbersPostRequestBodyContentApplicationJsonSchemaProvider.Twilio => "twilio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PhoneNumbersPostRequestBodyContentApplicationJsonSchemaProvider? ToEnum(string value)
        {
            return value switch
            {
                "twilio" => PhoneNumbersPostRequestBodyContentApplicationJsonSchemaProvider.Twilio,
                _ => null,
            };
        }
    }
}