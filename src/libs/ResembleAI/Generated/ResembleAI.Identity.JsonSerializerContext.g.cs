
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IdentitySummaryVisibility), TypeInfoPropertyName = "IdentitySummaryVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IdentitySummaryIdentityType), TypeInfoPropertyName = "IdentitySummaryIdentityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IdentitySummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IdentityListIdentitiesResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ResembleAI.IdentitySummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IdentityCreateIdentityRequest0))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IdentityPostRequestBodyContentApplicationJsonSchemaOneOf1IdentityIdentityType), TypeInfoPropertyName = "IdentityPostRequestBodyContentApplicationJsonSchemaOneOf1IdentityIdentityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IdentityPostRequestBodyContentApplicationJsonSchemaOneOf1IdentityVisibility), TypeInfoPropertyName = "IdentityPostRequestBodyContentApplicationJsonSchemaOneOf1IdentityVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IdentityPostRequestBodyContentApplicationJsonSchemaOneOf1Identity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IdentityCreateIdentityRequest1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IdentityCreateIdentityRequest), TypeInfoPropertyName = "IdentityCreateIdentityRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IdentityCreateIdentityResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IdentityDeleteIdentityResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IdentityUuidAttachmentsPostRequestBodyContentMultipartFormDataSchemaModality), TypeInfoPropertyName = "IdentityUuidAttachmentsPostRequestBodyContentMultipartFormDataSchemaModality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IdentityIdentityType), TypeInfoPropertyName = "IdentityIdentityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IdentityVisibility), TypeInfoPropertyName = "IdentityVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IdentityAttachment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IdentityEmbeddingsItemsModality), TypeInfoPropertyName = "IdentityEmbeddingsItemsModality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IdentityEmbeddingsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IdentityProjectsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.Identity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ResembleAI.IdentityAttachment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ResembleAI.IdentityEmbeddingsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ResembleAI.IdentityProjectsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IdentityDeleteIdentityAttachmentResponse204))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IdentitySearchPostRequestBodyContentApplicationJsonSchemaModality), TypeInfoPropertyName = "IdentitySearchPostRequestBodyContentApplicationJsonSchemaModality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IdentitySearchPostResponsesContentApplicationJsonSchemaModality), TypeInfoPropertyName = "IdentitySearchPostResponsesContentApplicationJsonSchemaModality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IdentitySearchPostResponsesContentApplicationJsonSchemaItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IdentitySearchIdentitiesResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::ResembleAI.IdentitySearchPostResponsesContentApplicationJsonSchemaItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.CreateIdentityAttachmentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SearchIdentitiesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IdentitySummaryVisibility?), TypeInfoPropertyName = "NullableIdentitySummaryVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IdentitySummaryIdentityType?), TypeInfoPropertyName = "NullableIdentitySummaryIdentityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IdentityPostRequestBodyContentApplicationJsonSchemaOneOf1IdentityIdentityType?), TypeInfoPropertyName = "NullableIdentityPostRequestBodyContentApplicationJsonSchemaOneOf1IdentityIdentityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IdentityPostRequestBodyContentApplicationJsonSchemaOneOf1IdentityVisibility?), TypeInfoPropertyName = "NullableIdentityPostRequestBodyContentApplicationJsonSchemaOneOf1IdentityVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IdentityCreateIdentityRequest?), TypeInfoPropertyName = "NullableIdentityCreateIdentityRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IdentityUuidAttachmentsPostRequestBodyContentMultipartFormDataSchemaModality?), TypeInfoPropertyName = "NullableIdentityUuidAttachmentsPostRequestBodyContentMultipartFormDataSchemaModality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IdentityIdentityType?), TypeInfoPropertyName = "NullableIdentityIdentityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IdentityVisibility?), TypeInfoPropertyName = "NullableIdentityVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IdentityEmbeddingsItemsModality?), TypeInfoPropertyName = "NullableIdentityEmbeddingsItemsModality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IdentitySearchPostRequestBodyContentApplicationJsonSchemaModality?), TypeInfoPropertyName = "NullableIdentitySearchPostRequestBodyContentApplicationJsonSchemaModality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.IdentitySearchPostResponsesContentApplicationJsonSchemaModality?), TypeInfoPropertyName = "NullableIdentitySearchPostResponsesContentApplicationJsonSchemaModality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.IdentitySummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.IdentityAttachment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.IdentityEmbeddingsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.IdentityProjectsItems>))]
    internal sealed partial class IdentitySourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class IdentitySourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static IdentitySourceGenerationContext Default { get; } = new(DefaultOptions);

        private IdentitySourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::ResembleAI.JsonConverters.IdentityCreateIdentityRequestJsonConverter());
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
                    typeToConvert == typeof(global::ResembleAI.IdentitySummaryVisibility)

                    || typeToConvert == typeof(global::ResembleAI.IdentitySummaryVisibility?)

                    || typeToConvert == typeof(global::ResembleAI.IdentitySummaryIdentityType)

                    || typeToConvert == typeof(global::ResembleAI.IdentitySummaryIdentityType?)

                    || typeToConvert == typeof(global::ResembleAI.IdentityPostRequestBodyContentApplicationJsonSchemaOneOf1IdentityIdentityType)

                    || typeToConvert == typeof(global::ResembleAI.IdentityPostRequestBodyContentApplicationJsonSchemaOneOf1IdentityIdentityType?)

                    || typeToConvert == typeof(global::ResembleAI.IdentityPostRequestBodyContentApplicationJsonSchemaOneOf1IdentityVisibility)

                    || typeToConvert == typeof(global::ResembleAI.IdentityPostRequestBodyContentApplicationJsonSchemaOneOf1IdentityVisibility?)

                    || typeToConvert == typeof(global::ResembleAI.IdentityUuidAttachmentsPostRequestBodyContentMultipartFormDataSchemaModality)

                    || typeToConvert == typeof(global::ResembleAI.IdentityUuidAttachmentsPostRequestBodyContentMultipartFormDataSchemaModality?)

                    || typeToConvert == typeof(global::ResembleAI.IdentityIdentityType)

                    || typeToConvert == typeof(global::ResembleAI.IdentityIdentityType?)

                    || typeToConvert == typeof(global::ResembleAI.IdentityVisibility)

                    || typeToConvert == typeof(global::ResembleAI.IdentityVisibility?)

                    || typeToConvert == typeof(global::ResembleAI.IdentityEmbeddingsItemsModality)

                    || typeToConvert == typeof(global::ResembleAI.IdentityEmbeddingsItemsModality?)

                    || typeToConvert == typeof(global::ResembleAI.IdentitySearchPostRequestBodyContentApplicationJsonSchemaModality)

                    || typeToConvert == typeof(global::ResembleAI.IdentitySearchPostRequestBodyContentApplicationJsonSchemaModality?)

                    || typeToConvert == typeof(global::ResembleAI.IdentitySearchPostResponsesContentApplicationJsonSchemaModality)

                    || typeToConvert == typeof(global::ResembleAI.IdentitySearchPostResponsesContentApplicationJsonSchemaModality?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::ResembleAI.IdentitySummaryVisibility))
                {
                    return new global::ResembleAI.JsonConverters.IdentitySummaryVisibilityJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.IdentitySummaryVisibility?))
                {
                    return new global::ResembleAI.JsonConverters.IdentitySummaryVisibilityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.IdentitySummaryIdentityType))
                {
                    return new global::ResembleAI.JsonConverters.IdentitySummaryIdentityTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.IdentitySummaryIdentityType?))
                {
                    return new global::ResembleAI.JsonConverters.IdentitySummaryIdentityTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.IdentityPostRequestBodyContentApplicationJsonSchemaOneOf1IdentityIdentityType))
                {
                    return new global::ResembleAI.JsonConverters.IdentityPostRequestBodyContentApplicationJsonSchemaOneOf1IdentityIdentityTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.IdentityPostRequestBodyContentApplicationJsonSchemaOneOf1IdentityIdentityType?))
                {
                    return new global::ResembleAI.JsonConverters.IdentityPostRequestBodyContentApplicationJsonSchemaOneOf1IdentityIdentityTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.IdentityPostRequestBodyContentApplicationJsonSchemaOneOf1IdentityVisibility))
                {
                    return new global::ResembleAI.JsonConverters.IdentityPostRequestBodyContentApplicationJsonSchemaOneOf1IdentityVisibilityJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.IdentityPostRequestBodyContentApplicationJsonSchemaOneOf1IdentityVisibility?))
                {
                    return new global::ResembleAI.JsonConverters.IdentityPostRequestBodyContentApplicationJsonSchemaOneOf1IdentityVisibilityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.IdentityUuidAttachmentsPostRequestBodyContentMultipartFormDataSchemaModality))
                {
                    return new global::ResembleAI.JsonConverters.IdentityUuidAttachmentsPostRequestBodyContentMultipartFormDataSchemaModalityJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.IdentityUuidAttachmentsPostRequestBodyContentMultipartFormDataSchemaModality?))
                {
                    return new global::ResembleAI.JsonConverters.IdentityUuidAttachmentsPostRequestBodyContentMultipartFormDataSchemaModalityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.IdentityIdentityType))
                {
                    return new global::ResembleAI.JsonConverters.IdentityIdentityTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.IdentityIdentityType?))
                {
                    return new global::ResembleAI.JsonConverters.IdentityIdentityTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.IdentityVisibility))
                {
                    return new global::ResembleAI.JsonConverters.IdentityVisibilityJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.IdentityVisibility?))
                {
                    return new global::ResembleAI.JsonConverters.IdentityVisibilityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.IdentityEmbeddingsItemsModality))
                {
                    return new global::ResembleAI.JsonConverters.IdentityEmbeddingsItemsModalityJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.IdentityEmbeddingsItemsModality?))
                {
                    return new global::ResembleAI.JsonConverters.IdentityEmbeddingsItemsModalityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.IdentitySearchPostRequestBodyContentApplicationJsonSchemaModality))
                {
                    return new global::ResembleAI.JsonConverters.IdentitySearchPostRequestBodyContentApplicationJsonSchemaModalityJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.IdentitySearchPostRequestBodyContentApplicationJsonSchemaModality?))
                {
                    return new global::ResembleAI.JsonConverters.IdentitySearchPostRequestBodyContentApplicationJsonSchemaModalityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.IdentitySearchPostResponsesContentApplicationJsonSchemaModality))
                {
                    return new global::ResembleAI.JsonConverters.IdentitySearchPostResponsesContentApplicationJsonSchemaModalityJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.IdentitySearchPostResponsesContentApplicationJsonSchemaModality?))
                {
                    return new global::ResembleAI.JsonConverters.IdentitySearchPostResponsesContentApplicationJsonSchemaModalityNullableJsonConverter();
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
                    0 => new IdentitySourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}