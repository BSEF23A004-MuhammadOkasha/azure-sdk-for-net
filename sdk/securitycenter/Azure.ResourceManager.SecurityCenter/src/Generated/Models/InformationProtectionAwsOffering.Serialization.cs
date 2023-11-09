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

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class InformationProtectionAwsOffering : IUtf8JsonSerializable, IJsonModel<InformationProtectionAwsOffering>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<InformationProtectionAwsOffering>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<InformationProtectionAwsOffering>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(InformationProtection))
            {
                writer.WritePropertyName("informationProtection"u8);
                writer.WriteObjectValue(InformationProtection);
            }
            writer.WritePropertyName("offeringType"u8);
            writer.WriteStringValue(OfferingType.ToString());
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(Description))
                {
                    writer.WritePropertyName("description"u8);
                    writer.WriteStringValue(Description);
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

        InformationProtectionAwsOffering IJsonModel<InformationProtectionAwsOffering>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(InformationProtectionAwsOffering)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInformationProtectionAwsOffering(document.RootElement, options);
        }

        internal static InformationProtectionAwsOffering DeserializeInformationProtectionAwsOffering(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AwsInformationProtection> informationProtection = default;
            OfferingType offeringType = default;
            Optional<string> description = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("informationProtection"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    informationProtection = AwsInformationProtection.DeserializeAwsInformationProtection(property.Value);
                    continue;
                }
                if (property.NameEquals("offeringType"u8))
                {
                    offeringType = new OfferingType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new InformationProtectionAwsOffering(offeringType, description.Value, serializedAdditionalRawData, informationProtection.Value);
        }

        BinaryData IModel<InformationProtectionAwsOffering>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(InformationProtectionAwsOffering)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        InformationProtectionAwsOffering IModel<InformationProtectionAwsOffering>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(InformationProtectionAwsOffering)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeInformationProtectionAwsOffering(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<InformationProtectionAwsOffering>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
