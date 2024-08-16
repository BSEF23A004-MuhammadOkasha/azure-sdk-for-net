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

namespace Azure.ResourceManager.MobileNetwork.Models
{
    public partial class UEQosFlow : IUtf8JsonSerializable, IJsonModel<UEQosFlow>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<UEQosFlow>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<UEQosFlow>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UEQosFlow>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UEQosFlow)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("qfi"u8);
            writer.WriteNumberValue(Qfi);
            writer.WritePropertyName("fiveqi"u8);
            writer.WriteNumberValue(Fiveqi);
            writer.WritePropertyName("gbr"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(UplinkGbrUplink))
            {
                writer.WritePropertyName("uplink"u8);
                writer.WriteStringValue(UplinkGbrUplink);
            }
            if (Optional.IsDefined(DownlinkGbrDownlink))
            {
                writer.WritePropertyName("downlink"u8);
                writer.WriteStringValue(DownlinkGbrDownlink);
            }
            writer.WriteEndObject();
            writer.WritePropertyName("mbr"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(UplinkMbrUplink))
            {
                writer.WritePropertyName("uplink"u8);
                writer.WriteStringValue(UplinkMbrUplink);
            }
            if (Optional.IsDefined(DownlinkMbrDownlink))
            {
                writer.WritePropertyName("downlink"u8);
                writer.WriteStringValue(DownlinkMbrDownlink);
            }
            writer.WriteEndObject();
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

        UEQosFlow IJsonModel<UEQosFlow>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UEQosFlow>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UEQosFlow)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeUEQosFlow(document.RootElement, options);
        }

        internal static UEQosFlow DeserializeUEQosFlow(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int qfi = default;
            int fiveqi = default;
            string uplink = default;
            string downlink = default;
            string uplink0 = default;
            string downlink0 = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("qfi"u8))
                {
                    qfi = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("fiveqi"u8))
                {
                    fiveqi = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("gbr"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("uplink"u8))
                        {
                            uplink = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("downlink"u8))
                        {
                            downlink = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
                if (property.NameEquals("mbr"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("uplink"u8))
                        {
                            uplink0 = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("downlink"u8))
                        {
                            downlink0 = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new UEQosFlow(
                qfi,
                fiveqi,
                uplink,
                downlink,
                uplink0,
                downlink0,
                serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Qfi), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  qfi: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  qfi: ");
                builder.AppendLine($"{Qfi}");
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Fiveqi), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  fiveqi: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  fiveqi: ");
                builder.AppendLine($"{Fiveqi}");
            }

            builder.Append("  gbr:");
            builder.AppendLine(" {");
            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(UplinkGbrUplink), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    uplink: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(UplinkGbrUplink))
                {
                    builder.Append("    uplink: ");
                    if (UplinkGbrUplink.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{UplinkGbrUplink}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{UplinkGbrUplink}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DownlinkGbrDownlink), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    downlink: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(DownlinkGbrDownlink))
                {
                    builder.Append("    downlink: ");
                    if (DownlinkGbrDownlink.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{DownlinkGbrDownlink}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{DownlinkGbrDownlink}'");
                    }
                }
            }

            builder.AppendLine("  }");
            builder.Append("  mbr:");
            builder.AppendLine(" {");
            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(UplinkMbrUplink), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    uplink: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(UplinkMbrUplink))
                {
                    builder.Append("    uplink: ");
                    if (UplinkMbrUplink.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{UplinkMbrUplink}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{UplinkMbrUplink}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DownlinkMbrDownlink), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    downlink: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(DownlinkMbrDownlink))
                {
                    builder.Append("    downlink: ");
                    if (DownlinkMbrDownlink.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{DownlinkMbrDownlink}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{DownlinkMbrDownlink}'");
                    }
                }
            }

            builder.AppendLine("  }");
            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<UEQosFlow>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UEQosFlow>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(UEQosFlow)} does not support writing '{options.Format}' format.");
            }
        }

        UEQosFlow IPersistableModel<UEQosFlow>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UEQosFlow>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeUEQosFlow(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(UEQosFlow)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<UEQosFlow>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
