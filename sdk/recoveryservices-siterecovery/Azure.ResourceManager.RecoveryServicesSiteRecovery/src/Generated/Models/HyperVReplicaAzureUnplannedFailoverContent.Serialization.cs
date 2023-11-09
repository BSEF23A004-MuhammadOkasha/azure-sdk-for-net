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
    public partial class HyperVReplicaAzureUnplannedFailoverContent : IUtf8JsonSerializable, IJsonModel<HyperVReplicaAzureUnplannedFailoverContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HyperVReplicaAzureUnplannedFailoverContent>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<HyperVReplicaAzureUnplannedFailoverContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(PrimaryKekCertificatePfx))
            {
                writer.WritePropertyName("primaryKekCertificatePfx"u8);
                writer.WriteStringValue(PrimaryKekCertificatePfx);
            }
            if (Optional.IsDefined(SecondaryKekCertificatePfx))
            {
                writer.WritePropertyName("secondaryKekCertificatePfx"u8);
                writer.WriteStringValue(SecondaryKekCertificatePfx);
            }
            if (Optional.IsDefined(RecoveryPointId))
            {
                writer.WritePropertyName("recoveryPointId"u8);
                writer.WriteStringValue(RecoveryPointId);
            }
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

        HyperVReplicaAzureUnplannedFailoverContent IJsonModel<HyperVReplicaAzureUnplannedFailoverContent>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(HyperVReplicaAzureUnplannedFailoverContent)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHyperVReplicaAzureUnplannedFailoverContent(document.RootElement, options);
        }

        internal static HyperVReplicaAzureUnplannedFailoverContent DeserializeHyperVReplicaAzureUnplannedFailoverContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> primaryKekCertificatePfx = default;
            Optional<string> secondaryKekCertificatePfx = default;
            Optional<ResourceIdentifier> recoveryPointId = default;
            string instanceType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("primaryKekCertificatePfx"u8))
                {
                    primaryKekCertificatePfx = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secondaryKekCertificatePfx"u8))
                {
                    secondaryKekCertificatePfx = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recoveryPointId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryPointId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("instanceType"u8))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new HyperVReplicaAzureUnplannedFailoverContent(instanceType, serializedAdditionalRawData, primaryKekCertificatePfx.Value, secondaryKekCertificatePfx.Value, recoveryPointId.Value);
        }

        BinaryData IModel<HyperVReplicaAzureUnplannedFailoverContent>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(HyperVReplicaAzureUnplannedFailoverContent)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        HyperVReplicaAzureUnplannedFailoverContent IModel<HyperVReplicaAzureUnplannedFailoverContent>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(HyperVReplicaAzureUnplannedFailoverContent)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeHyperVReplicaAzureUnplannedFailoverContent(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<HyperVReplicaAzureUnplannedFailoverContent>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
