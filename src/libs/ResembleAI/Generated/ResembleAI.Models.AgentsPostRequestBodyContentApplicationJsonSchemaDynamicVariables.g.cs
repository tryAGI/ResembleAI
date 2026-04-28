#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ResembleAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct AgentsPostRequestBodyContentApplicationJsonSchemaDynamicVariables : global::System.IEquatable<AgentsPostRequestBodyContentApplicationJsonSchemaDynamicVariables>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? AgentsPostRequestBodyContentApplicationJsonSchemaDynamicVariablesVariant1 { get; init; }
#else
        public string? AgentsPostRequestBodyContentApplicationJsonSchemaDynamicVariablesVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentsPostRequestBodyContentApplicationJsonSchemaDynamicVariablesVariant1))]
#endif
        public bool IsAgentsPostRequestBodyContentApplicationJsonSchemaDynamicVariablesVariant1 => AgentsPostRequestBodyContentApplicationJsonSchemaDynamicVariablesVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public double? AgentsPostRequestBodyContentApplicationJsonSchemaDynamicVariablesVariant2 { get; init; }
#else
        public double? AgentsPostRequestBodyContentApplicationJsonSchemaDynamicVariablesVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentsPostRequestBodyContentApplicationJsonSchemaDynamicVariablesVariant2))]
#endif
        public bool IsAgentsPostRequestBodyContentApplicationJsonSchemaDynamicVariablesVariant2 => AgentsPostRequestBodyContentApplicationJsonSchemaDynamicVariablesVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public bool? AgentsPostRequestBodyContentApplicationJsonSchemaDynamicVariablesVariant3 { get; init; }
#else
        public bool? AgentsPostRequestBodyContentApplicationJsonSchemaDynamicVariablesVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentsPostRequestBodyContentApplicationJsonSchemaDynamicVariablesVariant3))]
