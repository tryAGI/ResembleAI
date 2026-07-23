#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace ResembleAI.JsonConverters
{
    /// <inheritdoc />
    public class WatermarkDetectItemMetricsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ResembleAI.WatermarkDetectItemMetrics>
    {
        /// <inheritdoc />
        public override global::ResembleAI.WatermarkDetectItemMetrics Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);

                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("confidence")) __score0++;
            if (__jsonProps.Contains("coverage_complete")) __score0++;
            if (__jsonProps.Contains("detected_model_versions")) __score0++;
            if (__jsonProps.Contains("has_watermark")) __score0++;
            if (__jsonProps.Contains("model_results")) __score0++;
            if (__jsonProps.Contains("overall_status")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("detected_model_versions")) __score1++;
            if (__jsonProps.Contains("detection_score")) __score1++;
            if (__jsonProps.Contains("has_watermark")) __score1++;
            if (__jsonProps.Contains("model_results")) __score1++;
            if (__jsonProps.Contains("overall_status")) __score1++;
            if (__jsonProps.Contains("synthid")) __score1++;
            if (__jsonProps.Contains("verdict")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::ResembleAI.WatermarkAudioDetectionMetrics? watermarkAudioDetectionMetrics = default;
            global::ResembleAI.WatermarkVisionDetectionMetrics? watermarkVisionDetectionMetrics = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ResembleAI.WatermarkAudioDetectionMetrics), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ResembleAI.WatermarkAudioDetectionMetrics> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ResembleAI.WatermarkAudioDetectionMetrics).Name}");
                        watermarkAudioDetectionMetrics = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ResembleAI.WatermarkVisionDetectionMetrics), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ResembleAI.WatermarkVisionDetectionMetrics> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ResembleAI.WatermarkVisionDetectionMetrics).Name}");
                        watermarkVisionDetectionMetrics = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (watermarkAudioDetectionMetrics == null && watermarkVisionDetectionMetrics == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ResembleAI.WatermarkAudioDetectionMetrics), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ResembleAI.WatermarkAudioDetectionMetrics> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ResembleAI.WatermarkAudioDetectionMetrics).Name}");
                    watermarkAudioDetectionMetrics = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (watermarkAudioDetectionMetrics == null && watermarkVisionDetectionMetrics == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ResembleAI.WatermarkVisionDetectionMetrics), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ResembleAI.WatermarkVisionDetectionMetrics> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ResembleAI.WatermarkVisionDetectionMetrics).Name}");
                    watermarkVisionDetectionMetrics = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::ResembleAI.WatermarkDetectItemMetrics(
                watermarkAudioDetectionMetrics,

                watermarkVisionDetectionMetrics
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ResembleAI.WatermarkDetectItemMetrics value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsWatermarkAudioDetectionMetrics)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ResembleAI.WatermarkAudioDetectionMetrics), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ResembleAI.WatermarkAudioDetectionMetrics?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ResembleAI.WatermarkAudioDetectionMetrics).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WatermarkAudioDetectionMetrics!, typeInfo);
            }
            else if (value.IsWatermarkVisionDetectionMetrics)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ResembleAI.WatermarkVisionDetectionMetrics), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ResembleAI.WatermarkVisionDetectionMetrics?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ResembleAI.WatermarkVisionDetectionMetrics).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WatermarkVisionDetectionMetrics!, typeInfo);
            }
        }
    }
}