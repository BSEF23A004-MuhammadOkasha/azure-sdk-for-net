// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.Quantum.Jobs.Models
{
    public partial class UsageEvent : IUtf8JsonSerializable, IJsonModel<UsageEvent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<UsageEvent>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<UsageEvent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(DimensionId))
            {
                writer.WritePropertyName("dimensionId"u8);
                writer.WriteStringValue(DimensionId);
            }
            if (Optional.IsDefined(DimensionName))
            {
                writer.WritePropertyName("dimensionName"u8);
                writer.WriteStringValue(DimensionName);
            }
            if (Optional.IsDefined(MeasureUnit))
            {
                writer.WritePropertyName("measureUnit"u8);
                writer.WriteStringValue(MeasureUnit);
            }
            if (Optional.IsDefined(AmountBilled))
            {
                writer.WritePropertyName("amountBilled"u8);
                writer.WriteNumberValue(AmountBilled.Value);
            }
            if (Optional.IsDefined(AmountConsumed))
            {
                writer.WritePropertyName("amountConsumed"u8);
                writer.WriteNumberValue(AmountConsumed.Value);
            }
            if (Optional.IsDefined(UnitPrice))
            {
                writer.WritePropertyName("unitPrice"u8);
                writer.WriteNumberValue(UnitPrice.Value);
            }
            if (_serializedAdditionalRawData != null && options.Format == ModelReaderWriterFormat.Json)
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

        UsageEvent IJsonModel<UsageEvent>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(UsageEvent)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeUsageEvent(document.RootElement, options);
        }

        internal static UsageEvent DeserializeUsageEvent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> dimensionId = default;
            Optional<string> dimensionName = default;
            Optional<string> measureUnit = default;
            Optional<float> amountBilled = default;
            Optional<float> amountConsumed = default;
            Optional<float> unitPrice = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dimensionId"u8))
                {
                    dimensionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dimensionName"u8))
                {
                    dimensionName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("measureUnit"u8))
                {
                    measureUnit = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("amountBilled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    amountBilled = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("amountConsumed"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    amountConsumed = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("unitPrice"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    unitPrice = property.Value.GetSingle();
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new UsageEvent(dimensionId.Value, dimensionName.Value, measureUnit.Value, Optional.ToNullable(amountBilled), Optional.ToNullable(amountConsumed), Optional.ToNullable(unitPrice), serializedAdditionalRawData);
        }

        BinaryData IModel<UsageEvent>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(UsageEvent)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        UsageEvent IModel<UsageEvent>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(UsageEvent)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeUsageEvent(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<UsageEvent>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
