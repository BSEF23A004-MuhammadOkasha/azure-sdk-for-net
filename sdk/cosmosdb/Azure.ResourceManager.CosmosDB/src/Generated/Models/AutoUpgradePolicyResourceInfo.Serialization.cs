// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    internal partial class AutoUpgradePolicyResourceInfo : IUtf8JsonSerializable, IJsonModel<AutoUpgradePolicyResourceInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AutoUpgradePolicyResourceInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AutoUpgradePolicyResourceInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutoUpgradePolicyResourceInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AutoUpgradePolicyResourceInfo)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ThroughputPolicy))
            {
                writer.WritePropertyName("throughputPolicy"u8);
                BinaryData data = ModelReaderWriter.Write(ThroughputPolicy, options);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(data);
#else
                using (JsonDocument document = JsonDocument.Parse(data))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
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

        AutoUpgradePolicyResourceInfo IJsonModel<AutoUpgradePolicyResourceInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutoUpgradePolicyResourceInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AutoUpgradePolicyResourceInfo)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAutoUpgradePolicyResourceInfo(document.RootElement, options);
        }

        internal static AutoUpgradePolicyResourceInfo DeserializeAutoUpgradePolicyResourceInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ThroughputPolicyResourceInfo> throughputPolicy = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("throughputPolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    throughputPolicy = ThroughputPolicyResourceInfo.DeserializeThroughputPolicyResourceInfo(property.Value);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AutoUpgradePolicyResourceInfo(throughputPolicy.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AutoUpgradePolicyResourceInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutoUpgradePolicyResourceInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AutoUpgradePolicyResourceInfo)} does not support '{options.Format}' format.");
            }
        }

        AutoUpgradePolicyResourceInfo IPersistableModel<AutoUpgradePolicyResourceInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutoUpgradePolicyResourceInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAutoUpgradePolicyResourceInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AutoUpgradePolicyResourceInfo)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AutoUpgradePolicyResourceInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
