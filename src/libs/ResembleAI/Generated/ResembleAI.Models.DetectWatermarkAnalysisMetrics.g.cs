#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// Present when watermark analysis completes. Audio uses Perth v1/v2 metrics; image and video use the Resemble image/video detector metrics. `synthid`, when present, is the boolean verdict returned by SynthID. Its omission means the provider result was unavailable, not that no watermark was found.
    /// </summary>
    public readonly partial struct DetectWatermarkAnalysisMetrics : global::System.IEquatable<DetectWatermarkAnalysisMetrics>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ResembleAI.WatermarkAudioDetectionMetrics? WatermarkAudioDetectionMetrics { get; init; }
#else
        public global::ResembleAI.WatermarkAudioDetectionMetrics? WatermarkAudioDetectionMetrics { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WatermarkAudioDetectionMetrics))]
#endif
        public bool IsWatermarkAudioDetectionMetrics => WatermarkAudioDetectionMetrics != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWatermarkAudioDetectionMetrics(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ResembleAI.WatermarkAudioDetectionMetrics? value)
        {
            value = WatermarkAudioDetectionMetrics;
            return IsWatermarkAudioDetectionMetrics;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ResembleAI.WatermarkAudioDetectionMetrics PickWatermarkAudioDetectionMetrics() => IsWatermarkAudioDetectionMetrics
            ? WatermarkAudioDetectionMetrics!
            : throw new global::System.InvalidOperationException($"Expected union variant 'WatermarkAudioDetectionMetrics' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ResembleAI.WatermarkVisionDetectionMetrics? WatermarkVisionDetectionMetrics { get; init; }
#else
        public global::ResembleAI.WatermarkVisionDetectionMetrics? WatermarkVisionDetectionMetrics { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WatermarkVisionDetectionMetrics))]
