
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentsPostRequestBodyContentApplicationJsonSchemaAsr
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Default Value: deepgram
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        public string? Provider { get; set; }

        /// <summary>
        /// Default Value: pcm_16000
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_input_audio_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ResembleAI.JsonConverters.AgentsPostRequestBodyContentApplicationJsonSchemaAsrUserInputAudioFormatJsonConverter))]
        public global::ResembleAI.AgentsPostRequestBodyContentApplicationJsonSchemaAsrUserInputAudioFormat? UserInputAudioFormat { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keywords")]
        public global::System.Collections.Generic.IList<string>? Keywords { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentsPostRequestBodyContentApplicationJsonSchemaAsr" /> class.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="provider">
        /// Default Value: deepgram
        /// </param>
        /// <param name="userInputAudioFormat">
        /// Default Value: pcm_16000
        /// </param>
        /// <param name="keywords"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentsPostRequestBodyContentApplicationJsonSchemaAsr(
            string? model,
            string? provider,
            global::ResembleAI.AgentsPostRequestBodyContentApplicationJsonSchemaAsrUserInputAudioFormat? userInputAudioFormat,
            global::System.Collections.Generic.IList<string>? keywords)
        {
            this.Model = model;
            this.Provider = provider;
            this.UserInputAudioFormat = userInputAudioFormat;
            this.Keywords = keywords;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentsPostRequestBodyContentApplicationJsonSchemaAsr" /> class.
        /// </summary>
        public AgentsPostRequestBodyContentApplicationJsonSchemaAsr()
        {
        }

    }
}