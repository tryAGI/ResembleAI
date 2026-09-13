
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.Error))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IntelligencePostRequestBodyContentApplicationJsonSchemaMediaType), TypeInfoPropertyName = "IntelligencePostRequestBodyContentApplicationJsonSchemaMediaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IntelligencePostResponsesContentApplicationJsonSchemaItemMediaType), TypeInfoPropertyName = "IntelligencePostResponsesContentApplicationJsonSchemaItemMediaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IntelligencePostResponsesContentApplicationJsonSchemaItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IntelligenceRunIntelligenceResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescriptionFraudType), TypeInfoPropertyName = "IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescriptionFraudType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescriptionFraud))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescriptionLivenessAssessment), TypeInfoPropertyName = "IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescriptionLivenessAssessment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescriptionLiveness))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescriptionDigitallyAltered))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescription))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsMediaType), TypeInfoPropertyName = "IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsMediaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IntelligencesGetResponsesContentApplicationJsonSchemaItemsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IntelligenceListIntelligencesResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ResembleAI.IntelligencesGetResponsesContentApplicationJsonSchemaItemsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemDescriptionFraudType), TypeInfoPropertyName = "IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemDescriptionFraudType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemDescriptionFraud))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemDescriptionLivenessAssessment), TypeInfoPropertyName = "IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemDescriptionLivenessAssessment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemDescriptionLiveness))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemDescriptionDigitallyAltered))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemDescription))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemMediaType), TypeInfoPropertyName = "IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemMediaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IntelligencesUuidGetResponsesContentApplicationJsonSchemaItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IntelligenceGetIntelligenceResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.RunIntelligenceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IntelligencePostRequestBodyContentApplicationJsonSchemaMediaType?), TypeInfoPropertyName = "NullableIntelligencePostRequestBodyContentApplicationJsonSchemaMediaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IntelligencePostResponsesContentApplicationJsonSchemaItemMediaType?), TypeInfoPropertyName = "NullableIntelligencePostResponsesContentApplicationJsonSchemaItemMediaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescriptionFraudType?), TypeInfoPropertyName = "NullableIntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescriptionFraudType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescriptionLivenessAssessment?), TypeInfoPropertyName = "NullableIntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescriptionLivenessAssessment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsMediaType?), TypeInfoPropertyName = "NullableIntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsMediaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemDescriptionFraudType?), TypeInfoPropertyName = "NullableIntelligencesUuidGetResponsesContentApplicationJsonSchemaItemDescriptionFraudType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemDescriptionLivenessAssessment?), TypeInfoPropertyName = "NullableIntelligencesUuidGetResponsesContentApplicationJsonSchemaItemDescriptionLivenessAssessment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemMediaType?), TypeInfoPropertyName = "NullableIntelligencesUuidGetResponsesContentApplicationJsonSchemaItemMediaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.IntelligencesGetResponsesContentApplicationJsonSchemaItemsItems>))]
    internal sealed partial class IntelligenceSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class IntelligenceSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static IntelligenceSourceGenerationContext Default { get; } = new(DefaultOptions);

        private IntelligenceSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::ResembleAI.IntelligencePostRequestBodyContentApplicationJsonSchemaMediaType)

                    || typeToConvert == typeof(global::ResembleAI.IntelligencePostRequestBodyContentApplicationJsonSchemaMediaType?)

                    || typeToConvert == typeof(global::ResembleAI.IntelligencePostResponsesContentApplicationJsonSchemaItemMediaType)

                    || typeToConvert == typeof(global::ResembleAI.IntelligencePostResponsesContentApplicationJsonSchemaItemMediaType?)

                    || typeToConvert == typeof(global::ResembleAI.IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescriptionFraudType)

                    || typeToConvert == typeof(global::ResembleAI.IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescriptionFraudType?)

                    || typeToConvert == typeof(global::ResembleAI.IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescriptionLivenessAssessment)

                    || typeToConvert == typeof(global::ResembleAI.IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescriptionLivenessAssessment?)

                    || typeToConvert == typeof(global::ResembleAI.IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsMediaType)

                    || typeToConvert == typeof(global::ResembleAI.IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsMediaType?)

                    || typeToConvert == typeof(global::ResembleAI.IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemDescriptionFraudType)

                    || typeToConvert == typeof(global::ResembleAI.IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemDescriptionFraudType?)

                    || typeToConvert == typeof(global::ResembleAI.IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemDescriptionLivenessAssessment)

                    || typeToConvert == typeof(global::ResembleAI.IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemDescriptionLivenessAssessment?)

                    || typeToConvert == typeof(global::ResembleAI.IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemMediaType)

                    || typeToConvert == typeof(global::ResembleAI.IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemMediaType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::ResembleAI.IntelligencePostRequestBodyContentApplicationJsonSchemaMediaType))
                {
                    return new global::ResembleAI.JsonConverters.IntelligencePostRequestBodyContentApplicationJsonSchemaMediaTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.IntelligencePostRequestBodyContentApplicationJsonSchemaMediaType?))
                {
                    return new global::ResembleAI.JsonConverters.IntelligencePostRequestBodyContentApplicationJsonSchemaMediaTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.IntelligencePostResponsesContentApplicationJsonSchemaItemMediaType))
                {
                    return new global::ResembleAI.JsonConverters.IntelligencePostResponsesContentApplicationJsonSchemaItemMediaTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.IntelligencePostResponsesContentApplicationJsonSchemaItemMediaType?))
                {
                    return new global::ResembleAI.JsonConverters.IntelligencePostResponsesContentApplicationJsonSchemaItemMediaTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescriptionFraudType))
                {
                    return new global::ResembleAI.JsonConverters.IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescriptionFraudTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescriptionFraudType?))
                {
                    return new global::ResembleAI.JsonConverters.IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescriptionFraudTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescriptionLivenessAssessment))
                {
                    return new global::ResembleAI.JsonConverters.IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescriptionLivenessAssessmentJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescriptionLivenessAssessment?))
                {
                    return new global::ResembleAI.JsonConverters.IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsDescriptionLivenessAssessmentNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsMediaType))
                {
                    return new global::ResembleAI.JsonConverters.IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsMediaTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsMediaType?))
                {
                    return new global::ResembleAI.JsonConverters.IntelligencesGetResponsesContentApplicationJsonSchemaItemsItemsMediaTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemDescriptionFraudType))
                {
                    return new global::ResembleAI.JsonConverters.IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemDescriptionFraudTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemDescriptionFraudType?))
                {
                    return new global::ResembleAI.JsonConverters.IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemDescriptionFraudTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemDescriptionLivenessAssessment))
                {
                    return new global::ResembleAI.JsonConverters.IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemDescriptionLivenessAssessmentJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemDescriptionLivenessAssessment?))
                {
                    return new global::ResembleAI.JsonConverters.IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemDescriptionLivenessAssessmentNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemMediaType))
                {
                    return new global::ResembleAI.JsonConverters.IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemMediaTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemMediaType?))
                {
                    return new global::ResembleAI.JsonConverters.IntelligencesUuidGetResponsesContentApplicationJsonSchemaItemMediaTypeNullableJsonConverter();
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
                    0 => new IntelligenceSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}