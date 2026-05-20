
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// Aggregate state for a batch detection job. Returned by `POST /detect/batch` and `GET /detect/batch/{uuid}`.
    /// </summary>
    public sealed partial class DetectBatch
    {
        /// <summary>
        /// Batch UUID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uuid")]
        public string? Uuid { get; set; }

        /// <summary>
        /// Aggregate status across all child detects.<br/>
        ///   - `processing` — at least one child detect is still running.<br/>
        ///   - `completed` — every child detect completed successfully.<br/>
        ///   - `partially_failed` — at least one succeeded and at least one failed.<br/>
        ///   - `failed` — every child detect failed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ResembleAI.JsonConverters.DetectBatchStatusJsonConverter))]
        public global::ResembleAI.DetectBatchStatus? Status { get; set; }

        /// <summary>
        /// Number of files in the batch (1–50).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_files")]
        public int? TotalFiles { get; set; }

        /// <summary>
        /// Number of child detects that have completed successfully.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_count")]
        public int? CompletedCount { get; set; }

        /// <summary>
        /// Number of child detects that have failed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed_count")]
        public int? FailedCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// UUIDs of the child detects. Use `GET /detect/{uuid}` to retrieve per-file results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detect_uuids")]
        public global::System.Collections.Generic.IList<string>? DetectUuids { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DetectBatch" /> class.
        /// </summary>
        /// <param name="uuid">
        /// Batch UUID.
        /// </param>
        /// <param name="status">
        /// Aggregate status across all child detects.<br/>
        ///   - `processing` — at least one child detect is still running.<br/>
        ///   - `completed` — every child detect completed successfully.<br/>
        ///   - `partially_failed` — at least one succeeded and at least one failed.<br/>
        ///   - `failed` — every child detect failed.
        /// </param>
        /// <param name="totalFiles">
        /// Number of files in the batch (1–50).
        /// </param>
        /// <param name="completedCount">
        /// Number of child detects that have completed successfully.
        /// </param>
        /// <param name="failedCount">
        /// Number of child detects that have failed.
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="detectUuids">
        /// UUIDs of the child detects. Use `GET /detect/{uuid}` to retrieve per-file results.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DetectBatch(
            string? uuid,
            global::ResembleAI.DetectBatchStatus? status,
            int? totalFiles,
            int? completedCount,
            int? failedCount,
            global::System.DateTime? createdAt,
            global::System.Collections.Generic.IList<string>? detectUuids)
        {
            this.Uuid = uuid;
            this.Status = status;
            this.TotalFiles = totalFiles;
            this.CompletedCount = completedCount;
            this.FailedCount = failedCount;
            this.CreatedAt = createdAt;
            this.DetectUuids = detectUuids;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DetectBatch" /> class.
        /// </summary>
        public DetectBatch()
        {
        }

    }
}