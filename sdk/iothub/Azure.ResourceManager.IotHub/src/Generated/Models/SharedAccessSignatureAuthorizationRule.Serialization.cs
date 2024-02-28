// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.IotHub.Models
{
    public partial class SharedAccessSignatureAuthorizationRule : IUtf8JsonSerializable, IJsonModel<SharedAccessSignatureAuthorizationRule>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SharedAccessSignatureAuthorizationRule>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SharedAccessSignatureAuthorizationRule>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SharedAccessSignatureAuthorizationRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SharedAccessSignatureAuthorizationRule)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("keyName"u8);
            writer.WriteStringValue(KeyName);
            if (PrimaryKey != null)
            {
                writer.WritePropertyName("primaryKey"u8);
                writer.WriteStringValue(PrimaryKey);
            }
            if (SecondaryKey != null)
            {
                writer.WritePropertyName("secondaryKey"u8);
                writer.WriteStringValue(SecondaryKey);
            }
            writer.WritePropertyName("rights"u8);
            writer.WriteStringValue(Rights.ToSerialString());
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

        SharedAccessSignatureAuthorizationRule IJsonModel<SharedAccessSignatureAuthorizationRule>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SharedAccessSignatureAuthorizationRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SharedAccessSignatureAuthorizationRule)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSharedAccessSignatureAuthorizationRule(document.RootElement, options);
        }

        internal static SharedAccessSignatureAuthorizationRule DeserializeSharedAccessSignatureAuthorizationRule(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string keyName = default;
            string primaryKey = default;
            string secondaryKey = default;
            IotHubSharedAccessRight rights = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("keyName"u8))
                {
                    keyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("primaryKey"u8))
                {
                    primaryKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secondaryKey"u8))
                {
                    secondaryKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("rights"u8))
                {
                    rights = property.Value.GetString().ToIotHubSharedAccessRight();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SharedAccessSignatureAuthorizationRule(keyName, primaryKey, secondaryKey, rights, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SharedAccessSignatureAuthorizationRule>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SharedAccessSignatureAuthorizationRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SharedAccessSignatureAuthorizationRule)} does not support '{options.Format}' format.");
            }
        }

        SharedAccessSignatureAuthorizationRule IPersistableModel<SharedAccessSignatureAuthorizationRule>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SharedAccessSignatureAuthorizationRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSharedAccessSignatureAuthorizationRule(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SharedAccessSignatureAuthorizationRule)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SharedAccessSignatureAuthorizationRule>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
