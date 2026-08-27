#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ResembleAI
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct IdentityCreateIdentityRequest : global::System.IEquatable<IdentityCreateIdentityRequest>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ResembleAI.IdentityCreateIdentityRequest0? IdentityCreateIdentityRequest0 { get; init; }
#else
        public global::ResembleAI.IdentityCreateIdentityRequest0? IdentityCreateIdentityRequest0 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(IdentityCreateIdentityRequest0))]
#endif
        public bool IsIdentityCreateIdentityRequest0 => IdentityCreateIdentityRequest0 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickIdentityCreateIdentityRequest0(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ResembleAI.IdentityCreateIdentityRequest0? value)
        {
            value = IdentityCreateIdentityRequest0;
            return IsIdentityCreateIdentityRequest0;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ResembleAI.IdentityCreateIdentityRequest0 PickIdentityCreateIdentityRequest0() => IsIdentityCreateIdentityRequest0
            ? IdentityCreateIdentityRequest0!
            : throw new global::System.InvalidOperationException($"Expected union variant 'IdentityCreateIdentityRequest0' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ResembleAI.IdentityCreateIdentityRequest1? IdentityCreateIdentityRequest1 { get; init; }
#else
        public global::ResembleAI.IdentityCreateIdentityRequest1? IdentityCreateIdentityRequest1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(IdentityCreateIdentityRequest1))]
#endif
        public bool IsIdentityCreateIdentityRequest1 => IdentityCreateIdentityRequest1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickIdentityCreateIdentityRequest1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ResembleAI.IdentityCreateIdentityRequest1? value)
        {
            value = IdentityCreateIdentityRequest1;
            return IsIdentityCreateIdentityRequest1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ResembleAI.IdentityCreateIdentityRequest1 PickIdentityCreateIdentityRequest1() => IsIdentityCreateIdentityRequest1
            ? IdentityCreateIdentityRequest1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'IdentityCreateIdentityRequest1' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator IdentityCreateIdentityRequest(global::ResembleAI.IdentityCreateIdentityRequest0 value) => new IdentityCreateIdentityRequest((global::ResembleAI.IdentityCreateIdentityRequest0?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ResembleAI.IdentityCreateIdentityRequest0?(IdentityCreateIdentityRequest @this) => @this.IdentityCreateIdentityRequest0;

        /// <summary>
        ///
        /// </summary>
        public IdentityCreateIdentityRequest(global::ResembleAI.IdentityCreateIdentityRequest0? value)
        {
            IdentityCreateIdentityRequest0 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IdentityCreateIdentityRequest FromIdentityCreateIdentityRequest0(global::ResembleAI.IdentityCreateIdentityRequest0? value) => new IdentityCreateIdentityRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IdentityCreateIdentityRequest(global::ResembleAI.IdentityCreateIdentityRequest1 value) => new IdentityCreateIdentityRequest((global::ResembleAI.IdentityCreateIdentityRequest1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ResembleAI.IdentityCreateIdentityRequest1?(IdentityCreateIdentityRequest @this) => @this.IdentityCreateIdentityRequest1;

        /// <summary>
        ///
        /// </summary>
        public IdentityCreateIdentityRequest(global::ResembleAI.IdentityCreateIdentityRequest1? value)
        {
            IdentityCreateIdentityRequest1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IdentityCreateIdentityRequest FromIdentityCreateIdentityRequest1(global::ResembleAI.IdentityCreateIdentityRequest1? value) => new IdentityCreateIdentityRequest(value);

        /// <summary>
        ///
        /// </summary>
        public IdentityCreateIdentityRequest(
            global::ResembleAI.IdentityCreateIdentityRequest0? identityCreateIdentityRequest0,
            global::ResembleAI.IdentityCreateIdentityRequest1? identityCreateIdentityRequest1
            )
        {
            IdentityCreateIdentityRequest0 = identityCreateIdentityRequest0;
            IdentityCreateIdentityRequest1 = identityCreateIdentityRequest1;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            IdentityCreateIdentityRequest1 as object ??
            IdentityCreateIdentityRequest0 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            IdentityCreateIdentityRequest0?.ToString() ??
            IdentityCreateIdentityRequest1?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsIdentityCreateIdentityRequest0 && !IsIdentityCreateIdentityRequest1 || !IsIdentityCreateIdentityRequest0 && IsIdentityCreateIdentityRequest1;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ResembleAI.IdentityCreateIdentityRequest0, TResult>? identityCreateIdentityRequest0 = null,
            global::System.Func<global::ResembleAI.IdentityCreateIdentityRequest1, TResult>? identityCreateIdentityRequest1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsIdentityCreateIdentityRequest0 && identityCreateIdentityRequest0 != null)
            {
                return identityCreateIdentityRequest0(IdentityCreateIdentityRequest0!);
            }
            else if (IsIdentityCreateIdentityRequest1 && identityCreateIdentityRequest1 != null)
            {
                return identityCreateIdentityRequest1(IdentityCreateIdentityRequest1!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::ResembleAI.IdentityCreateIdentityRequest0>? identityCreateIdentityRequest0 = null,

            global::System.Action<global::ResembleAI.IdentityCreateIdentityRequest1>? identityCreateIdentityRequest1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsIdentityCreateIdentityRequest0)
            {
                identityCreateIdentityRequest0?.Invoke(IdentityCreateIdentityRequest0!);
            }
            else if (IsIdentityCreateIdentityRequest1)
            {
                identityCreateIdentityRequest1?.Invoke(IdentityCreateIdentityRequest1!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::ResembleAI.IdentityCreateIdentityRequest0>? identityCreateIdentityRequest0 = null,
            global::System.Action<global::ResembleAI.IdentityCreateIdentityRequest1>? identityCreateIdentityRequest1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsIdentityCreateIdentityRequest0)
            {
                identityCreateIdentityRequest0?.Invoke(IdentityCreateIdentityRequest0!);
            }
            else if (IsIdentityCreateIdentityRequest1)
            {
                identityCreateIdentityRequest1?.Invoke(IdentityCreateIdentityRequest1!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                IdentityCreateIdentityRequest0,
                typeof(global::ResembleAI.IdentityCreateIdentityRequest0),
                IdentityCreateIdentityRequest1,
                typeof(global::ResembleAI.IdentityCreateIdentityRequest1),
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
        public bool Equals(IdentityCreateIdentityRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ResembleAI.IdentityCreateIdentityRequest0?>.Default.Equals(IdentityCreateIdentityRequest0, other.IdentityCreateIdentityRequest0) &&
                global::System.Collections.Generic.EqualityComparer<global::ResembleAI.IdentityCreateIdentityRequest1?>.Default.Equals(IdentityCreateIdentityRequest1, other.IdentityCreateIdentityRequest1)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(IdentityCreateIdentityRequest obj1, IdentityCreateIdentityRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IdentityCreateIdentityRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(IdentityCreateIdentityRequest obj1, IdentityCreateIdentityRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IdentityCreateIdentityRequest o && Equals(o);
        }
    }
}
