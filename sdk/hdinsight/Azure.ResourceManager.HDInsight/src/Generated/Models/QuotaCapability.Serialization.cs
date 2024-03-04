// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.HDInsight;

namespace Azure.ResourceManager.HDInsight.Models
{
    public partial class QuotaCapability : IUtf8JsonSerializable, IJsonModel<QuotaCapability>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<QuotaCapability>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<QuotaCapability>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<QuotaCapability>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(QuotaCapability)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(CoresUsed))
            {
                writer.WritePropertyName("coresUsed"u8);
                writer.WriteNumberValue(CoresUsed.Value);
            }
            if (Optional.IsDefined(MaxCoresAllowed))
            {
                writer.WritePropertyName("maxCoresAllowed"u8);
                writer.WriteNumberValue(MaxCoresAllowed.Value);
            }
            if (Optional.IsCollectionDefined(RegionalQuotas))
            {
                writer.WritePropertyName("regionalQuotas"u8);
                writer.WriteStartArray();
                foreach (var item in RegionalQuotas)
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

        QuotaCapability IJsonModel<QuotaCapability>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<QuotaCapability>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(QuotaCapability)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeQuotaCapability(document.RootElement, options);
        }

        internal static QuotaCapability DeserializeQuotaCapability(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            long? coresUsed = default;
            long? maxCoresAllowed = default;
            IReadOnlyList<RegionalQuotaCapability> regionalQuotas = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("coresUsed"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    coresUsed = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("maxCoresAllowed"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxCoresAllowed = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("regionalQuotas"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RegionalQuotaCapability> array = new List<RegionalQuotaCapability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RegionalQuotaCapability.DeserializeRegionalQuotaCapability(item, options));
                    }
                    regionalQuotas = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new QuotaCapability(coresUsed, maxCoresAllowed, regionalQuotas ?? new ChangeTrackingList<RegionalQuotaCapability>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<QuotaCapability>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<QuotaCapability>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(QuotaCapability)} does not support '{options.Format}' format.");
            }
        }

        QuotaCapability IPersistableModel<QuotaCapability>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<QuotaCapability>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeQuotaCapability(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(QuotaCapability)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<QuotaCapability>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
