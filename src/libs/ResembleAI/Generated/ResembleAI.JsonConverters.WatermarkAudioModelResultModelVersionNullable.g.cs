#nullable enable

namespace ResembleAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class WatermarkAudioModelResultModelVersionNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ResembleAI.WatermarkAudioModelResultModelVersion?>
    {
        /// <inheritdoc />
        public override global::ResembleAI.WatermarkAudioModelResultModelVersion? Read(
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
                        return global::ResembleAI.WatermarkAudioModelResultModelVersionExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::ResembleAI.WatermarkAudioModelResultModelVersion)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::ResembleAI.WatermarkAudioModelResultModelVersion?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ResembleAI.WatermarkAudioModelResultModelVersion? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::ResembleAI.WatermarkAudioModelResultModelVersionExtensions.ToValueString(value.Value));
            }
        }
    }
}
