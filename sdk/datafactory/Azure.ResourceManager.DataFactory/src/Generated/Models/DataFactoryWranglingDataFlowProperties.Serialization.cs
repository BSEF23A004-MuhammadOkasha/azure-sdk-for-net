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

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class DataFactoryWranglingDataFlowProperties : IUtf8JsonSerializable, IModelJsonSerializable<DataFactoryWranglingDataFlowProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DataFactoryWranglingDataFlowProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DataFactoryWranglingDataFlowProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataFactoryWranglingDataFlowProperties>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(DataFlowType);
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
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
                    ((IModelJsonSerializable<DataFlowFolder>)Folder).Serialize(writer, options);
                }
            }
            writer.WritePropertyName("typeProperties"u8);
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Sources))
            {
                writer.WritePropertyName("sources"u8);
                writer.WriteStartArray();
                foreach (var item in Sources)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<PowerQuerySource>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Script))
            {
                writer.WritePropertyName("script"u8);
                writer.WriteStringValue(Script);
            }
            if (Optional.IsDefined(DocumentLocale))
            {
                writer.WritePropertyName("documentLocale"u8);
                writer.WriteStringValue(DocumentLocale);
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

        internal static DataFactoryWranglingDataFlowProperties DeserializeDataFactoryWranglingDataFlowProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string type = default;
            Optional<string> description = default;
            Optional<IList<BinaryData>> annotations = default;
            Optional<DataFlowFolder> folder = default;
            Optional<IList<PowerQuerySource>> sources = default;
            Optional<string> script = default;
            Optional<string> documentLocale = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
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
                    folder = DataFlowFolder.DeserializeDataFlowFolder(property.Value);
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
                        if (property0.NameEquals("sources"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<PowerQuerySource> array = new List<PowerQuerySource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(PowerQuerySource.DeserializePowerQuerySource(item));
                            }
                            sources = array;
                            continue;
                        }
                        if (property0.NameEquals("script"u8))
                        {
                            script = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("documentLocale"u8))
                        {
                            documentLocale = property0.Value.GetString();
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
            return new DataFactoryWranglingDataFlowProperties(type, description.Value, Optional.ToList(annotations), folder.Value, Optional.ToList(sources), script.Value, documentLocale.Value, rawData);
        }

        DataFactoryWranglingDataFlowProperties IModelJsonSerializable<DataFactoryWranglingDataFlowProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataFactoryWranglingDataFlowProperties>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDataFactoryWranglingDataFlowProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DataFactoryWranglingDataFlowProperties>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataFactoryWranglingDataFlowProperties>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DataFactoryWranglingDataFlowProperties IModelSerializable<DataFactoryWranglingDataFlowProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataFactoryWranglingDataFlowProperties>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDataFactoryWranglingDataFlowProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DataFactoryWranglingDataFlowProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DataFactoryWranglingDataFlowProperties"/> to convert. </param>
        public static implicit operator RequestContent(DataFactoryWranglingDataFlowProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DataFactoryWranglingDataFlowProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DataFactoryWranglingDataFlowProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDataFactoryWranglingDataFlowProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
