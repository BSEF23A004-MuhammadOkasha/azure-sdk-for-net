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

namespace Azure.ResourceManager.RecoveryServicesDataReplication.Models
{
    public partial class HyperVToAzStackHciReplicationExtensionModelCustomProperties : IUtf8JsonSerializable, IJsonModel<HyperVToAzStackHciReplicationExtensionModelCustomProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HyperVToAzStackHciReplicationExtensionModelCustomProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<HyperVToAzStackHciReplicationExtensionModelCustomProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HyperVToAzStackHciReplicationExtensionModelCustomProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(HyperVToAzStackHciReplicationExtensionModelCustomProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("hyperVFabricArmId"u8);
            writer.WriteStringValue(HyperVFabricArmId);
            if (options.Format != "W" && Optional.IsDefined(HyperVSiteId))
            {
                writer.WritePropertyName("hyperVSiteId"u8);
                writer.WriteStringValue(HyperVSiteId);
            }
            writer.WritePropertyName("azStackHciFabricArmId"u8);
            writer.WriteStringValue(AzStackHciFabricArmId);
            if (options.Format != "W" && Optional.IsDefined(AzStackHciSiteId))
            {
                writer.WritePropertyName("azStackHciSiteId"u8);
                writer.WriteStringValue(AzStackHciSiteId);
            }
            if (Optional.IsDefined(StorageAccountId))
            {
                writer.WritePropertyName("storageAccountId"u8);
                writer.WriteStringValue(StorageAccountId);
            }
            if (Optional.IsDefined(StorageAccountSasSecretName))
            {
                writer.WritePropertyName("storageAccountSasSecretName"u8);
                writer.WriteStringValue(StorageAccountSasSecretName);
            }
            if (options.Format != "W" && Optional.IsDefined(AsrServiceUri))
            {
                writer.WritePropertyName("asrServiceUri"u8);
                writer.WriteStringValue(AsrServiceUri.AbsoluteUri);
            }
            if (options.Format != "W" && Optional.IsDefined(RcmServiceUri))
            {
                writer.WritePropertyName("rcmServiceUri"u8);
                writer.WriteStringValue(RcmServiceUri.AbsoluteUri);
            }
            if (options.Format != "W" && Optional.IsDefined(GatewayServiceUri))
            {
                writer.WritePropertyName("gatewayServiceUri"u8);
                writer.WriteStringValue(GatewayServiceUri.AbsoluteUri);
            }
            if (options.Format != "W" && Optional.IsDefined(SourceGatewayServiceId))
            {
                writer.WritePropertyName("sourceGatewayServiceId"u8);
                writer.WriteStringValue(SourceGatewayServiceId);
            }
            if (options.Format != "W" && Optional.IsDefined(TargetGatewayServiceId))
            {
                writer.WritePropertyName("targetGatewayServiceId"u8);
                writer.WriteStringValue(TargetGatewayServiceId);
            }
            if (options.Format != "W" && Optional.IsDefined(SourceStorageContainerName))
            {
                writer.WritePropertyName("sourceStorageContainerName"u8);
                writer.WriteStringValue(SourceStorageContainerName);
            }
            if (options.Format != "W" && Optional.IsDefined(TargetStorageContainerName))
            {
                writer.WritePropertyName("targetStorageContainerName"u8);
                writer.WriteStringValue(TargetStorageContainerName);
            }
            if (options.Format != "W" && Optional.IsDefined(ResourceLocation))
            {
                writer.WritePropertyName("resourceLocation"u8);
                writer.WriteStringValue(ResourceLocation);
            }
            if (options.Format != "W" && Optional.IsDefined(SubscriptionId))
            {
                writer.WritePropertyName("subscriptionId"u8);
                writer.WriteStringValue(SubscriptionId);
            }
            if (options.Format != "W" && Optional.IsDefined(ResourceGroup))
            {
                writer.WritePropertyName("resourceGroup"u8);
                writer.WriteStringValue(ResourceGroup);
            }
            writer.WritePropertyName("instanceType"u8);
            writer.WriteStringValue(InstanceType);
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

        HyperVToAzStackHciReplicationExtensionModelCustomProperties IJsonModel<HyperVToAzStackHciReplicationExtensionModelCustomProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HyperVToAzStackHciReplicationExtensionModelCustomProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(HyperVToAzStackHciReplicationExtensionModelCustomProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHyperVToAzStackHciReplicationExtensionModelCustomProperties(document.RootElement, options);
        }

        internal static HyperVToAzStackHciReplicationExtensionModelCustomProperties DeserializeHyperVToAzStackHciReplicationExtensionModelCustomProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier hyperVFabricArmId = default;
            Optional<ResourceIdentifier> hyperVSiteId = default;
            ResourceIdentifier azStackHciFabricArmId = default;
            Optional<ResourceIdentifier> azStackHciSiteId = default;
            Optional<string> storageAccountId = default;
            Optional<string> storageAccountSasSecretName = default;
            Optional<Uri> asrServiceUri = default;
            Optional<Uri> rcmServiceUri = default;
            Optional<Uri> gatewayServiceUri = default;
            Optional<string> sourceGatewayServiceId = default;
            Optional<string> targetGatewayServiceId = default;
            Optional<string> sourceStorageContainerName = default;
            Optional<string> targetStorageContainerName = default;
            Optional<string> resourceLocation = default;
            Optional<string> subscriptionId = default;
            Optional<string> resourceGroup = default;
            string instanceType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("hyperVFabricArmId"u8))
                {
                    hyperVFabricArmId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("hyperVSiteId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    hyperVSiteId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("azStackHciFabricArmId"u8))
                {
                    azStackHciFabricArmId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("azStackHciSiteId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    azStackHciSiteId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("storageAccountId"u8))
                {
                    storageAccountId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("storageAccountSasSecretName"u8))
                {
                    storageAccountSasSecretName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("asrServiceUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    asrServiceUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("rcmServiceUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rcmServiceUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("gatewayServiceUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    gatewayServiceUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sourceGatewayServiceId"u8))
                {
                    sourceGatewayServiceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetGatewayServiceId"u8))
                {
                    targetGatewayServiceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceStorageContainerName"u8))
                {
                    sourceStorageContainerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetStorageContainerName"u8))
                {
                    targetStorageContainerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceLocation"u8))
                {
                    resourceLocation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subscriptionId"u8))
                {
                    subscriptionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceGroup"u8))
                {
                    resourceGroup = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("instanceType"u8))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new HyperVToAzStackHciReplicationExtensionModelCustomProperties(instanceType, serializedAdditionalRawData, hyperVFabricArmId, hyperVSiteId.Value, azStackHciFabricArmId, azStackHciSiteId.Value, storageAccountId.Value, storageAccountSasSecretName.Value, asrServiceUri.Value, rcmServiceUri.Value, gatewayServiceUri.Value, sourceGatewayServiceId.Value, targetGatewayServiceId.Value, sourceStorageContainerName.Value, targetStorageContainerName.Value, resourceLocation.Value, subscriptionId.Value, resourceGroup.Value);
        }

        BinaryData IPersistableModel<HyperVToAzStackHciReplicationExtensionModelCustomProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HyperVToAzStackHciReplicationExtensionModelCustomProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(HyperVToAzStackHciReplicationExtensionModelCustomProperties)} does not support '{options.Format}' format.");
            }
        }

        HyperVToAzStackHciReplicationExtensionModelCustomProperties IPersistableModel<HyperVToAzStackHciReplicationExtensionModelCustomProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HyperVToAzStackHciReplicationExtensionModelCustomProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeHyperVToAzStackHciReplicationExtensionModelCustomProperties(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(HyperVToAzStackHciReplicationExtensionModelCustomProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<HyperVToAzStackHciReplicationExtensionModelCustomProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
