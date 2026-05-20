#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace ResembleAI.JsonConverters
{
    /// <inheritdoc />
    public class DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ResembleAI.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription>
    {
        /// <inheritdoc />
        public override global::ResembleAI.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription Read(
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
                    if (__jsonProp.Value.ValueKind == global::System.Text.Json.JsonValueKind.Object)
                    {
                        foreach (var __nestedJsonProp in __jsonProp.Value.EnumerateObject())
                        {
                            __jsonProps.Add(__jsonProp.Name + "." + __nestedJsonProp.Name);
                        }
                    }

                }
            }

            var __score0 = 0;
            var __score1 = 0;
            if (__jsonProps.Contains("abnormalities")) __score1++;
            if (__jsonProps.Contains("context")) __score1++;
            if (__jsonProps.Contains("dialect")) __score1++;
            if (__jsonProps.Contains("digitally_altered")) __score1++;
            if (__jsonProps.Contains("digitally_altered.alterations")) __score1++;
            if (__jsonProps.Contains("digitally_altered.confidence")) __score1++;
            if (__jsonProps.Contains("digitally_altered.detected")) __score1++;
            if (__jsonProps.Contains("emotion")) __score1++;
            if (__jsonProps.Contains("fraud")) __score1++;
            if (__jsonProps.Contains("fraud.confidence")) __score1++;
            if (__jsonProps.Contains("fraud.reasoning")) __score1++;
            if (__jsonProps.Contains("fraud.type")) __score1++;
            if (__jsonProps.Contains("language")) __score1++;
            if (__jsonProps.Contains("liveness")) __score1++;
            if (__jsonProps.Contains("liveness.assessment")) __score1++;
            if (__jsonProps.Contains("liveness.confidence")) __score1++;
            if (__jsonProps.Contains("liveness.indicators")) __score1++;
            if (__jsonProps.Contains("message")) __score1++;
            if (__jsonProps.Contains("misinformation")) __score1++;
            if (__jsonProps.Contains("speaker_info")) __score1++;
            if (__jsonProps.Contains("speaking_style")) __score1++;
            if (__jsonProps.Contains("transcription")) __score1++;
            if (__jsonProps.Contains("translation")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            string? detectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant1 = default;
            global::ResembleAI.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription1? detectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription1 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(string), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<string> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(string).Name}");
                        detectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ResembleAI.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ResembleAI.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ResembleAI.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription1).Name}");
                        detectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (detectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant1 == null && detectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription1 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(string), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<string> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(string).Name}");
                    detectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (detectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant1 == null && detectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription1 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ResembleAI.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ResembleAI.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ResembleAI.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription1).Name}");
                    detectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::ResembleAI.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription(
                detectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant1,

                detectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription1
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ResembleAI.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsDetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(string), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<string?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(string).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescriptionVariant1!, typeInfo);
            }
            else if (value.IsDetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ResembleAI.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ResembleAI.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ResembleAI.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DetectPostResponsesContentApplicationJsonSchemaItemIntelligenceDescription1!, typeInfo);
            }
        }
    }
}