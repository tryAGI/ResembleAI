
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// RAG search strategy - speed (faster) or accuracy (more thorough)<br/>
    /// Default Value: accuracy
    /// </summary>
    public enum AgentsPostRequestBodyContentApplicationJsonSchemaSearchMode
    {
        /// <summary>
        /// 
        /// </summary>
        Accuracy,
        /// <summary>
        /// 
        /// </summary>
        Speed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentsPostRequestBodyContentApplicationJsonSchemaSearchModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentsPostRequestBodyContentApplicationJsonSchemaSearchMode value)
        {
            return value switch
            {
                AgentsPostRequestBodyContentApplicationJsonSchemaSearchMode.Accuracy => "accuracy",
                AgentsPostRequestBodyContentApplicationJsonSchemaSearchMode.Speed => "speed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentsPostRequestBodyContentApplicationJsonSchemaSearchMode? ToEnum(string value)
        {
            return value switch
            {
                "accuracy" => AgentsPostRequestBodyContentApplicationJsonSchemaSearchMode.Accuracy,
                "speed" => AgentsPostRequestBodyContentApplicationJsonSchemaSearchMode.Speed,
                _ => null,
            };
        }
    }
}