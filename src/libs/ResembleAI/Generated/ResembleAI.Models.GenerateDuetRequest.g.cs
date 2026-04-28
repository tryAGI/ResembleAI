
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerateDuetRequest
    {
        /// <summary>
        /// Voice pair ID to use
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_pair_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int VoicePairId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("script")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ResembleAI.DuetPostRequestBodyContentApplicationJsonSchemaScriptItems> Script { get; set; }

        /// <summary>
        /// Optional title for the duet
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Webhook URL for completion notification
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callback_uri")]
        public string? CallbackUri { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateDuetRequest" /> class.
        /// </summary>
        /// <param name="voicePairId">
        /// Voice pair ID to use
        /// </param>
        /// <param name="script"></param>
        /// <param name="title">
        /// Optional title for the duet
        /// </param>
        /// <param name="callbackUri">
        /// Webhook URL for completion notification
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateDuetRequest(
            int voicePairId,
            global::System.Collections.Generic.IList<global::ResembleAI.DuetPostRequestBodyContentApplicationJsonSchemaScriptItems> script,
            string? title,
            string? callbackUri)
        {
            this.VoicePairId = voicePairId;
            this.Script = script ?? throw new global::System.ArgumentNullException(nameof(script));
            this.Title = title;
            this.CallbackUri = callbackUri;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateDuetRequest" /> class.
        /// </summary>
        public GenerateDuetRequest()
        {
        }
    }
}