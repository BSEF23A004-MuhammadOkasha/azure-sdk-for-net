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

namespace Azure.ResourceManager.ContainerService.Models
{
    public partial class KubeletConfig : IUtf8JsonSerializable, IJsonModel<KubeletConfig>, IPersistableModel<KubeletConfig>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<KubeletConfig>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<KubeletConfig>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KubeletConfig>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(KubeletConfig)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(CpuManagerPolicy))
            {
                writer.WritePropertyName("cpuManagerPolicy"u8);
                writer.WriteStringValue(CpuManagerPolicy);
            }
            if (Optional.IsDefined(IsCpuCfsQuotaEnabled))
            {
                writer.WritePropertyName("cpuCfsQuota"u8);
                writer.WriteBooleanValue(IsCpuCfsQuotaEnabled.Value);
            }
            if (Optional.IsDefined(CpuCfsQuotaPeriod))
            {
                writer.WritePropertyName("cpuCfsQuotaPeriod"u8);
                writer.WriteStringValue(CpuCfsQuotaPeriod);
            }
            if (Optional.IsDefined(ImageGcHighThreshold))
            {
                writer.WritePropertyName("imageGcHighThreshold"u8);
                writer.WriteNumberValue(ImageGcHighThreshold.Value);
            }
            if (Optional.IsDefined(ImageGcLowThreshold))
            {
                writer.WritePropertyName("imageGcLowThreshold"u8);
                writer.WriteNumberValue(ImageGcLowThreshold.Value);
            }
            if (Optional.IsDefined(TopologyManagerPolicy))
            {
                writer.WritePropertyName("topologyManagerPolicy"u8);
                writer.WriteStringValue(TopologyManagerPolicy);
            }
            if (Optional.IsCollectionDefined(AllowedUnsafeSysctls))
            {
                writer.WritePropertyName("allowedUnsafeSysctls"u8);
                writer.WriteStartArray();
                foreach (var item in AllowedUnsafeSysctls)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(FailStartWithSwapOn))
            {
                writer.WritePropertyName("failSwapOn"u8);
                writer.WriteBooleanValue(FailStartWithSwapOn.Value);
            }
            if (Optional.IsDefined(ContainerLogMaxSizeInMB))
            {
                writer.WritePropertyName("containerLogMaxSizeMB"u8);
                writer.WriteNumberValue(ContainerLogMaxSizeInMB.Value);
            }
            if (Optional.IsDefined(ContainerLogMaxFiles))
            {
                writer.WritePropertyName("containerLogMaxFiles"u8);
                writer.WriteNumberValue(ContainerLogMaxFiles.Value);
            }
            if (Optional.IsDefined(PodMaxPids))
            {
                writer.WritePropertyName("podMaxPids"u8);
                writer.WriteNumberValue(PodMaxPids.Value);
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

        KubeletConfig IJsonModel<KubeletConfig>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KubeletConfig>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(KubeletConfig)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeKubeletConfig(document.RootElement, options);
        }

        internal static KubeletConfig DeserializeKubeletConfig(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> cpuManagerPolicy = default;
            Optional<bool> cpuCfsQuota = default;
            Optional<string> cpuCfsQuotaPeriod = default;
            Optional<int> imageGcHighThreshold = default;
            Optional<int> imageGcLowThreshold = default;
            Optional<string> topologyManagerPolicy = default;
            Optional<IList<string>> allowedUnsafeSysctls = default;
            Optional<bool> failSwapOn = default;
            Optional<int> containerLogMaxSizeMB = default;
            Optional<int> containerLogMaxFiles = default;
            Optional<int> podMaxPids = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("cpuManagerPolicy"u8))
                {
                    cpuManagerPolicy = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("cpuCfsQuota"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cpuCfsQuota = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("cpuCfsQuotaPeriod"u8))
                {
                    cpuCfsQuotaPeriod = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("imageGcHighThreshold"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    imageGcHighThreshold = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("imageGcLowThreshold"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    imageGcLowThreshold = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("topologyManagerPolicy"u8))
                {
                    topologyManagerPolicy = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("allowedUnsafeSysctls"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    allowedUnsafeSysctls = array;
                    continue;
                }
                if (property.NameEquals("failSwapOn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    failSwapOn = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("containerLogMaxSizeMB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    containerLogMaxSizeMB = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("containerLogMaxFiles"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    containerLogMaxFiles = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("podMaxPids"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    podMaxPids = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new KubeletConfig(cpuManagerPolicy.Value, Optional.ToNullable(cpuCfsQuota), cpuCfsQuotaPeriod.Value, Optional.ToNullable(imageGcHighThreshold), Optional.ToNullable(imageGcLowThreshold), topologyManagerPolicy.Value, Optional.ToList(allowedUnsafeSysctls), Optional.ToNullable(failSwapOn), Optional.ToNullable(containerLogMaxSizeMB), Optional.ToNullable(containerLogMaxFiles), Optional.ToNullable(podMaxPids), serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(CpuManagerPolicy))
            {
                builder.Append("  cpuManagerPolicy:");
                builder.AppendLine($" '{CpuManagerPolicy}'");
            }

            if (Optional.IsDefined(IsCpuCfsQuotaEnabled))
            {
                builder.Append("  cpuCfsQuota:");
                var boolValue = IsCpuCfsQuotaEnabled.Value == true ? "true" : "false";
                builder.AppendLine($" {boolValue}");
            }

            if (Optional.IsDefined(CpuCfsQuotaPeriod))
            {
                builder.Append("  cpuCfsQuotaPeriod:");
                builder.AppendLine($" '{CpuCfsQuotaPeriod}'");
            }

            if (Optional.IsDefined(ImageGcHighThreshold))
            {
                builder.Append("  imageGcHighThreshold:");
                builder.AppendLine($" '{ImageGcHighThreshold.Value.ToString()}'");
            }

            if (Optional.IsDefined(ImageGcLowThreshold))
            {
                builder.Append("  imageGcLowThreshold:");
                builder.AppendLine($" '{ImageGcLowThreshold.Value.ToString()}'");
            }

            if (Optional.IsDefined(TopologyManagerPolicy))
            {
                builder.Append("  topologyManagerPolicy:");
                builder.AppendLine($" '{TopologyManagerPolicy}'");
            }

            if (Optional.IsCollectionDefined(AllowedUnsafeSysctls))
            {
                builder.Append("  allowedUnsafeSysctls:");
                builder.AppendLine(" [");
                foreach (var item in AllowedUnsafeSysctls)
                {
                    if (item == null)
                    {
                        builder.Append("null");
                        continue;
                    }
                    builder.AppendLine($"    '{item}'");
                }
                builder.AppendLine("  ]");
            }

            if (Optional.IsDefined(FailStartWithSwapOn))
            {
                builder.Append("  failSwapOn:");
                var boolValue = FailStartWithSwapOn.Value == true ? "true" : "false";
                builder.AppendLine($" {boolValue}");
            }

            if (Optional.IsDefined(ContainerLogMaxSizeInMB))
            {
                builder.Append("  containerLogMaxSizeMB:");
                builder.AppendLine($" '{ContainerLogMaxSizeInMB.Value.ToString()}'");
            }

            if (Optional.IsDefined(ContainerLogMaxFiles))
            {
                builder.Append("  containerLogMaxFiles:");
                builder.AppendLine($" '{ContainerLogMaxFiles.Value.ToString()}'");
            }

            if (Optional.IsDefined(PodMaxPids))
            {
                builder.Append("  podMaxPids:");
                builder.AppendLine($" '{PodMaxPids.Value.ToString()}'");
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

        BinaryData IPersistableModel<KubeletConfig>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KubeletConfig>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(KubeletConfig)} does not support '{options.Format}' format.");
            }
        }

        KubeletConfig IPersistableModel<KubeletConfig>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KubeletConfig>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeKubeletConfig(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(KubeletConfig)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<KubeletConfig>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
