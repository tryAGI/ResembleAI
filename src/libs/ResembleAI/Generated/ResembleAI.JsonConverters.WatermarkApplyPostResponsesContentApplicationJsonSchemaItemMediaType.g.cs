#nullable enable

namespace ResembleAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class WatermarkApplyPostResponsesContentApplicationJsonSchemaItemMediaTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ResembleAI.WatermarkApplyPostResponsesContentApplicationJsonSchemaItemMediaType>
    {
        /// <inheritdoc />
        public override global::ResembleAI.WatermarkApplyPostResponsesContentApplicationJsonSchemaItemMediaType Read(
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
                        return global::ResembleAI.WatermarkApplyPostResponsesContentApplicationJsonSchemaItemMediaTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::ResembleAI.WatermarkApplyPostResponsesContentApplicationJsonSchemaItemMediaType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::ResembleAI.WatermarkApplyPostResponsesContentApplicationJsonSchemaItemMediaType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ResembleAI.WatermarkApplyPostResponsesContentApplicationJsonSchemaItemMediaType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::ResembleAI.WatermarkApplyPostResponsesContentApplicationJsonSchemaItemMediaTypeExtensions.ToValueString(value));
        }
    }
}
