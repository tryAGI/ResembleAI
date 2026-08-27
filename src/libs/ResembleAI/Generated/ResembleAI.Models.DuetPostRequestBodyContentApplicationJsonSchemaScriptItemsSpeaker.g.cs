
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// Speaker index (0 or 1)
    /// </summary>
    public enum DuetPostRequestBodyContentApplicationJsonSchemaScriptItemsSpeaker
    {
        /// <summary>
        ///
        /// </summary>
        x0,
        /// <summary>
        ///
        /// </summary>
        x1,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DuetPostRequestBodyContentApplicationJsonSchemaScriptItemsSpeakerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DuetPostRequestBodyContentApplicationJsonSchemaScriptItemsSpeaker value)
        {
            return value switch
            {
                DuetPostRequestBodyContentApplicationJsonSchemaScriptItemsSpeaker.x0 => "0",
                DuetPostRequestBodyContentApplicationJsonSchemaScriptItemsSpeaker.x1 => "1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DuetPostRequestBodyContentApplicationJsonSchemaScriptItemsSpeaker? ToEnum(string value)
        {
            return value switch
            {
                "0" => DuetPostRequestBodyContentApplicationJsonSchemaScriptItemsSpeaker.x0,
                "1" => DuetPostRequestBodyContentApplicationJsonSchemaScriptItemsSpeaker.x1,
                _ => null,
            };
        }
    }
}