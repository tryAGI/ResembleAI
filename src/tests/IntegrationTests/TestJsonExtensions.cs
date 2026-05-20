using System.Globalization;
using System.Text.Json;

namespace ResembleAI.IntegrationTests;

internal static class TestJsonExtensions
{
    internal static string? GetString(this IDictionary<string, object> properties, string propertyName)
    {
        if (!properties.TryGetValue(propertyName, out var value) || value is null)
        {
            return null;
        }

        return value switch
        {
            string stringValue => stringValue,
            JsonElement { ValueKind: JsonValueKind.String } jsonElement => jsonElement.GetString(),
            JsonElement jsonElement => jsonElement.ToString(),
            _ => Convert.ToString(value, CultureInfo.InvariantCulture),
        };
    }

    internal static JsonElement? GetObject(this IDictionary<string, object> properties, string propertyName)
    {
        if (!properties.TryGetValue(propertyName, out var value) || value is null)
        {
            return null;
        }

        return value switch
        {
            JsonElement { ValueKind: JsonValueKind.Object } jsonElement => jsonElement,
            _ => null,
        };
    }

    internal static bool? GetBooleanProperty(this JsonElement element, string propertyName)
    {
        if (!element.TryGetProperty(propertyName, out var property))
        {
            return null;
        }

        return property.ValueKind switch
        {
            JsonValueKind.True => true,
            JsonValueKind.False => false,
            JsonValueKind.String when bool.TryParse(property.GetString(), out var parsed) => parsed,
            _ => null,
        };
    }
}
