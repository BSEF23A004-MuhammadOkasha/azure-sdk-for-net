// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.HybridCompute.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.HybridCompute
{
    public partial class HybridComputeMachineData : IUtf8JsonSerializable, IJsonModel<HybridComputeMachineData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HybridComputeMachineData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<HybridComputeMachineData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HybridComputeMachineData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HybridComputeMachineData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsCollectionDefined(Resources))
            {
                writer.WritePropertyName("resources"u8);
                writer.WriteStartArray();
                foreach (var item in Resources)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity"u8);
                JsonSerializer.Serialize(writer, Identity);
            }
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind.Value.ToString());
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
            if (Optional.IsDefined(LocationData))
            {
                writer.WritePropertyName("locationData"u8);
                writer.WriteObjectValue(LocationData);
            }
            if (options.Format != "W" && Optional.IsDefined(AgentConfiguration))
            {
                writer.WritePropertyName("agentConfiguration"u8);
                writer.WriteObjectValue(AgentConfiguration);
            }
            if (Optional.IsDefined(ServiceStatuses))
            {
                writer.WritePropertyName("serviceStatuses"u8);
                writer.WriteObjectValue(ServiceStatuses);
            }
            if (Optional.IsDefined(CloudMetadata))
            {
                writer.WritePropertyName("cloudMetadata"u8);
                writer.WriteObjectValue(CloudMetadata);
            }
            if (Optional.IsDefined(AgentUpgrade))
            {
                writer.WritePropertyName("agentUpgrade"u8);
                writer.WriteObjectValue(AgentUpgrade);
            }
            if (Optional.IsDefined(OSProfile))
            {
                writer.WritePropertyName("osProfile"u8);
                writer.WriteObjectValue(OSProfile);
            }
            if (Optional.IsDefined(LicenseProfile))
            {
                writer.WritePropertyName("licenseProfile"u8);
                writer.WriteObjectValue(LicenseProfile);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState);
            }
            if (options.Format != "W" && Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(LastStatusChange))
            {
                writer.WritePropertyName("lastStatusChange"u8);
                writer.WriteStringValue(LastStatusChange.Value, "O");
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(ErrorDetails))
            {
                writer.WritePropertyName("errorDetails"u8);
                writer.WriteStartArray();
                foreach (var item in ErrorDetails)
                {
                    JsonSerializer.Serialize(writer, item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(AgentVersion))
            {
                writer.WritePropertyName("agentVersion"u8);
                writer.WriteStringValue(AgentVersion);
            }
            if (Optional.IsDefined(VmId))
            {
                writer.WritePropertyName("vmId"u8);
                writer.WriteStringValue(VmId.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (options.Format != "W" && Optional.IsDefined(MachineFqdn))
            {
                writer.WritePropertyName("machineFqdn"u8);
                writer.WriteStringValue(MachineFqdn);
            }
            if (Optional.IsDefined(ClientPublicKey))
            {
                writer.WritePropertyName("clientPublicKey"u8);
                writer.WriteStringValue(ClientPublicKey);
            }
            if (options.Format != "W" && Optional.IsDefined(OSName))
            {
                writer.WritePropertyName("osName"u8);
                writer.WriteStringValue(OSName);
            }
            if (options.Format != "W" && Optional.IsDefined(OSVersion))
            {
                writer.WritePropertyName("osVersion"u8);
                writer.WriteStringValue(OSVersion);
            }
            if (Optional.IsDefined(OSType))
            {
                writer.WritePropertyName("osType"u8);
                writer.WriteStringValue(OSType);
            }
            if (options.Format != "W" && Optional.IsDefined(VmUuid))
            {
                writer.WritePropertyName("vmUuid"u8);
                writer.WriteStringValue(VmUuid.Value);
            }
            if (Optional.IsCollectionDefined(Extensions))
            {
                writer.WritePropertyName("extensions"u8);
                writer.WriteStartArray();
                foreach (var item in Extensions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(OSSku))
            {
                writer.WritePropertyName("osSku"u8);
                writer.WriteStringValue(OSSku);
            }
            if (options.Format != "W" && Optional.IsDefined(OSEdition))
            {
                writer.WritePropertyName("osEdition"u8);
                writer.WriteStringValue(OSEdition);
            }
            if (options.Format != "W" && Optional.IsDefined(DomainName))
            {
                writer.WritePropertyName("domainName"u8);
                writer.WriteStringValue(DomainName);
            }
            if (options.Format != "W" && Optional.IsDefined(ADFqdn))
            {
                writer.WritePropertyName("adFqdn"u8);
                writer.WriteStringValue(ADFqdn);
            }
            if (options.Format != "W" && Optional.IsDefined(DnsFqdn))
            {
                writer.WritePropertyName("dnsFqdn"u8);
                writer.WriteStringValue(DnsFqdn);
            }
            if (Optional.IsDefined(PrivateLinkScopeResourceId))
            {
                writer.WritePropertyName("privateLinkScopeResourceId"u8);
                writer.WriteStringValue(PrivateLinkScopeResourceId);
            }
            if (Optional.IsDefined(ParentClusterResourceId))
            {
                writer.WritePropertyName("parentClusterResourceId"u8);
                writer.WriteStringValue(ParentClusterResourceId);
            }
            if (Optional.IsDefined(MSSqlDiscovered))
            {
                writer.WritePropertyName("mssqlDiscovered"u8);
                writer.WriteStringValue(MSSqlDiscovered);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(DetectedProperties))
            {
                writer.WritePropertyName("detectedProperties"u8);
                writer.WriteStartObject();
                foreach (var item in DetectedProperties)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (options.Format != "W" && Optional.IsDefined(NetworkProfile))
            {
                writer.WritePropertyName("networkProfile"u8);
                writer.WriteObjectValue(NetworkProfile);
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

        HybridComputeMachineData IJsonModel<HybridComputeMachineData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HybridComputeMachineData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HybridComputeMachineData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHybridComputeMachineData(document.RootElement, options);
        }

        internal static HybridComputeMachineData DeserializeHybridComputeMachineData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<HybridComputeMachineExtensionData> resources = default;
            ManagedServiceIdentity identity = default;
            ArcKindEnum? kind = default;
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            HybridComputeLocation locationData = default;
            AgentConfiguration agentConfiguration = default;
            HybridComputeServiceStatuses serviceStatuses = default;
            HybridComputeCloudMetadata cloudMetadata = default;
            AgentUpgrade agentUpgrade = default;
            HybridComputeOSProfile osProfile = default;
            LicenseProfileMachineInstanceView licenseProfile = default;
            string provisioningState = default;
            HybridComputeStatusType? status = default;
            DateTimeOffset? lastStatusChange = default;
            IReadOnlyList<ResponseError> errorDetails = default;
            string agentVersion = default;
            Guid? vmId = default;
            string displayName = default;
            string machineFqdn = default;
            string clientPublicKey = default;
            string osName = default;
            string osVersion = default;
            string osType = default;
            Guid? vmUuid = default;
            IList<MachineExtensionInstanceView> extensions = default;
            string osSku = default;
            string osEdition = default;
            string domainName = default;
            string adFqdn = default;
            string dnsFqdn = default;
            ResourceIdentifier privateLinkScopeResourceId = default;
            ResourceIdentifier parentClusterResourceId = default;
            string mssqlDiscovered = default;
            IReadOnlyDictionary<string, string> detectedProperties = default;
            HybridComputeNetworkProfile networkProfile = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resources"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<HybridComputeMachineExtensionData> array = new List<HybridComputeMachineExtensionData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HybridComputeMachineExtensionData.DeserializeHybridComputeMachineExtensionData(item, options));
                    }
                    resources = array;
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
                if (property.NameEquals("kind"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    kind = new ArcKindEnum(property.Value.GetString());
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
                        if (property0.NameEquals("locationData"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            locationData = HybridComputeLocation.DeserializeHybridComputeLocation(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("agentConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            agentConfiguration = AgentConfiguration.DeserializeAgentConfiguration(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("serviceStatuses"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            serviceStatuses = HybridComputeServiceStatuses.DeserializeHybridComputeServiceStatuses(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("cloudMetadata"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            cloudMetadata = HybridComputeCloudMetadata.DeserializeHybridComputeCloudMetadata(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("agentUpgrade"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            agentUpgrade = AgentUpgrade.DeserializeAgentUpgrade(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("osProfile"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            osProfile = HybridComputeOSProfile.DeserializeHybridComputeOSProfile(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("licenseProfile"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            licenseProfile = LicenseProfileMachineInstanceView.DeserializeLicenseProfileMachineInstanceView(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("status"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            status = new HybridComputeStatusType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("lastStatusChange"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastStatusChange = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("errorDetails"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ResponseError> array = new List<ResponseError>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(JsonSerializer.Deserialize<ResponseError>(item.GetRawText()));
                            }
                            errorDetails = array;
                            continue;
                        }
                        if (property0.NameEquals("agentVersion"u8))
                        {
                            agentVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("vmId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            vmId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("displayName"u8))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("machineFqdn"u8))
                        {
                            machineFqdn = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("clientPublicKey"u8))
                        {
                            clientPublicKey = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("osName"u8))
                        {
                            osName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("osVersion"u8))
                        {
                            osVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("osType"u8))
                        {
                            osType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("vmUuid"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            vmUuid = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("extensions"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<MachineExtensionInstanceView> array = new List<MachineExtensionInstanceView>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(MachineExtensionInstanceView.DeserializeMachineExtensionInstanceView(item, options));
                            }
                            extensions = array;
                            continue;
                        }
                        if (property0.NameEquals("osSku"u8))
                        {
                            osSku = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("osEdition"u8))
                        {
                            osEdition = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("domainName"u8))
                        {
                            domainName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("adFqdn"u8))
                        {
                            adFqdn = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("dnsFqdn"u8))
                        {
                            dnsFqdn = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("privateLinkScopeResourceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            privateLinkScopeResourceId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("parentClusterResourceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            parentClusterResourceId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("mssqlDiscovered"u8))
                        {
                            mssqlDiscovered = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("detectedProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, string> dictionary = new Dictionary<string, string>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, property1.Value.GetString());
                            }
                            detectedProperties = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("networkProfile"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            networkProfile = HybridComputeNetworkProfile.DeserializeHybridComputeNetworkProfile(property0.Value, options);
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
            return new HybridComputeMachineData(
                id,
                name,
                type,
                systemData,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                location,
                resources ?? new ChangeTrackingList<HybridComputeMachineExtensionData>(),
                identity,
                kind,
                locationData,
                agentConfiguration,
                serviceStatuses,
                cloudMetadata,
                agentUpgrade,
                osProfile,
                licenseProfile,
                provisioningState,
                status,
                lastStatusChange,
                errorDetails ?? new ChangeTrackingList<ResponseError>(),
                agentVersion,
                vmId,
                displayName,
                machineFqdn,
                clientPublicKey,
                osName,
                osVersion,
                osType,
                vmUuid,
                extensions ?? new ChangeTrackingList<MachineExtensionInstanceView>(),
                osSku,
                osEdition,
                domainName,
                adFqdn,
                dnsFqdn,
                privateLinkScopeResourceId,
                parentClusterResourceId,
                mssqlDiscovered,
                detectedProperties ?? new ChangeTrackingDictionary<string, string>(),
                networkProfile,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<HybridComputeMachineData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HybridComputeMachineData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(HybridComputeMachineData)} does not support '{options.Format}' format.");
            }
        }

        HybridComputeMachineData IPersistableModel<HybridComputeMachineData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HybridComputeMachineData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeHybridComputeMachineData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HybridComputeMachineData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<HybridComputeMachineData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
