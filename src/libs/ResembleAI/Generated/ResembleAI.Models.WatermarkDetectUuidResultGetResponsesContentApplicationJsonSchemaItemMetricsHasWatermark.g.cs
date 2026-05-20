#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct WatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetricsHasWatermark : global::System.IEquatable<WatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetricsHasWatermark>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.Dictionary<string, bool>? WatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetricsHasWatermarkVariant1 { get; init; }
#else
        public global::System.Collections.Generic.Dictionary<string, bool>? WatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetricsHasWatermarkVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetricsHasWatermarkVariant1))]
#endif
        public bool IsWatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetricsHasWatermarkVariant1 => WatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetricsHasWatermarkVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickWatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetricsHasWatermarkVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.Dictionary<string, bool>? value)
        {
            value = WatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetricsHasWatermarkVariant1;
            return IsWatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetricsHasWatermarkVariant1;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, bool> PickWatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetricsHasWatermarkVariant1() => IsWatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetricsHasWatermarkVariant1
            ? WatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetricsHasWatermarkVariant1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'WatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetricsHasWatermarkVariant1' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public bool? WatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetricsHasWatermarkVariant2 { get; init; }
#else
        public bool? WatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetricsHasWatermarkVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetricsHasWatermarkVariant2))]
#endif
        public bool IsWatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetricsHasWatermarkVariant2 => WatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetricsHasWatermarkVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickWatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetricsHasWatermarkVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out bool? value)
        {
            value = WatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetricsHasWatermarkVariant2;
            return IsWatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetricsHasWatermarkVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public bool PickWatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetricsHasWatermarkVariant2() => IsWatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetricsHasWatermarkVariant2
            ? WatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetricsHasWatermarkVariant2!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetricsHasWatermarkVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetricsHasWatermark(global::System.Collections.Generic.Dictionary<string, bool> value) => new WatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetricsHasWatermark((global::System.Collections.Generic.Dictionary<string, bool>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::System.Collections.Generic.Dictionary<string, bool>?(WatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetricsHasWatermark @this) => @this.WatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetricsHasWatermarkVariant1;

        /// <summary>
        /// 
        /// </summary>
        public WatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetricsHasWatermark(global::System.Collections.Generic.Dictionary<string, bool>? value)
        {
            WatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetricsHasWatermarkVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static WatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetricsHasWatermark FromWatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetricsHasWatermarkVariant1(global::System.Collections.Generic.Dictionary<string, bool>? value) => new WatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetricsHasWatermark(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetricsHasWatermark(bool value) => new WatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetricsHasWatermark((bool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator bool?(WatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetricsHasWatermark @this) => @this.WatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetricsHasWatermarkVariant2;

        /// <summary>
        /// 
        /// </summary>
        public WatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetricsHasWatermark(bool? value)
        {
            WatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetricsHasWatermarkVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static WatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetricsHasWatermark FromWatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetricsHasWatermarkVariant2(bool? value) => new WatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetricsHasWatermark(value);

        /// <summary>
        /// 
        /// </summary>
        public WatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetricsHasWatermark(
            global::System.Collections.Generic.Dictionary<string, bool>? watermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetricsHasWatermarkVariant1,
            bool? watermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetricsHasWatermarkVariant2
            )
        {
            WatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetricsHasWatermarkVariant1 = watermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetricsHasWatermarkVariant1;
            WatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetricsHasWatermarkVariant2 = watermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetricsHasWatermarkVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            WatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetricsHasWatermarkVariant2 as object ??
            WatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetricsHasWatermarkVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            WatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetricsHasWatermarkVariant1?.ToString() ??
            WatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetricsHasWatermarkVariant2?.ToString().ToLowerInvariant() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsWatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetricsHasWatermarkVariant1 && !IsWatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetricsHasWatermarkVariant2 || !IsWatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetricsHasWatermarkVariant1 && IsWatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetricsHasWatermarkVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::System.Collections.Generic.Dictionary<string, bool>, TResult>? watermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetricsHasWatermarkVariant1 = null,
            global::System.Func<bool?, TResult>? watermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetricsHasWatermarkVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetricsHasWatermarkVariant1 && watermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetricsHasWatermarkVariant1 != null)
            {
                return watermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetricsHasWatermarkVariant1(WatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetricsHasWatermarkVariant1!);
            }
            else if (IsWatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetricsHasWatermarkVariant2 && watermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetricsHasWatermarkVariant2 != null)
            {
                return watermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetricsHasWatermarkVariant2(WatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetricsHasWatermarkVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::System.Collections.Generic.Dictionary<string, bool>>? watermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetricsHasWatermarkVariant1 = null,

            global::System.Action<bool?>? watermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetricsHasWatermarkVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetricsHasWatermarkVariant1)
            {
                watermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetricsHasWatermarkVariant1?.Invoke(WatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetricsHasWatermarkVariant1!);
            }
            else if (IsWatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetricsHasWatermarkVariant2)
            {
                watermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetricsHasWatermarkVariant2?.Invoke(WatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetricsHasWatermarkVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::System.Collections.Generic.Dictionary<string, bool>>? watermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetricsHasWatermarkVariant1 = null,
            global::System.Action<bool?>? watermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetricsHasWatermarkVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetricsHasWatermarkVariant1)
            {
                watermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetricsHasWatermarkVariant1?.Invoke(WatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetricsHasWatermarkVariant1!);
            }
            else if (IsWatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetricsHasWatermarkVariant2)
            {
                watermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetricsHasWatermarkVariant2?.Invoke(WatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetricsHasWatermarkVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                WatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetricsHasWatermarkVariant1,
                typeof(global::System.Collections.Generic.Dictionary<string, bool>),
                WatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetricsHasWatermarkVariant2,
                typeof(bool),
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
        public bool Equals(WatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetricsHasWatermark other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.Dictionary<string, bool>?>.Default.Equals(WatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetricsHasWatermarkVariant1, other.WatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetricsHasWatermarkVariant1) &&
                global::System.Collections.Generic.EqualityComparer<bool?>.Default.Equals(WatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetricsHasWatermarkVariant2, other.WatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetricsHasWatermarkVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(WatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetricsHasWatermark obj1, WatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetricsHasWatermark obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<WatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetricsHasWatermark>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(WatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetricsHasWatermark obj1, WatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetricsHasWatermark obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is WatermarkDetectUuidResultGetResponsesContentApplicationJsonSchemaItemMetricsHasWatermark o && Equals(o);
        }
    }
}
