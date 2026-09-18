#nullable enable

namespace ResembleAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class TextDetectRequestThinkingJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ResembleAI.TextDetectRequestThinking>
    {
        /// <inheritdoc />
        public override global::ResembleAI.TextDetectRequestThinking Read(
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
                        return global::ResembleAI.TextDetectRequestThinkingExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::ResembleAI.TextDetectRequestThinking)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::ResembleAI.TextDetectRequestThinking);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ResembleAI.TextDetectRequestThinking value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::ResembleAI.TextDetectRequestThinkingExtensions.ToValueString(value));
        }
    }
}
