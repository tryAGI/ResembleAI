#nullable enable

namespace ResembleAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class WatermarkAudioDetectionMetricsDetectedModelVersionsItemsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ResembleAI.WatermarkAudioDetectionMetricsDetectedModelVersionsItems>
    {
        /// <inheritdoc />
        public override global::ResembleAI.WatermarkAudioDetectionMetricsDetectedModelVersionsItems Read(
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
                        return global::ResembleAI.WatermarkAudioDetectionMetricsDetectedModelVersionsItemsExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::ResembleAI.WatermarkAudioDetectionMetricsDetectedModelVersionsItems)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::ResembleAI.WatermarkAudioDetectionMetricsDetectedModelVersionsItems);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ResembleAI.WatermarkAudioDetectionMetricsDetectedModelVersionsItems value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::ResembleAI.WatermarkAudioDetectionMetricsDetectedModelVersionsItemsExtensions.ToValueString(value));
        }
    }
}
