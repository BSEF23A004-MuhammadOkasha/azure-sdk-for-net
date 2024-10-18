// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class GatewayRoute : IUtf8JsonSerializable, IJsonModel<GatewayRoute>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<GatewayRoute>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<GatewayRoute>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GatewayRoute>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GatewayRoute)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(LocalAddress))
            {
                writer.WritePropertyName("localAddress"u8);
                writer.WriteStringValue(LocalAddress);
            }
            if (options.Format != "W" && Optional.IsDefined(Network))
            {
                writer.WritePropertyName("network"u8);
                writer.WriteStringValue(Network);
            }
            if (options.Format != "W" && Optional.IsDefined(NextHop))
            {
                writer.WritePropertyName("nextHop"u8);
                writer.WriteStringValue(NextHop);
            }
            if (options.Format != "W" && Optional.IsDefined(SourcePeer))
            {
                writer.WritePropertyName("sourcePeer"u8);
                writer.WriteStringValue(SourcePeer);
            }
            if (options.Format != "W" && Optional.IsDefined(Origin))
            {
                writer.WritePropertyName("origin"u8);
                writer.WriteStringValue(Origin);
            }
            if (options.Format != "W" && Optional.IsDefined(AsPath))
            {
                writer.WritePropertyName("asPath"u8);
                writer.WriteStringValue(AsPath);
            }
            if (options.Format != "W" && Optional.IsDefined(Weight))
            {
                writer.WritePropertyName("weight"u8);
                writer.WriteNumberValue(Weight.Value);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
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
        }

        GatewayRoute IJsonModel<GatewayRoute>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GatewayRoute>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GatewayRoute)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeGatewayRoute(document.RootElement, options);
        }

        internal static GatewayRoute DeserializeGatewayRoute(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string localAddress = default;
            string network = default;
            string nextHop = default;
            string sourcePeer = default;
            string origin = default;
            string asPath = default;
            int? weight = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("localAddress"u8))
                {
                    localAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("network"u8))
                {
                    network = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("nextHop"u8))
                {
                    nextHop = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourcePeer"u8))
                {
                    sourcePeer = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("origin"u8))
                {
                    origin = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("asPath"u8))
                {
                    asPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("weight"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    weight = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new GatewayRoute(
                localAddress,
                network,
                nextHop,
                sourcePeer,
                origin,
                asPath,
                weight,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<GatewayRoute>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GatewayRoute>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(GatewayRoute)} does not support writing '{options.Format}' format.");
            }
        }

        GatewayRoute IPersistableModel<GatewayRoute>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GatewayRoute>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeGatewayRoute(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(GatewayRoute)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<GatewayRoute>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
