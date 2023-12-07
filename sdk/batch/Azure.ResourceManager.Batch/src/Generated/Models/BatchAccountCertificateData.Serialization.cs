// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Batch.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Batch
{
    public partial class BatchAccountCertificateData : IUtf8JsonSerializable, IJsonModel<BatchAccountCertificateData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BatchAccountCertificateData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<BatchAccountCertificateData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchAccountCertificateData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(BatchAccountCertificateData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(ThumbprintAlgorithm))
            {
                writer.WritePropertyName("thumbprintAlgorithm"u8);
                writer.WriteStringValue(ThumbprintAlgorithm);
            }
            if (Optional.IsDefined(ThumbprintString))
            {
                writer.WritePropertyName("thumbprint"u8);
                writer.WriteStringValue(ThumbprintString);
            }
            if (Optional.IsDefined(Format))
            {
                writer.WritePropertyName("format"u8);
                writer.WriteStringValue(Format.Value.ToSerialString());
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningStateTransitOn))
            {
                writer.WritePropertyName("provisioningStateTransitionTime"u8);
                writer.WriteStringValue(ProvisioningStateTransitOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(PreviousProvisioningState))
            {
                writer.WritePropertyName("previousProvisioningState"u8);
                writer.WriteStringValue(PreviousProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(PreviousProvisioningStateTransitOn))
            {
                writer.WritePropertyName("previousProvisioningStateTransitionTime"u8);
                writer.WriteStringValue(PreviousProvisioningStateTransitOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(PublicData))
            {
                writer.WritePropertyName("publicData"u8);
                writer.WriteStringValue(PublicData);
            }
            if (options.Format != "W" && Optional.IsDefined(DeleteCertificateError))
            {
                writer.WritePropertyName("deleteCertificateError"u8);
                JsonSerializer.Serialize(writer, DeleteCertificateError);
            }
            writer.WriteEndObject();
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

        BatchAccountCertificateData IJsonModel<BatchAccountCertificateData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchAccountCertificateData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(BatchAccountCertificateData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBatchAccountCertificateData(document.RootElement, options);
        }

        internal static BatchAccountCertificateData DeserializeBatchAccountCertificateData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ETag> etag = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> thumbprintAlgorithm = default;
            Optional<string> thumbprint = default;
            Optional<BatchAccountCertificateFormat> format = default;
            Optional<BatchAccountCertificateProvisioningState> provisioningState = default;
            Optional<DateTimeOffset> provisioningStateTransitionTime = default;
            Optional<BatchAccountCertificateProvisioningState> previousProvisioningState = default;
            Optional<DateTimeOffset> previousProvisioningStateTransitionTime = default;
            Optional<string> publicData = default;
            Optional<ResponseError> deleteCertificateError = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("thumbprintAlgorithm"u8))
                        {
                            thumbprintAlgorithm = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("thumbprint"u8))
                        {
                            thumbprint = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("format"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            format = property0.Value.GetString().ToBatchAccountCertificateFormat();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new BatchAccountCertificateProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningStateTransitionTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningStateTransitionTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("previousProvisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            previousProvisioningState = new BatchAccountCertificateProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("previousProvisioningStateTransitionTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            previousProvisioningStateTransitionTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("publicData"u8))
                        {
                            publicData = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("deleteCertificateError"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            deleteCertificateError = JsonSerializer.Deserialize<ResponseError>(property0.Value.GetRawText());
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new BatchAccountCertificateData(id, name, type, systemData.Value, thumbprintAlgorithm.Value, thumbprint.Value, Optional.ToNullable(format), Optional.ToNullable(provisioningState), Optional.ToNullable(provisioningStateTransitionTime), Optional.ToNullable(previousProvisioningState), Optional.ToNullable(previousProvisioningStateTransitionTime), publicData.Value, deleteCertificateError.Value, Optional.ToNullable(etag), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BatchAccountCertificateData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchAccountCertificateData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(BatchAccountCertificateData)} does not support '{options.Format}' format.");
            }
        }

        BatchAccountCertificateData IPersistableModel<BatchAccountCertificateData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchAccountCertificateData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBatchAccountCertificateData(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(BatchAccountCertificateData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<BatchAccountCertificateData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
