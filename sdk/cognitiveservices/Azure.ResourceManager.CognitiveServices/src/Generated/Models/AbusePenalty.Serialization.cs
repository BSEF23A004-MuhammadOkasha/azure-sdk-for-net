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

namespace Azure.ResourceManager.CognitiveServices.Models
{
    public partial class AbusePenalty : IUtf8JsonSerializable, IJsonModel<AbusePenalty>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AbusePenalty>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AbusePenalty>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AbusePenalty>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(AbusePenalty)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Action))
            {
                writer.WritePropertyName("action"u8);
                writer.WriteStringValue(Action.Value.ToString());
            }
            if (Optional.IsDefined(RateLimitPercentage))
            {
                writer.WritePropertyName("rateLimitPercentage"u8);
                writer.WriteNumberValue(RateLimitPercentage.Value);
            }
            if (Optional.IsDefined(Expiration))
            {
                writer.WritePropertyName("expiration"u8);
                writer.WriteStringValue(Expiration.Value, "O");
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

        AbusePenalty IJsonModel<AbusePenalty>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AbusePenalty>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(AbusePenalty)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAbusePenalty(document.RootElement, options);
        }

        internal static AbusePenalty DeserializeAbusePenalty(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AbusePenaltyAction> action = default;
            Optional<float> rateLimitPercentage = default;
            Optional<DateTimeOffset> expiration = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("action"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    action = new AbusePenaltyAction(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("rateLimitPercentage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rateLimitPercentage = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("expiration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expiration = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AbusePenalty(Optional.ToNullable(action), Optional.ToNullable(rateLimitPercentage), Optional.ToNullable(expiration), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AbusePenalty>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AbusePenalty>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(AbusePenalty)} does not support '{options.Format}' format.");
            }
        }

        AbusePenalty IPersistableModel<AbusePenalty>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AbusePenalty>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAbusePenalty(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(AbusePenalty)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AbusePenalty>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
