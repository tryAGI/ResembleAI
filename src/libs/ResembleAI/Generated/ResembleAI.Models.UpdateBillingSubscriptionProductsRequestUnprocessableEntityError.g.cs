#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ResembleAI
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct UpdateBillingSubscriptionProductsRequestUnprocessableEntityError : global::System.IEquatable<UpdateBillingSubscriptionProductsRequestUnprocessableEntityError>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ResembleAI.BillingError? BillingError { get; init; }
#else
        public global::ResembleAI.BillingError? BillingError { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BillingError))]
#endif
        public bool IsBillingError => BillingError != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBillingError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ResembleAI.BillingError? value)
        {
            value = BillingError;
            return IsBillingError;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ResembleAI.BillingError PickBillingError() => IsBillingError
            ? BillingError!
            : throw new global::System.InvalidOperationException($"Expected union variant 'BillingError' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ResembleAI.BillingValidationErrors? BillingValidationErrors { get; init; }
#else
        public global::ResembleAI.BillingValidationErrors? BillingValidationErrors { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BillingValidationErrors))]
#endif
        public bool IsBillingValidationErrors => BillingValidationErrors != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBillingValidationErrors(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ResembleAI.BillingValidationErrors? value)
        {
            value = BillingValidationErrors;
            return IsBillingValidationErrors;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ResembleAI.BillingValidationErrors PickBillingValidationErrors() => IsBillingValidationErrors
            ? BillingValidationErrors!
            : throw new global::System.InvalidOperationException($"Expected union variant 'BillingValidationErrors' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator UpdateBillingSubscriptionProductsRequestUnprocessableEntityError(global::ResembleAI.BillingError value) => new UpdateBillingSubscriptionProductsRequestUnprocessableEntityError((global::ResembleAI.BillingError?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ResembleAI.BillingError?(UpdateBillingSubscriptionProductsRequestUnprocessableEntityError @this) => @this.BillingError;

        /// <summary>
        ///
        /// </summary>
        public UpdateBillingSubscriptionProductsRequestUnprocessableEntityError(global::ResembleAI.BillingError? value)
        {
            BillingError = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UpdateBillingSubscriptionProductsRequestUnprocessableEntityError FromBillingError(global::ResembleAI.BillingError? value) => new UpdateBillingSubscriptionProductsRequestUnprocessableEntityError(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator UpdateBillingSubscriptionProductsRequestUnprocessableEntityError(global::ResembleAI.BillingValidationErrors value) => new UpdateBillingSubscriptionProductsRequestUnprocessableEntityError((global::ResembleAI.BillingValidationErrors?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ResembleAI.BillingValidationErrors?(UpdateBillingSubscriptionProductsRequestUnprocessableEntityError @this) => @this.BillingValidationErrors;

        /// <summary>
        ///
        /// </summary>
        public UpdateBillingSubscriptionProductsRequestUnprocessableEntityError(global::ResembleAI.BillingValidationErrors? value)
        {
            BillingValidationErrors = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UpdateBillingSubscriptionProductsRequestUnprocessableEntityError FromBillingValidationErrors(global::ResembleAI.BillingValidationErrors? value) => new UpdateBillingSubscriptionProductsRequestUnprocessableEntityError(value);

        /// <summary>
        ///
        /// </summary>
        public UpdateBillingSubscriptionProductsRequestUnprocessableEntityError(
            global::ResembleAI.BillingError? billingError,
            global::ResembleAI.BillingValidationErrors? billingValidationErrors
            )
        {
            BillingError = billingError;
            BillingValidationErrors = billingValidationErrors;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            BillingValidationErrors as object ??
            BillingError as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            BillingError?.ToString() ??
            BillingValidationErrors?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBillingError && !IsBillingValidationErrors || !IsBillingError && IsBillingValidationErrors;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ResembleAI.BillingError, TResult>? billingError = null,
            global::System.Func<global::ResembleAI.BillingValidationErrors, TResult>? billingValidationErrors = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBillingError && billingError != null)
            {
                return billingError(BillingError!);
            }
            else if (IsBillingValidationErrors && billingValidationErrors != null)
            {
                return billingValidationErrors(BillingValidationErrors!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::ResembleAI.BillingError>? billingError = null,

            global::System.Action<global::ResembleAI.BillingValidationErrors>? billingValidationErrors = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBillingError)
            {
                billingError?.Invoke(BillingError!);
            }
            else if (IsBillingValidationErrors)
            {
                billingValidationErrors?.Invoke(BillingValidationErrors!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::ResembleAI.BillingError>? billingError = null,
            global::System.Action<global::ResembleAI.BillingValidationErrors>? billingValidationErrors = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBillingError)
            {
                billingError?.Invoke(BillingError!);
            }
            else if (IsBillingValidationErrors)
            {
                billingValidationErrors?.Invoke(BillingValidationErrors!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                BillingError,
                typeof(global::ResembleAI.BillingError),
                BillingValidationErrors,
                typeof(global::ResembleAI.BillingValidationErrors),
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
        public bool Equals(UpdateBillingSubscriptionProductsRequestUnprocessableEntityError other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ResembleAI.BillingError?>.Default.Equals(BillingError, other.BillingError) &&
                global::System.Collections.Generic.EqualityComparer<global::ResembleAI.BillingValidationErrors?>.Default.Equals(BillingValidationErrors, other.BillingValidationErrors)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(UpdateBillingSubscriptionProductsRequestUnprocessableEntityError obj1, UpdateBillingSubscriptionProductsRequestUnprocessableEntityError obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<UpdateBillingSubscriptionProductsRequestUnprocessableEntityError>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(UpdateBillingSubscriptionProductsRequestUnprocessableEntityError obj1, UpdateBillingSubscriptionProductsRequestUnprocessableEntityError obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is UpdateBillingSubscriptionProductsRequestUnprocessableEntityError o && Equals(o);
        }
    }
}
