#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace ResembleAI.JsonConverters
{
    /// <inheritdoc />
    public class IdentityCreateIdentityRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ResembleAI.IdentityCreateIdentityRequest>
    {
        /// <inheritdoc />
        public override global::ResembleAI.IdentityCreateIdentityRequest Read(
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
            if (__jsonProps.Contains("name")) __score0++;
            if (__jsonProps.Contains("signed_id")) __score0++;
            if (__jsonProps.Contains("url")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("identity")) __score1++;
            if (__jsonProps.Contains("identity.identity_type")) __score1++;
            if (__jsonProps.Contains("identity.name")) __score1++;
            if (__jsonProps.Contains("identity.notes")) __score1++;
            if (__jsonProps.Contains("identity.visibility")) __score1++;
            if (__jsonProps.Contains("identity.voice_profile_id")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::ResembleAI.IdentityCreateIdentityRequest0? identityCreateIdentityRequest0 = default;
            global::ResembleAI.IdentityCreateIdentityRequest1? identityCreateIdentityRequest1 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ResembleAI.IdentityCreateIdentityRequest0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ResembleAI.IdentityCreateIdentityRequest0> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ResembleAI.IdentityCreateIdentityRequest0).Name}");
                        identityCreateIdentityRequest0 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ResembleAI.IdentityCreateIdentityRequest1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ResembleAI.IdentityCreateIdentityRequest1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ResembleAI.IdentityCreateIdentityRequest1).Name}");
                        identityCreateIdentityRequest1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (identityCreateIdentityRequest0 == null && identityCreateIdentityRequest1 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ResembleAI.IdentityCreateIdentityRequest0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ResembleAI.IdentityCreateIdentityRequest0> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ResembleAI.IdentityCreateIdentityRequest0).Name}");
                    identityCreateIdentityRequest0 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (identityCreateIdentityRequest0 == null && identityCreateIdentityRequest1 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ResembleAI.IdentityCreateIdentityRequest1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ResembleAI.IdentityCreateIdentityRequest1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ResembleAI.IdentityCreateIdentityRequest1).Name}");
                    identityCreateIdentityRequest1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::ResembleAI.IdentityCreateIdentityRequest(
                identityCreateIdentityRequest0,

                identityCreateIdentityRequest1
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ResembleAI.IdentityCreateIdentityRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsIdentityCreateIdentityRequest0)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ResembleAI.IdentityCreateIdentityRequest0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ResembleAI.IdentityCreateIdentityRequest0?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ResembleAI.IdentityCreateIdentityRequest0).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.IdentityCreateIdentityRequest0!, typeInfo);
            }
            else if (value.IsIdentityCreateIdentityRequest1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ResembleAI.IdentityCreateIdentityRequest1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ResembleAI.IdentityCreateIdentityRequest1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ResembleAI.IdentityCreateIdentityRequest1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.IdentityCreateIdentityRequest1!, typeInfo);
            }
        }
    }
}