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

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    public partial class DataBoxEdgeMetricCounter : IUtf8JsonSerializable, IModelJsonSerializable<DataBoxEdgeMetricCounter>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DataBoxEdgeMetricCounter>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DataBoxEdgeMetricCounter>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataBoxEdgeMetricCounter>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            if (Optional.IsDefined(Instance))
            {
                writer.WritePropertyName("instance"u8);
                writer.WriteStringValue(Instance);
            }
            if (Optional.IsCollectionDefined(DimensionFilter))
            {
                writer.WritePropertyName("dimensionFilter"u8);
                writer.WriteStartArray();
                foreach (var item in DimensionFilter)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<DataBoxEdgeMetricDimension>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(AdditionalDimensions))
            {
                writer.WritePropertyName("additionalDimensions"u8);
                writer.WriteStartArray();
                foreach (var item in AdditionalDimensions)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<DataBoxEdgeMetricDimension>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
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

        internal static DataBoxEdgeMetricCounter DeserializeDataBoxEdgeMetricCounter(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            Optional<string> instance = default;
            Optional<IList<DataBoxEdgeMetricDimension>> dimensionFilter = default;
            Optional<IList<DataBoxEdgeMetricDimension>> additionalDimensions = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("instance"u8))
                {
                    instance = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dimensionFilter"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataBoxEdgeMetricDimension> array = new List<DataBoxEdgeMetricDimension>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataBoxEdgeMetricDimension.DeserializeDataBoxEdgeMetricDimension(item));
                    }
                    dimensionFilter = array;
                    continue;
                }
                if (property.NameEquals("additionalDimensions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataBoxEdgeMetricDimension> array = new List<DataBoxEdgeMetricDimension>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataBoxEdgeMetricDimension.DeserializeDataBoxEdgeMetricDimension(item));
                    }
                    additionalDimensions = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DataBoxEdgeMetricCounter(name, instance.Value, Optional.ToList(dimensionFilter), Optional.ToList(additionalDimensions), rawData);
        }

        DataBoxEdgeMetricCounter IModelJsonSerializable<DataBoxEdgeMetricCounter>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataBoxEdgeMetricCounter>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDataBoxEdgeMetricCounter(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DataBoxEdgeMetricCounter>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataBoxEdgeMetricCounter>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DataBoxEdgeMetricCounter IModelSerializable<DataBoxEdgeMetricCounter>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataBoxEdgeMetricCounter>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDataBoxEdgeMetricCounter(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DataBoxEdgeMetricCounter"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DataBoxEdgeMetricCounter"/> to convert. </param>
        public static implicit operator RequestContent(DataBoxEdgeMetricCounter model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DataBoxEdgeMetricCounter"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DataBoxEdgeMetricCounter(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDataBoxEdgeMetricCounter(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
