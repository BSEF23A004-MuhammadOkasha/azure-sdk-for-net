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
    public partial class SiteRecoveryCreateReplicationNetworkMappingProperties : IUtf8JsonSerializable, IJsonModel<SiteRecoveryCreateReplicationNetworkMappingProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SiteRecoveryCreateReplicationNetworkMappingProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SiteRecoveryCreateReplicationNetworkMappingProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryCreateReplicationNetworkMappingProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(SiteRecoveryCreateReplicationNetworkMappingProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(RecoveryFabricName))
            {
                writer.WritePropertyName("recoveryFabricName"u8);
                writer.WriteStringValue(RecoveryFabricName);
            }
            writer.WritePropertyName("recoveryNetworkId"u8);
            writer.WriteStringValue(RecoveryNetworkId);
            if (Optional.IsDefined(FabricSpecificDetails))
            {
                writer.WritePropertyName("fabricSpecificDetails"u8);
                writer.WriteObjectValue(FabricSpecificDetails);
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
            writer.WriteEndObject();
        }

        SiteRecoveryCreateReplicationNetworkMappingProperties IJsonModel<SiteRecoveryCreateReplicationNetworkMappingProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryCreateReplicationNetworkMappingProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(SiteRecoveryCreateReplicationNetworkMappingProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSiteRecoveryCreateReplicationNetworkMappingProperties(document.RootElement, options);
        }

        internal static SiteRecoveryCreateReplicationNetworkMappingProperties DeserializeSiteRecoveryCreateReplicationNetworkMappingProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> recoveryFabricName = default;
            ResourceIdentifier recoveryNetworkId = default;
            Optional<FabricSpecificCreateNetworkMappingContent> fabricSpecificDetails = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("recoveryFabricName"u8))
                {
                    recoveryFabricName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recoveryNetworkId"u8))
                {
                    recoveryNetworkId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("fabricSpecificDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fabricSpecificDetails = FabricSpecificCreateNetworkMappingContent.DeserializeFabricSpecificCreateNetworkMappingContent(property.Value);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SiteRecoveryCreateReplicationNetworkMappingProperties(recoveryFabricName.Value, recoveryNetworkId, fabricSpecificDetails.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SiteRecoveryCreateReplicationNetworkMappingProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryCreateReplicationNetworkMappingProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(SiteRecoveryCreateReplicationNetworkMappingProperties)} does not support '{options.Format}' format.");
            }
        }

        SiteRecoveryCreateReplicationNetworkMappingProperties IPersistableModel<SiteRecoveryCreateReplicationNetworkMappingProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryCreateReplicationNetworkMappingProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSiteRecoveryCreateReplicationNetworkMappingProperties(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(SiteRecoveryCreateReplicationNetworkMappingProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SiteRecoveryCreateReplicationNetworkMappingProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
