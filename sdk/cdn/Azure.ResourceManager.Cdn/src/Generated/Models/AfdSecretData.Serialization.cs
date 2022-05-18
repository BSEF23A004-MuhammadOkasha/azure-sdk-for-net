// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Cdn.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Cdn
{
    public partial class AfdSecretData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(Parameters))
            {
                writer.WritePropertyName("parameters");
                writer.WriteObjectValue(Parameters);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static AfdSecretData DeserializeAfdSecretData(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            Optional<AfdProvisioningState> provisioningState = default;
            Optional<AfdDeploymentStatus> deploymentStatus = default;
            Optional<string> profileName = default;
            Optional<SecretDefinition> parameters = default;
            foreach (var property in element.EnumerateObject())
            {
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
                    type = property.Value.GetString();
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
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = new AfdProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("deploymentStatus"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            deploymentStatus = new AfdDeploymentStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("profileName"))
                        {
                            profileName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("parameters"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            parameters = SecretDefinition.DeserializeSecretDefinition(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new AfdSecretData(id, name, type, systemData, Optional.ToNullable(provisioningState), Optional.ToNullable(deploymentStatus), profileName.Value, parameters.Value);
        }
    }
}
