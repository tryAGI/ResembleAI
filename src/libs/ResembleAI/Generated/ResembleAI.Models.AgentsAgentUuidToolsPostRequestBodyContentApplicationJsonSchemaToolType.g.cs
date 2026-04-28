
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentsAgentUuidToolsPostRequestBodyContentApplicationJsonSchemaToolType
    {
        /// <summary>
        /// 
        /// </summary>
        Client,
        /// <summary>
        /// 
        /// </summary>
        Webhook,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentsAgentUuidToolsPostRequestBodyContentApplicationJsonSchemaToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentsAgentUuidToolsPostRequestBodyContentApplicationJsonSchemaToolType value)
        {
            return value switch
            {
                AgentsAgentUuidToolsPostRequestBodyContentApplicationJsonSchemaToolType.Client => "client",
                AgentsAgentUuidToolsPostRequestBodyContentApplicationJsonSchemaToolType.Webhook => "webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentsAgentUuidToolsPostRequestBodyContentApplicationJsonSchemaToolType? ToEnum(string value)
        {
            return value switch
            {
                "client" => AgentsAgentUuidToolsPostRequestBodyContentApplicationJsonSchemaToolType.Client,
                "webhook" => AgentsAgentUuidToolsPostRequestBodyContentApplicationJsonSchemaToolType.Webhook,
                _ => null,
            };
        }
    }
}