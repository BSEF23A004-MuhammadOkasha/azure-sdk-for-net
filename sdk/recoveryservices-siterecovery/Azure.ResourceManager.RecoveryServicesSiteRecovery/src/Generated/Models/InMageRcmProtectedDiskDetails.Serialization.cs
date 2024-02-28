// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class InMageRcmProtectedDiskDetails : IUtf8JsonSerializable, IJsonModel<InMageRcmProtectedDiskDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<InMageRcmProtectedDiskDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<InMageRcmProtectedDiskDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageRcmProtectedDiskDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InMageRcmProtectedDiskDetails)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && DiskId != null)
            {
                writer.WritePropertyName("diskId"u8);
                writer.WriteStringValue(DiskId);
            }
            if (options.Format != "W" && DiskName != null)
            {
                writer.WritePropertyName("diskName"u8);
                writer.WriteStringValue(DiskName);
            }
            if (options.Format != "W" && IsOSDisk != null)
            {
                writer.WritePropertyName("isOSDisk"u8);
                writer.WriteStringValue(IsOSDisk);
            }
            if (options.Format != "W" && CapacityInBytes.HasValue)
            {
                writer.WritePropertyName("capacityInBytes"u8);
                writer.WriteNumberValue(CapacityInBytes.Value);
            }
            if (options.Format != "W" && LogStorageAccountId != null)
            {
                writer.WritePropertyName("logStorageAccountId"u8);
                writer.WriteStringValue(LogStorageAccountId);
            }
            if (options.Format != "W" && DiskEncryptionSetId != null)
            {
                writer.WritePropertyName("diskEncryptionSetId"u8);
                writer.WriteStringValue(DiskEncryptionSetId);
            }
            if (options.Format != "W" && SeedManagedDiskId != null)
            {
                writer.WritePropertyName("seedManagedDiskId"u8);
                writer.WriteStringValue(SeedManagedDiskId);
            }
            if (options.Format != "W" && SeedBlobUri != null)
            {
                writer.WritePropertyName("seedBlobUri"u8);
                writer.WriteStringValue(SeedBlobUri.AbsoluteUri);
            }
            if (options.Format != "W" && TargetManagedDiskId != null)
            {
                writer.WritePropertyName("targetManagedDiskId"u8);
                writer.WriteStringValue(TargetManagedDiskId);
            }
            if (DiskType.HasValue)
            {
                writer.WritePropertyName("diskType"u8);
                writer.WriteStringValue(DiskType.Value.ToString());
            }
            if (options.Format != "W" && DataPendingInLogDataStoreInMB.HasValue)
            {
                writer.WritePropertyName("dataPendingInLogDataStoreInMB"u8);
                writer.WriteNumberValue(DataPendingInLogDataStoreInMB.Value);
            }
            if (options.Format != "W" && DataPendingAtSourceAgentInMB.HasValue)
            {
                writer.WritePropertyName("dataPendingAtSourceAgentInMB"u8);
                writer.WriteNumberValue(DataPendingAtSourceAgentInMB.Value);
            }
            if (options.Format != "W" && IsInitialReplicationComplete != null)
            {
                writer.WritePropertyName("isInitialReplicationComplete"u8);
                writer.WriteStringValue(IsInitialReplicationComplete);
            }
            if (IrDetails != null)
            {
                writer.WritePropertyName("irDetails"u8);
                writer.WriteObjectValue(IrDetails);
            }
            if (ResyncDetails != null)
            {
                writer.WritePropertyName("resyncDetails"u8);
                writer.WriteObjectValue(ResyncDetails);
            }
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

        InMageRcmProtectedDiskDetails IJsonModel<InMageRcmProtectedDiskDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageRcmProtectedDiskDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InMageRcmProtectedDiskDetails)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInMageRcmProtectedDiskDetails(document.RootElement, options);
        }

        internal static InMageRcmProtectedDiskDetails DeserializeInMageRcmProtectedDiskDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string diskId = default;
            string diskName = default;
            string isOSDisk = default;
            long? capacityInBytes = default;
            ResourceIdentifier logStorageAccountId = default;
            ResourceIdentifier diskEncryptionSetId = default;
            string seedManagedDiskId = default;
            Uri seedBlobUri = default;
            string targetManagedDiskId = default;
            SiteRecoveryDiskAccountType? diskType = default;
            double? dataPendingInLogDataStoreInMB = default;
            double? dataPendingAtSourceAgentInMB = default;
            string isInitialReplicationComplete = default;
            InMageRcmSyncDetails irDetails = default;
            InMageRcmSyncDetails resyncDetails = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("diskId"u8))
                {
                    diskId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("diskName"u8))
                {
                    diskName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isOSDisk"u8))
                {
                    isOSDisk = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("capacityInBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    capacityInBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("logStorageAccountId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    logStorageAccountId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("diskEncryptionSetId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    diskEncryptionSetId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("seedManagedDiskId"u8))
                {
                    seedManagedDiskId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("seedBlobUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    seedBlobUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetManagedDiskId"u8))
                {
                    targetManagedDiskId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("diskType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    diskType = new SiteRecoveryDiskAccountType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dataPendingInLogDataStoreInMB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataPendingInLogDataStoreInMB = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("dataPendingAtSourceAgentInMB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataPendingAtSourceAgentInMB = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("isInitialReplicationComplete"u8))
                {
                    isInitialReplicationComplete = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("irDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    irDetails = InMageRcmSyncDetails.DeserializeInMageRcmSyncDetails(property.Value, options);
                    continue;
                }
                if (property.NameEquals("resyncDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resyncDetails = InMageRcmSyncDetails.DeserializeInMageRcmSyncDetails(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new InMageRcmProtectedDiskDetails(
                diskId,
                diskName,
                isOSDisk,
                capacityInBytes,
                logStorageAccountId,
                diskEncryptionSetId,
                seedManagedDiskId,
                seedBlobUri,
                targetManagedDiskId,
                diskType,
                dataPendingInLogDataStoreInMB,
                dataPendingAtSourceAgentInMB,
                isInitialReplicationComplete,
                irDetails,
                resyncDetails,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<InMageRcmProtectedDiskDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageRcmProtectedDiskDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InMageRcmProtectedDiskDetails)} does not support '{options.Format}' format.");
            }
        }

        InMageRcmProtectedDiskDetails IPersistableModel<InMageRcmProtectedDiskDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageRcmProtectedDiskDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeInMageRcmProtectedDiskDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InMageRcmProtectedDiskDetails)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<InMageRcmProtectedDiskDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
