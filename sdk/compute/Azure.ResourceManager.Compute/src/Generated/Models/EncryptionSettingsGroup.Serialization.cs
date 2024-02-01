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

namespace Azure.ResourceManager.Compute.Models
{
    public partial class EncryptionSettingsGroup : IUtf8JsonSerializable, IJsonModel<EncryptionSettingsGroup>, IPersistableModel<EncryptionSettingsGroup>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EncryptionSettingsGroup>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<EncryptionSettingsGroup>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EncryptionSettingsGroup>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EncryptionSettingsGroup)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("enabled"u8);
            writer.WriteBooleanValue(Enabled);
            if (Optional.IsCollectionDefined(EncryptionSettings))
            {
                writer.WritePropertyName("encryptionSettings"u8);
                writer.WriteStartArray();
                foreach (var item in EncryptionSettings)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(EncryptionSettingsVersion))
            {
                writer.WritePropertyName("encryptionSettingsVersion"u8);
                writer.WriteStringValue(EncryptionSettingsVersion);
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

        EncryptionSettingsGroup IJsonModel<EncryptionSettingsGroup>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EncryptionSettingsGroup>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EncryptionSettingsGroup)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEncryptionSettingsGroup(document.RootElement, options);
        }

        internal static EncryptionSettingsGroup DeserializeEncryptionSettingsGroup(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool enabled = default;
            Optional<IList<EncryptionSettingsElement>> encryptionSettings = default;
            Optional<string> encryptionSettingsVersion = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enabled"u8))
                {
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("encryptionSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<EncryptionSettingsElement> array = new List<EncryptionSettingsElement>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(EncryptionSettingsElement.DeserializeEncryptionSettingsElement(item));
                    }
                    encryptionSettings = array;
                    continue;
                }
                if (property.NameEquals("encryptionSettingsVersion"u8))
                {
                    encryptionSettingsVersion = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new EncryptionSettingsGroup(enabled, Optional.ToList(encryptionSettings), encryptionSettingsVersion.Value, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(Enabled))
            {
                builder.Append("  enabled:");
                var boolValue = Enabled == true ? "true" : "false";
                builder.AppendLine($" {boolValue}");
            }

            if (Optional.IsCollectionDefined(EncryptionSettings))
            {
                builder.Append("  encryptionSettings:");
                builder.AppendLine(" [");
                foreach (var item in EncryptionSettings)
                {
                    AppendChildObject(builder, item, options, 4);
                }
                builder.AppendLine("  ]");
            }

            if (Optional.IsDefined(EncryptionSettingsVersion))
            {
                builder.Append("  encryptionSettingsVersion:");
                builder.AppendLine($" '{EncryptionSettingsVersion}'");
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        private void AppendChildObject(StringBuilder stringBuilder, object childObject, ModelReaderWriterOptions options, int spaces)
        {
            string indent = new string(' ', spaces);
            BinaryData data = ModelReaderWriter.Write(childObject, options);
            string[] lines = data.ToString().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            foreach (var line in lines)
            {
                stringBuilder.AppendLine($"{indent}{line}");
            }
        }

        BinaryData IPersistableModel<EncryptionSettingsGroup>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EncryptionSettingsGroup>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(EncryptionSettingsGroup)} does not support '{options.Format}' format.");
            }
        }

        EncryptionSettingsGroup IPersistableModel<EncryptionSettingsGroup>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EncryptionSettingsGroup>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeEncryptionSettingsGroup(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(EncryptionSettingsGroup)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<EncryptionSettingsGroup>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
