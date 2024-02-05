// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    public partial class DataBoxEdgeRefreshDetails : IUtf8JsonSerializable, IJsonModel<DataBoxEdgeRefreshDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataBoxEdgeRefreshDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DataBoxEdgeRefreshDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxEdgeRefreshDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataBoxEdgeRefreshDetails)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(InProgressRefreshJobId))
            {
                writer.WritePropertyName("inProgressRefreshJobId"u8);
                writer.WriteStringValue(InProgressRefreshJobId);
            }
            if (Optional.IsDefined(LastCompletedRefreshJobTimeInUtc))
            {
                writer.WritePropertyName("lastCompletedRefreshJobTimeInUTC"u8);
                writer.WriteStringValue(LastCompletedRefreshJobTimeInUtc.Value, "O");
            }
            if (Optional.IsDefined(ErrorManifestFile))
            {
                writer.WritePropertyName("errorManifestFile"u8);
                writer.WriteStringValue(ErrorManifestFile);
            }
            if (Optional.IsDefined(LastJob))
            {
                writer.WritePropertyName("lastJob"u8);
                writer.WriteStringValue(LastJob);
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

        DataBoxEdgeRefreshDetails IJsonModel<DataBoxEdgeRefreshDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxEdgeRefreshDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataBoxEdgeRefreshDetails)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataBoxEdgeRefreshDetails(document.RootElement, options);
        }

        internal static DataBoxEdgeRefreshDetails DeserializeDataBoxEdgeRefreshDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> inProgressRefreshJobId = default;
            Optional<DateTimeOffset> lastCompletedRefreshJobTimeInUtc = default;
            Optional<string> errorManifestFile = default;
            Optional<string> lastJob = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("inProgressRefreshJobId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    inProgressRefreshJobId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("lastCompletedRefreshJobTimeInUTC"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastCompletedRefreshJobTimeInUtc = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("errorManifestFile"u8))
                {
                    errorManifestFile = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastJob"u8))
                {
                    lastJob = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DataBoxEdgeRefreshDetails(inProgressRefreshJobId.Value, Optional.ToNullable(lastCompletedRefreshJobTimeInUtc), errorManifestFile.Value, lastJob.Value, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(InProgressRefreshJobId))
            {
                builder.Append("  inProgressRefreshJobId:");
                builder.AppendLine($" '{InProgressRefreshJobId.ToString()}'");
            }

            if (Optional.IsDefined(LastCompletedRefreshJobTimeInUtc))
            {
                builder.Append("  lastCompletedRefreshJobTimeInUTC:");
                var formattedDateTimeString = TypeFormatters.ToString(LastCompletedRefreshJobTimeInUtc.Value, "o");
                builder.AppendLine($" '{formattedDateTimeString}'");
            }

            if (Optional.IsDefined(ErrorManifestFile))
            {
                builder.Append("  errorManifestFile:");
                builder.AppendLine($" '{ErrorManifestFile}'");
            }

            if (Optional.IsDefined(LastJob))
            {
                builder.Append("  lastJob:");
                builder.AppendLine($" '{LastJob}'");
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        private void AppendChildObject(StringBuilder stringBuilder, object childObject, ModelReaderWriterOptions options, int spaces, bool indentFirstLine)
        {
            string indent = new string(' ', spaces);
            BinaryData data = ModelReaderWriter.Write(childObject, options);
            string[] lines = data.ToString().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                if (i == 0 && !indentFirstLine)
                {
                    stringBuilder.AppendLine($" {line}");
                }
                else
                {
                    stringBuilder.AppendLine($"{indent}{line}");
                }
            }
        }

        BinaryData IPersistableModel<DataBoxEdgeRefreshDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxEdgeRefreshDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(DataBoxEdgeRefreshDetails)} does not support '{options.Format}' format.");
            }
        }

        DataBoxEdgeRefreshDetails IPersistableModel<DataBoxEdgeRefreshDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxEdgeRefreshDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataBoxEdgeRefreshDetails(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(DataBoxEdgeRefreshDetails)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataBoxEdgeRefreshDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
