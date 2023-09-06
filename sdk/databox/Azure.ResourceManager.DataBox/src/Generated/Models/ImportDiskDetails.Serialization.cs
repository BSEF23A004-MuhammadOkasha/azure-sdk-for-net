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

namespace Azure.ResourceManager.DataBox.Models
{
    public partial class ImportDiskDetails : IUtf8JsonSerializable, IModelJsonSerializable<ImportDiskDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ImportDiskDetails>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ImportDiskDetails>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ImportDiskDetails>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("manifestFile"u8);
            writer.WriteStringValue(ManifestFile);
            writer.WritePropertyName("manifestHash"u8);
            writer.WriteStringValue(ManifestHash);
            writer.WritePropertyName("bitLockerKey"u8);
            writer.WriteStringValue(BitLockerKey);
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

        internal static ImportDiskDetails DeserializeImportDiskDetails(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string manifestFile = default;
            string manifestHash = default;
            string bitLockerKey = default;
            Optional<string> backupManifestCloudPath = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("manifestFile"u8))
                {
                    manifestFile = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("manifestHash"u8))
                {
                    manifestHash = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("bitLockerKey"u8))
                {
                    bitLockerKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("backupManifestCloudPath"u8))
                {
                    backupManifestCloudPath = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ImportDiskDetails(manifestFile, manifestHash, bitLockerKey, backupManifestCloudPath.Value, rawData);
        }

        ImportDiskDetails IModelJsonSerializable<ImportDiskDetails>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ImportDiskDetails>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeImportDiskDetails(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ImportDiskDetails>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ImportDiskDetails>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ImportDiskDetails IModelSerializable<ImportDiskDetails>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ImportDiskDetails>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeImportDiskDetails(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ImportDiskDetails"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ImportDiskDetails"/> to convert. </param>
        public static implicit operator RequestContent(ImportDiskDetails model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ImportDiskDetails"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ImportDiskDetails(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeImportDiskDetails(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
