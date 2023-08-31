// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    public partial class DataProtectionBackupVaultProperties : IUtf8JsonSerializable, IModelJsonSerializable<DataProtectionBackupVaultProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DataProtectionBackupVaultProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DataProtectionBackupVaultProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(MonitoringSettings))
            {
                writer.WritePropertyName("monitoringSettings"u8);
                if (MonitoringSettings is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<MonitoringSettings>)MonitoringSettings).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(SecuritySettings))
            {
                writer.WritePropertyName("securitySettings"u8);
                if (SecuritySettings is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<BackupVaultSecuritySettings>)SecuritySettings).Serialize(writer, options);
                }
            }
            writer.WritePropertyName("storageSettings"u8);
            writer.WriteStartArray();
            foreach (var item in StorageSettings)
            {
                if (item is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<DataProtectionBackupStorageSetting>)item).Serialize(writer, options);
                }
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(FeatureSettings))
            {
                writer.WritePropertyName("featureSettings"u8);
                if (FeatureSettings is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<FeatureSettings>)FeatureSettings).Serialize(writer, options);
                }
            }
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static DataProtectionBackupVaultProperties DeserializeDataProtectionBackupVaultProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<MonitoringSettings> monitoringSettings = default;
            Optional<DataProtectionBackupProvisioningState> provisioningState = default;
            Optional<BackupVaultResourceMoveState> resourceMoveState = default;
            Optional<BackupVaultResourceMoveDetails> resourceMoveDetails = default;
            Optional<BackupVaultSecuritySettings> securitySettings = default;
            IList<DataProtectionBackupStorageSetting> storageSettings = default;
            Optional<bool> isVaultProtectedByResourceGuard = default;
            Optional<FeatureSettings> featureSettings = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("monitoringSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    monitoringSettings = MonitoringSettings.DeserializeMonitoringSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new DataProtectionBackupProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resourceMoveState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceMoveState = new BackupVaultResourceMoveState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resourceMoveDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceMoveDetails = BackupVaultResourceMoveDetails.DeserializeBackupVaultResourceMoveDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("securitySettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    securitySettings = BackupVaultSecuritySettings.DeserializeBackupVaultSecuritySettings(property.Value);
                    continue;
                }
                if (property.NameEquals("storageSettings"u8))
                {
                    List<DataProtectionBackupStorageSetting> array = new List<DataProtectionBackupStorageSetting>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataProtectionBackupStorageSetting.DeserializeDataProtectionBackupStorageSetting(item));
                    }
                    storageSettings = array;
                    continue;
                }
                if (property.NameEquals("isVaultProtectedByResourceGuard"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isVaultProtectedByResourceGuard = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("featureSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    featureSettings = FeatureSettings.DeserializeFeatureSettings(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DataProtectionBackupVaultProperties(monitoringSettings.Value, Optional.ToNullable(provisioningState), Optional.ToNullable(resourceMoveState), resourceMoveDetails.Value, securitySettings.Value, storageSettings, Optional.ToNullable(isVaultProtectedByResourceGuard), featureSettings.Value, rawData);
        }

        DataProtectionBackupVaultProperties IModelJsonSerializable<DataProtectionBackupVaultProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDataProtectionBackupVaultProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DataProtectionBackupVaultProperties>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DataProtectionBackupVaultProperties IModelSerializable<DataProtectionBackupVaultProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDataProtectionBackupVaultProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DataProtectionBackupVaultProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DataProtectionBackupVaultProperties"/> to convert. </param>
        public static implicit operator RequestContent(DataProtectionBackupVaultProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DataProtectionBackupVaultProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DataProtectionBackupVaultProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDataProtectionBackupVaultProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
