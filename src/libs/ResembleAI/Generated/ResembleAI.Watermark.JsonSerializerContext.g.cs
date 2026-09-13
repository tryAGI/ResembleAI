
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkAudioDetectionMetricsOverallStatus), TypeInfoPropertyName = "WatermarkAudioDetectionMetricsOverallStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkAudioDetectionMetricsDetectedModelVersionsItems), TypeInfoPropertyName = "WatermarkAudioDetectionMetricsDetectedModelVersionsItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkAudioModelResultModelVersion), TypeInfoPropertyName = "WatermarkAudioModelResultModelVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkAudioModelResultStatus), TypeInfoPropertyName = "WatermarkAudioModelResultStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkAudioModelResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, bool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkAudioDetectionMetrics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ResembleAI.WatermarkAudioDetectionMetricsDetectedModelVersionsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ResembleAI.WatermarkAudioModelResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkVisionDetectionMetricsOverallStatus), TypeInfoPropertyName = "WatermarkVisionDetectionMetricsOverallStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkVisionDetectionMetricsDetectedModelVersionsItems), TypeInfoPropertyName = "WatermarkVisionDetectionMetricsDetectedModelVersionsItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkVisionModelResultModelVersion), TypeInfoPropertyName = "WatermarkVisionModelResultModelVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkVisionModelResultStatus), TypeInfoPropertyName = "WatermarkVisionModelResultStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkVisionModelResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkVisionDetectionMetricsVerdict), TypeInfoPropertyName = "WatermarkVisionDetectionMetricsVerdict2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkVisionDetectionMetrics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ResembleAI.WatermarkVisionDetectionMetricsDetectedModelVersionsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ResembleAI.WatermarkVisionModelResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkApplyPostParametersPrefer), TypeInfoPropertyName = "WatermarkApplyPostParametersPrefer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkApplyRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkApplyItemMediaType), TypeInfoPropertyName = "WatermarkApplyItemMediaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkApplyItemOperationType), TypeInfoPropertyName = "WatermarkApplyItemOperationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkApplyItemStatus), TypeInfoPropertyName = "WatermarkApplyItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkApplyItemModelVersion), TypeInfoPropertyName = "WatermarkApplyItemModelVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkApplyMetrics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkApplyItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkApplyResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkDetectPostParametersPrefer), TypeInfoPropertyName = "WatermarkDetectPostParametersPrefer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkDetectRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkDetectItemMediaType), TypeInfoPropertyName = "WatermarkDetectItemMediaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkDetectItemOperationType), TypeInfoPropertyName = "WatermarkDetectItemOperationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkDetectItemStatus), TypeInfoPropertyName = "WatermarkDetectItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkDetectItemModelVersion), TypeInfoPropertyName = "WatermarkDetectItemModelVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkDetectItemMetrics), TypeInfoPropertyName = "WatermarkDetectItemMetrics2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkDetectItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkDetectResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkAudioDetectionMetricsOverallStatus?), TypeInfoPropertyName = "NullableWatermarkAudioDetectionMetricsOverallStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkAudioDetectionMetricsDetectedModelVersionsItems?), TypeInfoPropertyName = "NullableWatermarkAudioDetectionMetricsDetectedModelVersionsItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkAudioModelResultModelVersion?), TypeInfoPropertyName = "NullableWatermarkAudioModelResultModelVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkAudioModelResultStatus?), TypeInfoPropertyName = "NullableWatermarkAudioModelResultStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkVisionDetectionMetricsOverallStatus?), TypeInfoPropertyName = "NullableWatermarkVisionDetectionMetricsOverallStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkVisionDetectionMetricsDetectedModelVersionsItems?), TypeInfoPropertyName = "NullableWatermarkVisionDetectionMetricsDetectedModelVersionsItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkVisionModelResultModelVersion?), TypeInfoPropertyName = "NullableWatermarkVisionModelResultModelVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkVisionModelResultStatus?), TypeInfoPropertyName = "NullableWatermarkVisionModelResultStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkVisionDetectionMetricsVerdict?), TypeInfoPropertyName = "NullableWatermarkVisionDetectionMetricsVerdict2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkApplyPostParametersPrefer?), TypeInfoPropertyName = "NullableWatermarkApplyPostParametersPrefer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkApplyItemMediaType?), TypeInfoPropertyName = "NullableWatermarkApplyItemMediaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkApplyItemOperationType?), TypeInfoPropertyName = "NullableWatermarkApplyItemOperationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkApplyItemStatus?), TypeInfoPropertyName = "NullableWatermarkApplyItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkApplyItemModelVersion?), TypeInfoPropertyName = "NullableWatermarkApplyItemModelVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkDetectPostParametersPrefer?), TypeInfoPropertyName = "NullableWatermarkDetectPostParametersPrefer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkDetectItemMediaType?), TypeInfoPropertyName = "NullableWatermarkDetectItemMediaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkDetectItemOperationType?), TypeInfoPropertyName = "NullableWatermarkDetectItemOperationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkDetectItemStatus?), TypeInfoPropertyName = "NullableWatermarkDetectItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkDetectItemModelVersion?), TypeInfoPropertyName = "NullableWatermarkDetectItemModelVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ResembleAI.WatermarkDetectItemMetrics?), TypeInfoPropertyName = "NullableWatermarkDetectItemMetrics2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.WatermarkAudioDetectionMetricsDetectedModelVersionsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.WatermarkAudioModelResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.WatermarkVisionDetectionMetricsDetectedModelVersionsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ResembleAI.WatermarkVisionModelResult>))]
    internal sealed partial class WatermarkSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WatermarkSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static WatermarkSourceGenerationContext Default { get; } = new(DefaultOptions);

        private WatermarkSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::ResembleAI.JsonConverters.WatermarkDetectItemMetricsJsonConverter());
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
                    typeToConvert == typeof(global::ResembleAI.WatermarkAudioDetectionMetricsOverallStatus)

                    || typeToConvert == typeof(global::ResembleAI.WatermarkAudioDetectionMetricsOverallStatus?)

                    || typeToConvert == typeof(global::ResembleAI.WatermarkAudioDetectionMetricsDetectedModelVersionsItems)

                    || typeToConvert == typeof(global::ResembleAI.WatermarkAudioDetectionMetricsDetectedModelVersionsItems?)

                    || typeToConvert == typeof(global::ResembleAI.WatermarkAudioModelResultModelVersion)

                    || typeToConvert == typeof(global::ResembleAI.WatermarkAudioModelResultModelVersion?)

                    || typeToConvert == typeof(global::ResembleAI.WatermarkAudioModelResultStatus)

                    || typeToConvert == typeof(global::ResembleAI.WatermarkAudioModelResultStatus?)

                    || typeToConvert == typeof(global::ResembleAI.WatermarkVisionDetectionMetricsOverallStatus)

                    || typeToConvert == typeof(global::ResembleAI.WatermarkVisionDetectionMetricsOverallStatus?)

                    || typeToConvert == typeof(global::ResembleAI.WatermarkVisionDetectionMetricsDetectedModelVersionsItems)

                    || typeToConvert == typeof(global::ResembleAI.WatermarkVisionDetectionMetricsDetectedModelVersionsItems?)

                    || typeToConvert == typeof(global::ResembleAI.WatermarkVisionModelResultModelVersion)

                    || typeToConvert == typeof(global::ResembleAI.WatermarkVisionModelResultModelVersion?)

                    || typeToConvert == typeof(global::ResembleAI.WatermarkVisionModelResultStatus)

                    || typeToConvert == typeof(global::ResembleAI.WatermarkVisionModelResultStatus?)

                    || typeToConvert == typeof(global::ResembleAI.WatermarkVisionDetectionMetricsVerdict)

                    || typeToConvert == typeof(global::ResembleAI.WatermarkVisionDetectionMetricsVerdict?)

                    || typeToConvert == typeof(global::ResembleAI.WatermarkApplyPostParametersPrefer)

                    || typeToConvert == typeof(global::ResembleAI.WatermarkApplyPostParametersPrefer?)

                    || typeToConvert == typeof(global::ResembleAI.WatermarkApplyItemMediaType)

                    || typeToConvert == typeof(global::ResembleAI.WatermarkApplyItemMediaType?)

                    || typeToConvert == typeof(global::ResembleAI.WatermarkApplyItemOperationType)

                    || typeToConvert == typeof(global::ResembleAI.WatermarkApplyItemOperationType?)

                    || typeToConvert == typeof(global::ResembleAI.WatermarkApplyItemStatus)

                    || typeToConvert == typeof(global::ResembleAI.WatermarkApplyItemStatus?)

                    || typeToConvert == typeof(global::ResembleAI.WatermarkApplyItemModelVersion)

                    || typeToConvert == typeof(global::ResembleAI.WatermarkApplyItemModelVersion?)

                    || typeToConvert == typeof(global::ResembleAI.WatermarkDetectPostParametersPrefer)

                    || typeToConvert == typeof(global::ResembleAI.WatermarkDetectPostParametersPrefer?)

                    || typeToConvert == typeof(global::ResembleAI.WatermarkDetectItemMediaType)

                    || typeToConvert == typeof(global::ResembleAI.WatermarkDetectItemMediaType?)

                    || typeToConvert == typeof(global::ResembleAI.WatermarkDetectItemOperationType)

                    || typeToConvert == typeof(global::ResembleAI.WatermarkDetectItemOperationType?)

                    || typeToConvert == typeof(global::ResembleAI.WatermarkDetectItemStatus)

                    || typeToConvert == typeof(global::ResembleAI.WatermarkDetectItemStatus?)

                    || typeToConvert == typeof(global::ResembleAI.WatermarkDetectItemModelVersion)

                    || typeToConvert == typeof(global::ResembleAI.WatermarkDetectItemModelVersion?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::ResembleAI.WatermarkAudioDetectionMetricsOverallStatus))
                {
                    return new global::ResembleAI.JsonConverters.WatermarkAudioDetectionMetricsOverallStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.WatermarkAudioDetectionMetricsOverallStatus?))
                {
                    return new global::ResembleAI.JsonConverters.WatermarkAudioDetectionMetricsOverallStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.WatermarkAudioDetectionMetricsDetectedModelVersionsItems))
                {
                    return new global::ResembleAI.JsonConverters.WatermarkAudioDetectionMetricsDetectedModelVersionsItemsJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.WatermarkAudioDetectionMetricsDetectedModelVersionsItems?))
                {
                    return new global::ResembleAI.JsonConverters.WatermarkAudioDetectionMetricsDetectedModelVersionsItemsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.WatermarkAudioModelResultModelVersion))
                {
                    return new global::ResembleAI.JsonConverters.WatermarkAudioModelResultModelVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.WatermarkAudioModelResultModelVersion?))
                {
                    return new global::ResembleAI.JsonConverters.WatermarkAudioModelResultModelVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.WatermarkAudioModelResultStatus))
                {
                    return new global::ResembleAI.JsonConverters.WatermarkAudioModelResultStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.WatermarkAudioModelResultStatus?))
                {
                    return new global::ResembleAI.JsonConverters.WatermarkAudioModelResultStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.WatermarkVisionDetectionMetricsOverallStatus))
                {
                    return new global::ResembleAI.JsonConverters.WatermarkVisionDetectionMetricsOverallStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.WatermarkVisionDetectionMetricsOverallStatus?))
                {
                    return new global::ResembleAI.JsonConverters.WatermarkVisionDetectionMetricsOverallStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.WatermarkVisionDetectionMetricsDetectedModelVersionsItems))
                {
                    return new global::ResembleAI.JsonConverters.WatermarkVisionDetectionMetricsDetectedModelVersionsItemsJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.WatermarkVisionDetectionMetricsDetectedModelVersionsItems?))
                {
                    return new global::ResembleAI.JsonConverters.WatermarkVisionDetectionMetricsDetectedModelVersionsItemsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.WatermarkVisionModelResultModelVersion))
                {
                    return new global::ResembleAI.JsonConverters.WatermarkVisionModelResultModelVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.WatermarkVisionModelResultModelVersion?))
                {
                    return new global::ResembleAI.JsonConverters.WatermarkVisionModelResultModelVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.WatermarkVisionModelResultStatus))
                {
                    return new global::ResembleAI.JsonConverters.WatermarkVisionModelResultStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.WatermarkVisionModelResultStatus?))
                {
                    return new global::ResembleAI.JsonConverters.WatermarkVisionModelResultStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.WatermarkVisionDetectionMetricsVerdict))
                {
                    return new global::ResembleAI.JsonConverters.WatermarkVisionDetectionMetricsVerdictJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.WatermarkVisionDetectionMetricsVerdict?))
                {
                    return new global::ResembleAI.JsonConverters.WatermarkVisionDetectionMetricsVerdictNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.WatermarkApplyPostParametersPrefer))
                {
                    return new global::ResembleAI.JsonConverters.WatermarkApplyPostParametersPreferJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.WatermarkApplyPostParametersPrefer?))
                {
                    return new global::ResembleAI.JsonConverters.WatermarkApplyPostParametersPreferNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.WatermarkApplyItemMediaType))
                {
                    return new global::ResembleAI.JsonConverters.WatermarkApplyItemMediaTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.WatermarkApplyItemMediaType?))
                {
                    return new global::ResembleAI.JsonConverters.WatermarkApplyItemMediaTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.WatermarkApplyItemOperationType))
                {
                    return new global::ResembleAI.JsonConverters.WatermarkApplyItemOperationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.WatermarkApplyItemOperationType?))
                {
                    return new global::ResembleAI.JsonConverters.WatermarkApplyItemOperationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.WatermarkApplyItemStatus))
                {
                    return new global::ResembleAI.JsonConverters.WatermarkApplyItemStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.WatermarkApplyItemStatus?))
                {
                    return new global::ResembleAI.JsonConverters.WatermarkApplyItemStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.WatermarkApplyItemModelVersion))
                {
                    return new global::ResembleAI.JsonConverters.WatermarkApplyItemModelVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.WatermarkApplyItemModelVersion?))
                {
                    return new global::ResembleAI.JsonConverters.WatermarkApplyItemModelVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.WatermarkDetectPostParametersPrefer))
                {
                    return new global::ResembleAI.JsonConverters.WatermarkDetectPostParametersPreferJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.WatermarkDetectPostParametersPrefer?))
                {
                    return new global::ResembleAI.JsonConverters.WatermarkDetectPostParametersPreferNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.WatermarkDetectItemMediaType))
                {
                    return new global::ResembleAI.JsonConverters.WatermarkDetectItemMediaTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.WatermarkDetectItemMediaType?))
                {
                    return new global::ResembleAI.JsonConverters.WatermarkDetectItemMediaTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.WatermarkDetectItemOperationType))
                {
                    return new global::ResembleAI.JsonConverters.WatermarkDetectItemOperationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.WatermarkDetectItemOperationType?))
                {
                    return new global::ResembleAI.JsonConverters.WatermarkDetectItemOperationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.WatermarkDetectItemStatus))
                {
                    return new global::ResembleAI.JsonConverters.WatermarkDetectItemStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.WatermarkDetectItemStatus?))
                {
                    return new global::ResembleAI.JsonConverters.WatermarkDetectItemStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.WatermarkDetectItemModelVersion))
                {
                    return new global::ResembleAI.JsonConverters.WatermarkDetectItemModelVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::ResembleAI.WatermarkDetectItemModelVersion?))
                {
                    return new global::ResembleAI.JsonConverters.WatermarkDetectItemModelVersionNullableJsonConverter();
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
                    0 => new WatermarkSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}