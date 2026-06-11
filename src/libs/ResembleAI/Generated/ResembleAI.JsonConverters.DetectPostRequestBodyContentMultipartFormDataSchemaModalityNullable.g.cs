#nullable enable

namespace ResembleAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class DetectPostRequestBodyContentMultipartFormDataSchemaModalityNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ResembleAI.DetectPostRequestBodyContentMultipartFormDataSchemaModality?>
    {
        /// <inheritdoc />
        public override global::ResembleAI.DetectPostRequestBodyContentMultipartFormDataSchemaModality? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::ResembleAI.DetectPostRequestBodyContentMultipartFormDataSchemaModalityExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::ResembleAI.DetectPostRequestBodyContentMultipartFormDataSchemaModality)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::ResembleAI.DetectPostRequestBodyContentMultipartFormDataSchemaModality?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ResembleAI.DetectPostRequestBodyContentMultipartFormDataSchemaModality? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::ResembleAI.DetectPostRequestBodyContentMultipartFormDataSchemaModalityExtensions.ToValueString(value.Value));
            }
        }
    }
}
