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
using Azure.ResourceManager;
using Azure.ResourceManager.ApplicationInsights;

namespace Azure.ResourceManager.ApplicationInsights.Models
{
    public partial class ApplicationInsightsComponentDataVolumeCap : IUtf8JsonSerializable, IJsonModel<ApplicationInsightsComponentDataVolumeCap>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ApplicationInsightsComponentDataVolumeCap>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ApplicationInsightsComponentDataVolumeCap>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationInsightsComponentDataVolumeCap>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApplicationInsightsComponentDataVolumeCap)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Cap))
            {
                writer.WritePropertyName("Cap"u8);
                writer.WriteNumberValue(Cap.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ResetTime))
            {
                writer.WritePropertyName("ResetTime"u8);
                writer.WriteNumberValue(ResetTime.Value);
            }
            if (Optional.IsDefined(WarningThreshold))
            {
                writer.WritePropertyName("WarningThreshold"u8);
                writer.WriteNumberValue(WarningThreshold.Value);
            }
            if (Optional.IsDefined(IsStopSendNotificationWhenHitThreshold))
            {
                writer.WritePropertyName("StopSendNotificationWhenHitThreshold"u8);
                writer.WriteBooleanValue(IsStopSendNotificationWhenHitThreshold.Value);
            }
            if (Optional.IsDefined(IsStopSendNotificationWhenHitCap))
            {
                writer.WritePropertyName("StopSendNotificationWhenHitCap"u8);
                writer.WriteBooleanValue(IsStopSendNotificationWhenHitCap.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(MaxHistoryCap))
            {
                writer.WritePropertyName("MaxHistoryCap"u8);
                writer.WriteNumberValue(MaxHistoryCap.Value);
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

        ApplicationInsightsComponentDataVolumeCap IJsonModel<ApplicationInsightsComponentDataVolumeCap>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationInsightsComponentDataVolumeCap>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApplicationInsightsComponentDataVolumeCap)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeApplicationInsightsComponentDataVolumeCap(document.RootElement, options);
        }

        internal static ApplicationInsightsComponentDataVolumeCap DeserializeApplicationInsightsComponentDataVolumeCap(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            float? cap = default;
            int? resetTime = default;
            int? warningThreshold = default;
            bool? stopSendNotificationWhenHitThreshold = default;
            bool? stopSendNotificationWhenHitCap = default;
            float? maxHistoryCap = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("Cap"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cap = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("ResetTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resetTime = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("WarningThreshold"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    warningThreshold = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("StopSendNotificationWhenHitThreshold"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    stopSendNotificationWhenHitThreshold = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("StopSendNotificationWhenHitCap"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    stopSendNotificationWhenHitCap = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("MaxHistoryCap"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxHistoryCap = property.Value.GetSingle();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ApplicationInsightsComponentDataVolumeCap(
                cap,
                resetTime,
                warningThreshold,
                stopSendNotificationWhenHitThreshold,
                stopSendNotificationWhenHitCap,
                maxHistoryCap,
                serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.ParameterOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Cap), out propertyOverride);
            if (Optional.IsDefined(Cap) || hasPropertyOverride)
            {
                builder.Append("  Cap: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    builder.AppendLine($"'{Cap.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ResetTime), out propertyOverride);
            if (Optional.IsDefined(ResetTime) || hasPropertyOverride)
            {
                builder.Append("  ResetTime: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    builder.AppendLine($"{ResetTime.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(WarningThreshold), out propertyOverride);
            if (Optional.IsDefined(WarningThreshold) || hasPropertyOverride)
            {
                builder.Append("  WarningThreshold: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    builder.AppendLine($"{WarningThreshold.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsStopSendNotificationWhenHitThreshold), out propertyOverride);
            if (Optional.IsDefined(IsStopSendNotificationWhenHitThreshold) || hasPropertyOverride)
            {
                builder.Append("  StopSendNotificationWhenHitThreshold: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    var boolValue = IsStopSendNotificationWhenHitThreshold.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsStopSendNotificationWhenHitCap), out propertyOverride);
            if (Optional.IsDefined(IsStopSendNotificationWhenHitCap) || hasPropertyOverride)
            {
                builder.Append("  StopSendNotificationWhenHitCap: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    var boolValue = IsStopSendNotificationWhenHitCap.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(MaxHistoryCap), out propertyOverride);
            if (Optional.IsDefined(MaxHistoryCap) || hasPropertyOverride)
            {
                builder.Append("  MaxHistoryCap: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    builder.AppendLine($"'{MaxHistoryCap.Value.ToString()}'");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        private void AppendChildObject(StringBuilder stringBuilder, object childObject, ModelReaderWriterOptions options, int spaces, bool indentFirstLine, string formattedPropertyName)
        {
            string indent = new string(' ', spaces);
            int emptyObjectLength = 2 + spaces + Environment.NewLine.Length + Environment.NewLine.Length;
            int length = stringBuilder.Length;
            bool inMultilineString = false;

            BinaryData data = ModelReaderWriter.Write(childObject, options);
            string[] lines = data.ToString().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                if (inMultilineString)
                {
                    if (line.Contains("'''"))
                    {
                        inMultilineString = false;
                    }
                    stringBuilder.AppendLine(line);
                    continue;
                }
                if (line.Contains("'''"))
                {
                    inMultilineString = true;
                    stringBuilder.AppendLine($"{indent}{line}");
                    continue;
                }
                if (i == 0 && !indentFirstLine)
                {
                    stringBuilder.AppendLine($"{line}");
                }
                else
                {
                    stringBuilder.AppendLine($"{indent}{line}");
                }
            }
            if (stringBuilder.Length == length + emptyObjectLength)
            {
                stringBuilder.Length = stringBuilder.Length - emptyObjectLength - formattedPropertyName.Length;
            }
        }

        BinaryData IPersistableModel<ApplicationInsightsComponentDataVolumeCap>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationInsightsComponentDataVolumeCap>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ApplicationInsightsComponentDataVolumeCap)} does not support '{options.Format}' format.");
            }
        }

        ApplicationInsightsComponentDataVolumeCap IPersistableModel<ApplicationInsightsComponentDataVolumeCap>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationInsightsComponentDataVolumeCap>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeApplicationInsightsComponentDataVolumeCap(document.RootElement, options);
                    }
                case "bicep":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(ApplicationInsightsComponentDataVolumeCap)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ApplicationInsightsComponentDataVolumeCap>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
