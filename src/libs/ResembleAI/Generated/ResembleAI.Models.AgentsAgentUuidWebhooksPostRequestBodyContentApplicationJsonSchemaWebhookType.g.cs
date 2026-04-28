
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentsAgentUuidWebhooksPostRequestBodyContentApplicationJsonSchemaWebhookType
    {
        /// <summary>
        /// 
        /// </summary>
        PostCall,
        /// <summary>
        /// 
        /// </summary>
        PreCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentsAgentUuidWebhooksPostRequestBodyContentApplicationJsonSchemaWebhookTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentsAgentUuidWebhooksPostRequestBodyContentApplicationJsonSchemaWebhookType value)
        {
            return value switch
            {
                AgentsAgentUuidWebhooksPostRequestBodyContentApplicationJsonSchemaWebhookType.PostCall => "post_call",
                AgentsAgentUuidWebhooksPostRequestBodyContentApplicationJsonSchemaWebhookType.PreCall => "pre_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentsAgentUuidWebhooksPostRequestBodyContentApplicationJsonSchemaWebhookType? ToEnum(string value)
        {
            return value switch
            {
                "post_call" => AgentsAgentUuidWebhooksPostRequestBodyContentApplicationJsonSchemaWebhookType.PostCall,
                "pre_call" => AgentsAgentUuidWebhooksPostRequestBodyContentApplicationJsonSchemaWebhookType.PreCall,
                _ => null,
            };
        }
    }
}