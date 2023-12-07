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

namespace Azure.ResourceManager.ChangeAnalysis.Models
{
    public partial class PropertyChange : IUtf8JsonSerializable, IJsonModel<PropertyChange>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PropertyChange>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PropertyChange>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PropertyChange>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(PropertyChange)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ChangeType))
            {
                writer.WritePropertyName("changeType"u8);
                writer.WriteStringValue(ChangeType.Value.ToString());
            }
            if (Optional.IsDefined(ChangeCategory))
            {
                writer.WritePropertyName("changeCategory"u8);
                writer.WriteStringValue(ChangeCategory.Value.ToSerialString());
            }
            if (Optional.IsDefined(JsonPath))
            {
                writer.WritePropertyName("jsonPath"u8);
                writer.WriteStringValue(JsonPath);
            }
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsDefined(Level))
            {
                writer.WritePropertyName("level"u8);
                writer.WriteStringValue(Level.Value.ToString());
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(OldValue))
            {
                writer.WritePropertyName("oldValue"u8);
                writer.WriteStringValue(OldValue);
            }
            if (Optional.IsDefined(NewValue))
            {
                writer.WritePropertyName("newValue"u8);
                writer.WriteStringValue(NewValue);
            }
            if (Optional.IsDefined(IsDataMasked))
            {
                writer.WritePropertyName("isDataMasked"u8);
                writer.WriteBooleanValue(IsDataMasked.Value);
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

        PropertyChange IJsonModel<PropertyChange>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PropertyChange>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(PropertyChange)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePropertyChange(document.RootElement, options);
        }

        internal static PropertyChange DeserializePropertyChange(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ChangeType> changeType = default;
            Optional<ChangeCategory> changeCategory = default;
            Optional<string> jsonPath = default;
            Optional<string> displayName = default;
            Optional<PropertyChangeLevel> level = default;
            Optional<string> description = default;
            Optional<string> oldValue = default;
            Optional<string> newValue = default;
            Optional<bool> isDataMasked = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("changeType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    changeType = new ChangeType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("changeCategory"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    changeCategory = property.Value.GetString().ToChangeCategory();
                    continue;
                }
                if (property.NameEquals("jsonPath"u8))
                {
                    jsonPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("displayName"u8))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("level"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    level = new PropertyChangeLevel(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("oldValue"u8))
                {
                    oldValue = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("newValue"u8))
                {
                    newValue = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isDataMasked"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isDataMasked = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PropertyChange(Optional.ToNullable(changeType), Optional.ToNullable(changeCategory), jsonPath.Value, displayName.Value, Optional.ToNullable(level), description.Value, oldValue.Value, newValue.Value, Optional.ToNullable(isDataMasked), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PropertyChange>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PropertyChange>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(PropertyChange)} does not support '{options.Format}' format.");
            }
        }

        PropertyChange IPersistableModel<PropertyChange>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PropertyChange>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePropertyChange(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(PropertyChange)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PropertyChange>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
