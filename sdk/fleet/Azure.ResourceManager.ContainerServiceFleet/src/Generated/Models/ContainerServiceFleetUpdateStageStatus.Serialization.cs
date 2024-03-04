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
    public partial class ContainerServiceFleetUpdateStageStatus : IUtf8JsonSerializable, IJsonModel<ContainerServiceFleetUpdateStageStatus>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerServiceFleetUpdateStageStatus>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ContainerServiceFleetUpdateStageStatus>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerServiceFleetUpdateStageStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerServiceFleetUpdateStageStatus)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteObjectValue(Status);
            }
            if (options.Format != "W" && Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(Groups))
            {
                writer.WritePropertyName("groups"u8);
                writer.WriteStartArray();
                foreach (var item in Groups)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(AfterStageWaitStatus))
            {
                writer.WritePropertyName("afterStageWaitStatus"u8);
                writer.WriteObjectValue(AfterStageWaitStatus);
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

        ContainerServiceFleetUpdateStageStatus IJsonModel<ContainerServiceFleetUpdateStageStatus>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerServiceFleetUpdateStageStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerServiceFleetUpdateStageStatus)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerServiceFleetUpdateStageStatus(document.RootElement, options);
        }

        internal static ContainerServiceFleetUpdateStageStatus DeserializeContainerServiceFleetUpdateStageStatus(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ContainerServiceFleetUpdateStatus status = default;
            string name = default;
            IReadOnlyList<ContainerServiceFleetUpdateGroupStatus> groups = default;
            ContainerServiceFleetWaitStatus afterStageWaitStatus = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = ContainerServiceFleetUpdateStatus.DeserializeContainerServiceFleetUpdateStatus(property.Value, options);
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("groups"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ContainerServiceFleetUpdateGroupStatus> array = new List<ContainerServiceFleetUpdateGroupStatus>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerServiceFleetUpdateGroupStatus.DeserializeContainerServiceFleetUpdateGroupStatus(item, options));
                    }
                    groups = array;
                    continue;
                }
                if (property.NameEquals("afterStageWaitStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    afterStageWaitStatus = ContainerServiceFleetWaitStatus.DeserializeContainerServiceFleetWaitStatus(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ContainerServiceFleetUpdateStageStatus(status, name, groups ?? new ChangeTrackingList<ContainerServiceFleetUpdateGroupStatus>(), afterStageWaitStatus, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ContainerServiceFleetUpdateStageStatus>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerServiceFleetUpdateStageStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ContainerServiceFleetUpdateStageStatus)} does not support '{options.Format}' format.");
            }
        }

        ContainerServiceFleetUpdateStageStatus IPersistableModel<ContainerServiceFleetUpdateStageStatus>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerServiceFleetUpdateStageStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerServiceFleetUpdateStageStatus(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerServiceFleetUpdateStageStatus)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerServiceFleetUpdateStageStatus>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
