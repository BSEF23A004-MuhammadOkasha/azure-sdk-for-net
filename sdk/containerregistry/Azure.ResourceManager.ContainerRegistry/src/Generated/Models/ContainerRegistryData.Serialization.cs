// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ContainerRegistry.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ContainerRegistry
{
    public partial class ContainerRegistryData : IUtf8JsonSerializable, IJsonModel<ContainerRegistryData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerRegistryData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ContainerRegistryData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerRegistryData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("sku"u8);
            writer.WriteObjectValue(Sku);
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity"u8);
                JsonSerializer.Serialize(writer, Identity);
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(LoginServer))
            {
                writer.WritePropertyName("loginServer"u8);
                writer.WriteStringValue(LoginServer);
            }
            if (options.Format != "W" && Optional.IsDefined(CreatedOn))
            {
                writer.WritePropertyName("creationDate"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteObjectValue(Status);
            }
            if (Optional.IsDefined(IsAdminUserEnabled))
            {
                writer.WritePropertyName("adminUserEnabled"u8);
                writer.WriteBooleanValue(IsAdminUserEnabled.Value);
            }
            if (Optional.IsDefined(NetworkRuleSet))
            {
                writer.WritePropertyName("networkRuleSet"u8);
                writer.WriteObjectValue(NetworkRuleSet);
            }
            if (Optional.IsDefined(Policies))
            {
                writer.WritePropertyName("policies"u8);
                writer.WriteObjectValue(Policies);
            }
            if (Optional.IsDefined(Encryption))
            {
                writer.WritePropertyName("encryption"u8);
                writer.WriteObjectValue(Encryption);
            }
            if (Optional.IsDefined(IsDataEndpointEnabled))
            {
                writer.WritePropertyName("dataEndpointEnabled"u8);
                writer.WriteBooleanValue(IsDataEndpointEnabled.Value);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(DataEndpointHostNames))
            {
                writer.WritePropertyName("dataEndpointHostNames"u8);
                writer.WriteStartArray();
                foreach (var item in DataEndpointHostNames)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(PrivateEndpointConnections))
            {
                writer.WritePropertyName("privateEndpointConnections"u8);
                writer.WriteStartArray();
                foreach (var item in PrivateEndpointConnections)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(PublicNetworkAccess))
            {
                writer.WritePropertyName("publicNetworkAccess"u8);
                writer.WriteStringValue(PublicNetworkAccess.Value.ToString());
            }
            if (Optional.IsDefined(NetworkRuleBypassOptions))
            {
                writer.WritePropertyName("networkRuleBypassOptions"u8);
                writer.WriteStringValue(NetworkRuleBypassOptions.Value.ToString());
            }
            if (Optional.IsDefined(ZoneRedundancy))
            {
                writer.WritePropertyName("zoneRedundancy"u8);
                writer.WriteStringValue(ZoneRedundancy.Value.ToString());
            }
            writer.WriteEndObject();
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        ContainerRegistryData IJsonModel<ContainerRegistryData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerRegistryData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerRegistryData(document.RootElement, options);
        }

        internal static ContainerRegistryData DeserializeContainerRegistryData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ContainerRegistrySku sku = default;
            Optional<ManagedServiceIdentity> identity = default;
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> loginServer = default;
            Optional<DateTimeOffset> creationDate = default;
            Optional<ContainerRegistryProvisioningState> provisioningState = default;
            Optional<ContainerRegistryResourceStatus> status = default;
            Optional<bool> adminUserEnabled = default;
            Optional<ContainerRegistryNetworkRuleSet> networkRuleSet = default;
            Optional<ContainerRegistryPolicies> policies = default;
            Optional<ContainerRegistryEncryption> encryption = default;
            Optional<bool> dataEndpointEnabled = default;
            Optional<IReadOnlyList<string>> dataEndpointHostNames = default;
            Optional<IReadOnlyList<ContainerRegistryPrivateEndpointConnectionData>> privateEndpointConnections = default;
            Optional<ContainerRegistryPublicNetworkAccess> publicNetworkAccess = default;
            Optional<ContainerRegistryNetworkRuleBypassOption> networkRuleBypassOptions = default;
            Optional<ContainerRegistryZoneRedundancy> zoneRedundancy = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"u8))
                {
                    sku = ContainerRegistrySku.DeserializeContainerRegistrySku(property.Value);
                    continue;
                }
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identity = JsonSerializer.Deserialize<ManagedServiceIdentity>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("loginServer"u8))
                        {
                            loginServer = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("creationDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            creationDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new ContainerRegistryProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("status"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            status = ContainerRegistryResourceStatus.DeserializeContainerRegistryResourceStatus(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("adminUserEnabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            adminUserEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("networkRuleSet"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            networkRuleSet = ContainerRegistryNetworkRuleSet.DeserializeContainerRegistryNetworkRuleSet(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("policies"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            policies = ContainerRegistryPolicies.DeserializeContainerRegistryPolicies(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("encryption"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            encryption = ContainerRegistryEncryption.DeserializeContainerRegistryEncryption(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("dataEndpointEnabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            dataEndpointEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("dataEndpointHostNames"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            dataEndpointHostNames = array;
                            continue;
                        }
                        if (property0.NameEquals("privateEndpointConnections"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ContainerRegistryPrivateEndpointConnectionData> array = new List<ContainerRegistryPrivateEndpointConnectionData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ContainerRegistryPrivateEndpointConnectionData.DeserializeContainerRegistryPrivateEndpointConnectionData(item));
                            }
                            privateEndpointConnections = array;
                            continue;
                        }
                        if (property0.NameEquals("publicNetworkAccess"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            publicNetworkAccess = new ContainerRegistryPublicNetworkAccess(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("networkRuleBypassOptions"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            networkRuleBypassOptions = new ContainerRegistryNetworkRuleBypassOption(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("zoneRedundancy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            zoneRedundancy = new ContainerRegistryZoneRedundancy(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ContainerRegistryData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, sku, identity, loginServer.Value, Optional.ToNullable(creationDate), Optional.ToNullable(provisioningState), status.Value, Optional.ToNullable(adminUserEnabled), networkRuleSet.Value, policies.Value, encryption.Value, Optional.ToNullable(dataEndpointEnabled), Optional.ToList(dataEndpointHostNames), Optional.ToList(privateEndpointConnections), Optional.ToNullable(publicNetworkAccess), Optional.ToNullable(networkRuleBypassOptions), Optional.ToNullable(zoneRedundancy), serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(Sku))
            {
                builder.Append("  sku:");
                AppendChildObject(builder, Sku, options, 2, false);
            }

            if (Optional.IsDefined(Identity))
            {
                builder.Append("  identity:");
                AppendChildObject(builder, Identity, options, 2, false);
            }

            if (Optional.IsCollectionDefined(Tags))
            {
                if (Tags.Any())
                {
                    builder.Append("  tags:");
                    builder.AppendLine(" {");
                    foreach (var item in Tags)
                    {
                        builder.Append($"    {item.Key}: ");
                        if (item.Value == null)
                        {
                            builder.Append("null");
                            continue;
                        }
                        builder.AppendLine($" '{item.Value}'");
                    }
                    builder.AppendLine("  }");
                }
            }

            if (Optional.IsDefined(Location))
            {
                builder.Append("  location:");
                builder.AppendLine($" '{Location.ToString()}'");
            }

            if (Optional.IsDefined(Id))
            {
                builder.Append("  id:");
                builder.AppendLine($" '{Id.ToString()}'");
            }

            if (Optional.IsDefined(Name))
            {
                builder.Append("  name:");
                builder.AppendLine($" '{Name}'");
            }

            if (Optional.IsDefined(ResourceType))
            {
                builder.Append("  type:");
                builder.AppendLine($" '{ResourceType.ToString()}'");
            }

            if (Optional.IsDefined(SystemData))
            {
                builder.Append("  systemData:");
                builder.AppendLine($" '{SystemData.ToString()}'");
            }

            builder.Append("  properties:");
            builder.AppendLine(" {");
            if (Optional.IsDefined(LoginServer))
            {
                builder.Append("    loginServer:");
                builder.AppendLine($" '{LoginServer}'");
            }

            if (Optional.IsDefined(CreatedOn))
            {
                builder.Append("    creationDate:");
                var formattedDateTimeString = TypeFormatters.ToString(CreatedOn.Value, "o");
                builder.AppendLine($" '{formattedDateTimeString}'");
            }

            if (Optional.IsDefined(ProvisioningState))
            {
                builder.Append("    provisioningState:");
                builder.AppendLine($" '{ProvisioningState.ToString()}'");
            }

            if (Optional.IsDefined(Status))
            {
                builder.Append("    status:");
                AppendChildObject(builder, Status, options, 4, false);
            }

            if (Optional.IsDefined(IsAdminUserEnabled))
            {
                builder.Append("    adminUserEnabled:");
                var boolValue = IsAdminUserEnabled.Value == true ? "true" : "false";
                builder.AppendLine($" {boolValue}");
            }

            if (Optional.IsDefined(NetworkRuleSet))
            {
                builder.Append("    networkRuleSet:");
                AppendChildObject(builder, NetworkRuleSet, options, 4, false);
            }

            if (Optional.IsDefined(Policies))
            {
                builder.Append("    policies:");
                AppendChildObject(builder, Policies, options, 4, false);
            }

            if (Optional.IsDefined(Encryption))
            {
                builder.Append("    encryption:");
                AppendChildObject(builder, Encryption, options, 4, false);
            }

            if (Optional.IsDefined(IsDataEndpointEnabled))
            {
                builder.Append("    dataEndpointEnabled:");
                var boolValue = IsDataEndpointEnabled.Value == true ? "true" : "false";
                builder.AppendLine($" {boolValue}");
            }

            if (Optional.IsCollectionDefined(DataEndpointHostNames))
            {
                if (DataEndpointHostNames.Any())
                {
                    builder.Append("    dataEndpointHostNames:");
                    builder.AppendLine(" [");
                    foreach (var item in DataEndpointHostNames)
                    {
                        if (item == null)
                        {
                            builder.Append("null");
                            continue;
                        }
                        builder.AppendLine($"      '{item}'");
                    }
                    builder.AppendLine("    ]");
                }
            }

            if (Optional.IsCollectionDefined(PrivateEndpointConnections))
            {
                if (PrivateEndpointConnections.Any())
                {
                    builder.Append("    privateEndpointConnections:");
                    builder.AppendLine(" [");
                    foreach (var item in PrivateEndpointConnections)
                    {
                        AppendChildObject(builder, item, options, 6, true);
                    }
                    builder.AppendLine("    ]");
                }
            }

            if (Optional.IsDefined(PublicNetworkAccess))
            {
                builder.Append("    publicNetworkAccess:");
                builder.AppendLine($" '{PublicNetworkAccess.ToString()}'");
            }

            if (Optional.IsDefined(NetworkRuleBypassOptions))
            {
                builder.Append("    networkRuleBypassOptions:");
                builder.AppendLine($" '{NetworkRuleBypassOptions.ToString()}'");
            }

            if (Optional.IsDefined(ZoneRedundancy))
            {
                builder.Append("    zoneRedundancy:");
                builder.AppendLine($" '{ZoneRedundancy.ToString()}'");
            }

            builder.AppendLine("  }");
            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        private void AppendChildObject(StringBuilder stringBuilder, object childObject, ModelReaderWriterOptions options, int spaces, bool indentFirstLine)
        {
            string indent = new string(' ', spaces);
            BinaryData data = ModelReaderWriter.Write(childObject, options);
            string[] lines = data.ToString().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                if (i == 0 && !indentFirstLine)
                {
                    stringBuilder.AppendLine($" {line}");
                }
                else
                {
                    stringBuilder.AppendLine($"{indent}{line}");
                }
            }
        }

        BinaryData IPersistableModel<ContainerRegistryData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ContainerRegistryData)} does not support '{options.Format}' format.");
            }
        }

        ContainerRegistryData IPersistableModel<ContainerRegistryData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerRegistryData(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(ContainerRegistryData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerRegistryData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
