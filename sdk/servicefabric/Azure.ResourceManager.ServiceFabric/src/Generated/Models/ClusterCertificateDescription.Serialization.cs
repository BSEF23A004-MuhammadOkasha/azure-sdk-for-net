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

namespace Azure.ResourceManager.ServiceFabric.Models
{
    public partial class ClusterCertificateDescription : IUtf8JsonSerializable, IJsonModel<ClusterCertificateDescription>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ClusterCertificateDescription>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ClusterCertificateDescription>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterCertificateDescription>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(ClusterCertificateDescription)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("thumbprint"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Thumbprint);
#else
            using (JsonDocument document = JsonDocument.Parse(Thumbprint))
            {
                JsonSerializer.Serialize(writer, document.RootElement);
            }
#endif
            if (Optional.IsDefined(ThumbprintSecondary))
            {
                writer.WritePropertyName("thumbprintSecondary"u8);
                writer.WriteStringValue(ThumbprintSecondary);
            }
            if (Optional.IsDefined(X509StoreName))
            {
                writer.WritePropertyName("x509StoreName"u8);
                writer.WriteStringValue(X509StoreName.Value.ToString());
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

        ClusterCertificateDescription IJsonModel<ClusterCertificateDescription>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterCertificateDescription>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(ClusterCertificateDescription)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeClusterCertificateDescription(document.RootElement, options);
        }

        internal static ClusterCertificateDescription DeserializeClusterCertificateDescription(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            BinaryData thumbprint = default;
            Optional<string> thumbprintSecondary = default;
            Optional<ClusterCertificateStoreName> x509StoreName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("thumbprint"u8))
                {
                    thumbprint = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("thumbprintSecondary"u8))
                {
                    thumbprintSecondary = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("x509StoreName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    x509StoreName = new ClusterCertificateStoreName(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ClusterCertificateDescription(thumbprint, thumbprintSecondary.Value, Optional.ToNullable(x509StoreName), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ClusterCertificateDescription>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterCertificateDescription>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(ClusterCertificateDescription)} does not support '{options.Format}' format.");
            }
        }

        ClusterCertificateDescription IPersistableModel<ClusterCertificateDescription>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterCertificateDescription>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeClusterCertificateDescription(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(ClusterCertificateDescription)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ClusterCertificateDescription>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
