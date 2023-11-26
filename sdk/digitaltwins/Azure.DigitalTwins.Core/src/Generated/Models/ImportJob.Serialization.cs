// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.DigitalTwins.Core
{
    public partial class ImportJob : IUtf8JsonSerializable, IJsonModel<ImportJob>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ImportJob>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ImportJob>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ImportJob>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(ImportJob)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            writer.WritePropertyName("inputBlobUri"u8);
            writer.WriteStringValue(InputBlobUri.AbsoluteUri);
            writer.WritePropertyName("outputBlobUri"u8);
            writer.WriteStringValue(OutputBlobUri.AbsoluteUri);
            if (options.Format != "W" && Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(CreatedDateTime))
            {
                writer.WritePropertyName("createdDateTime"u8);
                writer.WriteStringValue(CreatedDateTime.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(LastActionDateTime))
            {
                writer.WritePropertyName("lastActionDateTime"u8);
                writer.WriteStringValue(LastActionDateTime.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(FinishedDateTime))
            {
                writer.WritePropertyName("finishedDateTime"u8);
                writer.WriteStringValue(FinishedDateTime.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(PurgeDateTime))
            {
                writer.WritePropertyName("purgeDateTime"u8);
                writer.WriteStringValue(PurgeDateTime.Value, "O");
            }
            if (Optional.IsDefined(Error))
            {
                writer.WritePropertyName("error"u8);
                SerializeErrorValue(writer);
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

        ImportJob IJsonModel<ImportJob>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ImportJob>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(ImportJob)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeImportJob(document.RootElement, options);
        }

        internal static ImportJob DeserializeImportJob(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> id = default;
            Uri inputBlobUri = default;
            Uri outputBlobUri = default;
            Optional<ImportJobStatus> status = default;
            Optional<DateTimeOffset> createdDateTime = default;
            Optional<DateTimeOffset> lastActionDateTime = default;
            Optional<DateTimeOffset> finishedDateTime = default;
            Optional<DateTimeOffset> purgeDateTime = default;
            Optional<ResponseError> error = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("inputBlobUri"u8))
                {
                    inputBlobUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("outputBlobUri"u8))
                {
                    outputBlobUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new ImportJobStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("createdDateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    createdDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastActionDateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastActionDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("finishedDateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    finishedDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("purgeDateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    purgeDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("error"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    error = JsonSerializer.Deserialize<ResponseError>(property.Value.GetRawText());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ImportJob(id.Value, inputBlobUri, outputBlobUri, Optional.ToNullable(status), Optional.ToNullable(createdDateTime), Optional.ToNullable(lastActionDateTime), Optional.ToNullable(finishedDateTime), Optional.ToNullable(purgeDateTime), error.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ImportJob>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ImportJob>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(ImportJob)} does not support '{options.Format}' format.");
            }
        }

        ImportJob IPersistableModel<ImportJob>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ImportJob>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeImportJob(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(ImportJob)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ImportJob>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
