
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentsPostRequestBodyContentApplicationJsonSchemaTurn
    {
        /// <summary>
        /// Default Value: 7
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turn_timeout")]
        public int? TurnTimeout { get; set; }

        /// <summary>
        /// Default Value: -1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("silence_end_call_timeout")]
        public int? SilenceEndCallTimeout { get; set; }

        /// <summary>
        /// Default Value: silence
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ResembleAI.JsonConverters.AgentsPostRequestBodyContentApplicationJsonSchemaTurnModeJsonConverter))]
        public global::ResembleAI.AgentsPostRequestBodyContentApplicationJsonSchemaTurnMode? Mode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentsPostRequestBodyContentApplicationJsonSchemaTurn" /> class.
        /// </summary>
        /// <param name="turnTimeout">
        /// Default Value: 7
        /// </param>
        /// <param name="silenceEndCallTimeout">
        /// Default Value: -1
        /// </param>
        /// <param name="mode">
        /// Default Value: silence
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentsPostRequestBodyContentApplicationJsonSchemaTurn(
            int? turnTimeout,
            int? silenceEndCallTimeout,
            global::ResembleAI.AgentsPostRequestBodyContentApplicationJsonSchemaTurnMode? mode)
        {
            this.TurnTimeout = turnTimeout;
            this.SilenceEndCallTimeout = silenceEndCallTimeout;
            this.Mode = mode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentsPostRequestBodyContentApplicationJsonSchemaTurn" /> class.
        /// </summary>
        public AgentsPostRequestBodyContentApplicationJsonSchemaTurn()
        {
        }

    }
}