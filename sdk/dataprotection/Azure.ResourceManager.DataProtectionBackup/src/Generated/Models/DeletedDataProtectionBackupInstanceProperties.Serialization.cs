// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    public partial class DeletedDataProtectionBackupInstanceProperties : IUtf8JsonSerializable, IJsonModel<DeletedDataProtectionBackupInstanceProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DeletedDataProtectionBackupInstanceProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DeletedDataProtectionBackupInstanceProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeletedDataProtectionBackupInstanceProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(DeletedDataProtectionBackupInstanceProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(DeletionInfo))
            {
                writer.WritePropertyName("deletionInfo"u8);
                writer.WriteObjectValue(DeletionInfo);
            }
            if (Optional.IsDefined(FriendlyName))
            {
                writer.WritePropertyName("friendlyName"u8);
                writer.WriteStringValue(FriendlyName);
            }
            writer.WritePropertyName("dataSourceInfo"u8);
            writer.WriteObjectValue(DataSourceInfo);
            if (Optional.IsDefined(DataSourceSetInfo))
            {
                writer.WritePropertyName("dataSourceSetInfo"u8);
                writer.WriteObjectValue(DataSourceSetInfo);
            }
            writer.WritePropertyName("policyInfo"u8);
            writer.WriteObjectValue(PolicyInfo);
            if (options.Format != "W" && Optional.IsDefined(ProtectionStatus))
            {
                writer.WritePropertyName("protectionStatus"u8);
                writer.WriteObjectValue(ProtectionStatus);
            }
            if (options.Format != "W" && Optional.IsDefined(CurrentProtectionState))
            {
                writer.WritePropertyName("currentProtectionState"u8);
                writer.WriteStringValue(CurrentProtectionState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(ProtectionErrorDetails))
            {
                writer.WritePropertyName("protectionErrorDetails"u8);
                writer.WriteObjectValue(ProtectionErrorDetails);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState);
            }
            if (Optional.IsDefined(DataSourceAuthCredentials))
            {
                writer.WritePropertyName("datasourceAuthCredentials"u8);
                writer.WriteObjectValue(DataSourceAuthCredentials);
            }
            if (Optional.IsDefined(ValidationType))
            {
                writer.WritePropertyName("validationType"u8);
                writer.WriteStringValue(ValidationType.Value.ToString());
            }
            if (Optional.IsDefined(IdentityDetails))
            {
                writer.WritePropertyName("identityDetails"u8);
                writer.WriteObjectValue(IdentityDetails);
            }
            writer.WritePropertyName("objectType"u8);
            writer.WriteStringValue(ObjectType);
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

        DeletedDataProtectionBackupInstanceProperties IJsonModel<DeletedDataProtectionBackupInstanceProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeletedDataProtectionBackupInstanceProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(DeletedDataProtectionBackupInstanceProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDeletedDataProtectionBackupInstanceProperties(document.RootElement, options);
        }

        internal static DeletedDataProtectionBackupInstanceProperties DeserializeDeletedDataProtectionBackupInstanceProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<BackupInstanceDeletionInfo> deletionInfo = default;
            Optional<string> friendlyName = default;
            DataSourceInfo dataSourceInfo = default;
            Optional<DataSourceSetInfo> dataSourceSetInfo = default;
            BackupInstancePolicyInfo policyInfo = default;
            Optional<BackupInstanceProtectionStatusDetails> protectionStatus = default;
            Optional<CurrentProtectionState> currentProtectionState = default;
            Optional<ResponseError> protectionErrorDetails = default;
            Optional<string> provisioningState = default;
            Optional<DataProtectionBackupAuthCredentials> datasourceAuthCredentials = default;
            Optional<BackupValidationType> validationType = default;
            Optional<DataProtectionIdentityDetails> identityDetails = default;
            string objectType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("deletionInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deletionInfo = BackupInstanceDeletionInfo.DeserializeBackupInstanceDeletionInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("friendlyName"u8))
                {
                    friendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataSourceInfo"u8))
                {
                    dataSourceInfo = DataSourceInfo.DeserializeDataSourceInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("dataSourceSetInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataSourceSetInfo = DataSourceSetInfo.DeserializeDataSourceSetInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("policyInfo"u8))
                {
                    policyInfo = BackupInstancePolicyInfo.DeserializeBackupInstancePolicyInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("protectionStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    protectionStatus = BackupInstanceProtectionStatusDetails.DeserializeBackupInstanceProtectionStatusDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("currentProtectionState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    currentProtectionState = new CurrentProtectionState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("protectionErrorDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    protectionErrorDetails = JsonSerializer.Deserialize<ResponseError>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    provisioningState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("datasourceAuthCredentials"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    datasourceAuthCredentials = DataProtectionBackupAuthCredentials.DeserializeDataProtectionBackupAuthCredentials(property.Value);
                    continue;
                }
                if (property.NameEquals("validationType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    validationType = new BackupValidationType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("identityDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identityDetails = DataProtectionIdentityDetails.DeserializeDataProtectionIdentityDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("objectType"u8))
                {
                    objectType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DeletedDataProtectionBackupInstanceProperties(friendlyName.Value, dataSourceInfo, dataSourceSetInfo.Value, policyInfo, protectionStatus.Value, Optional.ToNullable(currentProtectionState), protectionErrorDetails.Value, provisioningState.Value, datasourceAuthCredentials.Value, Optional.ToNullable(validationType), identityDetails.Value, objectType, serializedAdditionalRawData, deletionInfo.Value);
        }

        BinaryData IPersistableModel<DeletedDataProtectionBackupInstanceProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeletedDataProtectionBackupInstanceProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(DeletedDataProtectionBackupInstanceProperties)} does not support '{options.Format}' format.");
            }
        }

        DeletedDataProtectionBackupInstanceProperties IPersistableModel<DeletedDataProtectionBackupInstanceProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeletedDataProtectionBackupInstanceProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDeletedDataProtectionBackupInstanceProperties(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(DeletedDataProtectionBackupInstanceProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DeletedDataProtectionBackupInstanceProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
