#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace ResembleAI.JsonConverters
{
    /// <inheritdoc />
    public class UpdateBillingAutoReloadRequestUnprocessableEntityErrorJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ResembleAI.UpdateBillingAutoReloadRequestUnprocessableEntityError>
    {
        /// <inheritdoc />
        public override global::ResembleAI.UpdateBillingAutoReloadRequestUnprocessableEntityError Read(
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
            if (__jsonProps.Contains("error")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("errors")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::ResembleAI.BillingError? billingError = default;
            global::ResembleAI.BillingValidationErrors? billingValidationErrors = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ResembleAI.BillingError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ResembleAI.BillingError> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ResembleAI.BillingError).Name}");
                        billingError = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ResembleAI.BillingValidationErrors), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ResembleAI.BillingValidationErrors> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ResembleAI.BillingValidationErrors).Name}");
                        billingValidationErrors = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (billingError == null && billingValidationErrors == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ResembleAI.BillingError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ResembleAI.BillingError> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ResembleAI.BillingError).Name}");
                    billingError = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (billingError == null && billingValidationErrors == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ResembleAI.BillingValidationErrors), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ResembleAI.BillingValidationErrors> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ResembleAI.BillingValidationErrors).Name}");
                    billingValidationErrors = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::ResembleAI.UpdateBillingAutoReloadRequestUnprocessableEntityError(
                billingError,

                billingValidationErrors
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ResembleAI.UpdateBillingAutoReloadRequestUnprocessableEntityError value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsBillingError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ResembleAI.BillingError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ResembleAI.BillingError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ResembleAI.BillingError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BillingError!, typeInfo);
            }
            else if (value.IsBillingValidationErrors)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ResembleAI.BillingValidationErrors), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ResembleAI.BillingValidationErrors?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ResembleAI.BillingValidationErrors).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BillingValidationErrors!, typeInfo);
            }
        }
    }
}