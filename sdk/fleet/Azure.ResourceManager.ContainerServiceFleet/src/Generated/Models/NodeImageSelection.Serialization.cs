// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerServiceFleet.Models
{
    public partial class NodeImageSelection : IUtf8JsonSerializable, IJsonModel<NodeImageSelection>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NodeImageSelection>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<NodeImageSelection>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NodeImageSelection>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NodeImageSelection)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(SelectionType.ToString());
            if (Optional.IsCollectionDefined(CustomNodeImageVersions))
            {
                writer.WritePropertyName("customNodeImageVersions"u8);
                writer.WriteStartArray();
                foreach (var item in CustomNodeImageVersions)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
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

        NodeImageSelection IJsonModel<NodeImageSelection>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NodeImageSelection>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NodeImageSelection)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNodeImageSelection(document.RootElement, options);
        }

        internal static NodeImageSelection DeserializeNodeImageSelection(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            NodeImageSelectionType type = default;
            IList<NodeImageVersion> customNodeImageVersions = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = new NodeImageSelectionType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("customNodeImageVersions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<NodeImageVersion> array = new List<NodeImageVersion>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NodeImageVersion.DeserializeNodeImageVersion(item, options));
                    }
                    customNodeImageVersions = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new NodeImageSelection(type, customNodeImageVersions ?? new ChangeTrackingList<NodeImageVersion>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NodeImageSelection>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NodeImageSelection>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NodeImageSelection)} does not support writing '{options.Format}' format.");
            }
        }

        NodeImageSelection IPersistableModel<NodeImageSelection>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NodeImageSelection>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNodeImageSelection(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NodeImageSelection)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<NodeImageSelection>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
