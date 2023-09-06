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
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    public partial class DataBoxEdgeDeviceExtendedInfo : IUtf8JsonSerializable, IModelJsonSerializable<DataBoxEdgeDeviceExtendedInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DataBoxEdgeDeviceExtendedInfo>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DataBoxEdgeDeviceExtendedInfo>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataBoxEdgeDeviceExtendedInfo>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(EncryptionKeyThumbprint))
            {
                writer.WritePropertyName("encryptionKeyThumbprint"u8);
                writer.WriteStringValue(EncryptionKeyThumbprint);
            }
            if (Optional.IsDefined(EncryptionKey))
            {
                writer.WritePropertyName("encryptionKey"u8);
                writer.WriteStringValue(EncryptionKey);
            }
            if (Optional.IsDefined(ClientSecretStoreId))
            {
                writer.WritePropertyName("clientSecretStoreId"u8);
                writer.WriteStringValue(ClientSecretStoreId);
            }
            if (Optional.IsDefined(ClientSecretStoreUri))
            {
                writer.WritePropertyName("clientSecretStoreUrl"u8);
                writer.WriteStringValue(ClientSecretStoreUri.AbsoluteUri);
            }
            if (Optional.IsDefined(ChannelIntegrityKeyName))
            {
                writer.WritePropertyName("channelIntegrityKeyName"u8);
                writer.WriteStringValue(ChannelIntegrityKeyName);
            }
            if (Optional.IsDefined(ChannelIntegrityKeyVersion))
            {
                writer.WritePropertyName("channelIntegrityKeyVersion"u8);
                writer.WriteStringValue(ChannelIntegrityKeyVersion);
            }
            if (Optional.IsDefined(KeyVaultSyncStatus))
            {
                writer.WritePropertyName("keyVaultSyncStatus"u8);
                writer.WriteStringValue(KeyVaultSyncStatus.Value.ToString());
            }
            writer.WriteEndObject();
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

        internal static DataBoxEdgeDeviceExtendedInfo DeserializeDataBoxEdgeDeviceExtendedInfo(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> encryptionKeyThumbprint = default;
            Optional<string> encryptionKey = default;
            Optional<string> resourceKey = default;
            Optional<ResourceIdentifier> clientSecretStoreId = default;
            Optional<Uri> clientSecretStoreUrl = default;
            Optional<string> channelIntegrityKeyName = default;
            Optional<string> channelIntegrityKeyVersion = default;
            Optional<EdgeKeyVaultSyncStatus> keyVaultSyncStatus = default;
            Optional<IReadOnlyDictionary<string, DataBoxEdgeDeviceSecret>> deviceSecrets = default;
            Optional<EdgeClusterWitnessType> clusterWitnessType = default;
            Optional<string> fileShareWitnessLocation = default;
            Optional<string> fileShareWitnessUsername = default;
            Optional<string> cloudWitnessStorageAccountName = default;
            Optional<string> cloudWitnessContainerName = default;
            Optional<string> cloudWitnessStorageEndpoint = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
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
                        if (property0.NameEquals("encryptionKeyThumbprint"u8))
                        {
                            encryptionKeyThumbprint = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("encryptionKey"u8))
                        {
                            encryptionKey = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("resourceKey"u8))
                        {
                            resourceKey = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("clientSecretStoreId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            clientSecretStoreId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("clientSecretStoreUrl"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            clientSecretStoreUrl = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("channelIntegrityKeyName"u8))
                        {
                            channelIntegrityKeyName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("channelIntegrityKeyVersion"u8))
                        {
                            channelIntegrityKeyVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("keyVaultSyncStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            keyVaultSyncStatus = new EdgeKeyVaultSyncStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("deviceSecrets"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, DataBoxEdgeDeviceSecret> dictionary = new Dictionary<string, DataBoxEdgeDeviceSecret>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, DataBoxEdgeDeviceSecret.DeserializeDataBoxEdgeDeviceSecret(property1.Value));
                            }
                            deviceSecrets = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("clusterWitnessType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            clusterWitnessType = new EdgeClusterWitnessType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("fileShareWitnessLocation"u8))
                        {
                            fileShareWitnessLocation = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("fileShareWitnessUsername"u8))
                        {
                            fileShareWitnessUsername = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("cloudWitnessStorageAccountName"u8))
                        {
                            cloudWitnessStorageAccountName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("cloudWitnessContainerName"u8))
                        {
                            cloudWitnessContainerName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("cloudWitnessStorageEndpoint"u8))
                        {
                            cloudWitnessStorageEndpoint = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DataBoxEdgeDeviceExtendedInfo(id, name, type, systemData.Value, encryptionKeyThumbprint.Value, encryptionKey.Value, resourceKey.Value, clientSecretStoreId.Value, clientSecretStoreUrl.Value, channelIntegrityKeyName.Value, channelIntegrityKeyVersion.Value, Optional.ToNullable(keyVaultSyncStatus), Optional.ToDictionary(deviceSecrets), Optional.ToNullable(clusterWitnessType), fileShareWitnessLocation.Value, fileShareWitnessUsername.Value, cloudWitnessStorageAccountName.Value, cloudWitnessContainerName.Value, cloudWitnessStorageEndpoint.Value, rawData);
        }

        DataBoxEdgeDeviceExtendedInfo IModelJsonSerializable<DataBoxEdgeDeviceExtendedInfo>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataBoxEdgeDeviceExtendedInfo>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDataBoxEdgeDeviceExtendedInfo(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DataBoxEdgeDeviceExtendedInfo>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataBoxEdgeDeviceExtendedInfo>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DataBoxEdgeDeviceExtendedInfo IModelSerializable<DataBoxEdgeDeviceExtendedInfo>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataBoxEdgeDeviceExtendedInfo>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDataBoxEdgeDeviceExtendedInfo(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DataBoxEdgeDeviceExtendedInfo"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DataBoxEdgeDeviceExtendedInfo"/> to convert. </param>
        public static implicit operator RequestContent(DataBoxEdgeDeviceExtendedInfo model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DataBoxEdgeDeviceExtendedInfo"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DataBoxEdgeDeviceExtendedInfo(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDataBoxEdgeDeviceExtendedInfo(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
