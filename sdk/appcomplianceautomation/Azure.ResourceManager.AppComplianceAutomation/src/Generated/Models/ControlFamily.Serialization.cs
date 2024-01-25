// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppComplianceAutomation.Models
{
    public partial class ControlFamily : IUtf8JsonSerializable, IJsonModel<ControlFamily>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ControlFamily>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ControlFamily>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ControlFamily>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ControlFamily)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(FamilyName))
            {
                writer.WritePropertyName("familyName"u8);
                writer.WriteStringValue(FamilyName);
            }
            if (options.Format != "W" && Optional.IsDefined(FamilyType))
            {
                writer.WritePropertyName("familyType"u8);
                writer.WriteStringValue(FamilyType.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(FamilyStatus))
            {
                writer.WritePropertyName("familyStatus"u8);
                writer.WriteStringValue(FamilyStatus.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(Controls))
            {
                writer.WritePropertyName("controls"u8);
                writer.WriteStartArray();
                foreach (var item in Controls)
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

        ControlFamily IJsonModel<ControlFamily>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ControlFamily>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ControlFamily)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeControlFamily(document.RootElement, options);
        }

        internal static ControlFamily DeserializeControlFamily(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> familyName = default;
            Optional<ControlFamilyType> familyType = default;
            Optional<ControlFamilyStatus> familyStatus = default;
            Optional<IReadOnlyList<Control>> controls = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("familyName"u8))
                {
                    familyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("familyType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    familyType = new ControlFamilyType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("familyStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    familyStatus = new ControlFamilyStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("controls"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<Control> array = new List<Control>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Control.DeserializeControl(item));
                    }
                    controls = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ControlFamily(familyName.Value, Optional.ToNullable(familyType), Optional.ToNullable(familyStatus), Optional.ToList(controls), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ControlFamily>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ControlFamily>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ControlFamily)} does not support '{options.Format}' format.");
            }
        }

        ControlFamily IPersistableModel<ControlFamily>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ControlFamily>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeControlFamily(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ControlFamily)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ControlFamily>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
