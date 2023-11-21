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
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class AzureDatabricksDeltaLakeImportCommand : IUtf8JsonSerializable, IJsonModel<AzureDatabricksDeltaLakeImportCommand>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AzureDatabricksDeltaLakeImportCommand>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AzureDatabricksDeltaLakeImportCommand>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureDatabricksDeltaLakeImportCommand>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(AzureDatabricksDeltaLakeImportCommand)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(DateFormat))
            {
                writer.WritePropertyName("dateFormat"u8);
                JsonSerializer.Serialize(writer, DateFormat);
            }
            if (Optional.IsDefined(TimestampFormat))
            {
                writer.WritePropertyName("timestampFormat"u8);
                JsonSerializer.Serialize(writer, TimestampFormat);
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(ImportSettingsType);
            if (AdditionalProperties != null)
            {
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
            }
            writer.WriteEndObject();
        }

        AzureDatabricksDeltaLakeImportCommand IJsonModel<AzureDatabricksDeltaLakeImportCommand>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureDatabricksDeltaLakeImportCommand>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(AzureDatabricksDeltaLakeImportCommand)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAzureDatabricksDeltaLakeImportCommand(document.RootElement, options);
        }

        internal static AzureDatabricksDeltaLakeImportCommand DeserializeAzureDatabricksDeltaLakeImportCommand(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DataFactoryElement<string>> dateFormat = default;
            Optional<DataFactoryElement<string>> timestampFormat = default;
            string type = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dateFormat"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dateFormat = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("timestampFormat"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timestampFormat = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new AzureDatabricksDeltaLakeImportCommand(type, additionalProperties, dateFormat.Value, timestampFormat.Value);
        }

        BinaryData IPersistableModel<AzureDatabricksDeltaLakeImportCommand>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureDatabricksDeltaLakeImportCommand>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(AzureDatabricksDeltaLakeImportCommand)} does not support '{options.Format}' format.");
            }
        }

        AzureDatabricksDeltaLakeImportCommand IPersistableModel<AzureDatabricksDeltaLakeImportCommand>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureDatabricksDeltaLakeImportCommand>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAzureDatabricksDeltaLakeImportCommand(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(AzureDatabricksDeltaLakeImportCommand)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AzureDatabricksDeltaLakeImportCommand>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
