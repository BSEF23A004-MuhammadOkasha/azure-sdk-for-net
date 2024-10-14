// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    internal partial class ApplicationGatewayAvailableSslPredefinedPolicies : IUtf8JsonSerializable, IJsonModel<ApplicationGatewayAvailableSslPredefinedPolicies>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ApplicationGatewayAvailableSslPredefinedPolicies>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ApplicationGatewayAvailableSslPredefinedPolicies>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationGatewayAvailableSslPredefinedPolicies>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApplicationGatewayAvailableSslPredefinedPolicies)} does not support writing '{format}' format.");
            }

            if (Optional.IsCollectionDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStartArray();
                foreach (var item in Value)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(NextLink))
            {
                writer.WritePropertyName("nextLink"u8);
                writer.WriteStringValue(NextLink);
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

        ApplicationGatewayAvailableSslPredefinedPolicies IJsonModel<ApplicationGatewayAvailableSslPredefinedPolicies>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationGatewayAvailableSslPredefinedPolicies>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApplicationGatewayAvailableSslPredefinedPolicies)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeApplicationGatewayAvailableSslPredefinedPolicies(document.RootElement, options);
        }

        internal static ApplicationGatewayAvailableSslPredefinedPolicies DeserializeApplicationGatewayAvailableSslPredefinedPolicies(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<ApplicationGatewaySslPredefinedPolicy> value = default;
            string nextLink = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ApplicationGatewaySslPredefinedPolicy> array = new List<ApplicationGatewaySslPredefinedPolicy>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ApplicationGatewaySslPredefinedPolicy.DeserializeApplicationGatewaySslPredefinedPolicy(item, options));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ApplicationGatewayAvailableSslPredefinedPolicies(value ?? new ChangeTrackingList<ApplicationGatewaySslPredefinedPolicy>(), nextLink, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ApplicationGatewayAvailableSslPredefinedPolicies>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationGatewayAvailableSslPredefinedPolicies>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ApplicationGatewayAvailableSslPredefinedPolicies)} does not support writing '{options.Format}' format.");
            }
        }

        ApplicationGatewayAvailableSslPredefinedPolicies IPersistableModel<ApplicationGatewayAvailableSslPredefinedPolicies>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationGatewayAvailableSslPredefinedPolicies>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeApplicationGatewayAvailableSslPredefinedPolicies(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ApplicationGatewayAvailableSslPredefinedPolicies)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ApplicationGatewayAvailableSslPredefinedPolicies>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
