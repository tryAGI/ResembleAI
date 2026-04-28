#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescription : global::System.IEquatable<DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescription>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant1 { get; init; }
#else
        public string? DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant1))]
#endif
        public bool IsDetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant1 => DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public object? DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant2 { get; init; }
#else
        public object? DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant2))]
#endif
        public bool IsDetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant2 => DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescription(string value) => new DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescription((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescription @this) => @this.DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant1;

        /// <summary>
        /// 
        /// </summary>
        public DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescription(string? value)
        {
            DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescription(
            string? detectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant1,
            object? detectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant2
            )
        {
            DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant1 = detectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant1;
            DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant2 = detectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant2 as object ??
            DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant1?.ToString() ??
            DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsDetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant1 && !IsDetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant2 || !IsDetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant1 && IsDetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? detectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant1 = null,
            global::System.Func<object?, TResult>? detectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant1 && detectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant1 != null)
            {
                return detectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant1(DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant1!);
            }
            else if (IsDetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant2 && detectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant2 != null)
            {
                return detectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant2(DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? detectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant1 = null,
            global::System.Action<object?>? detectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant1)
            {
                detectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant1?.Invoke(DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant1!);
            }
            else if (IsDetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant2)
            {
                detectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant2?.Invoke(DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant1,
                typeof(string),
                DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant2,
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
        public bool Equals(DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescription other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant1, other.DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant1) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant2, other.DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescription obj1, DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescription obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescription>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescription obj1, DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescription obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescription o && Equals(o);
        }
    }
}
