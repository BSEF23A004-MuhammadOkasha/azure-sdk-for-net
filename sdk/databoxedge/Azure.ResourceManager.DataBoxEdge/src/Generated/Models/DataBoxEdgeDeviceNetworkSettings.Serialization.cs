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
    public partial class DataBoxEdgeDeviceNetworkSettings : IUtf8JsonSerializable, IModelJsonSerializable<DataBoxEdgeDeviceNetworkSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DataBoxEdgeDeviceNetworkSettings>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DataBoxEdgeDeviceNetworkSettings>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataBoxEdgeDeviceNetworkSettings>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
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

        internal static DataBoxEdgeDeviceNetworkSettings DeserializeDataBoxEdgeDeviceNetworkSettings(JsonElement element, ModelSerializerOptions options = default)
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
            Optional<IReadOnlyList<DataBoxEdgeNetworkAdapter>> networkAdapters = default;
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
                        if (property0.NameEquals("networkAdapters"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DataBoxEdgeNetworkAdapter> array = new List<DataBoxEdgeNetworkAdapter>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DataBoxEdgeNetworkAdapter.DeserializeDataBoxEdgeNetworkAdapter(item));
                            }
                            networkAdapters = array;
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
            return new DataBoxEdgeDeviceNetworkSettings(id, name, type, systemData.Value, Optional.ToList(networkAdapters), rawData);
        }

        DataBoxEdgeDeviceNetworkSettings IModelJsonSerializable<DataBoxEdgeDeviceNetworkSettings>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataBoxEdgeDeviceNetworkSettings>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDataBoxEdgeDeviceNetworkSettings(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DataBoxEdgeDeviceNetworkSettings>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataBoxEdgeDeviceNetworkSettings>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DataBoxEdgeDeviceNetworkSettings IModelSerializable<DataBoxEdgeDeviceNetworkSettings>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataBoxEdgeDeviceNetworkSettings>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDataBoxEdgeDeviceNetworkSettings(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DataBoxEdgeDeviceNetworkSettings"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DataBoxEdgeDeviceNetworkSettings"/> to convert. </param>
        public static implicit operator RequestContent(DataBoxEdgeDeviceNetworkSettings model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DataBoxEdgeDeviceNetworkSettings"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DataBoxEdgeDeviceNetworkSettings(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDataBoxEdgeDeviceNetworkSettings(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
