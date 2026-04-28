
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// RAG search strategy
    /// </summary>
    public enum AgentsUuidPatchRequestBodyContentApplicationJsonSchemaSearchMode
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
    public static class AgentsUuidPatchRequestBodyContentApplicationJsonSchemaSearchModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentsUuidPatchRequestBodyContentApplicationJsonSchemaSearchMode value)
        {
            return value switch
            {
                AgentsUuidPatchRequestBodyContentApplicationJsonSchemaSearchMode.Accuracy => "accuracy",
                AgentsUuidPatchRequestBodyContentApplicationJsonSchemaSearchMode.Speed => "speed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentsUuidPatchRequestBodyContentApplicationJsonSchemaSearchMode? ToEnum(string value)
        {
            return value switch
            {
                "accuracy" => AgentsUuidPatchRequestBodyContentApplicationJsonSchemaSearchMode.Accuracy,
                "speed" => AgentsUuidPatchRequestBodyContentApplicationJsonSchemaSearchMode.Speed,
                _ => null,
            };
        }
    }
}