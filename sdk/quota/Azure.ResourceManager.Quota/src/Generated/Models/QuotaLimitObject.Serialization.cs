// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Quota.Models
{
    public partial class QuotaLimitObject : IUtf8JsonSerializable, IJsonModel<QuotaLimitObject>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<QuotaLimitObject>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<QuotaLimitObject>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<QuotaLimitObject>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(QuotaLimitObject)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("value"u8);
            writer.WriteNumberValue(Value);
            if (Optional.IsDefined(LimitType))
            {
                writer.WritePropertyName("limitType"u8);
                writer.WriteStringValue(LimitType.Value.ToString());
            }
            writer.WritePropertyName("limitObjectType"u8);
            writer.WriteStringValue(LimitObjectType.ToString());
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

        QuotaLimitObject IJsonModel<QuotaLimitObject>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<QuotaLimitObject>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(QuotaLimitObject)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeQuotaLimitObject(document.RootElement, options);
        }

        internal static QuotaLimitObject DeserializeQuotaLimitObject(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int value = default;
            Optional<QuotaLimitType> limitType = default;
            LimitType limitObjectType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    value = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("limitType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    limitType = new QuotaLimitType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("limitObjectType"u8))
                {
                    limitObjectType = new LimitType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new QuotaLimitObject(limitObjectType, serializedAdditionalRawData, value, Optional.ToNullable(limitType));
        }

        BinaryData IPersistableModel<QuotaLimitObject>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<QuotaLimitObject>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(QuotaLimitObject)} does not support '{options.Format}' format.");
            }
        }

        QuotaLimitObject IPersistableModel<QuotaLimitObject>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<QuotaLimitObject>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeQuotaLimitObject(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(QuotaLimitObject)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<QuotaLimitObject>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
