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

namespace Azure.ResourceManager.AppService.Models
{
    public partial class SiteLimits : IUtf8JsonSerializable, IJsonModel<SiteLimits>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SiteLimits>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SiteLimits>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteLimits>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SiteLimits)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(MaxPercentageCpu))
            {
                writer.WritePropertyName("maxPercentageCpu"u8);
                writer.WriteNumberValue(MaxPercentageCpu.Value);
            }
            if (Optional.IsDefined(MaxMemoryInMb))
            {
                writer.WritePropertyName("maxMemoryInMb"u8);
                writer.WriteNumberValue(MaxMemoryInMb.Value);
            }
            if (Optional.IsDefined(MaxDiskSizeInMb))
            {
                writer.WritePropertyName("maxDiskSizeInMb"u8);
                writer.WriteNumberValue(MaxDiskSizeInMb.Value);
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
        }

        SiteLimits IJsonModel<SiteLimits>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteLimits>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SiteLimits)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSiteLimits(document.RootElement, options);
        }

        internal static SiteLimits DeserializeSiteLimits(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            double? maxPercentageCpu = default;
            long? maxMemoryInMb = default;
            long? maxDiskSizeInMb = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("maxPercentageCpu"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxPercentageCpu = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("maxMemoryInMb"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxMemoryInMb = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("maxDiskSizeInMb"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxDiskSizeInMb = property.Value.GetInt64();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SiteLimits(maxPercentageCpu, maxMemoryInMb, maxDiskSizeInMb, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(MaxPercentageCpu), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  maxPercentageCpu: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(MaxPercentageCpu))
                {
                    builder.Append("  maxPercentageCpu: ");
                    builder.AppendLine($"'{MaxPercentageCpu.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(MaxMemoryInMb), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  maxMemoryInMb: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(MaxMemoryInMb))
                {
                    builder.Append("  maxMemoryInMb: ");
                    builder.AppendLine($"'{MaxMemoryInMb.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(MaxDiskSizeInMb), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  maxDiskSizeInMb: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(MaxDiskSizeInMb))
                {
                    builder.Append("  maxDiskSizeInMb: ");
                    builder.AppendLine($"'{MaxDiskSizeInMb.Value.ToString()}'");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<SiteLimits>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteLimits>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(SiteLimits)} does not support writing '{options.Format}' format.");
            }
        }

        SiteLimits IPersistableModel<SiteLimits>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteLimits>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSiteLimits(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SiteLimits)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SiteLimits>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
