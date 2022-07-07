// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    public partial class SsoProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Scope))
            {
                writer.WritePropertyName("scope");
                writer.WriteStartArray();
                foreach (var item in Scope)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ClientId))
            {
                writer.WritePropertyName("clientId");
                writer.WriteStringValue(ClientId);
            }
            if (Optional.IsDefined(ClientSecret))
            {
                writer.WritePropertyName("clientSecret");
                writer.WriteStringValue(ClientSecret);
            }
            if (Optional.IsDefined(IssuerUri))
            {
                writer.WritePropertyName("issuerUri");
                writer.WriteStringValue(IssuerUri.AbsoluteUri);
            }
            writer.WriteEndObject();
        }

        internal static SsoProperties DeserializeSsoProperties(JsonElement element)
        {
            Optional<IList<string>> scope = default;
            Optional<string> clientId = default;
            Optional<string> clientSecret = default;
            Optional<Uri> issuerUri = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("scope"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    scope = array;
                    continue;
                }
                if (property.NameEquals("clientId"))
                {
                    clientId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clientSecret"))
                {
                    clientSecret = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("issuerUri"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        issuerUri = null;
                        continue;
                    }
                    issuerUri = new Uri(property.Value.GetString());
                    continue;
                }
            }
            return new SsoProperties(Optional.ToList(scope), clientId.Value, clientSecret.Value, issuerUri.Value);
        }
    }
}
