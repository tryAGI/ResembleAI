
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// Default Value: silence
    /// </summary>
    public enum AgentsPostRequestBodyContentApplicationJsonSchemaTurnMode
    {
        /// <summary>
        /// 
        /// </summary>
        Silence,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentsPostRequestBodyContentApplicationJsonSchemaTurnModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentsPostRequestBodyContentApplicationJsonSchemaTurnMode value)
        {
            return value switch
            {
                AgentsPostRequestBodyContentApplicationJsonSchemaTurnMode.Silence => "silence",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentsPostRequestBodyContentApplicationJsonSchemaTurnMode? ToEnum(string value)
        {
            return value switch
            {
                "silence" => AgentsPostRequestBodyContentApplicationJsonSchemaTurnMode.Silence,
                _ => null,
            };
        }
    }
}