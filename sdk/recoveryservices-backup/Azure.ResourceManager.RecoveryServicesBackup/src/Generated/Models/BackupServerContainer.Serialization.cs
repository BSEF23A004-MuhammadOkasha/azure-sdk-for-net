// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class BackupServerContainer : IUtf8JsonSerializable, IJsonModel<BackupServerContainer>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BackupServerContainer>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<BackupServerContainer>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(CanReRegister))
            {
                writer.WritePropertyName("canReRegister"u8);
                writer.WriteBooleanValue(CanReRegister.Value);
            }
            if (Optional.IsDefined(ContainerId))
            {
                writer.WritePropertyName("containerId"u8);
                writer.WriteStringValue(ContainerId);
            }
            if (Optional.IsDefined(ProtectedItemCount))
            {
                writer.WritePropertyName("protectedItemCount"u8);
                writer.WriteNumberValue(ProtectedItemCount.Value);
            }
            if (Optional.IsDefined(DpmAgentVersion))
            {
                writer.WritePropertyName("dpmAgentVersion"u8);
                writer.WriteStringValue(DpmAgentVersion);
            }
            if (Optional.IsCollectionDefined(DpmServers))
            {
                writer.WritePropertyName("dpmServers"u8);
                writer.WriteStartArray();
                foreach (var item in DpmServers)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(IsUpgradeAvailable))
            {
                writer.WritePropertyName("upgradeAvailable"u8);
                writer.WriteBooleanValue(IsUpgradeAvailable.Value);
            }
            if (Optional.IsDefined(ProtectionStatus))
            {
                writer.WritePropertyName("protectionStatus"u8);
                writer.WriteStringValue(ProtectionStatus);
            }
            if (Optional.IsDefined(ExtendedInfo))
            {
                writer.WritePropertyName("extendedInfo"u8);
                writer.WriteObjectValue(ExtendedInfo);
            }
            if (Optional.IsDefined(FriendlyName))
            {
                writer.WritePropertyName("friendlyName"u8);
                writer.WriteStringValue(FriendlyName);
            }
            if (Optional.IsDefined(BackupManagementType))
            {
                writer.WritePropertyName("backupManagementType"u8);
                writer.WriteStringValue(BackupManagementType.Value.ToString());
            }
            if (Optional.IsDefined(RegistrationStatus))
            {
                writer.WritePropertyName("registrationStatus"u8);
                writer.WriteStringValue(RegistrationStatus);
            }
            if (Optional.IsDefined(HealthStatus))
            {
                writer.WritePropertyName("healthStatus"u8);
                writer.WriteStringValue(HealthStatus);
            }
            writer.WritePropertyName("containerType"u8);
            writer.WriteStringValue(ContainerType.ToSerialString());
            if (Optional.IsDefined(ProtectableObjectType))
            {
                writer.WritePropertyName("protectableObjectType"u8);
                writer.WriteStringValue(ProtectableObjectType);
            }
            if (_serializedAdditionalRawData != null && options.Format == ModelReaderWriterFormat.Json)
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

        BackupServerContainer IJsonModel<BackupServerContainer>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(BackupServerContainer)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBackupServerContainer(document.RootElement, options);
        }

        internal static BackupServerContainer DeserializeBackupServerContainer(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> canReRegister = default;
            Optional<string> containerId = default;
            Optional<long> protectedItemCount = default;
            Optional<string> dpmAgentVersion = default;
            Optional<IList<string>> dpmServers = default;
            Optional<bool> upgradeAvailable = default;
            Optional<string> protectionStatus = default;
            Optional<DpmContainerExtendedInfo> extendedInfo = default;
            Optional<string> friendlyName = default;
            Optional<BackupManagementType> backupManagementType = default;
            Optional<string> registrationStatus = default;
            Optional<string> healthStatus = default;
            ProtectableContainerType containerType = default;
            Optional<string> protectableObjectType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("canReRegister"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    canReRegister = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("containerId"u8))
                {
                    containerId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("protectedItemCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    protectedItemCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("dpmAgentVersion"u8))
                {
                    dpmAgentVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dpmServers"u8))
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
                    dpmServers = array;
                    continue;
                }
                if (property.NameEquals("upgradeAvailable"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    upgradeAvailable = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("protectionStatus"u8))
                {
                    protectionStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("extendedInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    extendedInfo = DpmContainerExtendedInfo.DeserializeDpmContainerExtendedInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("friendlyName"u8))
                {
                    friendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("backupManagementType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    backupManagementType = new BackupManagementType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("registrationStatus"u8))
                {
                    registrationStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("healthStatus"u8))
                {
                    healthStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("containerType"u8))
                {
                    containerType = property.Value.GetString().ToProtectableContainerType();
                    continue;
                }
                if (property.NameEquals("protectableObjectType"u8))
                {
                    protectableObjectType = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new BackupServerContainer(friendlyName.Value, Optional.ToNullable(backupManagementType), registrationStatus.Value, healthStatus.Value, containerType, protectableObjectType.Value, serializedAdditionalRawData, Optional.ToNullable(canReRegister), containerId.Value, Optional.ToNullable(protectedItemCount), dpmAgentVersion.Value, Optional.ToList(dpmServers), Optional.ToNullable(upgradeAvailable), protectionStatus.Value, extendedInfo.Value);
        }

        BinaryData IModel<BackupServerContainer>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(BackupServerContainer)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        BackupServerContainer IModel<BackupServerContainer>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(BackupServerContainer)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeBackupServerContainer(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<BackupServerContainer>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
