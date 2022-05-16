// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Applications.Containers.Models
{
    public partial class HttpRequestDataHttpHeadersItem : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            writer.WritePropertyName("value");
            writer.WriteStringValue(Value);
            writer.WriteEndObject();
        }

        internal static HttpRequestDataHttpHeadersItem DeserializeHttpRequestDataHttpHeadersItem(JsonElement element)
        {
            string name = default;
            string value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"))
                {
                    value = property.Value.GetString();
                    continue;
                }
            }
            return new HttpRequestDataHttpHeadersItem(name, value);
        }
    }
}
