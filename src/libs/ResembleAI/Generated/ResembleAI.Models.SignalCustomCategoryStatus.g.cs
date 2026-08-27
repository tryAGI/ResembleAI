
#nullable enable

namespace ResembleAI
{
    /// <summary>
    ///
    /// </summary>
    public enum SignalCustomCategoryStatus
    {
        /// <summary>
        ///
        /// </summary>
        Embedding,
        /// <summary>
        ///
        /// </summary>
        Failed,
        /// <summary>
        ///
        /// </summary>
        NeedsMoreExamples,
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
    public static class SignalCustomCategoryStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SignalCustomCategoryStatus value)
        {
            return value switch
            {
                SignalCustomCategoryStatus.Embedding => "embedding",
                SignalCustomCategoryStatus.Failed => "failed",
                SignalCustomCategoryStatus.NeedsMoreExamples => "needs_more_examples",
                SignalCustomCategoryStatus.Pending => "pending",
                SignalCustomCategoryStatus.Ready => "ready",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SignalCustomCategoryStatus? ToEnum(string value)
        {
            return value switch
            {
                "embedding" => SignalCustomCategoryStatus.Embedding,
                "failed" => SignalCustomCategoryStatus.Failed,
                "needs_more_examples" => SignalCustomCategoryStatus.NeedsMoreExamples,
                "pending" => SignalCustomCategoryStatus.Pending,
                "ready" => SignalCustomCategoryStatus.Ready,
                _ => null,
            };
        }
    }
}