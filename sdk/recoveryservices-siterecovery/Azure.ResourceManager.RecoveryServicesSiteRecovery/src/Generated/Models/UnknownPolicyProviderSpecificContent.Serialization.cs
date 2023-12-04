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
    internal partial class UnknownPolicyProviderSpecificContent : IUtf8JsonSerializable, IJsonModel<PolicyProviderSpecificContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PolicyProviderSpecificContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PolicyProviderSpecificContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicyProviderSpecificContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(PolicyProviderSpecificContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("instanceType"u8);
            writer.WriteStringValue(InstanceType);
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

        PolicyProviderSpecificContent IJsonModel<PolicyProviderSpecificContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicyProviderSpecificContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(PolicyProviderSpecificContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeUnknownPolicyProviderSpecificContent(document.RootElement, options);
        }

        internal static UnknownPolicyProviderSpecificContent DeserializeUnknownPolicyProviderSpecificContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string instanceType = "Unknown";
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("instanceType"u8))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new UnknownPolicyProviderSpecificContent(instanceType, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PolicyProviderSpecificContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicyProviderSpecificContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(PolicyProviderSpecificContent)} does not support '{options.Format}' format.");
            }
        }

        PolicyProviderSpecificContent IPersistableModel<PolicyProviderSpecificContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicyProviderSpecificContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeUnknownPolicyProviderSpecificContent(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(PolicyProviderSpecificContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PolicyProviderSpecificContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
