// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    [PersistableModelProxy(typeof(UnknownRecoveryAvailabilitySetCustomDetails))]
    public partial class RecoveryAvailabilitySetCustomDetails : IUtf8JsonSerializable, IJsonModel<RecoveryAvailabilitySetCustomDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RecoveryAvailabilitySetCustomDetails>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<RecoveryAvailabilitySetCustomDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecoveryAvailabilitySetCustomDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RecoveryAvailabilitySetCustomDetails)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("resourceType"u8);
            writer.WriteStringValue(ResourceType);
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

        RecoveryAvailabilitySetCustomDetails IJsonModel<RecoveryAvailabilitySetCustomDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecoveryAvailabilitySetCustomDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RecoveryAvailabilitySetCustomDetails)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRecoveryAvailabilitySetCustomDetails(document.RootElement, options);
        }

        internal static RecoveryAvailabilitySetCustomDetails DeserializeRecoveryAvailabilitySetCustomDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("resourceType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Existing": return ExistingRecoveryAvailabilitySet.DeserializeExistingRecoveryAvailabilitySet(element, options);
                }
            }
            return UnknownRecoveryAvailabilitySetCustomDetails.DeserializeUnknownRecoveryAvailabilitySetCustomDetails(element, options);
        }

        BinaryData IPersistableModel<RecoveryAvailabilitySetCustomDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecoveryAvailabilitySetCustomDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RecoveryAvailabilitySetCustomDetails)} does not support writing '{options.Format}' format.");
            }
        }

        RecoveryAvailabilitySetCustomDetails IPersistableModel<RecoveryAvailabilitySetCustomDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecoveryAvailabilitySetCustomDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRecoveryAvailabilitySetCustomDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RecoveryAvailabilitySetCustomDetails)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<RecoveryAvailabilitySetCustomDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
