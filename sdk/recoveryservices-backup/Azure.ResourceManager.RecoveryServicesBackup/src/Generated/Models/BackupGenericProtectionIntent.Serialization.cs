// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    [ModelReaderProxy(typeof(UnknownProtectionIntent))]
    public partial class BackupGenericProtectionIntent : IUtf8JsonSerializable, IJsonModel<BackupGenericProtectionIntent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BackupGenericProtectionIntent>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<BackupGenericProtectionIntent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("protectionIntentItemType"u8);
            writer.WriteStringValue(ProtectionIntentItemType.ToString());
            if (Optional.IsDefined(BackupManagementType))
            {
                writer.WritePropertyName("backupManagementType"u8);
                writer.WriteStringValue(BackupManagementType.Value.ToString());
            }
            if (Optional.IsDefined(SourceResourceId))
            {
                writer.WritePropertyName("sourceResourceId"u8);
                writer.WriteStringValue(SourceResourceId);
            }
            if (Optional.IsDefined(ItemId))
            {
                writer.WritePropertyName("itemId"u8);
                writer.WriteStringValue(ItemId);
            }
            if (Optional.IsDefined(PolicyId))
            {
                writer.WritePropertyName("policyId"u8);
                writer.WriteStringValue(PolicyId);
            }
            if (Optional.IsDefined(ProtectionState))
            {
                writer.WritePropertyName("protectionState"u8);
                writer.WriteStringValue(ProtectionState.Value.ToString());
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

        BackupGenericProtectionIntent IJsonModel<BackupGenericProtectionIntent>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(BackupGenericProtectionIntent)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBackupGenericProtectionIntent(document.RootElement, options);
        }

        internal static BackupGenericProtectionIntent DeserializeBackupGenericProtectionIntent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("protectionIntentItemType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AzureResourceItem": return ResourceProtectionIntent.DeserializeResourceProtectionIntent(element);
                    case "AzureWorkloadAutoProtectionIntent": return WorkloadAutoProtectionIntent.DeserializeWorkloadAutoProtectionIntent(element);
                    case "AzureWorkloadContainerAutoProtectionIntent": return WorkloadContainerAutoProtectionIntent.DeserializeWorkloadContainerAutoProtectionIntent(element);
                    case "AzureWorkloadSQLAutoProtectionIntent": return WorkloadSqlAutoProtectionIntent.DeserializeWorkloadSqlAutoProtectionIntent(element);
                    case "RecoveryServiceVaultItem": return RecoveryServiceVaultProtectionIntent.DeserializeRecoveryServiceVaultProtectionIntent(element);
                }
            }
            return UnknownProtectionIntent.DeserializeUnknownProtectionIntent(element);
        }

        BinaryData IModel<BackupGenericProtectionIntent>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(BackupGenericProtectionIntent)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        BackupGenericProtectionIntent IModel<BackupGenericProtectionIntent>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(BackupGenericProtectionIntent)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeBackupGenericProtectionIntent(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<BackupGenericProtectionIntent>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
