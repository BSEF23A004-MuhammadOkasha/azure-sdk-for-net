// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    public partial class IntegrationServiceEnvironmentProperties : IUtf8JsonSerializable, IJsonModel<IntegrationServiceEnvironmentProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<IntegrationServiceEnvironmentProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<IntegrationServiceEnvironmentProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IntegrationServiceEnvironmentProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IntegrationServiceEnvironmentProperties)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToString());
            }
            if (Optional.IsDefined(IntegrationServiceEnvironmentId))
            {
                writer.WritePropertyName("integrationServiceEnvironmentId"u8);
                writer.WriteStringValue(IntegrationServiceEnvironmentId);
            }
            if (Optional.IsDefined(EndpointsConfiguration))
            {
                writer.WritePropertyName("endpointsConfiguration"u8);
                writer.WriteObjectValue(EndpointsConfiguration, options);
            }
            if (Optional.IsDefined(NetworkConfiguration))
            {
                writer.WritePropertyName("networkConfiguration"u8);
                writer.WriteObjectValue(NetworkConfiguration, options);
            }
            if (Optional.IsDefined(EncryptionConfiguration))
            {
                writer.WritePropertyName("encryptionConfiguration"u8);
                writer.WriteObjectValue(EncryptionConfiguration, options);
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

        IntegrationServiceEnvironmentProperties IJsonModel<IntegrationServiceEnvironmentProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IntegrationServiceEnvironmentProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IntegrationServiceEnvironmentProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeIntegrationServiceEnvironmentProperties(document.RootElement, options);
        }

        internal static IntegrationServiceEnvironmentProperties DeserializeIntegrationServiceEnvironmentProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            LogicWorkflowProvisioningState? provisioningState = default;
            LogicWorkflowState? state = default;
            string integrationServiceEnvironmentId = default;
            FlowEndpointsConfiguration endpointsConfiguration = default;
            IntegrationServiceNetworkConfiguration networkConfiguration = default;
            IntegrationServiceEnvironmenEncryptionConfiguration encryptionConfiguration = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new LogicWorkflowProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new LogicWorkflowState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("integrationServiceEnvironmentId"u8))
                {
                    integrationServiceEnvironmentId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("endpointsConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endpointsConfiguration = FlowEndpointsConfiguration.DeserializeFlowEndpointsConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("networkConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    networkConfiguration = IntegrationServiceNetworkConfiguration.DeserializeIntegrationServiceNetworkConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("encryptionConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    encryptionConfiguration = IntegrationServiceEnvironmenEncryptionConfiguration.DeserializeIntegrationServiceEnvironmenEncryptionConfiguration(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new IntegrationServiceEnvironmentProperties(
                provisioningState,
                state,
                integrationServiceEnvironmentId,
                endpointsConfiguration,
                networkConfiguration,
                encryptionConfiguration,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<IntegrationServiceEnvironmentProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IntegrationServiceEnvironmentProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(IntegrationServiceEnvironmentProperties)} does not support writing '{options.Format}' format.");
            }
        }

        IntegrationServiceEnvironmentProperties IPersistableModel<IntegrationServiceEnvironmentProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IntegrationServiceEnvironmentProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeIntegrationServiceEnvironmentProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(IntegrationServiceEnvironmentProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<IntegrationServiceEnvironmentProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
