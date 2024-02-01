// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class CloudServiceNetworkProfile : IUtf8JsonSerializable, IJsonModel<CloudServiceNetworkProfile>, IPersistableModel<CloudServiceNetworkProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CloudServiceNetworkProfile>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CloudServiceNetworkProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CloudServiceNetworkProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CloudServiceNetworkProfile)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(LoadBalancerConfigurations))
            {
                writer.WritePropertyName("loadBalancerConfigurations"u8);
                writer.WriteStartArray();
                foreach (var item in LoadBalancerConfigurations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(SlotType))
            {
                writer.WritePropertyName("slotType"u8);
                writer.WriteStringValue(SlotType.Value.ToString());
            }
            if (Optional.IsDefined(SwappableCloudService))
            {
                writer.WritePropertyName("swappableCloudService"u8);
                JsonSerializer.Serialize(writer, SwappableCloudService);
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

        CloudServiceNetworkProfile IJsonModel<CloudServiceNetworkProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CloudServiceNetworkProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CloudServiceNetworkProfile)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCloudServiceNetworkProfile(document.RootElement, options);
        }

        internal static CloudServiceNetworkProfile DeserializeCloudServiceNetworkProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<CloudServiceLoadBalancerConfiguration>> loadBalancerConfigurations = default;
            Optional<CloudServiceSlotType> slotType = default;
            Optional<WritableSubResource> swappableCloudService = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("loadBalancerConfigurations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CloudServiceLoadBalancerConfiguration> array = new List<CloudServiceLoadBalancerConfiguration>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CloudServiceLoadBalancerConfiguration.DeserializeCloudServiceLoadBalancerConfiguration(item));
                    }
                    loadBalancerConfigurations = array;
                    continue;
                }
                if (property.NameEquals("slotType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    slotType = new CloudServiceSlotType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("swappableCloudService"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    swappableCloudService = JsonSerializer.Deserialize<WritableSubResource>(property.Value.GetRawText());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CloudServiceNetworkProfile(Optional.ToList(loadBalancerConfigurations), Optional.ToNullable(slotType), swappableCloudService, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsCollectionDefined(LoadBalancerConfigurations))
            {
                builder.Append("  loadBalancerConfigurations:");
                builder.AppendLine(" [");
                foreach (var item in LoadBalancerConfigurations)
                {
                    AppendChildObject(builder, item, options, 4);
                }
                builder.AppendLine("  ]");
            }

            if (Optional.IsDefined(SlotType))
            {
                builder.Append("  slotType:");
                builder.AppendLine($" '{SlotType.ToString()}'");
            }

            if (Optional.IsDefined(SwappableCloudService))
            {
                builder.Append("  swappableCloudService:");
                AppendChildObject(builder, SwappableCloudService, options, 2);
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        private void AppendChildObject(StringBuilder stringBuilder, object childObject, ModelReaderWriterOptions options, int spaces)
        {
            string indent = new string(' ', spaces);
            BinaryData data = ModelReaderWriter.Write(childObject, options);
            string[] lines = data.ToString().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            foreach (var line in lines)
            {
                stringBuilder.AppendLine($"{indent}{line}");
            }
        }

        BinaryData IPersistableModel<CloudServiceNetworkProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CloudServiceNetworkProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(CloudServiceNetworkProfile)} does not support '{options.Format}' format.");
            }
        }

        CloudServiceNetworkProfile IPersistableModel<CloudServiceNetworkProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CloudServiceNetworkProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCloudServiceNetworkProfile(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(CloudServiceNetworkProfile)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CloudServiceNetworkProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
