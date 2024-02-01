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

namespace Azure.ResourceManager.ConfidentialLedger.Models
{
    public partial class ConfidentialLedgerMemberIdentityCertificate : IUtf8JsonSerializable, IJsonModel<ConfidentialLedgerMemberIdentityCertificate>, IPersistableModel<ConfidentialLedgerMemberIdentityCertificate>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ConfidentialLedgerMemberIdentityCertificate>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ConfidentialLedgerMemberIdentityCertificate>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConfidentialLedgerMemberIdentityCertificate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConfidentialLedgerMemberIdentityCertificate)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Certificate))
            {
                writer.WritePropertyName("certificate"u8);
                writer.WriteStringValue(Certificate);
            }
            if (Optional.IsDefined(Encryptionkey))
            {
                writer.WritePropertyName("encryptionkey"u8);
                writer.WriteStringValue(Encryptionkey);
            }
            if (Optional.IsDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Tags);
#else
                using (JsonDocument document = JsonDocument.Parse(Tags))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
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

        ConfidentialLedgerMemberIdentityCertificate IJsonModel<ConfidentialLedgerMemberIdentityCertificate>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConfidentialLedgerMemberIdentityCertificate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConfidentialLedgerMemberIdentityCertificate)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConfidentialLedgerMemberIdentityCertificate(document.RootElement, options);
        }

        internal static ConfidentialLedgerMemberIdentityCertificate DeserializeConfidentialLedgerMemberIdentityCertificate(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> certificate = default;
            Optional<string> encryptionkey = default;
            Optional<BinaryData> tags = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("certificate"u8))
                {
                    certificate = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("encryptionkey"u8))
                {
                    encryptionkey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tags = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ConfidentialLedgerMemberIdentityCertificate(certificate.Value, encryptionkey.Value, tags.Value, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(Certificate))
            {
                builder.Append("  certificate:");
                builder.AppendLine($" '{Certificate}'");
            }

            if (Optional.IsDefined(Encryptionkey))
            {
                builder.Append("  encryptionkey:");
                builder.AppendLine($" '{Encryptionkey}'");
            }

            if (Optional.IsDefined(Tags))
            {
                builder.Append("  tags:");
                builder.AppendLine($" '{Tags.ToString()}'");
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

        BinaryData IPersistableModel<ConfidentialLedgerMemberIdentityCertificate>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConfidentialLedgerMemberIdentityCertificate>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ConfidentialLedgerMemberIdentityCertificate)} does not support '{options.Format}' format.");
            }
        }

        ConfidentialLedgerMemberIdentityCertificate IPersistableModel<ConfidentialLedgerMemberIdentityCertificate>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConfidentialLedgerMemberIdentityCertificate>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeConfidentialLedgerMemberIdentityCertificate(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(ConfidentialLedgerMemberIdentityCertificate)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ConfidentialLedgerMemberIdentityCertificate>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
