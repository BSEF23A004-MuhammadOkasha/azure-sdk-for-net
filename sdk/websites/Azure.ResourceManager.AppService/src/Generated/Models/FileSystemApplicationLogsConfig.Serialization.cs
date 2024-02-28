// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    internal partial class FileSystemApplicationLogsConfig : IUtf8JsonSerializable, IJsonModel<FileSystemApplicationLogsConfig>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FileSystemApplicationLogsConfig>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<FileSystemApplicationLogsConfig>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FileSystemApplicationLogsConfig>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FileSystemApplicationLogsConfig)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Level.HasValue)
            {
                writer.WritePropertyName("level"u8);
                writer.WriteStringValue(Level.Value.ToSerialString());
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

        FileSystemApplicationLogsConfig IJsonModel<FileSystemApplicationLogsConfig>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FileSystemApplicationLogsConfig>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FileSystemApplicationLogsConfig)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFileSystemApplicationLogsConfig(document.RootElement, options);
        }

        internal static FileSystemApplicationLogsConfig DeserializeFileSystemApplicationLogsConfig(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            WebAppLogLevel? level = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("level"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    level = property.Value.GetString().ToWebAppLogLevel();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new FileSystemApplicationLogsConfig(level, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<FileSystemApplicationLogsConfig>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FileSystemApplicationLogsConfig>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(FileSystemApplicationLogsConfig)} does not support '{options.Format}' format.");
            }
        }

        FileSystemApplicationLogsConfig IPersistableModel<FileSystemApplicationLogsConfig>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FileSystemApplicationLogsConfig>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeFileSystemApplicationLogsConfig(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FileSystemApplicationLogsConfig)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<FileSystemApplicationLogsConfig>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
