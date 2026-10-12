
#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// `processing` until inference returns, `completed` once `metrics` is populated, or `failed` if the analysis errored. Failed analyses are not billed.
    /// </summary>
    public enum MusicDetectItemStatus
    {
        /// <summary>
        ///
        /// </summary>
        Completed,
        /// <summary>
        ///
        /// </summary>
        Failed,
        /// <summary>
        ///
        /// </summary>
        Processing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MusicDetectItemStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MusicDetectItemStatus value)
        {
            return value switch
            {
                MusicDetectItemStatus.Completed => "completed",
                MusicDetectItemStatus.Failed => "failed",
                MusicDetectItemStatus.Processing => "processing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MusicDetectItemStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => MusicDetectItemStatus.Completed,
                "failed" => MusicDetectItemStatus.Failed,
                "processing" => MusicDetectItemStatus.Processing,
                _ => null,
            };
        }
    }
}