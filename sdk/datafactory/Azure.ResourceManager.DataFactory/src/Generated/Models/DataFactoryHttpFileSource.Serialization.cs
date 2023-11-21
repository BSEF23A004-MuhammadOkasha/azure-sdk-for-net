// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class DataFactoryHttpFileSource : IUtf8JsonSerializable, IJsonModel<DataFactoryHttpFileSource>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataFactoryHttpFileSource>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DataFactoryHttpFileSource>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataFactoryHttpFileSource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(DataFactoryHttpFileSource)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(HttpRequestTimeout))
            {
                writer.WritePropertyName("httpRequestTimeout"u8);
                JsonSerializer.Serialize(writer, HttpRequestTimeout);
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(CopySourceType);
            if (Optional.IsDefined(SourceRetryCount))
            {
                writer.WritePropertyName("sourceRetryCount"u8);
                JsonSerializer.Serialize(writer, SourceRetryCount);
            }
            if (Optional.IsDefined(SourceRetryWait))
            {
                writer.WritePropertyName("sourceRetryWait"u8);
                JsonSerializer.Serialize(writer, SourceRetryWait);
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
            if (AdditionalProperties != null)
            {
                foreach (var item in AdditionalProperties)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        DataFactoryHttpFileSource IJsonModel<DataFactoryHttpFileSource>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataFactoryHttpFileSource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(DataFactoryHttpFileSource)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataFactoryHttpFileSource(document.RootElement, options);
        }

        internal static DataFactoryHttpFileSource DeserializeDataFactoryHttpFileSource(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DataFactoryElement<string>> httpRequestTimeout = default;
            string type = default;
            Optional<DataFactoryElement<int>> sourceRetryCount = default;
            Optional<DataFactoryElement<string>> sourceRetryWait = default;
            Optional<DataFactoryElement<int>> maxConcurrentConnections = default;
            Optional<DataFactoryElement<bool>> disableMetricsCollection = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("httpRequestTimeout"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    httpRequestTimeout = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceRetryCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceRetryCount = JsonSerializer.Deserialize<DataFactoryElement<int>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("sourceRetryWait"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceRetryWait = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
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
            return new DataFactoryHttpFileSource(type, sourceRetryCount.Value, sourceRetryWait.Value, maxConcurrentConnections.Value, disableMetricsCollection.Value, additionalProperties, httpRequestTimeout.Value);
        }

        BinaryData IPersistableModel<DataFactoryHttpFileSource>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataFactoryHttpFileSource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(DataFactoryHttpFileSource)} does not support '{options.Format}' format.");
            }
        }

        DataFactoryHttpFileSource IPersistableModel<DataFactoryHttpFileSource>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataFactoryHttpFileSource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataFactoryHttpFileSource(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(DataFactoryHttpFileSource)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataFactoryHttpFileSource>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
