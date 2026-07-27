#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct DetectIntelligenceResultDescription : global::System.IEquatable<DetectIntelligenceResultDescription>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? DetectIntelligenceResultDescriptionVariant1 { get; init; }
#else
        public string? DetectIntelligenceResultDescriptionVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DetectIntelligenceResultDescriptionVariant1))]
#endif
        public bool IsDetectIntelligenceResultDescriptionVariant1 => DetectIntelligenceResultDescriptionVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickDetectIntelligenceResultDescriptionVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = DetectIntelligenceResultDescriptionVariant1;
            return IsDetectIntelligenceResultDescriptionVariant1;
        }

        /// <summary>
        /// 
        /// </summary>
        public string PickDetectIntelligenceResultDescriptionVariant1() => IsDetectIntelligenceResultDescriptionVariant1
            ? DetectIntelligenceResultDescriptionVariant1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'DetectIntelligenceResultDescriptionVariant1' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ResembleAI.DetectIntelligenceResultDescription1? DetectIntelligenceResultDescription1 { get; init; }
#else
        public global::ResembleAI.DetectIntelligenceResultDescription1? DetectIntelligenceResultDescription1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DetectIntelligenceResultDescription1))]
#endif
        public bool IsDetectIntelligenceResultDescription1 => DetectIntelligenceResultDescription1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickDetectIntelligenceResultDescription1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ResembleAI.DetectIntelligenceResultDescription1? value)
        {
            value = DetectIntelligenceResultDescription1;
            return IsDetectIntelligenceResultDescription1;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ResembleAI.DetectIntelligenceResultDescription1 PickDetectIntelligenceResultDescription1() => IsDetectIntelligenceResultDescription1
            ? DetectIntelligenceResultDescription1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'DetectIntelligenceResultDescription1' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DetectIntelligenceResultDescription(string value) => new DetectIntelligenceResultDescription((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(DetectIntelligenceResultDescription @this) => @this.DetectIntelligenceResultDescriptionVariant1;

        /// <summary>
        /// 
        /// </summary>
        public DetectIntelligenceResultDescription(string? value)
        {
            DetectIntelligenceResultDescriptionVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static DetectIntelligenceResultDescription FromDetectIntelligenceResultDescriptionVariant1(string? value) => new DetectIntelligenceResultDescription(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DetectIntelligenceResultDescription(global::ResembleAI.DetectIntelligenceResultDescription1 value) => new DetectIntelligenceResultDescription((global::ResembleAI.DetectIntelligenceResultDescription1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ResembleAI.DetectIntelligenceResultDescription1?(DetectIntelligenceResultDescription @this) => @this.DetectIntelligenceResultDescription1;

        /// <summary>
        /// 
        /// </summary>
        public DetectIntelligenceResultDescription(global::ResembleAI.DetectIntelligenceResultDescription1? value)
        {
            DetectIntelligenceResultDescription1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static DetectIntelligenceResultDescription FromDetectIntelligenceResultDescription1(global::ResembleAI.DetectIntelligenceResultDescription1? value) => new DetectIntelligenceResultDescription(value);

        /// <summary>
        /// 
        /// </summary>
        public DetectIntelligenceResultDescription(
            string? detectIntelligenceResultDescriptionVariant1,
            global::ResembleAI.DetectIntelligenceResultDescription1? detectIntelligenceResultDescription1
            )
        {
            DetectIntelligenceResultDescriptionVariant1 = detectIntelligenceResultDescriptionVariant1;
            DetectIntelligenceResultDescription1 = detectIntelligenceResultDescription1;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            DetectIntelligenceResultDescription1 as object ??
            DetectIntelligenceResultDescriptionVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            DetectIntelligenceResultDescriptionVariant1?.ToString() ??
            DetectIntelligenceResultDescription1?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsDetectIntelligenceResultDescriptionVariant1 && !IsDetectIntelligenceResultDescription1 || !IsDetectIntelligenceResultDescriptionVariant1 && IsDetectIntelligenceResultDescription1;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string, TResult>? detectIntelligenceResultDescriptionVariant1 = null,
            global::System.Func<global::ResembleAI.DetectIntelligenceResultDescription1, TResult>? detectIntelligenceResultDescription1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDetectIntelligenceResultDescriptionVariant1 && detectIntelligenceResultDescriptionVariant1 != null)
            {
                return detectIntelligenceResultDescriptionVariant1(DetectIntelligenceResultDescriptionVariant1!);
            }
            else if (IsDetectIntelligenceResultDescription1 && detectIntelligenceResultDescription1 != null)
            {
                return detectIntelligenceResultDescription1(DetectIntelligenceResultDescription1!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string>? detectIntelligenceResultDescriptionVariant1 = null,

            global::System.Action<global::ResembleAI.DetectIntelligenceResultDescription1>? detectIntelligenceResultDescription1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDetectIntelligenceResultDescriptionVariant1)
            {
                detectIntelligenceResultDescriptionVariant1?.Invoke(DetectIntelligenceResultDescriptionVariant1!);
            }
            else if (IsDetectIntelligenceResultDescription1)
            {
                detectIntelligenceResultDescription1?.Invoke(DetectIntelligenceResultDescription1!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<string>? detectIntelligenceResultDescriptionVariant1 = null,
            global::System.Action<global::ResembleAI.DetectIntelligenceResultDescription1>? detectIntelligenceResultDescription1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDetectIntelligenceResultDescriptionVariant1)
            {
                detectIntelligenceResultDescriptionVariant1?.Invoke(DetectIntelligenceResultDescriptionVariant1!);
            }
            else if (IsDetectIntelligenceResultDescription1)
            {
                detectIntelligenceResultDescription1?.Invoke(DetectIntelligenceResultDescription1!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                DetectIntelligenceResultDescriptionVariant1,
                typeof(string),
                DetectIntelligenceResultDescription1,
                typeof(global::ResembleAI.DetectIntelligenceResultDescription1),
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
        public bool Equals(DetectIntelligenceResultDescription other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(DetectIntelligenceResultDescriptionVariant1, other.DetectIntelligenceResultDescriptionVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::ResembleAI.DetectIntelligenceResultDescription1?>.Default.Equals(DetectIntelligenceResultDescription1, other.DetectIntelligenceResultDescription1) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(DetectIntelligenceResultDescription obj1, DetectIntelligenceResultDescription obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<DetectIntelligenceResultDescription>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(DetectIntelligenceResultDescription obj1, DetectIntelligenceResultDescription obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is DetectIntelligenceResultDescription o && Equals(o);
        }
    }
}
