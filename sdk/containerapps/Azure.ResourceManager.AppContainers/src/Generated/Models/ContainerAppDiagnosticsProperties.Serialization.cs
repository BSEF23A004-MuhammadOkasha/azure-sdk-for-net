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

namespace Azure.ResourceManager.AppContainers.Models
{
    public partial class ContainerAppDiagnosticsProperties : IUtf8JsonSerializable, IJsonModel<ContainerAppDiagnosticsProperties>, IPersistableModel<ContainerAppDiagnosticsProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerAppDiagnosticsProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ContainerAppDiagnosticsProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppDiagnosticsProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppDiagnosticsProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Metadata))
            {
                writer.WritePropertyName("metadata"u8);
                writer.WriteObjectValue(Metadata);
            }
            if (Optional.IsCollectionDefined(Dataset))
            {
                writer.WritePropertyName("dataset"u8);
                writer.WriteStartArray();
                foreach (var item in Dataset)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteObjectValue(Status);
            }
            if (Optional.IsDefined(DataProviderMetadata))
            {
                writer.WritePropertyName("dataProviderMetadata"u8);
                writer.WriteObjectValue(DataProviderMetadata);
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

        ContainerAppDiagnosticsProperties IJsonModel<ContainerAppDiagnosticsProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppDiagnosticsProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppDiagnosticsProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerAppDiagnosticsProperties(document.RootElement, options);
        }

        internal static ContainerAppDiagnosticsProperties DeserializeContainerAppDiagnosticsProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ContainerAppDiagnosticsMetadata> metadata = default;
            Optional<IList<ContainerAppDiagnosticsDataApiResult>> dataset = default;
            Optional<ContainerAppDiagnosticsStatus> status = default;
            Optional<ContainerAppDiagnosticDataProviderMetadata> dataProviderMetadata = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("metadata"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    metadata = ContainerAppDiagnosticsMetadata.DeserializeContainerAppDiagnosticsMetadata(property.Value);
                    continue;
                }
                if (property.NameEquals("dataset"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ContainerAppDiagnosticsDataApiResult> array = new List<ContainerAppDiagnosticsDataApiResult>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerAppDiagnosticsDataApiResult.DeserializeContainerAppDiagnosticsDataApiResult(item));
                    }
                    dataset = array;
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = ContainerAppDiagnosticsStatus.DeserializeContainerAppDiagnosticsStatus(property.Value);
                    continue;
                }
                if (property.NameEquals("dataProviderMetadata"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataProviderMetadata = ContainerAppDiagnosticDataProviderMetadata.DeserializeContainerAppDiagnosticDataProviderMetadata(property.Value);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ContainerAppDiagnosticsProperties(metadata.Value, Optional.ToList(dataset), status.Value, dataProviderMetadata.Value, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(Metadata))
            {
                builder.Append("  metadata:");
                AppendChildObject(builder, Metadata, options, 2);
            }

            if (Optional.IsCollectionDefined(Dataset))
            {
                builder.Append("  dataset:");
                builder.AppendLine(" [");
                foreach (var item in Dataset)
                {
                    AppendChildObject(builder, item, options, 4);
                }
                builder.AppendLine("  ]");
            }

            if (Optional.IsDefined(Status))
            {
                builder.Append("  status:");
                AppendChildObject(builder, Status, options, 2);
            }

            if (Optional.IsDefined(DataProviderMetadata))
            {
                builder.Append("  dataProviderMetadata:");
                AppendChildObject(builder, DataProviderMetadata, options, 2);
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        private void AppendChildObject(StringBuilder stringBuilder, object childObject, ModelReaderWriterOptions options, int spaces)
        {
            string indent = new string(' ', spaces);
            BinaryData data = ModelReaderWriter.Write(childObject, options);
            string[] lines = data.ToString().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            foreach (var line in lines)
            {
                stringBuilder.AppendLine($"{indent}{line}");
            }
        }

        BinaryData IPersistableModel<ContainerAppDiagnosticsProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppDiagnosticsProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ContainerAppDiagnosticsProperties)} does not support '{options.Format}' format.");
            }
        }

        ContainerAppDiagnosticsProperties IPersistableModel<ContainerAppDiagnosticsProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppDiagnosticsProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerAppDiagnosticsProperties(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(ContainerAppDiagnosticsProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerAppDiagnosticsProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
