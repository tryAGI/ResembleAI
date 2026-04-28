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
#if NET6_0_OR_GREATER
        public object? DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant2 { get; init; }
#else
        public object? DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant2))]
#endif
        public bool IsDetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant2 => DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant2 != null;
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
        public DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription(
            string? detectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant1,
            object? detectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant2
            )
        {
            DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant1 = detectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant1;
            DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant2 = detectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant2 as object ??
            DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant1?.ToString() ??
            DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsDetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant1 && !IsDetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant2 || !IsDetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant1 && IsDetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? detectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant1 = null,
            global::System.Func<object?, TResult>? detectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant2 = null,
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
            else if (IsDetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant2 && detectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant2 != null)
            {
                return detectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant2(DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? detectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant1 = null,
            global::System.Action<object?>? detectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant2 = null,
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
            else if (IsDetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant2)
            {
                detectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant2?.Invoke(DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant2!);
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
                DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant2,
                typeof(object),
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
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant2, other.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant2) 
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
