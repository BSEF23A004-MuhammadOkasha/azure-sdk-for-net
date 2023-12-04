// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    [PersistableModelProxy(typeof(UnknownEnableProtectionProviderSpecificContent))]
    public partial class EnableProtectionProviderSpecificContent : IUtf8JsonSerializable, IJsonModel<EnableProtectionProviderSpecificContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EnableProtectionProviderSpecificContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<EnableProtectionProviderSpecificContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EnableProtectionProviderSpecificContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(EnableProtectionProviderSpecificContent)} does not support '{format}' format.");
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

        EnableProtectionProviderSpecificContent IJsonModel<EnableProtectionProviderSpecificContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EnableProtectionProviderSpecificContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(EnableProtectionProviderSpecificContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEnableProtectionProviderSpecificContent(document.RootElement, options);
        }

        internal static EnableProtectionProviderSpecificContent DeserializeEnableProtectionProviderSpecificContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("instanceType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "A2A": return A2AEnableProtectionContent.DeserializeA2AEnableProtectionContent(element);
                    case "A2ACrossClusterMigration": return A2ACrossClusterMigrationEnableProtectionContent.DeserializeA2ACrossClusterMigrationEnableProtectionContent(element);
                    case "HyperVReplicaAzure": return HyperVReplicaAzureEnableProtectionContent.DeserializeHyperVReplicaAzureEnableProtectionContent(element);
                    case "InMage": return InMageEnableProtectionContent.DeserializeInMageEnableProtectionContent(element);
                    case "InMageAzureV2": return InMageAzureV2EnableProtectionContent.DeserializeInMageAzureV2EnableProtectionContent(element);
                    case "InMageRcm": return InMageRcmEnableProtectionContent.DeserializeInMageRcmEnableProtectionContent(element);
                }
            }
            return UnknownEnableProtectionProviderSpecificContent.DeserializeUnknownEnableProtectionProviderSpecificContent(element);
        }

        BinaryData IPersistableModel<EnableProtectionProviderSpecificContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EnableProtectionProviderSpecificContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(EnableProtectionProviderSpecificContent)} does not support '{options.Format}' format.");
            }
        }

        EnableProtectionProviderSpecificContent IPersistableModel<EnableProtectionProviderSpecificContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EnableProtectionProviderSpecificContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeEnableProtectionProviderSpecificContent(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(EnableProtectionProviderSpecificContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<EnableProtectionProviderSpecificContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
