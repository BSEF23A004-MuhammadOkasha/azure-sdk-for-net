// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Models
{
    public partial class CorsOptions : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("allowedOrigins");
            writer.WriteStartArray();
            foreach (var item in AllowedOrigins)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            if (MaxAgeInSeconds != null)
            {
                writer.WritePropertyName("maxAgeInSeconds");
                writer.WriteNumberValue(MaxAgeInSeconds.Value);
            }
            writer.WriteEndObject();
        }

        internal static CorsOptions DeserializeCorsOptions(JsonElement element)
        {
            CorsOptions result = new CorsOptions();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("allowedOrigins"))
                {
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        result.AllowedOrigins.Add(item.GetString());
                    }
                    continue;
                }
                if (property.NameEquals("maxAgeInSeconds"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.MaxAgeInSeconds = property.Value.GetInt64();
                    continue;
                }
            }
            return result;
        }
    }
}
