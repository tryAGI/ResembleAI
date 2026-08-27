#nullable enable

namespace ResembleAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class IntelligencePostResponsesContentApplicationJsonSchemaItemMediaTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ResembleAI.IntelligencePostResponsesContentApplicationJsonSchemaItemMediaType?>
    {
        /// <inheritdoc />
        public override global::ResembleAI.IntelligencePostResponsesContentApplicationJsonSchemaItemMediaType? Read(
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
                        return global::ResembleAI.IntelligencePostResponsesContentApplicationJsonSchemaItemMediaTypeExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::ResembleAI.IntelligencePostResponsesContentApplicationJsonSchemaItemMediaType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::ResembleAI.IntelligencePostResponsesContentApplicationJsonSchemaItemMediaType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ResembleAI.IntelligencePostResponsesContentApplicationJsonSchemaItemMediaType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::ResembleAI.IntelligencePostResponsesContentApplicationJsonSchemaItemMediaTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
