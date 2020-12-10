// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Media.LiveVideoAnalytics.Edge.Models
{
    public partial class MediaGraphOutputSelector : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Property))
            {
                writer.WritePropertyName("property");
                writer.WriteStringValue(Property);
            }
            if (Optional.IsDefined(Operator))
            {
                writer.WritePropertyName("operator");
                writer.WriteStringValue(Operator.Value.ToSerialString());
            }
            if (Optional.IsDefined(Value))
            {
                writer.WritePropertyName("value");
                writer.WriteStringValue(Value);
            }
            writer.WriteEndObject();
        }

        internal static MediaGraphOutputSelector DeserializeMediaGraphOutputSelector(JsonElement element)
        {
            Optional<string> property = default;
            Optional<MediaGraphOutputSelectorOperator> @operator = default;
            Optional<string> value = default;
            foreach (var property0 in element.EnumerateObject())
            {
                if (property0.NameEquals("property"))
                {
                    property = property0.Value.GetString();
                    continue;
                }
                if (property0.NameEquals("operator"))
                {
                    if (property0.Value.ValueKind == JsonValueKind.Null)
                    {
                        property0.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    @operator = property0.Value.GetString().ToMediaGraphOutputSelectorOperator();
                    continue;
                }
                if (property0.NameEquals("value"))
                {
                    value = property0.Value.GetString();
                    continue;
                }
            }
            return new MediaGraphOutputSelector(property.Value, Optional.ToNullable(@operator), value.Value);
        }
    }
}
