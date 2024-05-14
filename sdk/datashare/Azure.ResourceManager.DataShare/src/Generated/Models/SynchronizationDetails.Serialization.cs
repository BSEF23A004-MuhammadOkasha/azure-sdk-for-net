// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataShare.Models
{
    public partial class SynchronizationDetails : IUtf8JsonSerializable, IJsonModel<SynchronizationDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SynchronizationDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SynchronizationDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynchronizationDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynchronizationDetails)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(DataSetId))
            {
                writer.WritePropertyName("dataSetId"u8);
                writer.WriteStringValue(DataSetId.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(DataSetType))
            {
                writer.WritePropertyName("dataSetType"u8);
                writer.WriteStringValue(DataSetType.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(DurationInMilliSeconds))
            {
                writer.WritePropertyName("durationMs"u8);
                writer.WriteNumberValue(DurationInMilliSeconds.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(EndOn))
            {
                writer.WritePropertyName("endTime"u8);
                writer.WriteStringValue(EndOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(FilesRead))
            {
                writer.WritePropertyName("filesRead"u8);
                writer.WriteNumberValue(FilesRead.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(FilesWritten))
            {
                writer.WritePropertyName("filesWritten"u8);
                writer.WriteNumberValue(FilesWritten.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(Message))
            {
                writer.WritePropertyName("message"u8);
                writer.WriteStringValue(Message);
            }
            if (options.Format != "W" && Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W" && Optional.IsDefined(RowsCopied))
            {
                writer.WritePropertyName("rowsCopied"u8);
                writer.WriteNumberValue(RowsCopied.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(RowsRead))
            {
                writer.WritePropertyName("rowsRead"u8);
                writer.WriteNumberValue(RowsRead.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(SizeRead))
            {
                writer.WritePropertyName("sizeRead"u8);
                writer.WriteNumberValue(SizeRead.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(SizeWritten))
            {
                writer.WritePropertyName("sizeWritten"u8);
                writer.WriteNumberValue(SizeWritten.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(StartOn))
            {
                writer.WritePropertyName("startTime"u8);
                writer.WriteStringValue(StartOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status);
            }
            if (options.Format != "W" && Optional.IsDefined(VCore))
            {
                writer.WritePropertyName("vCore"u8);
                writer.WriteNumberValue(VCore.Value);
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

        SynchronizationDetails IJsonModel<SynchronizationDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynchronizationDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynchronizationDetails)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSynchronizationDetails(document.RootElement, options);
        }

        internal static SynchronizationDetails DeserializeSynchronizationDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<Guid> dataSetId = default;
            Optional<ShareDataSetType> dataSetType = default;
            Optional<int> durationMs = default;
            Optional<DateTimeOffset> endTime = default;
            Optional<long> filesRead = default;
            Optional<long> filesWritten = default;
            Optional<string> message = default;
            Optional<string> name = default;
            Optional<long> rowsCopied = default;
            Optional<long> rowsRead = default;
            Optional<long> sizeRead = default;
            Optional<long> sizeWritten = default;
            Optional<DateTimeOffset> startTime = default;
            Optional<string> status = default;
            Optional<long> vCore = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dataSetId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataSetId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("dataSetType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataSetType = new ShareDataSetType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("durationMs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    durationMs = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("endTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("filesRead"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    filesRead = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("filesWritten"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    filesWritten = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("message"u8))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("rowsCopied"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rowsCopied = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("rowsRead"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rowsRead = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("sizeRead"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sizeRead = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("sizeWritten"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sizeWritten = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("startTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vCore"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    vCore = property.Value.GetInt64();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SynchronizationDetails(Optional.ToNullable(dataSetId), Optional.ToNullable(dataSetType), Optional.ToNullable(durationMs), Optional.ToNullable(endTime), Optional.ToNullable(filesRead), Optional.ToNullable(filesWritten), message.Value, name.Value, Optional.ToNullable(rowsCopied), Optional.ToNullable(rowsRead), Optional.ToNullable(sizeRead), Optional.ToNullable(sizeWritten), Optional.ToNullable(startTime), status.Value, Optional.ToNullable(vCore), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SynchronizationDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynchronizationDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SynchronizationDetails)} does not support '{options.Format}' format.");
            }
        }

        SynchronizationDetails IPersistableModel<SynchronizationDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynchronizationDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSynchronizationDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SynchronizationDetails)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SynchronizationDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
