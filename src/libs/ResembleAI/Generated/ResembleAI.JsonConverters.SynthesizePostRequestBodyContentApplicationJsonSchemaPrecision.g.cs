#nullable enable

namespace ResembleAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class SynthesizePostRequestBodyContentApplicationJsonSchemaPrecisionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ResembleAI.SynthesizePostRequestBodyContentApplicationJsonSchemaPrecision>
    {
        /// <inheritdoc />
        public override global::ResembleAI.SynthesizePostRequestBodyContentApplicationJsonSchemaPrecision Read(
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
                        return global::ResembleAI.SynthesizePostRequestBodyContentApplicationJsonSchemaPrecisionExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::ResembleAI.SynthesizePostRequestBodyContentApplicationJsonSchemaPrecision)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::ResembleAI.SynthesizePostRequestBodyContentApplicationJsonSchemaPrecision);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ResembleAI.SynthesizePostRequestBodyContentApplicationJsonSchemaPrecision value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::ResembleAI.SynthesizePostRequestBodyContentApplicationJsonSchemaPrecisionExtensions.ToValueString(value));
        }
    }
}
