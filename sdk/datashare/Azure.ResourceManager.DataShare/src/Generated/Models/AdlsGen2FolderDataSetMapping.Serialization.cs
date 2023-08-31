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

namespace Azure.ResourceManager.DataShare.Models
{
    public partial class AdlsGen2FolderDataSetMapping : IUtf8JsonSerializable, IModelJsonSerializable<AdlsGen2FolderDataSetMapping>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AdlsGen2FolderDataSetMapping>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AdlsGen2FolderDataSetMapping>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<AdlsGen2FolderDataSetMapping>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            writer.WritePropertyName("dataSetId"u8);
            writer.WriteStringValue(DataSetId);
            writer.WritePropertyName("fileSystem"u8);
            writer.WriteStringValue(FileSystem);
            writer.WritePropertyName("folderPath"u8);
            writer.WriteStringValue(FolderPath);
            writer.WritePropertyName("resourceGroup"u8);
            writer.WriteStringValue(ResourceGroup);
            writer.WritePropertyName("storageAccountName"u8);
            writer.WriteStringValue(StorageAccountName);
            writer.WritePropertyName("subscriptionId"u8);
            writer.WriteStringValue(SubscriptionId);
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

        internal static AdlsGen2FolderDataSetMapping DeserializeAdlsGen2FolderDataSetMapping(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DataSetMappingKind kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Guid dataSetId = default;
            Optional<DataSetMappingStatus> dataSetMappingStatus = default;
            string fileSystem = default;
            string folderPath = default;
            Optional<DataShareProvisioningState> provisioningState = default;
            string resourceGroup = default;
            string storageAccountName = default;
            string subscriptionId = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = new DataSetMappingKind(property.Value.GetString());
                    continue;
                }
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
                        if (property0.NameEquals("dataSetId"u8))
                        {
                            dataSetId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("dataSetMappingStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            dataSetMappingStatus = new DataSetMappingStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("fileSystem"u8))
                        {
                            fileSystem = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("folderPath"u8))
                        {
                            folderPath = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new DataShareProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("resourceGroup"u8))
                        {
                            resourceGroup = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("storageAccountName"u8))
                        {
                            storageAccountName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("subscriptionId"u8))
                        {
                            subscriptionId = property0.Value.GetString();
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
            return new AdlsGen2FolderDataSetMapping(id, name, type, systemData.Value, kind, dataSetId, Optional.ToNullable(dataSetMappingStatus), fileSystem, folderPath, Optional.ToNullable(provisioningState), resourceGroup, storageAccountName, subscriptionId, rawData);
        }

        AdlsGen2FolderDataSetMapping IModelJsonSerializable<AdlsGen2FolderDataSetMapping>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<AdlsGen2FolderDataSetMapping>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAdlsGen2FolderDataSetMapping(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AdlsGen2FolderDataSetMapping>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<AdlsGen2FolderDataSetMapping>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AdlsGen2FolderDataSetMapping IModelSerializable<AdlsGen2FolderDataSetMapping>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<AdlsGen2FolderDataSetMapping>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAdlsGen2FolderDataSetMapping(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="AdlsGen2FolderDataSetMapping"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="AdlsGen2FolderDataSetMapping"/> to convert. </param>
        public static implicit operator RequestContent(AdlsGen2FolderDataSetMapping model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="AdlsGen2FolderDataSetMapping"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator AdlsGen2FolderDataSetMapping(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAdlsGen2FolderDataSetMapping(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
