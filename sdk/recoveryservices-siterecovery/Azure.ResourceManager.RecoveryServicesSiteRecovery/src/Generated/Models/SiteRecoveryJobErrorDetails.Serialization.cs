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

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class SiteRecoveryJobErrorDetails : IUtf8JsonSerializable, IJsonModel<SiteRecoveryJobErrorDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SiteRecoveryJobErrorDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SiteRecoveryJobErrorDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryJobErrorDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(SiteRecoveryJobErrorDetails)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ServiceErrorDetails))
            {
                writer.WritePropertyName("serviceErrorDetails"u8);
                writer.WriteObjectValue(ServiceErrorDetails);
            }
            if (Optional.IsDefined(ProviderErrorDetails))
            {
                writer.WritePropertyName("providerErrorDetails"u8);
                writer.WriteObjectValue(ProviderErrorDetails);
            }
            if (Optional.IsDefined(ErrorLevel))
            {
                writer.WritePropertyName("errorLevel"u8);
                writer.WriteStringValue(ErrorLevel);
            }
            if (Optional.IsDefined(CreatedOn))
            {
                writer.WritePropertyName("creationTime"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (Optional.IsDefined(TaskId))
            {
                writer.WritePropertyName("taskId"u8);
                writer.WriteStringValue(TaskId);
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

        SiteRecoveryJobErrorDetails IJsonModel<SiteRecoveryJobErrorDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryJobErrorDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(SiteRecoveryJobErrorDetails)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSiteRecoveryJobErrorDetails(document.RootElement, options);
        }

        internal static SiteRecoveryJobErrorDetails DeserializeSiteRecoveryJobErrorDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<SiteRecoveryServiceError> serviceErrorDetails = default;
            Optional<SiteRecoveryJobProviderError> providerErrorDetails = default;
            Optional<string> errorLevel = default;
            Optional<DateTimeOffset> creationTime = default;
            Optional<string> taskId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("serviceErrorDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    serviceErrorDetails = SiteRecoveryServiceError.DeserializeSiteRecoveryServiceError(property.Value);
                    continue;
                }
                if (property.NameEquals("providerErrorDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    providerErrorDetails = SiteRecoveryJobProviderError.DeserializeSiteRecoveryJobProviderError(property.Value);
                    continue;
                }
                if (property.NameEquals("errorLevel"u8))
                {
                    errorLevel = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("creationTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    creationTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("taskId"u8))
                {
                    taskId = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SiteRecoveryJobErrorDetails(serviceErrorDetails.Value, providerErrorDetails.Value, errorLevel.Value, Optional.ToNullable(creationTime), taskId.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SiteRecoveryJobErrorDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryJobErrorDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(SiteRecoveryJobErrorDetails)} does not support '{options.Format}' format.");
            }
        }

        SiteRecoveryJobErrorDetails IPersistableModel<SiteRecoveryJobErrorDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryJobErrorDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSiteRecoveryJobErrorDetails(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(SiteRecoveryJobErrorDetails)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SiteRecoveryJobErrorDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
