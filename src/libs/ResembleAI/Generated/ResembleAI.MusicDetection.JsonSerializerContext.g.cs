
#nullable enable

namespace ResembleAI
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
    )]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.Error))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectMusicPostParametersPrefer), TypeInfoPropertyName = "DetectMusicPostParametersPrefer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.MusicDetectItemStatus), TypeInfoPropertyName = "MusicDetectItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.MusicDetectItemMediaType), TypeInfoPropertyName = "MusicDetectItemMediaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.MusicDetectMetricsLabel), TypeInfoPropertyName = "MusicDetectMetricsLabel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.MusicDetectMetrics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.MusicDetectItemExtraParamsDetector), TypeInfoPropertyName = "MusicDetectItemExtraParamsDetector2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.MusicDetectItemExtraParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.MusicDetectItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.MusicDetectResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.CreateMusicDetectionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.DetectMusicPostParametersPrefer?), TypeInfoPropertyName = "NullableDetectMusicPostParametersPrefer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.MusicDetectItemStatus?), TypeInfoPropertyName = "NullableMusicDetectItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.MusicDetectItemMediaType?), TypeInfoPropertyName = "NullableMusicDetectItemMediaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.MusicDetectMetricsLabel?), TypeInfoPropertyName = "NullableMusicDetectMetricsLabel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.MusicDetectItemExtraParamsDetector?), TypeInfoPropertyName = "NullableMusicDetectItemExtraParamsDetector2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    internal sealed partial class MusicDetectionSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class MusicDetectionSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static MusicDetectionSourceGenerationContext Default { get; } = new(DefaultOptions);

        private MusicDetectionSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::ResembleAI.DetectMusicPostParametersPrefer)

                    || typeToConvert == typeof(global::ResembleAI.DetectMusicPostParametersPrefer?)

                    || typeToConvert == typeof(global::ResembleAI.MusicDetectItemStatus)

                    || typeToConvert == typeof(global::ResembleAI.MusicDetectItemStatus?)

                    || typeToConvert == typeof(global::ResembleAI.MusicDetectItemMediaType)

                    || typeToConvert == typeof(global::ResembleAI.MusicDetectItemMediaType?)

                    || typeToConvert == typeof(global::ResembleAI.MusicDetectMetricsLabel)

                    || typeToConvert == typeof(global::ResembleAI.MusicDetectMetricsLabel?)

                    || typeToConvert == typeof(global::ResembleAI.MusicDetectItemExtraParamsDetector)

                    || typeToConvert == typeof(global::ResembleAI.MusicDetectItemExtraParamsDetector?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::ResembleAI.DetectMusicPostParametersPrefer))
                {
                    return new global::ResembleAI.JsonConverters.DetectMusicPostParametersPreferJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.DetectMusicPostParametersPrefer?))
                {
                    return new global::ResembleAI.JsonConverters.DetectMusicPostParametersPreferNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.MusicDetectItemStatus))
                {
                    return new global::ResembleAI.JsonConverters.MusicDetectItemStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.MusicDetectItemStatus?))
                {
                    return new global::ResembleAI.JsonConverters.MusicDetectItemStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.MusicDetectItemMediaType))
                {
                    return new global::ResembleAI.JsonConverters.MusicDetectItemMediaTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.MusicDetectItemMediaType?))
                {
                    return new global::ResembleAI.JsonConverters.MusicDetectItemMediaTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.MusicDetectMetricsLabel))
                {
                    return new global::ResembleAI.JsonConverters.MusicDetectMetricsLabelJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.MusicDetectMetricsLabel?))
                {
                    return new global::ResembleAI.JsonConverters.MusicDetectMetricsLabelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.MusicDetectItemExtraParamsDetector))
                {
                    return new global::ResembleAI.JsonConverters.MusicDetectItemExtraParamsDetectorJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.MusicDetectItemExtraParamsDetector?))
                {
                    return new global::ResembleAI.JsonConverters.MusicDetectItemExtraParamsDetectorNullableJsonConverter();
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
                    0 => new MusicDetectionSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}