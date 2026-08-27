
#nullable enable

namespace ResembleAI
{
    /// <summary>
    ///
    /// </summary>
    public enum PronunciationsGetParametersStatus
    {
        /// <summary>
        ///
        /// </summary>
        Failed,
        /// <summary>
        ///
        /// </summary>
        Pending,
        /// <summary>
        ///
        /// </summary>
        Ready,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PronunciationsGetParametersStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PronunciationsGetParametersStatus value)
        {
            return value switch
            {
                PronunciationsGetParametersStatus.Failed => "failed",
                PronunciationsGetParametersStatus.Pending => "pending",
                PronunciationsGetParametersStatus.Ready => "ready",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PronunciationsGetParametersStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => PronunciationsGetParametersStatus.Failed,
                "pending" => PronunciationsGetParametersStatus.Pending,
                "ready" => PronunciationsGetParametersStatus.Ready,
                _ => null,
            };
        }
    }
}