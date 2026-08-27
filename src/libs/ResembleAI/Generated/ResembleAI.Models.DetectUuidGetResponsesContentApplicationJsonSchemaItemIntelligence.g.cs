#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// With experts omitted or false, one completed Intelligence result when available; otherwise, the current processing or failed result. With experts=true, all successfully completed results as an array, or an empty array when none have completed successfully.
    /// </summary>
    public readonly partial struct DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligence : global::System.IEquatable<DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligence>
    {
        /// <summary>
        /// One Detect Intelligence expert result
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ResembleAI.DetectIntelligenceResult? DetectIntelligenceResult { get; init; }
#else
        public global::ResembleAI.DetectIntelligenceResult? DetectIntelligenceResult { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DetectIntelligenceResult))]
#endif
        public bool IsDetectIntelligenceResult => DetectIntelligenceResult != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickDetectIntelligenceResult(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ResembleAI.DetectIntelligenceResult? value)
        {
            value = DetectIntelligenceResult;
            return IsDetectIntelligenceResult;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ResembleAI.DetectIntelligenceResult PickDetectIntelligenceResult() => IsDetectIntelligenceResult
            ? DetectIntelligenceResult!
            : throw new global::System.InvalidOperationException($"Expected union variant 'DetectIntelligenceResult' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::ResembleAI.DetectIntelligenceResult>? DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligence1 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::ResembleAI.DetectIntelligenceResult>? DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligence1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligence1))]
#endif
        public bool IsDetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligence1 => DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligence1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickDetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligence1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.IList<global::ResembleAI.DetectIntelligenceResult>? value)
        {
            value = DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligence1;
            return IsDetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligence1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ResembleAI.DetectIntelligenceResult> PickDetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligence1() => IsDetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligence1
            ? DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligence1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligence1' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligence(global::ResembleAI.DetectIntelligenceResult value) => new DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligence((global::ResembleAI.DetectIntelligenceResult?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ResembleAI.DetectIntelligenceResult?(DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligence @this) => @this.DetectIntelligenceResult;

        /// <summary>
        ///
        /// </summary>
        public DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligence(global::ResembleAI.DetectIntelligenceResult? value)
        {
            DetectIntelligenceResult = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligence FromDetectIntelligenceResult(global::ResembleAI.DetectIntelligenceResult? value) => new DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligence(value);

        /// <summary>
        ///
        /// </summary>
        public DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligence(
            global::ResembleAI.DetectIntelligenceResult? detectIntelligenceResult,
            global::System.Collections.Generic.IList<global::ResembleAI.DetectIntelligenceResult>? detectUuidGetResponsesContentApplicationJsonSchemaItemIntelligence1
            )
        {
            DetectIntelligenceResult = detectIntelligenceResult;
            DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligence1 = detectUuidGetResponsesContentApplicationJsonSchemaItemIntelligence1;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligence1 as object ??
            DetectIntelligenceResult as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            DetectIntelligenceResult?.ToString() ??
            DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligence1?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsDetectIntelligenceResult && !IsDetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligence1 || !IsDetectIntelligenceResult && IsDetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligence1;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ResembleAI.DetectIntelligenceResult, TResult>? detectIntelligenceResult = null,
            global::System.Func<global::System.Collections.Generic.IList<global::ResembleAI.DetectIntelligenceResult>, TResult>? detectUuidGetResponsesContentApplicationJsonSchemaItemIntelligence1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDetectIntelligenceResult && detectIntelligenceResult != null)
            {
                return detectIntelligenceResult(DetectIntelligenceResult!);
            }
            else if (IsDetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligence1 && detectUuidGetResponsesContentApplicationJsonSchemaItemIntelligence1 != null)
            {
                return detectUuidGetResponsesContentApplicationJsonSchemaItemIntelligence1(DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligence1!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::ResembleAI.DetectIntelligenceResult>? detectIntelligenceResult = null,

            global::System.Action<global::System.Collections.Generic.IList<global::ResembleAI.DetectIntelligenceResult>>? detectUuidGetResponsesContentApplicationJsonSchemaItemIntelligence1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDetectIntelligenceResult)
            {
                detectIntelligenceResult?.Invoke(DetectIntelligenceResult!);
            }
            else if (IsDetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligence1)
            {
                detectUuidGetResponsesContentApplicationJsonSchemaItemIntelligence1?.Invoke(DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligence1!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::ResembleAI.DetectIntelligenceResult>? detectIntelligenceResult = null,
            global::System.Action<global::System.Collections.Generic.IList<global::ResembleAI.DetectIntelligenceResult>>? detectUuidGetResponsesContentApplicationJsonSchemaItemIntelligence1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDetectIntelligenceResult)
            {
                detectIntelligenceResult?.Invoke(DetectIntelligenceResult!);
            }
            else if (IsDetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligence1)
            {
                detectUuidGetResponsesContentApplicationJsonSchemaItemIntelligence1?.Invoke(DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligence1!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                DetectIntelligenceResult,
                typeof(global::ResembleAI.DetectIntelligenceResult),
                DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligence1,
                typeof(global::System.Collections.Generic.IList<global::ResembleAI.DetectIntelligenceResult>),
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
        public bool Equals(DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligence other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ResembleAI.DetectIntelligenceResult?>.Default.Equals(DetectIntelligenceResult, other.DetectIntelligenceResult) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::ResembleAI.DetectIntelligenceResult>?>.Default.Equals(DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligence1, other.DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligence1)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligence obj1, DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligence obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligence>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligence obj1, DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligence obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is DetectUuidGetResponsesContentApplicationJsonSchemaItemIntelligence o && Equals(o);
        }
    }
}
