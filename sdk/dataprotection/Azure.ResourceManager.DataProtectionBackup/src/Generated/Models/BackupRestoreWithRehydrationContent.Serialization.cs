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
    public partial class BackupRestoreWithRehydrationContent : IUtf8JsonSerializable, IModelJsonSerializable<BackupRestoreWithRehydrationContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<BackupRestoreWithRehydrationContent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<BackupRestoreWithRehydrationContent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<BackupRestoreWithRehydrationContent>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("rehydrationPriority"u8);
            writer.WriteStringValue(RehydrationPriority.ToString());
            writer.WritePropertyName("rehydrationRetentionDuration"u8);
            writer.WriteStringValue(RehydrationRetentionDuration, "P");
            writer.WritePropertyName("recoveryPointId"u8);
            writer.WriteStringValue(RecoveryPointId);
            writer.WritePropertyName("objectType"u8);
            writer.WriteStringValue(ObjectType);
            writer.WritePropertyName("restoreTargetInfo"u8);
            if (RestoreTargetInfo is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<RestoreTargetInfoBase>)RestoreTargetInfo).Serialize(writer, options);
            }
            writer.WritePropertyName("sourceDataStoreType"u8);
            writer.WriteStringValue(SourceDataStoreType.ToString());
            if (Optional.IsDefined(SourceResourceId))
            {
                writer.WritePropertyName("sourceResourceId"u8);
                writer.WriteStringValue(SourceResourceId);
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

        internal static BackupRestoreWithRehydrationContent DeserializeBackupRestoreWithRehydrationContent(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            BackupRehydrationPriority rehydrationPriority = default;
            TimeSpan rehydrationRetentionDuration = default;
            string recoveryPointId = default;
            string objectType = default;
            RestoreTargetInfoBase restoreTargetInfo = default;
            SourceDataStoreType sourceDataStoreType = default;
            Optional<ResourceIdentifier> sourceResourceId = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("rehydrationPriority"u8))
                {
                    rehydrationPriority = new BackupRehydrationPriority(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("rehydrationRetentionDuration"u8))
                {
                    rehydrationRetentionDuration = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("recoveryPointId"u8))
                {
                    recoveryPointId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("objectType"u8))
                {
                    objectType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("restoreTargetInfo"u8))
                {
                    restoreTargetInfo = RestoreTargetInfoBase.DeserializeRestoreTargetInfoBase(property.Value);
                    continue;
                }
                if (property.NameEquals("sourceDataStoreType"u8))
                {
                    sourceDataStoreType = new SourceDataStoreType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sourceResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new BackupRestoreWithRehydrationContent(objectType, restoreTargetInfo, sourceDataStoreType, sourceResourceId.Value, recoveryPointId, rehydrationPriority, rehydrationRetentionDuration, rawData);
        }

        BackupRestoreWithRehydrationContent IModelJsonSerializable<BackupRestoreWithRehydrationContent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<BackupRestoreWithRehydrationContent>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeBackupRestoreWithRehydrationContent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<BackupRestoreWithRehydrationContent>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<BackupRestoreWithRehydrationContent>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        BackupRestoreWithRehydrationContent IModelSerializable<BackupRestoreWithRehydrationContent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<BackupRestoreWithRehydrationContent>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeBackupRestoreWithRehydrationContent(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="BackupRestoreWithRehydrationContent"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="BackupRestoreWithRehydrationContent"/> to convert. </param>
        public static implicit operator RequestContent(BackupRestoreWithRehydrationContent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="BackupRestoreWithRehydrationContent"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator BackupRestoreWithRehydrationContent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeBackupRestoreWithRehydrationContent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