#endif
        public bool IsWatermarkVisionDetectionMetrics => WatermarkVisionDetectionMetrics != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWatermarkVisionDetectionMetrics(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ResembleAI.WatermarkVisionDetectionMetrics? value)
        {
            value = WatermarkVisionDetectionMetrics;
            return IsWatermarkVisionDetectionMetrics;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ResembleAI.WatermarkVisionDetectionMetrics PickWatermarkVisionDetectionMetrics() => IsWatermarkVisionDetectionMetrics
            ? WatermarkVisionDetectionMetrics!
            : throw new global::System.InvalidOperationException($"Expected union variant 'WatermarkVisionDetectionMetrics' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator DetectWatermarkAnalysisMetrics(global::ResembleAI.WatermarkAudioDetectionMetrics value) => new DetectWatermarkAnalysisMetrics((global::ResembleAI.WatermarkAudioDetectionMetrics?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ResembleAI.WatermarkAudioDetectionMetrics?(DetectWatermarkAnalysisMetrics @this) => @this.WatermarkAudioDetectionMetrics;

        /// <summary>
        ///
        /// </summary>
        public DetectWatermarkAnalysisMetrics(global::ResembleAI.WatermarkAudioDetectionMetrics? value)
        {
            WatermarkAudioDetectionMetrics = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static DetectWatermarkAnalysisMetrics FromWatermarkAudioDetectionMetrics(global::ResembleAI.WatermarkAudioDetectionMetrics? value) => new DetectWatermarkAnalysisMetrics(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator DetectWatermarkAnalysisMetrics(global::ResembleAI.WatermarkVisionDetectionMetrics value) => new DetectWatermarkAnalysisMetrics((global::ResembleAI.WatermarkVisionDetectionMetrics?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ResembleAI.WatermarkVisionDetectionMetrics?(DetectWatermarkAnalysisMetrics @this) => @this.WatermarkVisionDetectionMetrics;

        /// <summary>
        ///
        /// </summary>
        public DetectWatermarkAnalysisMetrics(global::ResembleAI.WatermarkVisionDetectionMetrics? value)
        {
            WatermarkVisionDetectionMetrics = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static DetectWatermarkAnalysisMetrics FromWatermarkVisionDetectionMetrics(global::ResembleAI.WatermarkVisionDetectionMetrics? value) => new DetectWatermarkAnalysisMetrics(value);

        /// <summary>
        ///
        /// </summary>
        public DetectWatermarkAnalysisMetrics(
            global::ResembleAI.WatermarkAudioDetectionMetrics? watermarkAudioDetectionMetrics,
            global::ResembleAI.WatermarkVisionDetectionMetrics? watermarkVisionDetectionMetrics
            )
        {
            WatermarkAudioDetectionMetrics = watermarkAudioDetectionMetrics;
            WatermarkVisionDetectionMetrics = watermarkVisionDetectionMetrics;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            WatermarkVisionDetectionMetrics as object ??
            WatermarkAudioDetectionMetrics as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            WatermarkAudioDetectionMetrics?.ToString() ??
            WatermarkVisionDetectionMetrics?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsWatermarkAudioDetectionMetrics && !IsWatermarkVisionDetectionMetrics || !IsWatermarkAudioDetectionMetrics && IsWatermarkVisionDetectionMetrics;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ResembleAI.WatermarkAudioDetectionMetrics, TResult>? watermarkAudioDetectionMetrics = null,
            global::System.Func<global::ResembleAI.WatermarkVisionDetectionMetrics, TResult>? watermarkVisionDetectionMetrics = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWatermarkAudioDetectionMetrics && watermarkAudioDetectionMetrics != null)
            {
                return watermarkAudioDetectionMetrics(WatermarkAudioDetectionMetrics!);
            }
            else if (IsWatermarkVisionDetectionMetrics && watermarkVisionDetectionMetrics != null)
            {
                return watermarkVisionDetectionMetrics(WatermarkVisionDetectionMetrics!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::ResembleAI.WatermarkAudioDetectionMetrics>? watermarkAudioDetectionMetrics = null,

            global::System.Action<global::ResembleAI.WatermarkVisionDetectionMetrics>? watermarkVisionDetectionMetrics = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWatermarkAudioDetectionMetrics)
            {
                watermarkAudioDetectionMetrics?.Invoke(WatermarkAudioDetectionMetrics!);
            }
            else if (IsWatermarkVisionDetectionMetrics)
            {
                watermarkVisionDetectionMetrics?.Invoke(WatermarkVisionDetectionMetrics!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::ResembleAI.WatermarkAudioDetectionMetrics>? watermarkAudioDetectionMetrics = null,
            global::System.Action<global::ResembleAI.WatermarkVisionDetectionMetrics>? watermarkVisionDetectionMetrics = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWatermarkAudioDetectionMetrics)
            {
                watermarkAudioDetectionMetrics?.Invoke(WatermarkAudioDetectionMetrics!);
            }
            else if (IsWatermarkVisionDetectionMetrics)
            {
                watermarkVisionDetectionMetrics?.Invoke(WatermarkVisionDetectionMetrics!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                WatermarkAudioDetectionMetrics,
                typeof(global::ResembleAI.WatermarkAudioDetectionMetrics),
                WatermarkVisionDetectionMetrics,
                typeof(global::ResembleAI.WatermarkVisionDetectionMetrics),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        ///
        /// </summary>
        public bool Equals(DetectWatermarkAnalysisMetrics other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ResembleAI.WatermarkAudioDetectionMetrics?>.Default.Equals(WatermarkAudioDetectionMetrics, other.WatermarkAudioDetectionMetrics) &&
                global::System.Collections.Generic.EqualityComparer<global::ResembleAI.WatermarkVisionDetectionMetrics?>.Default.Equals(WatermarkVisionDetectionMetrics, other.WatermarkVisionDetectionMetrics)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(DetectWatermarkAnalysisMetrics obj1, DetectWatermarkAnalysisMetrics obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<DetectWatermarkAnalysisMetrics>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(DetectWatermarkAnalysisMetrics obj1, DetectWatermarkAnalysisMetrics obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is DetectWatermarkAnalysisMetrics o && Equals(o);
        }
    }
}
