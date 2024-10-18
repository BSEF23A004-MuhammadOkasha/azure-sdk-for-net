// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    public partial class CommonMatchConditions : IUtf8JsonSerializable, IJsonModel<CommonMatchConditions>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CommonMatchConditions>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<CommonMatchConditions>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CommonMatchConditions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CommonMatchConditions)} does not support writing '{format}' format.");
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
                writer.WriteObjectValue(VlanMatchCondition, options);
            }
            if (Optional.IsDefined(IPCondition))
            {
                writer.WritePropertyName("ipCondition"u8);
                writer.WriteObjectValue(IPCondition, options);
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

        CommonMatchConditions IJsonModel<CommonMatchConditions>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CommonMatchConditions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CommonMatchConditions)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCommonMatchConditions(document.RootElement, options);
        }

        internal static CommonMatchConditions DeserializeCommonMatchConditions(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<string> protocolTypes = default;
            VlanMatchCondition vlanMatchCondition = default;
            IPMatchCondition ipCondition = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new CommonMatchConditions(protocolTypes ?? new ChangeTrackingList<string>(), vlanMatchCondition, ipCondition, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CommonMatchConditions>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CommonMatchConditions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CommonMatchConditions)} does not support writing '{options.Format}' format.");
            }
        }

        CommonMatchConditions IPersistableModel<CommonMatchConditions>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CommonMatchConditions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCommonMatchConditions(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CommonMatchConditions)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<CommonMatchConditions>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
