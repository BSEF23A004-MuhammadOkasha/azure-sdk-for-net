// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    internal partial class UnknownCharFilter : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("@odata.type"u8);
            writer.WriteStringValue(ODataType);
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WriteEndObject();
        }

        internal static UnknownCharFilter DeserializeUnknownCharFilter(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string odataType = "Unknown";
            string name = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("@odata.type"u8))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
            }
            return new UnknownCharFilter(odataType, name);
        }
    }
}
