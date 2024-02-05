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
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Compute
{
    public partial class CloudServiceData : IUtf8JsonSerializable, IJsonModel<CloudServiceData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CloudServiceData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CloudServiceData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CloudServiceData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CloudServiceData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Zones))
            {
                writer.WritePropertyName("zones"u8);
                writer.WriteStartArray();
                foreach (var item in Zones)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
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
            if (Optional.IsDefined(PackageUri))
            {
                writer.WritePropertyName("packageUrl"u8);
                writer.WriteStringValue(PackageUri.AbsoluteUri);
            }
            if (Optional.IsDefined(Configuration))
            {
                writer.WritePropertyName("configuration"u8);
                writer.WriteStringValue(Configuration);
            }
            if (Optional.IsDefined(ConfigurationUri))
            {
                writer.WritePropertyName("configurationUrl"u8);
                writer.WriteStringValue(ConfigurationUri.AbsoluteUri);
            }
            if (Optional.IsDefined(StartCloudService))
            {
                writer.WritePropertyName("startCloudService"u8);
                writer.WriteBooleanValue(StartCloudService.Value);
            }
            if (Optional.IsDefined(AllowModelOverride))
            {
                writer.WritePropertyName("allowModelOverride"u8);
                writer.WriteBooleanValue(AllowModelOverride.Value);
            }
            if (Optional.IsDefined(UpgradeMode))
            {
                writer.WritePropertyName("upgradeMode"u8);
                writer.WriteStringValue(UpgradeMode.Value.ToString());
            }
            if (Optional.IsDefined(RoleProfile))
            {
                writer.WritePropertyName("roleProfile"u8);
                writer.WriteObjectValue(RoleProfile);
            }
            if (Optional.IsDefined(OSProfile))
            {
                writer.WritePropertyName("osProfile"u8);
                writer.WriteObjectValue(OSProfile);
            }
            if (Optional.IsDefined(NetworkProfile))
            {
                writer.WritePropertyName("networkProfile"u8);
                writer.WriteObjectValue(NetworkProfile);
            }
            if (Optional.IsDefined(ExtensionProfile))
            {
                writer.WritePropertyName("extensionProfile"u8);
                writer.WriteObjectValue(ExtensionProfile);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState);
            }
            if (options.Format != "W" && Optional.IsDefined(UniqueId))
            {
                writer.WritePropertyName("uniqueId"u8);
                writer.WriteStringValue(UniqueId);
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

        CloudServiceData IJsonModel<CloudServiceData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CloudServiceData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CloudServiceData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCloudServiceData(document.RootElement, options);
        }

        internal static CloudServiceData DeserializeCloudServiceData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<string>> zones = default;
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<Uri> packageUrl = default;
            Optional<string> configuration = default;
            Optional<Uri> configurationUrl = default;
            Optional<bool> startCloudService = default;
            Optional<bool> allowModelOverride = default;
            Optional<CloudServiceUpgradeMode> upgradeMode = default;
            Optional<CloudServiceRoleProfile> roleProfile = default;
            Optional<CloudServiceOSProfile> osProfile = default;
            Optional<CloudServiceNetworkProfile> networkProfile = default;
            Optional<CloudServiceExtensionProfile> extensionProfile = default;
            Optional<string> provisioningState = default;
            Optional<string> uniqueId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("zones"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    zones = array;
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
                        if (property0.NameEquals("packageUrl"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            packageUrl = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("configuration"u8))
                        {
                            configuration = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("configurationUrl"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            configurationUrl = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("startCloudService"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            startCloudService = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("allowModelOverride"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            allowModelOverride = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("upgradeMode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            upgradeMode = new CloudServiceUpgradeMode(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("roleProfile"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            roleProfile = CloudServiceRoleProfile.DeserializeCloudServiceRoleProfile(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("osProfile"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            osProfile = CloudServiceOSProfile.DeserializeCloudServiceOSProfile(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("networkProfile"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            networkProfile = CloudServiceNetworkProfile.DeserializeCloudServiceNetworkProfile(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("extensionProfile"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            extensionProfile = CloudServiceExtensionProfile.DeserializeCloudServiceExtensionProfile(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("uniqueId"u8))
                        {
                            uniqueId = property0.Value.GetString();
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
            return new CloudServiceData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, Optional.ToList(zones), packageUrl.Value, configuration.Value, configurationUrl.Value, Optional.ToNullable(startCloudService), Optional.ToNullable(allowModelOverride), Optional.ToNullable(upgradeMode), roleProfile.Value, osProfile.Value, networkProfile.Value, extensionProfile.Value, provisioningState.Value, uniqueId.Value, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsCollectionDefined(Zones))
            {
                if (Zones.Any())
                {
                    builder.Append("  zones:");
                    builder.AppendLine(" [");
                    foreach (var item in Zones)
                    {
                        if (item == null)
                        {
                            builder.Append("null");
                            continue;
                        }
                        builder.AppendLine($"    '{item}'");
                    }
                    builder.AppendLine("  ]");
                }
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
            if (Optional.IsDefined(PackageUri))
            {
                builder.Append("    packageUrl:");
                builder.AppendLine($" '{PackageUri.AbsoluteUri}'");
            }

            if (Optional.IsDefined(Configuration))
            {
                builder.Append("    configuration:");
                builder.AppendLine($" '{Configuration}'");
            }

            if (Optional.IsDefined(ConfigurationUri))
            {
                builder.Append("    configurationUrl:");
                builder.AppendLine($" '{ConfigurationUri.AbsoluteUri}'");
            }

            if (Optional.IsDefined(StartCloudService))
            {
                builder.Append("    startCloudService:");
                var boolValue = StartCloudService.Value == true ? "true" : "false";
                builder.AppendLine($" {boolValue}");
            }

            if (Optional.IsDefined(AllowModelOverride))
            {
                builder.Append("    allowModelOverride:");
                var boolValue = AllowModelOverride.Value == true ? "true" : "false";
                builder.AppendLine($" {boolValue}");
            }

            if (Optional.IsDefined(UpgradeMode))
            {
                builder.Append("    upgradeMode:");
                builder.AppendLine($" '{UpgradeMode.ToString()}'");
            }

            if (Optional.IsDefined(RoleProfile))
            {
                builder.Append("    roleProfile:");
                AppendChildObject(builder, RoleProfile, options, 4, false);
            }

            if (Optional.IsDefined(OSProfile))
            {
                builder.Append("    osProfile:");
                AppendChildObject(builder, OSProfile, options, 4, false);
            }

            if (Optional.IsDefined(NetworkProfile))
            {
                builder.Append("    networkProfile:");
                AppendChildObject(builder, NetworkProfile, options, 4, false);
            }

            if (Optional.IsDefined(ExtensionProfile))
            {
                builder.Append("    extensionProfile:");
                AppendChildObject(builder, ExtensionProfile, options, 4, false);
            }

            if (Optional.IsDefined(ProvisioningState))
            {
                builder.Append("    provisioningState:");
                builder.AppendLine($" '{ProvisioningState}'");
            }

            if (Optional.IsDefined(UniqueId))
            {
                builder.Append("    uniqueId:");
                builder.AppendLine($" '{UniqueId}'");
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

        BinaryData IPersistableModel<CloudServiceData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CloudServiceData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(CloudServiceData)} does not support '{options.Format}' format.");
            }
        }

        CloudServiceData IPersistableModel<CloudServiceData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CloudServiceData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCloudServiceData(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(CloudServiceData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CloudServiceData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
