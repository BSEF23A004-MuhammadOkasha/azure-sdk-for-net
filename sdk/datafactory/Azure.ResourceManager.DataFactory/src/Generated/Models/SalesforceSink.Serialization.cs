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
    public partial class SalesforceSink : IUtf8JsonSerializable, IModelJsonSerializable<SalesforceSink>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SalesforceSink>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SalesforceSink>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SalesforceSink>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(WriteBehavior))
            {
                writer.WritePropertyName("writeBehavior"u8);
                writer.WriteStringValue(WriteBehavior.Value.ToString());
            }
            if (Optional.IsDefined(ExternalIdFieldName))
            {
                writer.WritePropertyName("externalIdFieldName"u8);
                JsonSerializer.Serialize(writer, ExternalIdFieldName);
            }
            if (Optional.IsDefined(IgnoreNullValues))
            {
                writer.WritePropertyName("ignoreNullValues"u8);
                JsonSerializer.Serialize(writer, IgnoreNullValues);
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(CopySinkType);
            if (Optional.IsDefined(WriteBatchSize))
            {
                writer.WritePropertyName("writeBatchSize"u8);
                JsonSerializer.Serialize(writer, WriteBatchSize);
            }
            if (Optional.IsDefined(WriteBatchTimeout))
            {
                writer.WritePropertyName("writeBatchTimeout"u8);
                JsonSerializer.Serialize(writer, WriteBatchTimeout);
            }
            if (Optional.IsDefined(SinkRetryCount))
            {
                writer.WritePropertyName("sinkRetryCount"u8);
                JsonSerializer.Serialize(writer, SinkRetryCount);
            }
            if (Optional.IsDefined(SinkRetryWait))
            {
                writer.WritePropertyName("sinkRetryWait"u8);
                JsonSerializer.Serialize(writer, SinkRetryWait);
            }
            if (Optional.IsDefined(MaxConcurrentConnections))
            {
                writer.WritePropertyName("maxConcurrentConnections"u8);
                JsonSerializer.Serialize(writer, MaxConcurrentConnections);
            }
            if (Optional.IsDefined(DisableMetricsCollection))
            {
                writer.WritePropertyName("disableMetricsCollection"u8);
                JsonSerializer.Serialize(writer, DisableMetricsCollection);
            }
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

        internal static SalesforceSink DeserializeSalesforceSink(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<SalesforceSinkWriteBehavior> writeBehavior = default;
            Optional<DataFactoryElement<string>> externalIdFieldName = default;
            Optional<DataFactoryElement<bool>> ignoreNullValues = default;
            string type = default;
            Optional<DataFactoryElement<int>> writeBatchSize = default;
            Optional<DataFactoryElement<string>> writeBatchTimeout = default;
            Optional<DataFactoryElement<int>> sinkRetryCount = default;
            Optional<DataFactoryElement<string>> sinkRetryWait = default;
            Optional<DataFactoryElement<int>> maxConcurrentConnections = default;
            Optional<DataFactoryElement<bool>> disableMetricsCollection = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("writeBehavior"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    writeBehavior = new SalesforceSinkWriteBehavior(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("externalIdFieldName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    externalIdFieldName = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("ignoreNullValues"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ignoreNullValues = JsonSerializer.Deserialize<DataFactoryElement<bool>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("writeBatchSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    writeBatchSize = JsonSerializer.Deserialize<DataFactoryElement<int>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("writeBatchTimeout"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    writeBatchTimeout = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("sinkRetryCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sinkRetryCount = JsonSerializer.Deserialize<DataFactoryElement<int>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("sinkRetryWait"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sinkRetryWait = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("maxConcurrentConnections"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxConcurrentConnections = JsonSerializer.Deserialize<DataFactoryElement<int>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("disableMetricsCollection"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    disableMetricsCollection = JsonSerializer.Deserialize<DataFactoryElement<bool>>(property.Value.GetRawText());
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new SalesforceSink(type, writeBatchSize.Value, writeBatchTimeout.Value, sinkRetryCount.Value, sinkRetryWait.Value, maxConcurrentConnections.Value, disableMetricsCollection.Value, additionalProperties, Optional.ToNullable(writeBehavior), externalIdFieldName.Value, ignoreNullValues.Value);
        }

        SalesforceSink IModelJsonSerializable<SalesforceSink>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SalesforceSink>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSalesforceSink(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SalesforceSink>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SalesforceSink>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SalesforceSink IModelSerializable<SalesforceSink>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SalesforceSink>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSalesforceSink(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SalesforceSink"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SalesforceSink"/> to convert. </param>
        public static implicit operator RequestContent(SalesforceSink model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SalesforceSink"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SalesforceSink(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSalesforceSink(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
