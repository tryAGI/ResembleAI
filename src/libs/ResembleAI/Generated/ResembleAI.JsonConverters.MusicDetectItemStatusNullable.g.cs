#nullable enable

namespace ResembleAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class MusicDetectItemStatusNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ResembleAI.MusicDetectItemStatus?>
    {
        /// <inheritdoc />
        public override global::ResembleAI.MusicDetectItemStatus? Read(
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
                        return global::ResembleAI.MusicDetectItemStatusExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::ResembleAI.MusicDetectItemStatus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::ResembleAI.MusicDetectItemStatus?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ResembleAI.MusicDetectItemStatus? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::ResembleAI.MusicDetectItemStatusExtensions.ToValueString(value.Value));
            }
        }
    }
}
