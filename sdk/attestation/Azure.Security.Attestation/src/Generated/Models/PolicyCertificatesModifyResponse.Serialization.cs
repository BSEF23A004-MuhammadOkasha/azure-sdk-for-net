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

namespace Azure.Security.Attestation
{
    internal partial class PolicyCertificatesModifyResponse : IUtf8JsonSerializable, IJsonModel<PolicyCertificatesModifyResponse>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PolicyCertificatesModifyResponse>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PolicyCertificatesModifyResponse>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicyCertificatesModifyResponse>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(PolicyCertificatesModifyResponse)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Token))
            {
                writer.WritePropertyName("token"u8);
                writer.WriteStringValue(Token);
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

        PolicyCertificatesModifyResponse IJsonModel<PolicyCertificatesModifyResponse>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicyCertificatesModifyResponse>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(PolicyCertificatesModifyResponse)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePolicyCertificatesModifyResponse(document.RootElement, options);
        }

        internal static PolicyCertificatesModifyResponse DeserializePolicyCertificatesModifyResponse(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> token = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("token"u8))
                {
                    token = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PolicyCertificatesModifyResponse(token.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PolicyCertificatesModifyResponse>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicyCertificatesModifyResponse>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(PolicyCertificatesModifyResponse)} does not support '{options.Format}' format.");
            }
        }

        PolicyCertificatesModifyResponse IPersistableModel<PolicyCertificatesModifyResponse>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicyCertificatesModifyResponse>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePolicyCertificatesModifyResponse(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(PolicyCertificatesModifyResponse)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PolicyCertificatesModifyResponse>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
