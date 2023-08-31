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
    public partial class BackupVaultSecuritySettings : IUtf8JsonSerializable, IModelJsonSerializable<BackupVaultSecuritySettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<BackupVaultSecuritySettings>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<BackupVaultSecuritySettings>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(SoftDeleteSettings))
            {
                writer.WritePropertyName("softDeleteSettings"u8);
                if (SoftDeleteSettings is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<BackupVaultSoftDeleteSettings>)SoftDeleteSettings).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(ImmutabilitySettings))
            {
                writer.WritePropertyName("immutabilitySettings"u8);
                if (ImmutabilitySettings is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ImmutabilitySettings>)ImmutabilitySettings).Serialize(writer, options);
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

        internal static BackupVaultSecuritySettings DeserializeBackupVaultSecuritySettings(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<BackupVaultSoftDeleteSettings> softDeleteSettings = default;
            Optional<ImmutabilitySettings> immutabilitySettings = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("softDeleteSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    softDeleteSettings = BackupVaultSoftDeleteSettings.DeserializeBackupVaultSoftDeleteSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("immutabilitySettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    immutabilitySettings = ImmutabilitySettings.DeserializeImmutabilitySettings(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new BackupVaultSecuritySettings(softDeleteSettings.Value, immutabilitySettings.Value, rawData);
        }

        BackupVaultSecuritySettings IModelJsonSerializable<BackupVaultSecuritySettings>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeBackupVaultSecuritySettings(doc.RootElement, options);
        }

        BinaryData IModelSerializable<BackupVaultSecuritySettings>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        BackupVaultSecuritySettings IModelSerializable<BackupVaultSecuritySettings>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeBackupVaultSecuritySettings(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="BackupVaultSecuritySettings"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="BackupVaultSecuritySettings"/> to convert. </param>
        public static implicit operator RequestContent(BackupVaultSecuritySettings model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="BackupVaultSecuritySettings"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator BackupVaultSecuritySettings(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeBackupVaultSecuritySettings(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
