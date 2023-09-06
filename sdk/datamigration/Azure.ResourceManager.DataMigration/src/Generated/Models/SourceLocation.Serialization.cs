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

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class SourceLocation : IUtf8JsonSerializable, IModelJsonSerializable<SourceLocation>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SourceLocation>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SourceLocation>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SourceLocation>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(FileShare))
            {
                writer.WritePropertyName("fileShare"u8);
                if (FileShare is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<SqlFileShare>)FileShare).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(AzureBlob))
            {
                writer.WritePropertyName("azureBlob"u8);
                if (AzureBlob is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<AzureBlob>)AzureBlob).Serialize(writer, options);
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

        internal static SourceLocation DeserializeSourceLocation(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<SqlFileShare> fileShare = default;
            Optional<AzureBlob> azureBlob = default;
            Optional<string> fileStorageType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("fileShare"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fileShare = SqlFileShare.DeserializeSqlFileShare(property.Value);
                    continue;
                }
                if (property.NameEquals("azureBlob"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    azureBlob = AzureBlob.DeserializeAzureBlob(property.Value);
                    continue;
                }
                if (property.NameEquals("fileStorageType"u8))
                {
                    fileStorageType = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SourceLocation(fileShare.Value, azureBlob.Value, fileStorageType.Value, rawData);
        }

        SourceLocation IModelJsonSerializable<SourceLocation>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SourceLocation>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSourceLocation(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SourceLocation>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SourceLocation>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SourceLocation IModelSerializable<SourceLocation>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SourceLocation>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSourceLocation(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SourceLocation"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SourceLocation"/> to convert. </param>
        public static implicit operator RequestContent(SourceLocation model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SourceLocation"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SourceLocation(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSourceLocation(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
