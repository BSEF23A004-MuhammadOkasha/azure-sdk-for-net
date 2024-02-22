// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    public partial class X12ProtocolSettings : IUtf8JsonSerializable, IJsonModel<X12ProtocolSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<X12ProtocolSettings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<X12ProtocolSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<X12ProtocolSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(X12ProtocolSettings)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("validationSettings"u8);
            writer.WriteObjectValue(ValidationSettings);
            writer.WritePropertyName("framingSettings"u8);
            writer.WriteObjectValue(FramingSettings);
            writer.WritePropertyName("envelopeSettings"u8);
            writer.WriteObjectValue(EnvelopeSettings);
            writer.WritePropertyName("acknowledgementSettings"u8);
            writer.WriteObjectValue(AcknowledgementSettings);
            writer.WritePropertyName("messageFilter"u8);
            writer.WriteObjectValue(MessageFilter);
            writer.WritePropertyName("securitySettings"u8);
            writer.WriteObjectValue(SecuritySettings);
            writer.WritePropertyName("processingSettings"u8);
            writer.WriteObjectValue(ProcessingSettings);
            if (Optional.IsCollectionDefined(EnvelopeOverrides))
            {
                writer.WritePropertyName("envelopeOverrides"u8);
                writer.WriteStartArray();
                foreach (var item in EnvelopeOverrides)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ValidationOverrides))
            {
                writer.WritePropertyName("validationOverrides"u8);
                writer.WriteStartArray();
                foreach (var item in ValidationOverrides)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(MessageFilterList))
            {
                writer.WritePropertyName("messageFilterList"u8);
                writer.WriteStartArray();
                foreach (var item in MessageFilterList)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("schemaReferences"u8);
            writer.WriteStartArray();
            foreach (var item in SchemaReferences)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsCollectionDefined(X12DelimiterOverrides))
            {
                writer.WritePropertyName("x12DelimiterOverrides"u8);
                writer.WriteStartArray();
                foreach (var item in X12DelimiterOverrides)
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

        X12ProtocolSettings IJsonModel<X12ProtocolSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<X12ProtocolSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(X12ProtocolSettings)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeX12ProtocolSettings(document.RootElement, options);
        }

        internal static X12ProtocolSettings DeserializeX12ProtocolSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            X12ValidationSettings validationSettings = default;
            X12FramingSettings framingSettings = default;
            X12EnvelopeSettings envelopeSettings = default;
            X12AcknowledgementSettings acknowledgementSettings = default;
            X12MessageFilter messageFilter = default;
            X12SecuritySettings securitySettings = default;
            X12ProcessingSettings processingSettings = default;
            Optional<IList<X12EnvelopeOverride>> envelopeOverrides = default;
            Optional<IList<X12ValidationOverride>> validationOverrides = default;
            Optional<IList<X12MessageIdentifier>> messageFilterList = default;
            IList<X12SchemaReference> schemaReferences = default;
            Optional<IList<X12DelimiterOverrides>> x12DelimiterOverrides = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("validationSettings"u8))
                {
                    validationSettings = X12ValidationSettings.DeserializeX12ValidationSettings(property.Value, options);
                    continue;
                }
                if (property.NameEquals("framingSettings"u8))
                {
                    framingSettings = X12FramingSettings.DeserializeX12FramingSettings(property.Value, options);
                    continue;
                }
                if (property.NameEquals("envelopeSettings"u8))
                {
                    envelopeSettings = X12EnvelopeSettings.DeserializeX12EnvelopeSettings(property.Value, options);
                    continue;
                }
                if (property.NameEquals("acknowledgementSettings"u8))
                {
                    acknowledgementSettings = X12AcknowledgementSettings.DeserializeX12AcknowledgementSettings(property.Value, options);
                    continue;
                }
                if (property.NameEquals("messageFilter"u8))
                {
                    messageFilter = X12MessageFilter.DeserializeX12MessageFilter(property.Value, options);
                    continue;
                }
                if (property.NameEquals("securitySettings"u8))
                {
                    securitySettings = X12SecuritySettings.DeserializeX12SecuritySettings(property.Value, options);
                    continue;
                }
                if (property.NameEquals("processingSettings"u8))
                {
                    processingSettings = X12ProcessingSettings.DeserializeX12ProcessingSettings(property.Value, options);
                    continue;
                }
                if (property.NameEquals("envelopeOverrides"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<X12EnvelopeOverride> array = new List<X12EnvelopeOverride>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(X12EnvelopeOverride.DeserializeX12EnvelopeOverride(item, options));
                    }
                    envelopeOverrides = array;
                    continue;
                }
                if (property.NameEquals("validationOverrides"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<X12ValidationOverride> array = new List<X12ValidationOverride>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(X12ValidationOverride.DeserializeX12ValidationOverride(item, options));
                    }
                    validationOverrides = array;
                    continue;
                }
                if (property.NameEquals("messageFilterList"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<X12MessageIdentifier> array = new List<X12MessageIdentifier>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(X12MessageIdentifier.DeserializeX12MessageIdentifier(item, options));
                    }
                    messageFilterList = array;
                    continue;
                }
                if (property.NameEquals("schemaReferences"u8))
                {
                    List<X12SchemaReference> array = new List<X12SchemaReference>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(X12SchemaReference.DeserializeX12SchemaReference(item, options));
                    }
                    schemaReferences = array;
                    continue;
                }
                if (property.NameEquals("x12DelimiterOverrides"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<X12DelimiterOverrides> array = new List<X12DelimiterOverrides>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Models.X12DelimiterOverrides.DeserializeX12DelimiterOverrides(item, options));
                    }
                    x12DelimiterOverrides = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new X12ProtocolSettings(validationSettings, framingSettings, envelopeSettings, acknowledgementSettings, messageFilter, securitySettings, processingSettings, Optional.ToList(envelopeOverrides), Optional.ToList(validationOverrides), Optional.ToList(messageFilterList), schemaReferences, Optional.ToList(x12DelimiterOverrides), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<X12ProtocolSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<X12ProtocolSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(X12ProtocolSettings)} does not support '{options.Format}' format.");
            }
        }

        X12ProtocolSettings IPersistableModel<X12ProtocolSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<X12ProtocolSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeX12ProtocolSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(X12ProtocolSettings)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<X12ProtocolSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
