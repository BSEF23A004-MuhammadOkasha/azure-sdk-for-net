// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MobileNetwork.Models
{
    internal partial class DiagnosticsUploadConfiguration : IUtf8JsonSerializable, IJsonModel<DiagnosticsUploadConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DiagnosticsUploadConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DiagnosticsUploadConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DiagnosticsUploadConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(DiagnosticsUploadConfiguration)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("storageAccountContainerUrl"u8);
            writer.WriteStringValue(StorageAccountContainerUri.AbsoluteUri);
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

        DiagnosticsUploadConfiguration IJsonModel<DiagnosticsUploadConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DiagnosticsUploadConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(DiagnosticsUploadConfiguration)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDiagnosticsUploadConfiguration(document.RootElement, options);
        }

        internal static DiagnosticsUploadConfiguration DeserializeDiagnosticsUploadConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Uri storageAccountContainerUrl = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("storageAccountContainerUrl"u8))
                {
                    storageAccountContainerUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DiagnosticsUploadConfiguration(storageAccountContainerUrl, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DiagnosticsUploadConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DiagnosticsUploadConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(DiagnosticsUploadConfiguration)} does not support '{options.Format}' format.");
            }
        }

        DiagnosticsUploadConfiguration IPersistableModel<DiagnosticsUploadConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DiagnosticsUploadConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDiagnosticsUploadConfiguration(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(DiagnosticsUploadConfiguration)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DiagnosticsUploadConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
