// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class SiteRecoveryInnerHealthError : IUtf8JsonSerializable, IJsonModel<SiteRecoveryInnerHealthError>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SiteRecoveryInnerHealthError>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<SiteRecoveryInnerHealthError>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
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
            if (_serializedAdditionalRawData != null && options.Format == ModelReaderWriterFormat.Json)
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

        SiteRecoveryInnerHealthError IJsonModel<SiteRecoveryInnerHealthError>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SiteRecoveryInnerHealthError)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSiteRecoveryInnerHealthError(document.RootElement, options);
        }

        internal static SiteRecoveryInnerHealthError DeserializeSiteRecoveryInnerHealthError(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> errorSource = default;
            Optional<string> errorType = default;
            Optional<string> errorLevel = default;
            Optional<string> errorCategory = default;
            Optional<string> errorCode = default;
            Optional<string> summaryMessage = default;
            Optional<string> errorMessage = default;
            Optional<string> possibleCauses = default;
            Optional<string> recommendedAction = default;
            Optional<DateTimeOffset> creationTimeUtc = default;
            Optional<string> recoveryProviderErrorMessage = default;
            Optional<string> entityId = default;
            Optional<string> errorId = default;
            Optional<HealthErrorCustomerResolvability> customerResolvability = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
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
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SiteRecoveryInnerHealthError(errorSource.Value, errorType.Value, errorLevel.Value, errorCategory.Value, errorCode.Value, summaryMessage.Value, errorMessage.Value, possibleCauses.Value, recommendedAction.Value, Optional.ToNullable(creationTimeUtc), recoveryProviderErrorMessage.Value, entityId.Value, errorId.Value, Optional.ToNullable(customerResolvability), serializedAdditionalRawData);
        }

        BinaryData IModel<SiteRecoveryInnerHealthError>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SiteRecoveryInnerHealthError)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        SiteRecoveryInnerHealthError IModel<SiteRecoveryInnerHealthError>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SiteRecoveryInnerHealthError)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeSiteRecoveryInnerHealthError(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<SiteRecoveryInnerHealthError>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
