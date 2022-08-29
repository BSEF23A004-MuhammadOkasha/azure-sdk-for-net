// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class FileShareDataset : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type");
            writer.WriteStringValue(DatasetType);
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(Structure))
            {
                writer.WritePropertyName("structure");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Structure);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(Structure.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(Schema))
            {
                writer.WritePropertyName("schema");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Schema);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(Schema.ToString()).RootElement);
#endif
            }
            writer.WritePropertyName("linkedServiceName");
            writer.WriteObjectValue(LinkedServiceName);
            if (Optional.IsCollectionDefined(Parameters))
            {
                writer.WritePropertyName("parameters");
                writer.WriteStartObject();
                foreach (var item in Parameters)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(Annotations))
            {
                writer.WritePropertyName("annotations");
                writer.WriteStartArray();
                foreach (var item in Annotations)
                {
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
                writer.WritePropertyName("folder");
                writer.WriteObjectValue(Folder);
            }
            writer.WritePropertyName("typeProperties");
            writer.WriteStartObject();
            if (Optional.IsDefined(FolderPath))
            {
                writer.WritePropertyName("folderPath");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(FolderPath);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(FolderPath.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(FileName))
            {
                writer.WritePropertyName("fileName");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(FileName);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(FileName.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(ModifiedDatetimeStart))
            {
                writer.WritePropertyName("modifiedDatetimeStart");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(ModifiedDatetimeStart);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(ModifiedDatetimeStart.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(ModifiedDatetimeEnd))
            {
                writer.WritePropertyName("modifiedDatetimeEnd");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(ModifiedDatetimeEnd);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(ModifiedDatetimeEnd.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(Format))
            {
                writer.WritePropertyName("format");
                writer.WriteObjectValue(Format);
            }
            if (Optional.IsDefined(FileFilter))
            {
                writer.WritePropertyName("fileFilter");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(FileFilter);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(FileFilter.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(Compression))
            {
                writer.WritePropertyName("compression");
                writer.WriteObjectValue(Compression);
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

        internal static FileShareDataset DeserializeFileShareDataset(JsonElement element)
        {
            string type = default;
            Optional<string> description = default;
            Optional<BinaryData> structure = default;
            Optional<BinaryData> schema = default;
            FactoryLinkedServiceReference linkedServiceName = default;
            Optional<IDictionary<string, EntityParameterSpecification>> parameters = default;
            Optional<IList<BinaryData>> annotations = default;
            Optional<DatasetFolder> folder = default;
            Optional<BinaryData> folderPath = default;
            Optional<BinaryData> fileName = default;
            Optional<BinaryData> modifiedDatetimeStart = default;
            Optional<BinaryData> modifiedDatetimeEnd = default;
            Optional<DatasetStorageFormat> format = default;
            Optional<BinaryData> fileFilter = default;
            Optional<DatasetCompression> compression = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("structure"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    structure = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("schema"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    schema = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("linkedServiceName"))
                {
                    linkedServiceName = FactoryLinkedServiceReference.DeserializeFactoryLinkedServiceReference(property.Value);
                    continue;
                }
                if (property.NameEquals("parameters"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
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
                if (property.NameEquals("annotations"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<BinaryData> array = new List<BinaryData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BinaryData.FromString(item.GetRawText()));
                    }
                    annotations = array;
                    continue;
                }
                if (property.NameEquals("folder"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    folder = DatasetFolder.DeserializeDatasetFolder(property.Value);
                    continue;
                }
                if (property.NameEquals("typeProperties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("folderPath"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            folderPath = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("fileName"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            fileName = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("modifiedDatetimeStart"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            modifiedDatetimeStart = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("modifiedDatetimeEnd"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            modifiedDatetimeEnd = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("format"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            format = DatasetStorageFormat.DeserializeDatasetStorageFormat(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("fileFilter"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            fileFilter = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("compression"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
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
            return new FileShareDataset(type, description.Value, structure.Value, schema.Value, linkedServiceName, Optional.ToDictionary(parameters), Optional.ToList(annotations), folder.Value, additionalProperties, folderPath.Value, fileName.Value, modifiedDatetimeStart.Value, modifiedDatetimeEnd.Value, format.Value, fileFilter.Value, compression.Value);
        }
    }
}
