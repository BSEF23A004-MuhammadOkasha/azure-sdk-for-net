// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ManagedNetworkFabric;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    public partial class NetworkTapRuleMatchCondition : IUtf8JsonSerializable, IJsonModel<NetworkTapRuleMatchCondition>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NetworkTapRuleMatchCondition>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<NetworkTapRuleMatchCondition>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkTapRuleMatchCondition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkTapRuleMatchCondition)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(EncapsulationType))
            {
                writer.WritePropertyName("encapsulationType"u8);
                writer.WriteStringValue(EncapsulationType.Value.ToString());
            }
            if (Optional.IsDefined(PortCondition))
            {
                writer.WritePropertyName("portCondition"u8);
                writer.WriteObjectValue(PortCondition);
            }
            if (Optional.IsCollectionDefined(ProtocolTypes))
            {
                writer.WritePropertyName("protocolTypes"u8);
                writer.WriteStartArray();
                foreach (var item in ProtocolTypes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(VlanMatchCondition))
            {
                writer.WritePropertyName("vlanMatchCondition"u8);
                writer.WriteObjectValue(VlanMatchCondition);
            }
            if (Optional.IsDefined(IPCondition))
            {
                writer.WritePropertyName("ipCondition"u8);
                writer.WriteObjectValue(IPCondition);
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

        NetworkTapRuleMatchCondition IJsonModel<NetworkTapRuleMatchCondition>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkTapRuleMatchCondition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkTapRuleMatchCondition)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNetworkTapRuleMatchCondition(document.RootElement, options);
        }

        internal static NetworkTapRuleMatchCondition DeserializeNetworkTapRuleMatchCondition(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            NetworkTapEncapsulationType? encapsulationType = default;
            NetworkFabricPortCondition portCondition = default;
            IList<string> protocolTypes = default;
            VlanMatchCondition vlanMatchCondition = default;
            IPMatchCondition ipCondition = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("encapsulationType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    encapsulationType = new NetworkTapEncapsulationType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("portCondition"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    portCondition = NetworkFabricPortCondition.DeserializeNetworkFabricPortCondition(property.Value, options);
                    continue;
                }
                if (property.NameEquals("protocolTypes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    protocolTypes = array;
                    continue;
                }
                if (property.NameEquals("vlanMatchCondition"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    vlanMatchCondition = VlanMatchCondition.DeserializeVlanMatchCondition(property.Value, options);
                    continue;
                }
                if (property.NameEquals("ipCondition"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ipCondition = IPMatchCondition.DeserializeIPMatchCondition(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new NetworkTapRuleMatchCondition(
                protocolTypes ?? new ChangeTrackingList<string>(),
                vlanMatchCondition,
                ipCondition,
                serializedAdditionalRawData,
                encapsulationType,
                portCondition);
        }

        BinaryData IPersistableModel<NetworkTapRuleMatchCondition>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkTapRuleMatchCondition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NetworkTapRuleMatchCondition)} does not support '{options.Format}' format.");
            }
        }

        NetworkTapRuleMatchCondition IPersistableModel<NetworkTapRuleMatchCondition>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkTapRuleMatchCondition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNetworkTapRuleMatchCondition(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NetworkTapRuleMatchCondition)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<NetworkTapRuleMatchCondition>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
