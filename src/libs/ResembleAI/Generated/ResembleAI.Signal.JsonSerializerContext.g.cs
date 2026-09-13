
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace ResembleAI
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SignalSubmissionInputModality), TypeInfoPropertyName = "SignalSubmissionInputModality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SignalSubmissionVerdict), TypeInfoPropertyName = "SignalSubmissionVerdict2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SignalCategoryScore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SignalScoreItemInputModality), TypeInfoPropertyName = "SignalScoreItemInputModality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SignalScoreItemVerdict), TypeInfoPropertyName = "SignalScoreItemVerdict2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SignalTopMatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SignalScoreItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ResembleAI.SignalCategoryScore>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ResembleAI.SignalTopMatch>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SignalSubmission))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SignalSubmissionListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ResembleAI.SignalSubmission>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SignalError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SignalScoreResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SignalSuccessResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SignalSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SignalBuiltInCategory))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SignalCustomCategoryStatus), TypeInfoPropertyName = "SignalCustomCategoryStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SignalCustomCategoryOverlapsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SignalScenario))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SignalCustomCategory))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ResembleAI.SignalCustomCategoryOverlapsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ResembleAI.SignalScenario>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SignalCalibrationWarningsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SignalCalibration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ResembleAI.SignalCalibrationWarningsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SignalCustomCategoryListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ResembleAI.SignalBuiltInCategory>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ResembleAI.SignalCustomCategory>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SignalCustomCategoryCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SignalCustomCategoryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SignalCustomCategoryUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SignalSettingsUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SignalSettingsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.CreateSignalSubmissionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SignalSubmissionInputModality?), TypeInfoPropertyName = "NullableSignalSubmissionInputModality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SignalSubmissionVerdict?), TypeInfoPropertyName = "NullableSignalSubmissionVerdict2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SignalScoreItemInputModality?), TypeInfoPropertyName = "NullableSignalScoreItemInputModality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SignalScoreItemVerdict?), TypeInfoPropertyName = "NullableSignalScoreItemVerdict2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SignalCustomCategoryStatus?), TypeInfoPropertyName = "NullableSignalCustomCategoryStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.SignalCategoryScore>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.SignalTopMatch>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.SignalSubmission>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.SignalCustomCategoryOverlapsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.SignalScenario>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.SignalCalibrationWarningsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.SignalBuiltInCategory>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.SignalCustomCategory>))]
    internal sealed partial class SignalSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SignalSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SignalSourceGenerationContext Default { get; } = new(DefaultOptions);

        private SignalSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::ResembleAI.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::ResembleAI.SignalSubmissionInputModality)

                    || typeToConvert == typeof(global::ResembleAI.SignalSubmissionInputModality?)

                    || typeToConvert == typeof(global::ResembleAI.SignalSubmissionVerdict)

                    || typeToConvert == typeof(global::ResembleAI.SignalSubmissionVerdict?)

                    || typeToConvert == typeof(global::ResembleAI.SignalScoreItemInputModality)

                    || typeToConvert == typeof(global::ResembleAI.SignalScoreItemInputModality?)

                    || typeToConvert == typeof(global::ResembleAI.SignalScoreItemVerdict)

                    || typeToConvert == typeof(global::ResembleAI.SignalScoreItemVerdict?)

                    || typeToConvert == typeof(global::ResembleAI.SignalCustomCategoryStatus)

                    || typeToConvert == typeof(global::ResembleAI.SignalCustomCategoryStatus?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::ResembleAI.SignalSubmissionInputModality))
                {
                    return new global::ResembleAI.JsonConverters.SignalSubmissionInputModalityJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.SignalSubmissionInputModality?))
                {
                    return new global::ResembleAI.JsonConverters.SignalSubmissionInputModalityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.SignalSubmissionVerdict))
                {
                    return new global::ResembleAI.JsonConverters.SignalSubmissionVerdictJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.SignalSubmissionVerdict?))
                {
                    return new global::ResembleAI.JsonConverters.SignalSubmissionVerdictNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.SignalScoreItemInputModality))
                {
                    return new global::ResembleAI.JsonConverters.SignalScoreItemInputModalityJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.SignalScoreItemInputModality?))
                {
                    return new global::ResembleAI.JsonConverters.SignalScoreItemInputModalityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.SignalScoreItemVerdict))
                {
                    return new global::ResembleAI.JsonConverters.SignalScoreItemVerdictJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.SignalScoreItemVerdict?))
                {
                    return new global::ResembleAI.JsonConverters.SignalScoreItemVerdictNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.SignalCustomCategoryStatus))
                {
                    return new global::ResembleAI.JsonConverters.SignalCustomCategoryStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.SignalCustomCategoryStatus?))
                {
                    return new global::ResembleAI.JsonConverters.SignalCustomCategoryStatusNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new SignalSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}