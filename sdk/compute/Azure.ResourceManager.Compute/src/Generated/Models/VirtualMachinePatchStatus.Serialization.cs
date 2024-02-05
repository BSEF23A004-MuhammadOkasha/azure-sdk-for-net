// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class VirtualMachinePatchStatus : IUtf8JsonSerializable, IJsonModel<VirtualMachinePatchStatus>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VirtualMachinePatchStatus>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<VirtualMachinePatchStatus>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachinePatchStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualMachinePatchStatus)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(AvailablePatchSummary))
            {
                writer.WritePropertyName("availablePatchSummary"u8);
                writer.WriteObjectValue(AvailablePatchSummary);
            }
            if (Optional.IsDefined(LastPatchInstallationSummary))
            {
                writer.WritePropertyName("lastPatchInstallationSummary"u8);
                writer.WriteObjectValue(LastPatchInstallationSummary);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(ConfigurationStatuses))
            {
                writer.WritePropertyName("configurationStatuses"u8);
                writer.WriteStartArray();
                foreach (var item in ConfigurationStatuses)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        VirtualMachinePatchStatus IJsonModel<VirtualMachinePatchStatus>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachinePatchStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualMachinePatchStatus)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVirtualMachinePatchStatus(document.RootElement, options);
        }

        internal static VirtualMachinePatchStatus DeserializeVirtualMachinePatchStatus(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AvailablePatchSummary> availablePatchSummary = default;
            Optional<LastPatchInstallationSummary> lastPatchInstallationSummary = default;
            Optional<IReadOnlyList<InstanceViewStatus>> configurationStatuses = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("availablePatchSummary"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    availablePatchSummary = AvailablePatchSummary.DeserializeAvailablePatchSummary(property.Value);
                    continue;
                }
                if (property.NameEquals("lastPatchInstallationSummary"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastPatchInstallationSummary = LastPatchInstallationSummary.DeserializeLastPatchInstallationSummary(property.Value);
                    continue;
                }
                if (property.NameEquals("configurationStatuses"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<InstanceViewStatus> array = new List<InstanceViewStatus>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(InstanceViewStatus.DeserializeInstanceViewStatus(item));
                    }
                    configurationStatuses = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new VirtualMachinePatchStatus(availablePatchSummary.Value, lastPatchInstallationSummary.Value, Optional.ToList(configurationStatuses), serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(AvailablePatchSummary))
            {
                builder.Append("  availablePatchSummary:");
                AppendChildObject(builder, AvailablePatchSummary, options, 2, false);
            }

            if (Optional.IsDefined(LastPatchInstallationSummary))
            {
                builder.Append("  lastPatchInstallationSummary:");
                AppendChildObject(builder, LastPatchInstallationSummary, options, 2, false);
            }

            if (Optional.IsCollectionDefined(ConfigurationStatuses))
            {
                if (ConfigurationStatuses.Any())
                {
                    builder.Append("  configurationStatuses:");
                    builder.AppendLine(" [");
                    foreach (var item in ConfigurationStatuses)
                    {
                        AppendChildObject(builder, item, options, 4, true);
                    }
                    builder.AppendLine("  ]");
                }
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

        BinaryData IPersistableModel<VirtualMachinePatchStatus>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachinePatchStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(VirtualMachinePatchStatus)} does not support '{options.Format}' format.");
            }
        }

        VirtualMachinePatchStatus IPersistableModel<VirtualMachinePatchStatus>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachinePatchStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVirtualMachinePatchStatus(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(VirtualMachinePatchStatus)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<VirtualMachinePatchStatus>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
