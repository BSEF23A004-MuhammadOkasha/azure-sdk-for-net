// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    public partial class MitigateJobContent : IUtf8JsonSerializable, IJsonModel<MitigateJobContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MitigateJobContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MitigateJobContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MitigateJobContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MitigateJobContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("customerResolutionCode"u8);
            writer.WriteStringValue(CustomerResolutionCode.ToSerialString());
            if (Optional.IsCollectionDefined(SerialNumberCustomerResolutionMap))
            {
                writer.WritePropertyName("serialNumberCustomerResolutionMap"u8);
                writer.WriteStartObject();
                foreach (var item in SerialNumberCustomerResolutionMap)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value.ToSerialString());
                }
                writer.WriteEndObject();
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

        MitigateJobContent IJsonModel<MitigateJobContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MitigateJobContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MitigateJobContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMitigateJobContent(document.RootElement, options);
        }

        internal static MitigateJobContent DeserializeMitigateJobContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            CustomerResolutionCode customerResolutionCode = default;
            Optional<IDictionary<string, CustomerResolutionCode>> serialNumberCustomerResolutionMap = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("customerResolutionCode"u8))
                {
                    customerResolutionCode = property.Value.GetString().ToCustomerResolutionCode();
                    continue;
                }
                if (property.NameEquals("serialNumberCustomerResolutionMap"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, CustomerResolutionCode> dictionary = new Dictionary<string, CustomerResolutionCode>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString().ToCustomerResolutionCode());
                    }
                    serialNumberCustomerResolutionMap = dictionary;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MitigateJobContent(customerResolutionCode, Optional.ToDictionary(serialNumberCustomerResolutionMap), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MitigateJobContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MitigateJobContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MitigateJobContent)} does not support '{options.Format}' format.");
            }
        }

        MitigateJobContent IPersistableModel<MitigateJobContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MitigateJobContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMitigateJobContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MitigateJobContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MitigateJobContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
