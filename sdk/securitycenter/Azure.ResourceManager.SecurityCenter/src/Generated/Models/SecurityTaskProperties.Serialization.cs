// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class SecurityTaskProperties : IUtf8JsonSerializable, IJsonModel<SecurityTaskProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SecurityTaskProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SecurityTaskProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityTaskProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityTaskProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Name != null)
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            foreach (var item in AdditionalProperties)
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
            writer.WriteEndObject();
        }

        SecurityTaskProperties IJsonModel<SecurityTaskProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityTaskProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityTaskProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSecurityTaskProperties(document.RootElement, options);
        }

        internal static SecurityTaskProperties DeserializeSecurityTaskProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new SecurityTaskProperties(name, additionalProperties);
        }

        BinaryData IPersistableModel<SecurityTaskProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityTaskProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SecurityTaskProperties)} does not support '{options.Format}' format.");
            }
        }

        SecurityTaskProperties IPersistableModel<SecurityTaskProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityTaskProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSecurityTaskProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SecurityTaskProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SecurityTaskProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
