// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    public partial class ApiKeyVaultReferenceData : IUtf8JsonSerializable
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
            if (Optional.IsDefined(Reference))
            {
                writer.WritePropertyName("reference");
                writer.WriteStringValue(Reference);
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status");
                writer.WriteStringValue(Status.Value.ToSerialString());
            }
            if (Optional.IsDefined(VaultName))
            {
                writer.WritePropertyName("vaultName");
                writer.WriteStringValue(VaultName);
            }
            if (Optional.IsDefined(SecretName))
            {
                writer.WritePropertyName("secretName");
                writer.WriteStringValue(SecretName);
            }
            if (Optional.IsDefined(SecretVersion))
            {
                writer.WritePropertyName("secretVersion");
                writer.WriteStringValue(SecretVersion);
            }
            if (Optional.IsDefined(IdentityType))
            {
                writer.WritePropertyName("identityType");
                JsonSerializer.Serialize(writer, IdentityType);
            }
            if (Optional.IsDefined(Details))
            {
                writer.WritePropertyName("details");
                writer.WriteStringValue(Details);
            }
            if (Optional.IsDefined(Source))
            {
                writer.WritePropertyName("source");
                writer.WriteStringValue(Source.Value.ToString());
            }
            if (Optional.IsDefined(ActiveVersion))
            {
                writer.WritePropertyName("activeVersion");
                writer.WriteStringValue(ActiveVersion);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ApiKeyVaultReferenceData DeserializeApiKeyVaultReferenceData(JsonElement element)
        {
            Optional<string> kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            Optional<string> reference = default;
            Optional<ResolveStatus> status = default;
            Optional<string> vaultName = default;
            Optional<string> secretName = default;
            Optional<string> secretVersion = default;
            Optional<ManagedServiceIdentity> identityType = default;
            Optional<string> details = default;
            Optional<ConfigReferenceSource> source = default;
            Optional<string> activeVersion = default;
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
                        if (property0.NameEquals("reference"))
                        {
                            reference = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("status"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            status = property0.Value.GetString().ToResolveStatus();
                            continue;
                        }
                        if (property0.NameEquals("vaultName"))
                        {
                            vaultName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("secretName"))
                        {
                            secretName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("secretVersion"))
                        {
                            secretVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("identityType"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            identityType = JsonSerializer.Deserialize<ManagedServiceIdentity>(property0.Value.ToString());
                            continue;
                        }
                        if (property0.NameEquals("details"))
                        {
                            details = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("source"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            source = new ConfigReferenceSource(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("activeVersion"))
                        {
                            activeVersion = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ApiKeyVaultReferenceData(id, name, type, systemData, kind.Value, reference.Value, Optional.ToNullable(status), vaultName.Value, secretName.Value, secretVersion.Value, identityType, details.Value, Optional.ToNullable(source), activeVersion.Value);
        }
    }
}
