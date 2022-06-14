// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    public partial class VnetGatewayData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind");
                writer.WriteStringValue(Kind);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(VnetName))
            {
                writer.WritePropertyName("vnetName");
                writer.WriteStringValue(VnetName);
            }
            if (Optional.IsDefined(VpnPackageUri))
            {
                writer.WritePropertyName("vpnPackageUri");
                writer.WriteStringValue(VpnPackageUri.AbsoluteUri);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static VnetGatewayData DeserializeVnetGatewayData(JsonElement element)
        {
            Optional<string> kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            Optional<string> vnetName = default;
            Optional<Uri> vpnPackageUri = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("vnetName"))
                        {
                            vnetName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("vpnPackageUri"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                vpnPackageUri = null;
                                continue;
                            }
                            vpnPackageUri = new Uri(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new VnetGatewayData(id, name, type, systemData, kind.Value, vnetName.Value, vpnPackageUri.Value);
        }
    }
}
