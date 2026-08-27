
#nullable enable

namespace ResembleAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DetectAgentRun
    {
        /// <summary>
        /// Investigation run identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uuid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Uuid { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ResembleAI.JsonConverters.DetectAgentRunSummaryStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ResembleAI.DetectAgentRunSummaryStatus Status { get; set; }

        /// <summary>
        /// Compact result summary derived from the investigation transcript.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ResembleAI.DetectAgentRunResult Result { get; set; }

        /// <summary>
        /// Submitted investigation inputs. Null-valued fields are omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ResembleAI.DetectAgentRunSummaryInputs Inputs { get; set; }

        /// <summary>
        /// Whether primary uploaded media is attached to this run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_media")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasMedia { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Public investigation events. Internal cost events are omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcript")]
        public global::System.Collections.Generic.IList<object>? Transcript { get; set; }

        /// <summary>
        /// Exact managed configuration used for the investigation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config_snapshot")]
        public object? ConfigSnapshot { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memory_before")]
        public string? MemoryBefore { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memory_after")]
        public string? MemoryAfter { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Relative URL for uploaded primary media, or null when the run used a public URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media_url")]
        public string? MediaUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DetectAgentRun" /> class.
        /// </summary>
        /// <param name="uuid">
        /// Investigation run identifier.
        /// </param>
        /// <param name="status"></param>
        /// <param name="result">
        /// Compact result summary derived from the investigation transcript.
        /// </param>
        /// <param name="inputs">
        /// Submitted investigation inputs. Null-valued fields are omitted.
        /// </param>
        /// <param name="hasMedia">
        /// Whether primary uploaded media is attached to this run.
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="transcript">
        /// Public investigation events. Internal cost events are omitted.
        /// </param>
        /// <param name="configSnapshot">
        /// Exact managed configuration used for the investigation.
        /// </param>
        /// <param name="memoryBefore"></param>
        /// <param name="memoryAfter"></param>
        /// <param name="error"></param>
        /// <param name="mediaUrl">
        /// Relative URL for uploaded primary media, or null when the run used a public URL.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DetectAgentRun(
            global::System.Guid uuid,
            global::ResembleAI.DetectAgentRunSummaryStatus status,
            global::ResembleAI.DetectAgentRunResult result,
            global::ResembleAI.DetectAgentRunSummaryInputs inputs,
            bool hasMedia,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            global::System.Collections.Generic.IList<object>? transcript,
            object? configSnapshot,
            string? memoryBefore,
            string? memoryAfter,
            string? error,
            string? mediaUrl)
        {
            this.Uuid = uuid;
            this.Status = status;
            this.Result = result ?? throw new global::System.ArgumentNullException(nameof(result));
            this.Inputs = inputs ?? throw new global::System.ArgumentNullException(nameof(inputs));
            this.HasMedia = hasMedia;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Transcript = transcript;
            this.ConfigSnapshot = configSnapshot;
            this.MemoryBefore = memoryBefore;
            this.MemoryAfter = memoryAfter;
            this.Error = error;
            this.MediaUrl = mediaUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DetectAgentRun" /> class.
        /// </summary>
        public DetectAgentRun()
        {
        }

    }
}