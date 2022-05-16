// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.MediaComposition.Models
{
    public partial class InputPosition : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(X))
            {
                writer.WritePropertyName("x");
                writer.WriteNumberValue(X.Value);
            }
            if (Optional.IsDefined(Y))
            {
                writer.WritePropertyName("y");
                writer.WriteNumberValue(Y.Value);
            }
            writer.WriteEndObject();
        }

        internal static InputPosition DeserializeInputPosition(JsonElement element)
        {
            Optional<int> x = default;
            Optional<int> y = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("x"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    x = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("y"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    y = property.Value.GetInt32();
                    continue;
                }
            }
            return new InputPosition(Optional.ToNullable(x), Optional.ToNullable(y));
        }
    }
}
