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
    [PersistableModelProxy(typeof(UnknownApplyRecoveryPointProviderSpecificContent))]
    public partial class SiteRecoveryApplyRecoveryPointProviderSpecificContent : IUtf8JsonSerializable, IJsonModel<SiteRecoveryApplyRecoveryPointProviderSpecificContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SiteRecoveryApplyRecoveryPointProviderSpecificContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SiteRecoveryApplyRecoveryPointProviderSpecificContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryApplyRecoveryPointProviderSpecificContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(SiteRecoveryApplyRecoveryPointProviderSpecificContent)} does not support '{format}' format.");
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

        SiteRecoveryApplyRecoveryPointProviderSpecificContent IJsonModel<SiteRecoveryApplyRecoveryPointProviderSpecificContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryApplyRecoveryPointProviderSpecificContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(SiteRecoveryApplyRecoveryPointProviderSpecificContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSiteRecoveryApplyRecoveryPointProviderSpecificContent(document.RootElement, options);
        }

        internal static SiteRecoveryApplyRecoveryPointProviderSpecificContent DeserializeSiteRecoveryApplyRecoveryPointProviderSpecificContent(JsonElement element, ModelReaderWriterOptions options = null)
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
                    case "A2A": return A2AApplyRecoveryPointContent.DeserializeA2AApplyRecoveryPointContent(element);
                    case "A2ACrossClusterMigration": return A2ACrossClusterMigrationApplyRecoveryPointContent.DeserializeA2ACrossClusterMigrationApplyRecoveryPointContent(element);
                    case "HyperVReplicaAzure": return HyperVReplicaAzureApplyRecoveryPointContent.DeserializeHyperVReplicaAzureApplyRecoveryPointContent(element);
                    case "InMageAzureV2": return InMageAzureV2ApplyRecoveryPointContent.DeserializeInMageAzureV2ApplyRecoveryPointContent(element);
                    case "InMageRcm": return InMageRcmApplyRecoveryPointContent.DeserializeInMageRcmApplyRecoveryPointContent(element);
                }
            }
            return UnknownApplyRecoveryPointProviderSpecificContent.DeserializeUnknownApplyRecoveryPointProviderSpecificContent(element);
        }

        BinaryData IPersistableModel<SiteRecoveryApplyRecoveryPointProviderSpecificContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryApplyRecoveryPointProviderSpecificContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(SiteRecoveryApplyRecoveryPointProviderSpecificContent)} does not support '{options.Format}' format.");
            }
        }

        SiteRecoveryApplyRecoveryPointProviderSpecificContent IPersistableModel<SiteRecoveryApplyRecoveryPointProviderSpecificContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryApplyRecoveryPointProviderSpecificContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSiteRecoveryApplyRecoveryPointProviderSpecificContent(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(SiteRecoveryApplyRecoveryPointProviderSpecificContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SiteRecoveryApplyRecoveryPointProviderSpecificContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
