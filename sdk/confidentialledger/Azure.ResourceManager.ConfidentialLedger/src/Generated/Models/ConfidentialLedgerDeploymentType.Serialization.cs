// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ConfidentialLedger.Models
{
    public partial class ConfidentialLedgerDeploymentType : IUtf8JsonSerializable, IJsonModel<ConfidentialLedgerDeploymentType>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ConfidentialLedgerDeploymentType>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ConfidentialLedgerDeploymentType>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConfidentialLedgerDeploymentType>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConfidentialLedgerDeploymentType)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (LanguageRuntime.HasValue)
            {
                writer.WritePropertyName("languageRuntime"u8);
                writer.WriteStringValue(LanguageRuntime.Value.ToString());
            }
            if (AppSourceUri != null)
            {
                writer.WritePropertyName("appSourceUri"u8);
                writer.WriteStringValue(AppSourceUri.AbsoluteUri);
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

        ConfidentialLedgerDeploymentType IJsonModel<ConfidentialLedgerDeploymentType>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConfidentialLedgerDeploymentType>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConfidentialLedgerDeploymentType)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConfidentialLedgerDeploymentType(document.RootElement, options);
        }

        internal static ConfidentialLedgerDeploymentType DeserializeConfidentialLedgerDeploymentType(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ConfidentialLedgerLanguageRuntime? languageRuntime = default;
            Uri appSourceUri = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("languageRuntime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    languageRuntime = new ConfidentialLedgerLanguageRuntime(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("appSourceUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    appSourceUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ConfidentialLedgerDeploymentType(languageRuntime, appSourceUri, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ConfidentialLedgerDeploymentType>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConfidentialLedgerDeploymentType>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ConfidentialLedgerDeploymentType)} does not support '{options.Format}' format.");
            }
        }

        ConfidentialLedgerDeploymentType IPersistableModel<ConfidentialLedgerDeploymentType>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConfidentialLedgerDeploymentType>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeConfidentialLedgerDeploymentType(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ConfidentialLedgerDeploymentType)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ConfidentialLedgerDeploymentType>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
