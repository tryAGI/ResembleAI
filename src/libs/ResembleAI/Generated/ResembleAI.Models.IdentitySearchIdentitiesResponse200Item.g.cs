
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// Matches keyed by identity UUID. distance is a 0-100 match score (higher is closer; an identical sample scores 100). Image matches include score_type "cosine".
    /// </summary>
    public sealed partial class IdentitySearchIdentitiesResponse200Item
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}