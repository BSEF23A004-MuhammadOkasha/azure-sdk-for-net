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

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    public partial class AsymmetricEncryptedSecret : IUtf8JsonSerializable, IJsonModel<AsymmetricEncryptedSecret>, IPersistableModel<AsymmetricEncryptedSecret>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AsymmetricEncryptedSecret>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AsymmetricEncryptedSecret>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AsymmetricEncryptedSecret>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AsymmetricEncryptedSecret)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("value"u8);
            writer.WriteStringValue(Value);
            if (Optional.IsDefined(EncryptionCertThumbprint))
            {
                writer.WritePropertyName("encryptionCertThumbprint"u8);
                writer.WriteStringValue(EncryptionCertThumbprint);
            }
            writer.WritePropertyName("encryptionAlgorithm"u8);
            writer.WriteStringValue(EncryptionAlgorithm.ToString());
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

        AsymmetricEncryptedSecret IJsonModel<AsymmetricEncryptedSecret>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AsymmetricEncryptedSecret>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AsymmetricEncryptedSecret)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAsymmetricEncryptedSecret(document.RootElement, options);
        }

        internal static AsymmetricEncryptedSecret DeserializeAsymmetricEncryptedSecret(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string value = default;
            Optional<string> encryptionCertThumbprint = default;
            DataBoxEdgeEncryptionAlgorithm encryptionAlgorithm = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    value = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("encryptionCertThumbprint"u8))
                {
                    encryptionCertThumbprint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("encryptionAlgorithm"u8))
                {
                    encryptionAlgorithm = new DataBoxEdgeEncryptionAlgorithm(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AsymmetricEncryptedSecret(value, encryptionCertThumbprint.Value, encryptionAlgorithm, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(Value))
            {
                builder.Append("  value:");
                builder.AppendLine($" '{Value}'");
            }

            if (Optional.IsDefined(EncryptionCertThumbprint))
            {
                builder.Append("  encryptionCertThumbprint:");
                builder.AppendLine($" '{EncryptionCertThumbprint}'");
            }

            if (Optional.IsDefined(EncryptionAlgorithm))
            {
                builder.Append("  encryptionAlgorithm:");
                builder.AppendLine($" '{EncryptionAlgorithm.ToString()}'");
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

        BinaryData IPersistableModel<AsymmetricEncryptedSecret>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AsymmetricEncryptedSecret>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(AsymmetricEncryptedSecret)} does not support '{options.Format}' format.");
            }
        }

        AsymmetricEncryptedSecret IPersistableModel<AsymmetricEncryptedSecret>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AsymmetricEncryptedSecret>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAsymmetricEncryptedSecret(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(AsymmetricEncryptedSecret)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AsymmetricEncryptedSecret>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
