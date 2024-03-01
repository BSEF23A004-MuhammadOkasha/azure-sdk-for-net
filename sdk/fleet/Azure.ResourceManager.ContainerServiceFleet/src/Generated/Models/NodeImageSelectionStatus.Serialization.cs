// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ContainerServiceFleet;

namespace Azure.ResourceManager.ContainerServiceFleet.Models
{
    internal partial class NodeImageSelectionStatus : IUtf8JsonSerializable, IJsonModel<NodeImageSelectionStatus>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NodeImageSelectionStatus>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<NodeImageSelectionStatus>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NodeImageSelectionStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NodeImageSelectionStatus)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && !(SelectedNodeImageVersions is ChangeTrackingList<NodeImageVersion> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("selectedNodeImageVersions"u8);
                writer.WriteStartArray();
                foreach (var item in SelectedNodeImageVersions)
                {
                    writer.WriteObjectValue(item);
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
            writer.WriteEndObject();
        }

        NodeImageSelectionStatus IJsonModel<NodeImageSelectionStatus>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NodeImageSelectionStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NodeImageSelectionStatus)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNodeImageSelectionStatus(document.RootElement, options);
        }

        internal static NodeImageSelectionStatus DeserializeNodeImageSelectionStatus(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<NodeImageVersion> selectedNodeImageVersions = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("selectedNodeImageVersions"u8))
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
                    selectedNodeImageVersions = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new NodeImageSelectionStatus(selectedNodeImageVersions ?? new ChangeTrackingList<NodeImageVersion>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NodeImageSelectionStatus>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NodeImageSelectionStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NodeImageSelectionStatus)} does not support '{options.Format}' format.");
            }
        }

        NodeImageSelectionStatus IPersistableModel<NodeImageSelectionStatus>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NodeImageSelectionStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNodeImageSelectionStatus(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NodeImageSelectionStatus)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<NodeImageSelectionStatus>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
