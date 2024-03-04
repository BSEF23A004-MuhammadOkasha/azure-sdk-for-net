// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.MySql;

namespace Azure.ResourceManager.MySql.FlexibleServers.Models
{
    public partial class MySqlFlexibleServerPrivateDnsZoneSuffixResponse : IUtf8JsonSerializable, IJsonModel<MySqlFlexibleServerPrivateDnsZoneSuffixResponse>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MySqlFlexibleServerPrivateDnsZoneSuffixResponse>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MySqlFlexibleServerPrivateDnsZoneSuffixResponse>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MySqlFlexibleServerPrivateDnsZoneSuffixResponse>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MySqlFlexibleServerPrivateDnsZoneSuffixResponse)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(PrivateDnsZoneSuffix))
            {
                writer.WritePropertyName("privateDnsZoneSuffix"u8);
                writer.WriteStringValue(PrivateDnsZoneSuffix);
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

        MySqlFlexibleServerPrivateDnsZoneSuffixResponse IJsonModel<MySqlFlexibleServerPrivateDnsZoneSuffixResponse>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MySqlFlexibleServerPrivateDnsZoneSuffixResponse>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MySqlFlexibleServerPrivateDnsZoneSuffixResponse)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMySqlFlexibleServerPrivateDnsZoneSuffixResponse(document.RootElement, options);
        }

        internal static MySqlFlexibleServerPrivateDnsZoneSuffixResponse DeserializeMySqlFlexibleServerPrivateDnsZoneSuffixResponse(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string privateDnsZoneSuffix = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("privateDnsZoneSuffix"u8))
                {
                    privateDnsZoneSuffix = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MySqlFlexibleServerPrivateDnsZoneSuffixResponse(privateDnsZoneSuffix, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MySqlFlexibleServerPrivateDnsZoneSuffixResponse>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MySqlFlexibleServerPrivateDnsZoneSuffixResponse>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MySqlFlexibleServerPrivateDnsZoneSuffixResponse)} does not support '{options.Format}' format.");
            }
        }

        MySqlFlexibleServerPrivateDnsZoneSuffixResponse IPersistableModel<MySqlFlexibleServerPrivateDnsZoneSuffixResponse>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MySqlFlexibleServerPrivateDnsZoneSuffixResponse>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMySqlFlexibleServerPrivateDnsZoneSuffixResponse(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MySqlFlexibleServerPrivateDnsZoneSuffixResponse)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MySqlFlexibleServerPrivateDnsZoneSuffixResponse>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
