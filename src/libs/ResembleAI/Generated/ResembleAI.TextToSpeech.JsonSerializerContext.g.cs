
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.Error))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SynthesizePostRequestBodyContentApplicationJsonSchemaPrecision), TypeInfoPropertyName = "SynthesizePostRequestBodyContentApplicationJsonSchemaPrecision2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SynthesizePostRequestBodyContentApplicationJsonSchemaOutputFormat), TypeInfoPropertyName = "SynthesizePostRequestBodyContentApplicationJsonSchemaOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SynthesizePostRequestBodyContentApplicationJsonSchemaSampleRate), TypeInfoPropertyName = "SynthesizePostRequestBodyContentApplicationJsonSchemaSampleRate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.AudioTimestamps))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.TextToSpeechSynthesizeResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.StreamPostRequestBodyContentApplicationJsonSchemaPrecision), TypeInfoPropertyName = "StreamPostRequestBodyContentApplicationJsonSchemaPrecision2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.StreamPostRequestBodyContentApplicationJsonSchemaSampleRate), TypeInfoPropertyName = "StreamPostRequestBodyContentApplicationJsonSchemaSampleRate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SynthesizeRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.StreamSynthesizeRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SynthesizePostRequestBodyContentApplicationJsonSchemaPrecision?), TypeInfoPropertyName = "NullableSynthesizePostRequestBodyContentApplicationJsonSchemaPrecision2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SynthesizePostRequestBodyContentApplicationJsonSchemaOutputFormat?), TypeInfoPropertyName = "NullableSynthesizePostRequestBodyContentApplicationJsonSchemaOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.SynthesizePostRequestBodyContentApplicationJsonSchemaSampleRate?), TypeInfoPropertyName = "NullableSynthesizePostRequestBodyContentApplicationJsonSchemaSampleRate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.StreamPostRequestBodyContentApplicationJsonSchemaPrecision?), TypeInfoPropertyName = "NullableStreamPostRequestBodyContentApplicationJsonSchemaPrecision2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.StreamPostRequestBodyContentApplicationJsonSchemaSampleRate?), TypeInfoPropertyName = "NullableStreamPostRequestBodyContentApplicationJsonSchemaSampleRate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<double>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    internal sealed partial class TextToSpeechSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TextToSpeechSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static TextToSpeechSourceGenerationContext Default { get; } = new(DefaultOptions);

        private TextToSpeechSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::ResembleAI.SynthesizePostRequestBodyContentApplicationJsonSchemaPrecision)

                    || typeToConvert == typeof(global::ResembleAI.SynthesizePostRequestBodyContentApplicationJsonSchemaPrecision?)

                    || typeToConvert == typeof(global::ResembleAI.SynthesizePostRequestBodyContentApplicationJsonSchemaOutputFormat)

                    || typeToConvert == typeof(global::ResembleAI.SynthesizePostRequestBodyContentApplicationJsonSchemaOutputFormat?)

                    || typeToConvert == typeof(global::ResembleAI.SynthesizePostRequestBodyContentApplicationJsonSchemaSampleRate)

                    || typeToConvert == typeof(global::ResembleAI.SynthesizePostRequestBodyContentApplicationJsonSchemaSampleRate?)

                    || typeToConvert == typeof(global::ResembleAI.StreamPostRequestBodyContentApplicationJsonSchemaPrecision)

                    || typeToConvert == typeof(global::ResembleAI.StreamPostRequestBodyContentApplicationJsonSchemaPrecision?)

                    || typeToConvert == typeof(global::ResembleAI.StreamPostRequestBodyContentApplicationJsonSchemaSampleRate)

                    || typeToConvert == typeof(global::ResembleAI.StreamPostRequestBodyContentApplicationJsonSchemaSampleRate?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::ResembleAI.SynthesizePostRequestBodyContentApplicationJsonSchemaPrecision))
                {
                    return new global::ResembleAI.JsonConverters.SynthesizePostRequestBodyContentApplicationJsonSchemaPrecisionJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.SynthesizePostRequestBodyContentApplicationJsonSchemaPrecision?))
                {
                    return new global::ResembleAI.JsonConverters.SynthesizePostRequestBodyContentApplicationJsonSchemaPrecisionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.SynthesizePostRequestBodyContentApplicationJsonSchemaOutputFormat))
                {
                    return new global::ResembleAI.JsonConverters.SynthesizePostRequestBodyContentApplicationJsonSchemaOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.SynthesizePostRequestBodyContentApplicationJsonSchemaOutputFormat?))
                {
                    return new global::ResembleAI.JsonConverters.SynthesizePostRequestBodyContentApplicationJsonSchemaOutputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.SynthesizePostRequestBodyContentApplicationJsonSchemaSampleRate))
                {
                    return new global::ResembleAI.JsonConverters.SynthesizePostRequestBodyContentApplicationJsonSchemaSampleRateJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.SynthesizePostRequestBodyContentApplicationJsonSchemaSampleRate?))
                {
                    return new global::ResembleAI.JsonConverters.SynthesizePostRequestBodyContentApplicationJsonSchemaSampleRateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.StreamPostRequestBodyContentApplicationJsonSchemaPrecision))
                {
                    return new global::ResembleAI.JsonConverters.StreamPostRequestBodyContentApplicationJsonSchemaPrecisionJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.StreamPostRequestBodyContentApplicationJsonSchemaPrecision?))
                {
                    return new global::ResembleAI.JsonConverters.StreamPostRequestBodyContentApplicationJsonSchemaPrecisionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.StreamPostRequestBodyContentApplicationJsonSchemaSampleRate))
                {
                    return new global::ResembleAI.JsonConverters.StreamPostRequestBodyContentApplicationJsonSchemaSampleRateJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.StreamPostRequestBodyContentApplicationJsonSchemaSampleRate?))
                {
                    return new global::ResembleAI.JsonConverters.StreamPostRequestBodyContentApplicationJsonSchemaSampleRateNullableJsonConverter();
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
                    0 => new TextToSpeechSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}