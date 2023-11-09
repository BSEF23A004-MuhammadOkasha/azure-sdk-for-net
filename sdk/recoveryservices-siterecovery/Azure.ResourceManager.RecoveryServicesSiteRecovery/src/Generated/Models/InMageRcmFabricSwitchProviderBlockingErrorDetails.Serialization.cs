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
    public partial class InMageRcmFabricSwitchProviderBlockingErrorDetails : IUtf8JsonSerializable, IJsonModel<InMageRcmFabricSwitchProviderBlockingErrorDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<InMageRcmFabricSwitchProviderBlockingErrorDetails>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<InMageRcmFabricSwitchProviderBlockingErrorDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(ErrorCode))
                {
                    writer.WritePropertyName("errorCode"u8);
                    writer.WriteStringValue(ErrorCode);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(ErrorMessage))
                {
                    writer.WritePropertyName("errorMessage"u8);
                    writer.WriteStringValue(ErrorMessage);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(PossibleCauses))
                {
                    writer.WritePropertyName("possibleCauses"u8);
                    writer.WriteStringValue(PossibleCauses);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(RecommendedAction))
                {
                    writer.WritePropertyName("recommendedAction"u8);
                    writer.WriteStringValue(RecommendedAction);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsCollectionDefined(ErrorMessageParameters))
                {
                    writer.WritePropertyName("errorMessageParameters"u8);
                    writer.WriteStartObject();
                    foreach (var item in ErrorMessageParameters)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteStringValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsCollectionDefined(ErrorTags))
                {
                    writer.WritePropertyName("errorTags"u8);
                    writer.WriteStartObject();
                    foreach (var item in ErrorTags)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteStringValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
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

        InMageRcmFabricSwitchProviderBlockingErrorDetails IJsonModel<InMageRcmFabricSwitchProviderBlockingErrorDetails>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(InMageRcmFabricSwitchProviderBlockingErrorDetails)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInMageRcmFabricSwitchProviderBlockingErrorDetails(document.RootElement, options);
        }

        internal static InMageRcmFabricSwitchProviderBlockingErrorDetails DeserializeInMageRcmFabricSwitchProviderBlockingErrorDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> errorCode = default;
            Optional<string> errorMessage = default;
            Optional<string> possibleCauses = default;
            Optional<string> recommendedAction = default;
            Optional<IReadOnlyDictionary<string, string>> errorMessageParameters = default;
            Optional<IReadOnlyDictionary<string, string>> errorTags = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("errorCode"u8))
                {
                    errorCode = property.Value.GetString();
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
                if (property.NameEquals("errorMessageParameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    errorMessageParameters = dictionary;
                    continue;
                }
                if (property.NameEquals("errorTags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    errorTags = dictionary;
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new InMageRcmFabricSwitchProviderBlockingErrorDetails(errorCode.Value, errorMessage.Value, possibleCauses.Value, recommendedAction.Value, Optional.ToDictionary(errorMessageParameters), Optional.ToDictionary(errorTags), serializedAdditionalRawData);
        }

        BinaryData IModel<InMageRcmFabricSwitchProviderBlockingErrorDetails>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(InMageRcmFabricSwitchProviderBlockingErrorDetails)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        InMageRcmFabricSwitchProviderBlockingErrorDetails IModel<InMageRcmFabricSwitchProviderBlockingErrorDetails>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(InMageRcmFabricSwitchProviderBlockingErrorDetails)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeInMageRcmFabricSwitchProviderBlockingErrorDetails(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<InMageRcmFabricSwitchProviderBlockingErrorDetails>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
