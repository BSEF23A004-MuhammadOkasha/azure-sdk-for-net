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
    public partial class OraclePartitionSettings : IUtf8JsonSerializable, IModelJsonSerializable<OraclePartitionSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<OraclePartitionSettings>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<OraclePartitionSettings>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<OraclePartitionSettings>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(PartitionNames))
            {
                writer.WritePropertyName("partitionNames"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(PartitionNames);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(PartitionNames.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(PartitionColumnName))
            {
                writer.WritePropertyName("partitionColumnName"u8);
                JsonSerializer.Serialize(writer, PartitionColumnName);
            }
            if (Optional.IsDefined(PartitionUpperBound))
            {
                writer.WritePropertyName("partitionUpperBound"u8);
                JsonSerializer.Serialize(writer, PartitionUpperBound);
            }
            if (Optional.IsDefined(PartitionLowerBound))
            {
                writer.WritePropertyName("partitionLowerBound"u8);
                JsonSerializer.Serialize(writer, PartitionLowerBound);
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

        internal static OraclePartitionSettings DeserializeOraclePartitionSettings(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<BinaryData> partitionNames = default;
            Optional<DataFactoryElement<string>> partitionColumnName = default;
            Optional<DataFactoryElement<string>> partitionUpperBound = default;
            Optional<DataFactoryElement<string>> partitionLowerBound = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("partitionNames"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    partitionNames = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("partitionColumnName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    partitionColumnName = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("partitionUpperBound"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    partitionUpperBound = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("partitionLowerBound"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    partitionLowerBound = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new OraclePartitionSettings(partitionNames.Value, partitionColumnName.Value, partitionUpperBound.Value, partitionLowerBound.Value, rawData);
        }

        OraclePartitionSettings IModelJsonSerializable<OraclePartitionSettings>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<OraclePartitionSettings>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeOraclePartitionSettings(doc.RootElement, options);
        }

        BinaryData IModelSerializable<OraclePartitionSettings>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<OraclePartitionSettings>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        OraclePartitionSettings IModelSerializable<OraclePartitionSettings>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<OraclePartitionSettings>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeOraclePartitionSettings(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="OraclePartitionSettings"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="OraclePartitionSettings"/> to convert. </param>
        public static implicit operator RequestContent(OraclePartitionSettings model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="OraclePartitionSettings"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator OraclePartitionSettings(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeOraclePartitionSettings(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
