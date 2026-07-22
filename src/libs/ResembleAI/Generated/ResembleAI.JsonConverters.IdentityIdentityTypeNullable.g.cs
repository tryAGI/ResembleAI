#nullable enable

namespace ResembleAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class IdentityIdentityTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ResembleAI.IdentityIdentityType?>
    {
        /// <inheritdoc />
        public override global::ResembleAI.IdentityIdentityType? Read(
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
                        return global::ResembleAI.IdentityIdentityTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::ResembleAI.IdentityIdentityType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::ResembleAI.IdentityIdentityType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ResembleAI.IdentityIdentityType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::ResembleAI.IdentityIdentityTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
