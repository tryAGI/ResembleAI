
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AccountTeamsGetResponsesContentApplicationJsonSchemaItemsItems
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uuid")]
        public string? Uuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plan")]
        public string? Plan { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_limit")]
        public int? VoiceLimit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("units")]
        public string? Units { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rate")]
        public double? Rate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("current_usage")]
        public int? CurrentUsage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountTeamsGetResponsesContentApplicationJsonSchemaItemsItems" /> class.
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="name"></param>
        /// <param name="plan"></param>
        /// <param name="voiceLimit"></param>
        /// <param name="units"></param>
        /// <param name="rate"></param>
        /// <param name="currentUsage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AccountTeamsGetResponsesContentApplicationJsonSchemaItemsItems(
            string? uuid,
            string? name,
            string? plan,
            int? voiceLimit,
            string? units,
            double? rate,
            int? currentUsage)
        {
            this.Uuid = uuid;
            this.Name = name;
            this.Plan = plan;
            this.VoiceLimit = voiceLimit;
            this.Units = units;
            this.Rate = rate;
            this.CurrentUsage = currentUsage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountTeamsGetResponsesContentApplicationJsonSchemaItemsItems" /> class.
        /// </summary>
        public AccountTeamsGetResponsesContentApplicationJsonSchemaItemsItems()
        {
        }

    }
}