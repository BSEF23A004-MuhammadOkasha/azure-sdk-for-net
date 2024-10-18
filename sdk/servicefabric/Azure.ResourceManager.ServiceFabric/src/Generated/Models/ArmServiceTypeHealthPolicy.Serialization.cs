// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabric.Models
{
    public partial class ArmServiceTypeHealthPolicy : IUtf8JsonSerializable, IJsonModel<ArmServiceTypeHealthPolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ArmServiceTypeHealthPolicy>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ArmServiceTypeHealthPolicy>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ArmServiceTypeHealthPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ArmServiceTypeHealthPolicy)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(MaxPercentUnhealthyServices))
            {
                writer.WritePropertyName("maxPercentUnhealthyServices"u8);
                writer.WriteNumberValue(MaxPercentUnhealthyServices.Value);
            }
            if (Optional.IsDefined(MaxPercentUnhealthyPartitionsPerService))
            {
                writer.WritePropertyName("maxPercentUnhealthyPartitionsPerService"u8);
                writer.WriteNumberValue(MaxPercentUnhealthyPartitionsPerService.Value);
            }
            if (Optional.IsDefined(MaxPercentUnhealthyReplicasPerPartition))
            {
                writer.WritePropertyName("maxPercentUnhealthyReplicasPerPartition"u8);
                writer.WriteNumberValue(MaxPercentUnhealthyReplicasPerPartition.Value);
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

        ArmServiceTypeHealthPolicy IJsonModel<ArmServiceTypeHealthPolicy>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ArmServiceTypeHealthPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ArmServiceTypeHealthPolicy)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeArmServiceTypeHealthPolicy(document.RootElement, options);
        }

        internal static ArmServiceTypeHealthPolicy DeserializeArmServiceTypeHealthPolicy(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? maxPercentUnhealthyServices = default;
            int? maxPercentUnhealthyPartitionsPerService = default;
            int? maxPercentUnhealthyReplicasPerPartition = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("maxPercentUnhealthyServices"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxPercentUnhealthyServices = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxPercentUnhealthyPartitionsPerService"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxPercentUnhealthyPartitionsPerService = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxPercentUnhealthyReplicasPerPartition"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxPercentUnhealthyReplicasPerPartition = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ArmServiceTypeHealthPolicy(maxPercentUnhealthyServices, maxPercentUnhealthyPartitionsPerService, maxPercentUnhealthyReplicasPerPartition, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ArmServiceTypeHealthPolicy>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ArmServiceTypeHealthPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ArmServiceTypeHealthPolicy)} does not support writing '{options.Format}' format.");
            }
        }

        ArmServiceTypeHealthPolicy IPersistableModel<ArmServiceTypeHealthPolicy>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ArmServiceTypeHealthPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeArmServiceTypeHealthPolicy(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ArmServiceTypeHealthPolicy)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ArmServiceTypeHealthPolicy>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
