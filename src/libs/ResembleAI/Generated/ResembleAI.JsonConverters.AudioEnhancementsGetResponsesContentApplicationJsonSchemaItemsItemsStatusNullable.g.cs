#nullable enable

namespace ResembleAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class AudioEnhancementsGetResponsesContentApplicationJsonSchemaItemsItemsStatusNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ResembleAI.AudioEnhancementsGetResponsesContentApplicationJsonSchemaItemsItemsStatus?>
    {
        /// <inheritdoc />
        public override global::ResembleAI.AudioEnhancementsGetResponsesContentApplicationJsonSchemaItemsItemsStatus? Read(
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
                        return global::ResembleAI.AudioEnhancementsGetResponsesContentApplicationJsonSchemaItemsItemsStatusExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::ResembleAI.AudioEnhancementsGetResponsesContentApplicationJsonSchemaItemsItemsStatus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::ResembleAI.AudioEnhancementsGetResponsesContentApplicationJsonSchemaItemsItemsStatus?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ResembleAI.AudioEnhancementsGetResponsesContentApplicationJsonSchemaItemsItemsStatus? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::ResembleAI.AudioEnhancementsGetResponsesContentApplicationJsonSchemaItemsItemsStatusExtensions.ToValueString(value.Value));
            }
        }
    }
}
