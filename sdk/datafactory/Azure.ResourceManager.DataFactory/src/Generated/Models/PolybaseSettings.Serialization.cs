// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class PolybaseSettings : IUtf8JsonSerializable, IJsonModel<PolybaseSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PolybaseSettings>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<PolybaseSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolybaseSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PolybaseSettings)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(RejectType))
            {
                writer.WritePropertyName("rejectType"u8);
                writer.WriteStringValue(RejectType.Value.ToString());
            }
            if (Optional.IsDefined(RejectValue))
            {
                writer.WritePropertyName("rejectValue"u8);
                JsonSerializer.Serialize(writer, RejectValue);
            }
            if (Optional.IsDefined(RejectSampleValue))
            {
                writer.WritePropertyName("rejectSampleValue"u8);
                JsonSerializer.Serialize(writer, RejectSampleValue);
            }
            if (Optional.IsDefined(UseTypeDefault))
            {
                writer.WritePropertyName("useTypeDefault"u8);
                JsonSerializer.Serialize(writer, UseTypeDefault);
            }
            foreach (var item in AdditionalProperties)
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

        PolybaseSettings IJsonModel<PolybaseSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolybaseSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PolybaseSettings)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePolybaseSettings(document.RootElement, options);
        }

        internal static PolybaseSettings DeserializePolybaseSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            PolybaseSettingsRejectType? rejectType = default;
            DataFactoryElement<int> rejectValue = default;
            DataFactoryElement<int> rejectSampleValue = default;
            DataFactoryElement<bool> useTypeDefault = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("rejectType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rejectType = new PolybaseSettingsRejectType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("rejectValue"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rejectValue = JsonSerializer.Deserialize<DataFactoryElement<int>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("rejectSampleValue"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rejectSampleValue = JsonSerializer.Deserialize<DataFactoryElement<int>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("useTypeDefault"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    useTypeDefault = JsonSerializer.Deserialize<DataFactoryElement<bool>>(property.Value.GetRawText());
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new PolybaseSettings(rejectType, rejectValue, rejectSampleValue, useTypeDefault, additionalProperties);
        }

        BinaryData IPersistableModel<PolybaseSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolybaseSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PolybaseSettings)} does not support writing '{options.Format}' format.");
            }
        }

        PolybaseSettings IPersistableModel<PolybaseSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolybaseSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePolybaseSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PolybaseSettings)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<PolybaseSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
