// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabric.Models
{
    public partial class ServiceFabricClusterPatch : IUtf8JsonSerializable, IJsonModel<ServiceFabricClusterPatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ServiceFabricClusterPatch>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ServiceFabricClusterPatch>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceFabricClusterPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(ServiceFabricClusterPatch)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
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
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(AddOnFeatures))
            {
                writer.WritePropertyName("addOnFeatures"u8);
                writer.WriteStartArray();
                foreach (var item in AddOnFeatures)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Certificate))
            {
                writer.WritePropertyName("certificate"u8);
                writer.WriteObjectValue(Certificate);
            }
            if (Optional.IsDefined(CertificateCommonNames))
            {
                writer.WritePropertyName("certificateCommonNames"u8);
                writer.WriteObjectValue(CertificateCommonNames);
            }
            if (Optional.IsCollectionDefined(ClientCertificateCommonNames))
            {
                writer.WritePropertyName("clientCertificateCommonNames"u8);
                writer.WriteStartArray();
                foreach (var item in ClientCertificateCommonNames)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ClientCertificateThumbprints))
            {
                writer.WritePropertyName("clientCertificateThumbprints"u8);
                writer.WriteStartArray();
                foreach (var item in ClientCertificateThumbprints)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ClusterCodeVersion))
            {
                writer.WritePropertyName("clusterCodeVersion"u8);
                writer.WriteStringValue(ClusterCodeVersion);
            }
            if (Optional.IsDefined(IsEventStoreServiceEnabled))
            {
                writer.WritePropertyName("eventStoreServiceEnabled"u8);
                writer.WriteBooleanValue(IsEventStoreServiceEnabled.Value);
            }
            if (Optional.IsCollectionDefined(FabricSettings))
            {
                writer.WritePropertyName("fabricSettings"u8);
                writer.WriteStartArray();
                foreach (var item in FabricSettings)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(NodeTypes))
            {
                writer.WritePropertyName("nodeTypes"u8);
                writer.WriteStartArray();
                foreach (var item in NodeTypes)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ReliabilityLevel))
            {
                writer.WritePropertyName("reliabilityLevel"u8);
                writer.WriteStringValue(ReliabilityLevel.Value.ToString());
            }
            if (Optional.IsDefined(ReverseProxyCertificate))
            {
                writer.WritePropertyName("reverseProxyCertificate"u8);
                writer.WriteObjectValue(ReverseProxyCertificate);
            }
            if (Optional.IsDefined(UpgradeDescription))
            {
                writer.WritePropertyName("upgradeDescription"u8);
                writer.WriteObjectValue(UpgradeDescription);
            }
            if (Optional.IsDefined(ApplicationTypeVersionsCleanupPolicy))
            {
                writer.WritePropertyName("applicationTypeVersionsCleanupPolicy"u8);
                writer.WriteObjectValue(ApplicationTypeVersionsCleanupPolicy);
            }
            if (Optional.IsDefined(UpgradeMode))
            {
                writer.WritePropertyName("upgradeMode"u8);
                writer.WriteStringValue(UpgradeMode.Value.ToString());
            }
            if (Optional.IsDefined(SfZonalUpgradeMode))
            {
                writer.WritePropertyName("sfZonalUpgradeMode"u8);
                writer.WriteStringValue(SfZonalUpgradeMode.Value.ToString());
            }
            if (Optional.IsDefined(VmssZonalUpgradeMode))
            {
                writer.WritePropertyName("vmssZonalUpgradeMode"u8);
                writer.WriteStringValue(VmssZonalUpgradeMode.Value.ToString());
            }
            if (Optional.IsDefined(IsInfrastructureServiceManagerEnabled))
            {
                writer.WritePropertyName("infrastructureServiceManager"u8);
                writer.WriteBooleanValue(IsInfrastructureServiceManagerEnabled.Value);
            }
            if (Optional.IsDefined(UpgradeWave))
            {
                writer.WritePropertyName("upgradeWave"u8);
                writer.WriteStringValue(UpgradeWave.Value.ToString());
            }
            if (Optional.IsDefined(UpgradePauseStartOn))
            {
                writer.WritePropertyName("upgradePauseStartTimestampUtc"u8);
                writer.WriteStringValue(UpgradePauseStartOn.Value, "O");
            }
            if (Optional.IsDefined(UpgradePauseEndOn))
            {
                writer.WritePropertyName("upgradePauseEndTimestampUtc"u8);
                writer.WriteStringValue(UpgradePauseEndOn.Value, "O");
            }
            if (Optional.IsDefined(IsWaveUpgradePaused))
            {
                writer.WritePropertyName("waveUpgradePaused"u8);
                writer.WriteBooleanValue(IsWaveUpgradePaused.Value);
            }
            if (Optional.IsCollectionDefined(Notifications))
            {
                writer.WritePropertyName("notifications"u8);
                writer.WriteStartArray();
                foreach (var item in Notifications)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        ServiceFabricClusterPatch IJsonModel<ServiceFabricClusterPatch>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceFabricClusterPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(ServiceFabricClusterPatch)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeServiceFabricClusterPatch(document.RootElement, options);
        }

        internal static ServiceFabricClusterPatch DeserializeServiceFabricClusterPatch(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IDictionary<string, string>> tags = default;
            Optional<IList<ClusterAddOnFeature>> addOnFeatures = default;
            Optional<ClusterCertificateDescription> certificate = default;
            Optional<ClusterServerCertificateCommonNames> certificateCommonNames = default;
            Optional<IList<ClusterClientCertificateCommonName>> clientCertificateCommonNames = default;
            Optional<IList<ClusterClientCertificateThumbprint>> clientCertificateThumbprints = default;
            Optional<string> clusterCodeVersion = default;
            Optional<bool> eventStoreServiceEnabled = default;
            Optional<IList<SettingsSectionDescription>> fabricSettings = default;
            Optional<IList<ClusterNodeTypeDescription>> nodeTypes = default;
            Optional<ClusterReliabilityLevel> reliabilityLevel = default;
            Optional<ClusterCertificateDescription> reverseProxyCertificate = default;
            Optional<ClusterUpgradePolicy> upgradeDescription = default;
            Optional<ApplicationTypeVersionsCleanupPolicy> applicationTypeVersionsCleanupPolicy = default;
            Optional<ClusterUpgradeMode> upgradeMode = default;
            Optional<SfZonalUpgradeMode> sfZonalUpgradeMode = default;
            Optional<VmssZonalUpgradeMode> vmssZonalUpgradeMode = default;
            Optional<bool> infrastructureServiceManager = default;
            Optional<ClusterUpgradeCadence> upgradeWave = default;
            Optional<DateTimeOffset> upgradePauseStartTimestampUtc = default;
            Optional<DateTimeOffset> upgradePauseEndTimestampUtc = default;
            Optional<bool> waveUpgradePaused = default;
            Optional<IList<ClusterNotification>> notifications = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("addOnFeatures"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ClusterAddOnFeature> array = new List<ClusterAddOnFeature>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(new ClusterAddOnFeature(item.GetString()));
                            }
                            addOnFeatures = array;
                            continue;
                        }
                        if (property0.NameEquals("certificate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            certificate = ClusterCertificateDescription.DeserializeClusterCertificateDescription(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("certificateCommonNames"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            certificateCommonNames = ClusterServerCertificateCommonNames.DeserializeClusterServerCertificateCommonNames(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("clientCertificateCommonNames"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ClusterClientCertificateCommonName> array = new List<ClusterClientCertificateCommonName>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ClusterClientCertificateCommonName.DeserializeClusterClientCertificateCommonName(item));
                            }
                            clientCertificateCommonNames = array;
                            continue;
                        }
                        if (property0.NameEquals("clientCertificateThumbprints"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ClusterClientCertificateThumbprint> array = new List<ClusterClientCertificateThumbprint>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ClusterClientCertificateThumbprint.DeserializeClusterClientCertificateThumbprint(item));
                            }
                            clientCertificateThumbprints = array;
                            continue;
                        }
                        if (property0.NameEquals("clusterCodeVersion"u8))
                        {
                            clusterCodeVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("eventStoreServiceEnabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            eventStoreServiceEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("fabricSettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<SettingsSectionDescription> array = new List<SettingsSectionDescription>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(SettingsSectionDescription.DeserializeSettingsSectionDescription(item));
                            }
                            fabricSettings = array;
                            continue;
                        }
                        if (property0.NameEquals("nodeTypes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ClusterNodeTypeDescription> array = new List<ClusterNodeTypeDescription>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ClusterNodeTypeDescription.DeserializeClusterNodeTypeDescription(item));
                            }
                            nodeTypes = array;
                            continue;
                        }
                        if (property0.NameEquals("reliabilityLevel"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            reliabilityLevel = new ClusterReliabilityLevel(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("reverseProxyCertificate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            reverseProxyCertificate = ClusterCertificateDescription.DeserializeClusterCertificateDescription(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("upgradeDescription"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            upgradeDescription = ClusterUpgradePolicy.DeserializeClusterUpgradePolicy(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("applicationTypeVersionsCleanupPolicy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            applicationTypeVersionsCleanupPolicy = ApplicationTypeVersionsCleanupPolicy.DeserializeApplicationTypeVersionsCleanupPolicy(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("upgradeMode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            upgradeMode = new ClusterUpgradeMode(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("sfZonalUpgradeMode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sfZonalUpgradeMode = new SfZonalUpgradeMode(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("vmssZonalUpgradeMode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            vmssZonalUpgradeMode = new VmssZonalUpgradeMode(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("infrastructureServiceManager"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            infrastructureServiceManager = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("upgradeWave"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            upgradeWave = new ClusterUpgradeCadence(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("upgradePauseStartTimestampUtc"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            upgradePauseStartTimestampUtc = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("upgradePauseEndTimestampUtc"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            upgradePauseEndTimestampUtc = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("waveUpgradePaused"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            waveUpgradePaused = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("notifications"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ClusterNotification> array = new List<ClusterNotification>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ClusterNotification.DeserializeClusterNotification(item));
                            }
                            notifications = array;
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
            return new ServiceFabricClusterPatch(Optional.ToDictionary(tags), Optional.ToList(addOnFeatures), certificate.Value, certificateCommonNames.Value, Optional.ToList(clientCertificateCommonNames), Optional.ToList(clientCertificateThumbprints), clusterCodeVersion.Value, Optional.ToNullable(eventStoreServiceEnabled), Optional.ToList(fabricSettings), Optional.ToList(nodeTypes), Optional.ToNullable(reliabilityLevel), reverseProxyCertificate.Value, upgradeDescription.Value, applicationTypeVersionsCleanupPolicy.Value, Optional.ToNullable(upgradeMode), Optional.ToNullable(sfZonalUpgradeMode), Optional.ToNullable(vmssZonalUpgradeMode), Optional.ToNullable(infrastructureServiceManager), Optional.ToNullable(upgradeWave), Optional.ToNullable(upgradePauseStartTimestampUtc), Optional.ToNullable(upgradePauseEndTimestampUtc), Optional.ToNullable(waveUpgradePaused), Optional.ToList(notifications), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ServiceFabricClusterPatch>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceFabricClusterPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(ServiceFabricClusterPatch)} does not support '{options.Format}' format.");
            }
        }

        ServiceFabricClusterPatch IPersistableModel<ServiceFabricClusterPatch>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceFabricClusterPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeServiceFabricClusterPatch(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(ServiceFabricClusterPatch)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ServiceFabricClusterPatch>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
