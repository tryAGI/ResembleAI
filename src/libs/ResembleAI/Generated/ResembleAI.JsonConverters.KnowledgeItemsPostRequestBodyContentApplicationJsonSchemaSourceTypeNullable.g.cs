#nullable enable

namespace ResembleAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class KnowledgeItemsPostRequestBodyContentApplicationJsonSchemaSourceTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ResembleAI.KnowledgeItemsPostRequestBodyContentApplicationJsonSchemaSourceType?>
    {
        /// <inheritdoc />
        public override global::ResembleAI.KnowledgeItemsPostRequestBodyContentApplicationJsonSchemaSourceType? Read(
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
                        return global::ResembleAI.KnowledgeItemsPostRequestBodyContentApplicationJsonSchemaSourceTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::ResembleAI.KnowledgeItemsPostRequestBodyContentApplicationJsonSchemaSourceType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::ResembleAI.KnowledgeItemsPostRequestBodyContentApplicationJsonSchemaSourceType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ResembleAI.KnowledgeItemsPostRequestBodyContentApplicationJsonSchemaSourceType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::ResembleAI.KnowledgeItemsPostRequestBodyContentApplicationJsonSchemaSourceTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
