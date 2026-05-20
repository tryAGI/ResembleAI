#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription : global::System.IEquatable<DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant1 { get; init; }
#else
        public string? DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant1))]
#endif
        public bool IsDetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant1 => DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickDetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant1;
            return IsDetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant1;
        }

        /// <summary>
        /// 
        /// </summary>
        public string PickDetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant1() => IsDetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant1
            ? DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant1' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ResembleAI.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription1? DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription1 { get; init; }
#else
        public global::ResembleAI.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription1? DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription1))]
#endif
        public bool IsDetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription1 => DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickDetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ResembleAI.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription1? value)
        {
            value = DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription1;
            return IsDetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription1;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ResembleAI.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription1 PickDetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription1() => IsDetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription1
            ? DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription1' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription(string value) => new DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription @this) => @this.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant1;

        /// <summary>
        /// 
        /// </summary>
        public DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription(string? value)
        {
            DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription FromDetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant1(string? value) => new DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription(global::ResembleAI.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription1 value) => new DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription((global::ResembleAI.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ResembleAI.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription1?(DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription @this) => @this.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription1;

        /// <summary>
        /// 
        /// </summary>
        public DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription(global::ResembleAI.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription1? value)
        {
            DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription FromDetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription1(global::ResembleAI.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription1? value) => new DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription(value);

        /// <summary>
        /// 
        /// </summary>
        public DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription(
            string? detectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant1,
            global::ResembleAI.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription1? detectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription1
            )
        {
            DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant1 = detectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant1;
            DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription1 = detectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription1;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription1 as object ??
            DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant1?.ToString() ??
            DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription1?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsDetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant1 && !IsDetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription1 || !IsDetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant1 && IsDetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription1;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string, TResult>? detectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant1 = null,
            global::System.Func<global::ResembleAI.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription1, TResult>? detectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant1 && detectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant1 != null)
            {
                return detectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant1(DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant1!);
            }
            else if (IsDetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription1 && detectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription1 != null)
            {
                return detectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription1(DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription1!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string>? detectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant1 = null,

            global::System.Action<global::ResembleAI.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription1>? detectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant1)
            {
                detectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant1?.Invoke(DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant1!);
            }
            else if (IsDetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription1)
            {
                detectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription1?.Invoke(DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription1!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<string>? detectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant1 = null,
            global::System.Action<global::ResembleAI.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription1>? detectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant1)
            {
                detectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant1?.Invoke(DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant1!);
            }
            else if (IsDetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription1)
            {
                detectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription1?.Invoke(DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription1!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant1,
                typeof(string),
                DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription1,
                typeof(global::ResembleAI.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription1),
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
        public bool Equals(DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant1, other.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::ResembleAI.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription1?>.Default.Equals(DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription1, other.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription1) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription obj1, DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription obj1, DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription o && Equals(o);
        }
    }
}