#endif
        public bool IsAgentsPostRequestBodyContentApplicationJsonSchemaDynamicVariablesVariant3 => AgentsPostRequestBodyContentApplicationJsonSchemaDynamicVariablesVariant3 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentsPostRequestBodyContentApplicationJsonSchemaDynamicVariables(string value) => new AgentsPostRequestBodyContentApplicationJsonSchemaDynamicVariables((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(AgentsPostRequestBodyContentApplicationJsonSchemaDynamicVariables @this) => @this.AgentsPostRequestBodyContentApplicationJsonSchemaDynamicVariablesVariant1;

        /// <summary>
        /// 
        /// </summary>
        public AgentsPostRequestBodyContentApplicationJsonSchemaDynamicVariables(string? value)
        {
            AgentsPostRequestBodyContentApplicationJsonSchemaDynamicVariablesVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentsPostRequestBodyContentApplicationJsonSchemaDynamicVariables(double value) => new AgentsPostRequestBodyContentApplicationJsonSchemaDynamicVariables((double?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator double?(AgentsPostRequestBodyContentApplicationJsonSchemaDynamicVariables @this) => @this.AgentsPostRequestBodyContentApplicationJsonSchemaDynamicVariablesVariant2;

        /// <summary>
        /// 
        /// </summary>
        public AgentsPostRequestBodyContentApplicationJsonSchemaDynamicVariables(double? value)
        {
            AgentsPostRequestBodyContentApplicationJsonSchemaDynamicVariablesVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentsPostRequestBodyContentApplicationJsonSchemaDynamicVariables(bool value) => new AgentsPostRequestBodyContentApplicationJsonSchemaDynamicVariables((bool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator bool?(AgentsPostRequestBodyContentApplicationJsonSchemaDynamicVariables @this) => @this.AgentsPostRequestBodyContentApplicationJsonSchemaDynamicVariablesVariant3;

        /// <summary>
        /// 
        /// </summary>
        public AgentsPostRequestBodyContentApplicationJsonSchemaDynamicVariables(bool? value)
        {
            AgentsPostRequestBodyContentApplicationJsonSchemaDynamicVariablesVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AgentsPostRequestBodyContentApplicationJsonSchemaDynamicVariables(
            string? agentsPostRequestBodyContentApplicationJsonSchemaDynamicVariablesVariant1,
            double? agentsPostRequestBodyContentApplicationJsonSchemaDynamicVariablesVariant2,
            bool? agentsPostRequestBodyContentApplicationJsonSchemaDynamicVariablesVariant3
            )
        {
            AgentsPostRequestBodyContentApplicationJsonSchemaDynamicVariablesVariant1 = agentsPostRequestBodyContentApplicationJsonSchemaDynamicVariablesVariant1;
            AgentsPostRequestBodyContentApplicationJsonSchemaDynamicVariablesVariant2 = agentsPostRequestBodyContentApplicationJsonSchemaDynamicVariablesVariant2;
            AgentsPostRequestBodyContentApplicationJsonSchemaDynamicVariablesVariant3 = agentsPostRequestBodyContentApplicationJsonSchemaDynamicVariablesVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            AgentsPostRequestBodyContentApplicationJsonSchemaDynamicVariablesVariant3 as object ??
            AgentsPostRequestBodyContentApplicationJsonSchemaDynamicVariablesVariant2 as object ??
            AgentsPostRequestBodyContentApplicationJsonSchemaDynamicVariablesVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AgentsPostRequestBodyContentApplicationJsonSchemaDynamicVariablesVariant1?.ToString() ??
            AgentsPostRequestBodyContentApplicationJsonSchemaDynamicVariablesVariant2?.ToString() ??
            AgentsPostRequestBodyContentApplicationJsonSchemaDynamicVariablesVariant3?.ToString().ToLowerInvariant() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAgentsPostRequestBodyContentApplicationJsonSchemaDynamicVariablesVariant1 && !IsAgentsPostRequestBodyContentApplicationJsonSchemaDynamicVariablesVariant2 && !IsAgentsPostRequestBodyContentApplicationJsonSchemaDynamicVariablesVariant3 || !IsAgentsPostRequestBodyContentApplicationJsonSchemaDynamicVariablesVariant1 && IsAgentsPostRequestBodyContentApplicationJsonSchemaDynamicVariablesVariant2 && !IsAgentsPostRequestBodyContentApplicationJsonSchemaDynamicVariablesVariant3 || !IsAgentsPostRequestBodyContentApplicationJsonSchemaDynamicVariablesVariant1 && !IsAgentsPostRequestBodyContentApplicationJsonSchemaDynamicVariablesVariant2 && IsAgentsPostRequestBodyContentApplicationJsonSchemaDynamicVariablesVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? agentsPostRequestBodyContentApplicationJsonSchemaDynamicVariablesVariant1 = null,
            global::System.Func<double?, TResult>? agentsPostRequestBodyContentApplicationJsonSchemaDynamicVariablesVariant2 = null,
            global::System.Func<bool?, TResult>? agentsPostRequestBodyContentApplicationJsonSchemaDynamicVariablesVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAgentsPostRequestBodyContentApplicationJsonSchemaDynamicVariablesVariant1 && agentsPostRequestBodyContentApplicationJsonSchemaDynamicVariablesVariant1 != null)
            {
                return agentsPostRequestBodyContentApplicationJsonSchemaDynamicVariablesVariant1(AgentsPostRequestBodyContentApplicationJsonSchemaDynamicVariablesVariant1!);
            }
            else if (IsAgentsPostRequestBodyContentApplicationJsonSchemaDynamicVariablesVariant2 && agentsPostRequestBodyContentApplicationJsonSchemaDynamicVariablesVariant2 != null)
            {
                return agentsPostRequestBodyContentApplicationJsonSchemaDynamicVariablesVariant2(AgentsPostRequestBodyContentApplicationJsonSchemaDynamicVariablesVariant2!);
            }
            else if (IsAgentsPostRequestBodyContentApplicationJsonSchemaDynamicVariablesVariant3 && agentsPostRequestBodyContentApplicationJsonSchemaDynamicVariablesVariant3 != null)
            {
                return agentsPostRequestBodyContentApplicationJsonSchemaDynamicVariablesVariant3(AgentsPostRequestBodyContentApplicationJsonSchemaDynamicVariablesVariant3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? agentsPostRequestBodyContentApplicationJsonSchemaDynamicVariablesVariant1 = null,
            global::System.Action<double?>? agentsPostRequestBodyContentApplicationJsonSchemaDynamicVariablesVariant2 = null,
            global::System.Action<bool?>? agentsPostRequestBodyContentApplicationJsonSchemaDynamicVariablesVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAgentsPostRequestBodyContentApplicationJsonSchemaDynamicVariablesVariant1)
            {
                agentsPostRequestBodyContentApplicationJsonSchemaDynamicVariablesVariant1?.Invoke(AgentsPostRequestBodyContentApplicationJsonSchemaDynamicVariablesVariant1!);
            }
            else if (IsAgentsPostRequestBodyContentApplicationJsonSchemaDynamicVariablesVariant2)
            {
                agentsPostRequestBodyContentApplicationJsonSchemaDynamicVariablesVariant2?.Invoke(AgentsPostRequestBodyContentApplicationJsonSchemaDynamicVariablesVariant2!);
            }
            else if (IsAgentsPostRequestBodyContentApplicationJsonSchemaDynamicVariablesVariant3)
            {
                agentsPostRequestBodyContentApplicationJsonSchemaDynamicVariablesVariant3?.Invoke(AgentsPostRequestBodyContentApplicationJsonSchemaDynamicVariablesVariant3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AgentsPostRequestBodyContentApplicationJsonSchemaDynamicVariablesVariant1,
                typeof(string),
                AgentsPostRequestBodyContentApplicationJsonSchemaDynamicVariablesVariant2,
                typeof(double),
                AgentsPostRequestBodyContentApplicationJsonSchemaDynamicVariablesVariant3,
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
        public bool Equals(AgentsPostRequestBodyContentApplicationJsonSchemaDynamicVariables other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(AgentsPostRequestBodyContentApplicationJsonSchemaDynamicVariablesVariant1, other.AgentsPostRequestBodyContentApplicationJsonSchemaDynamicVariablesVariant1) &&
                global::System.Collections.Generic.EqualityComparer<double?>.Default.Equals(AgentsPostRequestBodyContentApplicationJsonSchemaDynamicVariablesVariant2, other.AgentsPostRequestBodyContentApplicationJsonSchemaDynamicVariablesVariant2) &&
                global::System.Collections.Generic.EqualityComparer<bool?>.Default.Equals(AgentsPostRequestBodyContentApplicationJsonSchemaDynamicVariablesVariant3, other.AgentsPostRequestBodyContentApplicationJsonSchemaDynamicVariablesVariant3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AgentsPostRequestBodyContentApplicationJsonSchemaDynamicVariables obj1, AgentsPostRequestBodyContentApplicationJsonSchemaDynamicVariables obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AgentsPostRequestBodyContentApplicationJsonSchemaDynamicVariables>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AgentsPostRequestBodyContentApplicationJsonSchemaDynamicVariables obj1, AgentsPostRequestBodyContentApplicationJsonSchemaDynamicVariables obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AgentsPostRequestBodyContentApplicationJsonSchemaDynamicVariables o && Equals(o);
        }
    }
}
