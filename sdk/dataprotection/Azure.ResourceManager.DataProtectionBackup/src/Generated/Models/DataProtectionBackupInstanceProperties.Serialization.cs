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

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    public partial class DataProtectionBackupInstanceProperties : IUtf8JsonSerializable, IJsonModel<DataProtectionBackupInstanceProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataProtectionBackupInstanceProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DataProtectionBackupInstanceProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataProtectionBackupInstanceProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataProtectionBackupInstanceProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (FriendlyName != null)
            {
                writer.WritePropertyName("friendlyName"u8);
                writer.WriteStringValue(FriendlyName);
            }
            writer.WritePropertyName("dataSourceInfo"u8);
            writer.WriteObjectValue(DataSourceInfo);
            if (DataSourceSetInfo != null)
            {
                writer.WritePropertyName("dataSourceSetInfo"u8);
                writer.WriteObjectValue(DataSourceSetInfo);
            }
            writer.WritePropertyName("policyInfo"u8);
            writer.WriteObjectValue(PolicyInfo);
            if (options.Format != "W" && ProtectionStatus != null)
            {
                writer.WritePropertyName("protectionStatus"u8);
                writer.WriteObjectValue(ProtectionStatus);
            }
            if (options.Format != "W" && CurrentProtectionState.HasValue)
            {
                writer.WritePropertyName("currentProtectionState"u8);
                writer.WriteStringValue(CurrentProtectionState.Value.ToString());
            }
            if (options.Format != "W" && ProtectionErrorDetails != null)
            {
                writer.WritePropertyName("protectionErrorDetails"u8);
                JsonSerializer.Serialize(writer, ProtectionErrorDetails);
            }
            if (options.Format != "W" && ProvisioningState != null)
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState);
            }
            if (DataSourceAuthCredentials != null)
            {
                writer.WritePropertyName("datasourceAuthCredentials"u8);
                writer.WriteObjectValue(DataSourceAuthCredentials);
            }
            if (ValidationType.HasValue)
            {
                writer.WritePropertyName("validationType"u8);
                writer.WriteStringValue(ValidationType.Value.ToString());
            }
            if (IdentityDetails != null)
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

        DataProtectionBackupInstanceProperties IJsonModel<DataProtectionBackupInstanceProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataProtectionBackupInstanceProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataProtectionBackupInstanceProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataProtectionBackupInstanceProperties(document.RootElement, options);
        }

        internal static DataProtectionBackupInstanceProperties DeserializeDataProtectionBackupInstanceProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string friendlyName = default;
            DataSourceInfo dataSourceInfo = default;
            DataSourceSetInfo dataSourceSetInfo = default;
            BackupInstancePolicyInfo policyInfo = default;
            BackupInstanceProtectionStatusDetails protectionStatus = default;
            CurrentProtectionState? currentProtectionState = default;
            ResponseError protectionErrorDetails = default;
            string provisioningState = default;
            DataProtectionBackupAuthCredentials datasourceAuthCredentials = default;
            BackupValidationType? validationType = default;
            DataProtectionIdentityDetails identityDetails = default;
            string objectType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("friendlyName"u8))
                {
                    friendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataSourceInfo"u8))
                {
                    dataSourceInfo = DataSourceInfo.DeserializeDataSourceInfo(property.Value, options);
                    continue;
                }
                if (property.NameEquals("dataSourceSetInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataSourceSetInfo = DataSourceSetInfo.DeserializeDataSourceSetInfo(property.Value, options);
                    continue;
                }
                if (property.NameEquals("policyInfo"u8))
                {
                    policyInfo = BackupInstancePolicyInfo.DeserializeBackupInstancePolicyInfo(property.Value, options);
                    continue;
                }
                if (property.NameEquals("protectionStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    protectionStatus = BackupInstanceProtectionStatusDetails.DeserializeBackupInstanceProtectionStatusDetails(property.Value, options);
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
                    datasourceAuthCredentials = DataProtectionBackupAuthCredentials.DeserializeDataProtectionBackupAuthCredentials(property.Value, options);
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
                    identityDetails = DataProtectionIdentityDetails.DeserializeDataProtectionIdentityDetails(property.Value, options);
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
            return new DataProtectionBackupInstanceProperties(
                friendlyName,
                dataSourceInfo,
                dataSourceSetInfo,
                policyInfo,
                protectionStatus,
                currentProtectionState,
                protectionErrorDetails,
                provisioningState,
                datasourceAuthCredentials,
                validationType,
                identityDetails,
                objectType,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataProtectionBackupInstanceProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataProtectionBackupInstanceProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataProtectionBackupInstanceProperties)} does not support '{options.Format}' format.");
            }
        }

        DataProtectionBackupInstanceProperties IPersistableModel<DataProtectionBackupInstanceProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataProtectionBackupInstanceProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataProtectionBackupInstanceProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataProtectionBackupInstanceProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataProtectionBackupInstanceProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
