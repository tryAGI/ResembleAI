#nullable enable

namespace ResembleAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class AgentsPostRequestBodyContentApplicationJsonSchemaSearchModeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ResembleAI.AgentsPostRequestBodyContentApplicationJsonSchemaSearchMode>
    {
        /// <inheritdoc />
        public override global::ResembleAI.AgentsPostRequestBodyContentApplicationJsonSchemaSearchMode Read(
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
                        return global::ResembleAI.AgentsPostRequestBodyContentApplicationJsonSchemaSearchModeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::ResembleAI.AgentsPostRequestBodyContentApplicationJsonSchemaSearchMode)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::ResembleAI.AgentsPostRequestBodyContentApplicationJsonSchemaSearchMode);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ResembleAI.AgentsPostRequestBodyContentApplicationJsonSchemaSearchMode value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::ResembleAI.AgentsPostRequestBodyContentApplicationJsonSchemaSearchModeExtensions.ToValueString(value));
        }
    }
}
