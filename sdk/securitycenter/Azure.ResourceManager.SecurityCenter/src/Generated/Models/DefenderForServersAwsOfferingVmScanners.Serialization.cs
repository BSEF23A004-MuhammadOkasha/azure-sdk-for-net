// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class DefenderForServersAwsOfferingVmScanners : IUtf8JsonSerializable, IJsonModel<DefenderForServersAwsOfferingVmScanners>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DefenderForServersAwsOfferingVmScanners>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DefenderForServersAwsOfferingVmScanners>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefenderForServersAwsOfferingVmScanners>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DefenderForServersAwsOfferingVmScanners)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(IsEnabled))
            {
                writer.WritePropertyName("enabled"u8);
                writer.WriteBooleanValue(IsEnabled.Value);
            }
            if (Optional.IsDefined(Configuration))
            {
                writer.WritePropertyName("configuration"u8);
                writer.WriteObjectValue(Configuration);
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

        DefenderForServersAwsOfferingVmScanners IJsonModel<DefenderForServersAwsOfferingVmScanners>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefenderForServersAwsOfferingVmScanners>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DefenderForServersAwsOfferingVmScanners)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDefenderForServersAwsOfferingVmScanners(document.RootElement, options);
        }

        internal static DefenderForServersAwsOfferingVmScanners DeserializeDefenderForServersAwsOfferingVmScanners(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> enabled = default;
            Optional<DefenderForServersAwsOfferingVmScannersConfiguration> configuration = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("configuration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    configuration = DefenderForServersAwsOfferingVmScannersConfiguration.DeserializeDefenderForServersAwsOfferingVmScannersConfiguration(property.Value);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DefenderForServersAwsOfferingVmScanners(Optional.ToNullable(enabled), configuration.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DefenderForServersAwsOfferingVmScanners>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefenderForServersAwsOfferingVmScanners>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DefenderForServersAwsOfferingVmScanners)} does not support '{options.Format}' format.");
            }
        }

        DefenderForServersAwsOfferingVmScanners IPersistableModel<DefenderForServersAwsOfferingVmScanners>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefenderForServersAwsOfferingVmScanners>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDefenderForServersAwsOfferingVmScanners(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DefenderForServersAwsOfferingVmScanners)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DefenderForServersAwsOfferingVmScanners>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
