// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ApiManagement;

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class PortalSettingValidationKeyContract : IUtf8JsonSerializable, IJsonModel<PortalSettingValidationKeyContract>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PortalSettingValidationKeyContract>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PortalSettingValidationKeyContract>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PortalSettingValidationKeyContract>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PortalSettingValidationKeyContract)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ValidationKey))
            {
                writer.WritePropertyName("validationKey"u8);
                writer.WriteStringValue(ValidationKey);
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

        PortalSettingValidationKeyContract IJsonModel<PortalSettingValidationKeyContract>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PortalSettingValidationKeyContract>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PortalSettingValidationKeyContract)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePortalSettingValidationKeyContract(document.RootElement, options);
        }

        internal static PortalSettingValidationKeyContract DeserializePortalSettingValidationKeyContract(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string validationKey = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("validationKey"u8))
                {
                    validationKey = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PortalSettingValidationKeyContract(validationKey, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PortalSettingValidationKeyContract>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PortalSettingValidationKeyContract>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PortalSettingValidationKeyContract)} does not support '{options.Format}' format.");
            }
        }

        PortalSettingValidationKeyContract IPersistableModel<PortalSettingValidationKeyContract>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PortalSettingValidationKeyContract>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePortalSettingValidationKeyContract(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PortalSettingValidationKeyContract)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PortalSettingValidationKeyContract>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
