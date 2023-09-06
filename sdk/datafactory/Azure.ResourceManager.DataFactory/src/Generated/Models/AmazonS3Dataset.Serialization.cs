// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class AmazonS3Dataset : IUtf8JsonSerializable, IModelJsonSerializable<AmazonS3Dataset>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AmazonS3Dataset>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AmazonS3Dataset>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AmazonS3Dataset>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(DatasetType);
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(Structure))
            {
                writer.WritePropertyName("structure"u8);
                JsonSerializer.Serialize(writer, Structure);
            }
            if (Optional.IsDefined(Schema))
            {
                writer.WritePropertyName("schema"u8);
                JsonSerializer.Serialize(writer, Schema);
            }
            writer.WritePropertyName("linkedServiceName"u8);
            JsonSerializer.Serialize(writer, LinkedServiceName); if (Optional.IsCollectionDefined(Parameters))
            {
                writer.WritePropertyName("parameters"u8);
                writer.WriteStartObject();
                foreach (var item in Parameters)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<EntityParameterSpecification>)item.Value).Serialize(writer, options);
                    }
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(Annotations))
            {
                writer.WritePropertyName("annotations"u8);
                writer.WriteStartArray();
                foreach (var item in Annotations)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(item.ToString()).RootElement);
#endif
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Folder))
            {
                writer.WritePropertyName("folder"u8);
                if (Folder is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<DatasetFolder>)Folder).Serialize(writer, options);
                }
            }
            writer.WritePropertyName("typeProperties"u8);
            writer.WriteStartObject();
            writer.WritePropertyName("bucketName"u8);
            JsonSerializer.Serialize(writer, BucketName);
            if (Optional.IsDefined(Key))
            {
                writer.WritePropertyName("key"u8);
                JsonSerializer.Serialize(writer, Key);
            }
            if (Optional.IsDefined(Prefix))
            {
                writer.WritePropertyName("prefix"u8);
                JsonSerializer.Serialize(writer, Prefix);
            }
            if (Optional.IsDefined(Version))
            {
                writer.WritePropertyName("version"u8);
                JsonSerializer.Serialize(writer, Version);
            }
            if (Optional.IsDefined(ModifiedDatetimeStart))
            {
                writer.WritePropertyName("modifiedDatetimeStart"u8);
                JsonSerializer.Serialize(writer, ModifiedDatetimeStart);
            }
            if (Optional.IsDefined(ModifiedDatetimeEnd))
            {
                writer.WritePropertyName("modifiedDatetimeEnd"u8);
                JsonSerializer.Serialize(writer, ModifiedDatetimeEnd);
            }
            if (Optional.IsDefined(Format))
            {
                writer.WritePropertyName("format"u8);
                if (Format is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<DatasetStorageFormat>)Format).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(Compression))
            {
                writer.WritePropertyName("compression"u8);
                if (Compression is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<DatasetCompression>)Compression).Serialize(writer, options);
                }
            }
            writer.WriteEndObject();
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(item.Value.ToString()).RootElement);
#endif
            }
            writer.WriteEndObject();
        }

        internal static AmazonS3Dataset DeserializeAmazonS3Dataset(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string type = default;
            Optional<string> description = default;
            Optional<DataFactoryElement<IList<DatasetDataElement>>> structure = default;
            Optional<DataFactoryElement<IList<DatasetSchemaDataElement>>> schema = default;
            DataFactoryLinkedServiceReference linkedServiceName = default;
            Optional<IDictionary<string, EntityParameterSpecification>> parameters = default;
            Optional<IList<BinaryData>> annotations = default;
            Optional<DatasetFolder> folder = default;
            DataFactoryElement<string> bucketName = default;
            Optional<DataFactoryElement<string>> key = default;
            Optional<DataFactoryElement<string>> prefix = default;
            Optional<DataFactoryElement<string>> version = default;
            Optional<DataFactoryElement<string>> modifiedDatetimeStart = default;
            Optional<DataFactoryElement<string>> modifiedDatetimeEnd = default;
            Optional<DatasetStorageFormat> format = default;
            Optional<DatasetCompression> compression = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("structure"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    structure = JsonSerializer.Deserialize<DataFactoryElement<IList<DatasetDataElement>>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("schema"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    schema = JsonSerializer.Deserialize<DataFactoryElement<IList<DatasetSchemaDataElement>>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("linkedServiceName"u8))
                {
                    linkedServiceName = JsonSerializer.Deserialize<DataFactoryLinkedServiceReference>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("parameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, EntityParameterSpecification> dictionary = new Dictionary<string, EntityParameterSpecification>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, EntityParameterSpecification.DeserializeEntityParameterSpecification(property0.Value));
                    }
                    parameters = dictionary;
                    continue;
                }
                if (property.NameEquals("annotations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BinaryData> array = new List<BinaryData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(BinaryData.FromString(item.GetRawText()));
                        }
                    }
                    annotations = array;
                    continue;
                }
                if (property.NameEquals("folder"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    folder = DatasetFolder.DeserializeDatasetFolder(property.Value);
                    continue;
                }
                if (property.NameEquals("typeProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("bucketName"u8))
                        {
                            bucketName = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("key"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            key = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("prefix"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            prefix = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("version"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            version = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("modifiedDatetimeStart"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            modifiedDatetimeStart = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("modifiedDatetimeEnd"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            modifiedDatetimeEnd = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("format"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            format = DatasetStorageFormat.DeserializeDatasetStorageFormat(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("compression"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            compression = DatasetCompression.DeserializeDatasetCompression(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new AmazonS3Dataset(type, description.Value, structure.Value, schema.Value, linkedServiceName, Optional.ToDictionary(parameters), Optional.ToList(annotations), folder.Value, additionalProperties, bucketName, key.Value, prefix.Value, version.Value, modifiedDatetimeStart.Value, modifiedDatetimeEnd.Value, format.Value, compression.Value);
        }

        AmazonS3Dataset IModelJsonSerializable<AmazonS3Dataset>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AmazonS3Dataset>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAmazonS3Dataset(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AmazonS3Dataset>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AmazonS3Dataset>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AmazonS3Dataset IModelSerializable<AmazonS3Dataset>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AmazonS3Dataset>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAmazonS3Dataset(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="AmazonS3Dataset"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="AmazonS3Dataset"/> to convert. </param>
        public static implicit operator RequestContent(AmazonS3Dataset model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="AmazonS3Dataset"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator AmazonS3Dataset(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAmazonS3Dataset(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
