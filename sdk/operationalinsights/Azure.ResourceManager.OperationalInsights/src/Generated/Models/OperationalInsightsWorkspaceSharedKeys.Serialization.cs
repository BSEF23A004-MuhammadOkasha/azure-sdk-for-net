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

namespace Azure.ResourceManager.OperationalInsights.Models
{
    public partial class OperationalInsightsWorkspaceSharedKeys : IUtf8JsonSerializable, IJsonModel<OperationalInsightsWorkspaceSharedKeys>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<OperationalInsightsWorkspaceSharedKeys>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<OperationalInsightsWorkspaceSharedKeys>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OperationalInsightsWorkspaceSharedKeys>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OperationalInsightsWorkspaceSharedKeys)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(PrimarySharedKey))
            {
                writer.WritePropertyName("primarySharedKey"u8);
                writer.WriteStringValue(PrimarySharedKey);
            }
            if (Optional.IsDefined(SecondarySharedKey))
            {
                writer.WritePropertyName("secondarySharedKey"u8);
                writer.WriteStringValue(SecondarySharedKey);
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

        OperationalInsightsWorkspaceSharedKeys IJsonModel<OperationalInsightsWorkspaceSharedKeys>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OperationalInsightsWorkspaceSharedKeys>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OperationalInsightsWorkspaceSharedKeys)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeOperationalInsightsWorkspaceSharedKeys(document.RootElement, options);
        }

        internal static OperationalInsightsWorkspaceSharedKeys DeserializeOperationalInsightsWorkspaceSharedKeys(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string primarySharedKey = default;
            string secondarySharedKey = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("primarySharedKey"u8))
                {
                    primarySharedKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secondarySharedKey"u8))
                {
                    secondarySharedKey = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new OperationalInsightsWorkspaceSharedKeys(primarySharedKey, secondarySharedKey, serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PrimarySharedKey), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  primarySharedKey: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(PrimarySharedKey))
                {
                    builder.Append("  primarySharedKey: ");
                    if (PrimarySharedKey.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{PrimarySharedKey}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{PrimarySharedKey}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SecondarySharedKey), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  secondarySharedKey: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SecondarySharedKey))
                {
                    builder.Append("  secondarySharedKey: ");
                    if (SecondarySharedKey.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{SecondarySharedKey}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{SecondarySharedKey}'");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<OperationalInsightsWorkspaceSharedKeys>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OperationalInsightsWorkspaceSharedKeys>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(OperationalInsightsWorkspaceSharedKeys)} does not support writing '{options.Format}' format.");
            }
        }

        OperationalInsightsWorkspaceSharedKeys IPersistableModel<OperationalInsightsWorkspaceSharedKeys>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OperationalInsightsWorkspaceSharedKeys>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeOperationalInsightsWorkspaceSharedKeys(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(OperationalInsightsWorkspaceSharedKeys)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<OperationalInsightsWorkspaceSharedKeys>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
