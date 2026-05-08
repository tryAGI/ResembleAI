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
        public bool TryPickDetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant1;
            return IsDetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant1;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ResembleAI.DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescription1? DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescription1 { get; init; }
#else
        public global::ResembleAI.DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescription1? DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescription1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescription1))]
#endif
        public bool IsDetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescription1 => DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescription1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickDetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescription1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ResembleAI.DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescription1? value)
        {
            value = DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescription1;
            return IsDetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescription1;
        }
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
        public static implicit operator DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescription(global::ResembleAI.DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescription1 value) => new DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescription((global::ResembleAI.DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescription1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ResembleAI.DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescription1?(DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescription @this) => @this.DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescription1;

        /// <summary>
        /// 
        /// </summary>
        public DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescription(global::ResembleAI.DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescription1? value)
        {
            DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescription1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescription(
            string? detectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant1,
            global::ResembleAI.DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescription1? detectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescription1
            )
        {
            DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant1 = detectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant1;
            DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescription1 = detectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescription1;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescription1 as object ??
            DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant1?.ToString() ??
            DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescription1?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsDetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant1 && !IsDetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescription1 || !IsDetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant1 && IsDetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescription1;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string, TResult>? detectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant1 = null,
            global::System.Func<global::ResembleAI.DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescription1, TResult>? detectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescription1 = null,
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
            else if (IsDetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescription1 && detectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescription1 != null)
            {
                return detectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescription1(DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescription1!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string>? detectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant1 = null,

            global::System.Action<global::ResembleAI.DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescription1>? detectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescription1 = null,
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
            else if (IsDetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescription1)
            {
                detectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescription1?.Invoke(DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescription1!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<string>? detectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant1 = null,
            global::System.Action<global::ResembleAI.DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescription1>? detectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescription1 = null,
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
            else if (IsDetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescription1)
            {
                detectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescription1?.Invoke(DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescription1!);
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
                DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescription1,
                typeof(global::ResembleAI.DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescription1),
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
                global::System.Collections.Generic.EqualityComparer<global::ResembleAI.DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescription1?>.Default.Equals(DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescription1, other.DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligenceDescription1) 
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
