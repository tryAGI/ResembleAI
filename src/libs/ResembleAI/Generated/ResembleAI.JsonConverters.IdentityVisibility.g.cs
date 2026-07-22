#nullable enable

namespace ResembleAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class IdentityVisibilityJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ResembleAI.IdentityVisibility>
    {
        /// <inheritdoc />
        public override global::ResembleAI.IdentityVisibility Read(
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
                        return global::ResembleAI.IdentityVisibilityExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::ResembleAI.IdentityVisibility)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::ResembleAI.IdentityVisibility);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ResembleAI.IdentityVisibility value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::ResembleAI.IdentityVisibilityExtensions.ToValueString(value));
        }
    }
}
