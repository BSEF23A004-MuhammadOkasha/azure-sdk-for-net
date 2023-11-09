// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    [ModelReaderProxy(typeof(UnknownNetworkMappingFabricSpecificSettings))]
    public partial class NetworkMappingFabricSpecificSettings : IUtf8JsonSerializable, IJsonModel<NetworkMappingFabricSpecificSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NetworkMappingFabricSpecificSettings>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<NetworkMappingFabricSpecificSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("instanceType"u8);
            writer.WriteStringValue(InstanceType);
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

        NetworkMappingFabricSpecificSettings IJsonModel<NetworkMappingFabricSpecificSettings>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(NetworkMappingFabricSpecificSettings)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNetworkMappingFabricSpecificSettings(document.RootElement, options);
        }

        internal static NetworkMappingFabricSpecificSettings DeserializeNetworkMappingFabricSpecificSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("instanceType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AzureToAzure": return A2ANetworkMappingSettings.DeserializeA2ANetworkMappingSettings(element);
                    case "VmmToAzure": return VmmToAzureNetworkMappingSettings.DeserializeVmmToAzureNetworkMappingSettings(element);
                    case "VmmToVmm": return VmmToVmmNetworkMappingSettings.DeserializeVmmToVmmNetworkMappingSettings(element);
                }
            }
            return UnknownNetworkMappingFabricSpecificSettings.DeserializeUnknownNetworkMappingFabricSpecificSettings(element);
        }

        BinaryData IModel<NetworkMappingFabricSpecificSettings>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(NetworkMappingFabricSpecificSettings)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        NetworkMappingFabricSpecificSettings IModel<NetworkMappingFabricSpecificSettings>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(NetworkMappingFabricSpecificSettings)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeNetworkMappingFabricSpecificSettings(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<NetworkMappingFabricSpecificSettings>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
