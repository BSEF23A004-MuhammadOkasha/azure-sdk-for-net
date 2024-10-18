// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class SiteRecoveryInnerHealthError : IUtf8JsonSerializable, IJsonModel<SiteRecoveryInnerHealthError>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SiteRecoveryInnerHealthError>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SiteRecoveryInnerHealthError>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryInnerHealthError>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SiteRecoveryInnerHealthError)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(ErrorSource))
            {
                writer.WritePropertyName("errorSource"u8);
                writer.WriteStringValue(ErrorSource);
            }
            if (Optional.IsDefined(ErrorType))
            {
                writer.WritePropertyName("errorType"u8);
                writer.WriteStringValue(ErrorType);
            }
            if (Optional.IsDefined(ErrorLevel))
            {
                writer.WritePropertyName("errorLevel"u8);
                writer.WriteStringValue(ErrorLevel);
            }
            if (Optional.IsDefined(ErrorCategory))
            {
                writer.WritePropertyName("errorCategory"u8);
                writer.WriteStringValue(ErrorCategory);
            }
            if (Optional.IsDefined(ErrorCode))
            {
                writer.WritePropertyName("errorCode"u8);
                writer.WriteStringValue(ErrorCode);
            }
            if (Optional.IsDefined(SummaryMessage))
            {
                writer.WritePropertyName("summaryMessage"u8);
                writer.WriteStringValue(SummaryMessage);
            }
            if (Optional.IsDefined(ErrorMessage))
            {
                writer.WritePropertyName("errorMessage"u8);
                writer.WriteStringValue(ErrorMessage);
            }
            if (Optional.IsDefined(PossibleCauses))
            {
                writer.WritePropertyName("possibleCauses"u8);
                writer.WriteStringValue(PossibleCauses);
            }
            if (Optional.IsDefined(RecommendedAction))
            {
                writer.WritePropertyName("recommendedAction"u8);
                writer.WriteStringValue(RecommendedAction);
            }
            if (Optional.IsDefined(CreatedOn))
            {
                writer.WritePropertyName("creationTimeUtc"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (Optional.IsDefined(RecoveryProviderErrorMessage))
            {
                writer.WritePropertyName("recoveryProviderErrorMessage"u8);
                writer.WriteStringValue(RecoveryProviderErrorMessage);
            }
            if (Optional.IsDefined(EntityId))
            {
                writer.WritePropertyName("entityId"u8);
                writer.WriteStringValue(EntityId);
            }
            if (Optional.IsDefined(ErrorId))
            {
                writer.WritePropertyName("errorId"u8);
                writer.WriteStringValue(ErrorId);
            }
            if (Optional.IsDefined(CustomerResolvability))
            {
                writer.WritePropertyName("customerResolvability"u8);
                writer.WriteStringValue(CustomerResolvability.Value.ToString());
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
        }

        SiteRecoveryInnerHealthError IJsonModel<SiteRecoveryInnerHealthError>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryInnerHealthError>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SiteRecoveryInnerHealthError)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSiteRecoveryInnerHealthError(document.RootElement, options);
        }

        internal static SiteRecoveryInnerHealthError DeserializeSiteRecoveryInnerHealthError(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string errorSource = default;
            string errorType = default;
            string errorLevel = default;
            string errorCategory = default;
            string errorCode = default;
            string summaryMessage = default;
            string errorMessage = default;
            string possibleCauses = default;
            string recommendedAction = default;
            DateTimeOffset? creationTimeUtc = default;
            string recoveryProviderErrorMessage = default;
            string entityId = default;
            string errorId = default;
            HealthErrorCustomerResolvability? customerResolvability = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("errorSource"u8))
                {
                    errorSource = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("errorType"u8))
                {
                    errorType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("errorLevel"u8))
                {
                    errorLevel = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("errorCategory"u8))
                {
                    errorCategory = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("errorCode"u8))
                {
                    errorCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("summaryMessage"u8))
                {
                    summaryMessage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("errorMessage"u8))
                {
                    errorMessage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("possibleCauses"u8))
                {
                    possibleCauses = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recommendedAction"u8))
                {
                    recommendedAction = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("creationTimeUtc"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    creationTimeUtc = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("recoveryProviderErrorMessage"u8))
                {
                    recoveryProviderErrorMessage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("entityId"u8))
                {
                    entityId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("errorId"u8))
                {
                    errorId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("customerResolvability"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    customerResolvability = new HealthErrorCustomerResolvability(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SiteRecoveryInnerHealthError(
                errorSource,
                errorType,
                errorLevel,
                errorCategory,
                errorCode,
                summaryMessage,
                errorMessage,
                possibleCauses,
                recommendedAction,
                creationTimeUtc,
                recoveryProviderErrorMessage,
                entityId,
                errorId,
                customerResolvability,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SiteRecoveryInnerHealthError>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryInnerHealthError>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SiteRecoveryInnerHealthError)} does not support writing '{options.Format}' format.");
            }
        }

        SiteRecoveryInnerHealthError IPersistableModel<SiteRecoveryInnerHealthError>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryInnerHealthError>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSiteRecoveryInnerHealthError(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SiteRecoveryInnerHealthError)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SiteRecoveryInnerHealthError>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
