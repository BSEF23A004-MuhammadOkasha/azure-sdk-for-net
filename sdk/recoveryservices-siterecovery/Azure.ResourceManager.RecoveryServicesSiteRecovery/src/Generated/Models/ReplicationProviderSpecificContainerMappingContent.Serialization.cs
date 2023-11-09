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
    [ModelReaderProxy(typeof(UnknownReplicationProviderSpecificContainerMappingContent))]
    public partial class ReplicationProviderSpecificContainerMappingContent : IUtf8JsonSerializable, IJsonModel<ReplicationProviderSpecificContainerMappingContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ReplicationProviderSpecificContainerMappingContent>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<ReplicationProviderSpecificContainerMappingContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
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

        ReplicationProviderSpecificContainerMappingContent IJsonModel<ReplicationProviderSpecificContainerMappingContent>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ReplicationProviderSpecificContainerMappingContent)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeReplicationProviderSpecificContainerMappingContent(document.RootElement, options);
        }

        internal static ReplicationProviderSpecificContainerMappingContent DeserializeReplicationProviderSpecificContainerMappingContent(JsonElement element, ModelReaderWriterOptions options = null)
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
                    case "A2A": return A2AContainerMappingContent.DeserializeA2AContainerMappingContent(element);
                    case "VMwareCbt": return VMwareCbtContainerMappingContent.DeserializeVMwareCbtContainerMappingContent(element);
                }
            }
            return UnknownReplicationProviderSpecificContainerMappingContent.DeserializeUnknownReplicationProviderSpecificContainerMappingContent(element);
        }

        BinaryData IModel<ReplicationProviderSpecificContainerMappingContent>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ReplicationProviderSpecificContainerMappingContent)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        ReplicationProviderSpecificContainerMappingContent IModel<ReplicationProviderSpecificContainerMappingContent>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ReplicationProviderSpecificContainerMappingContent)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeReplicationProviderSpecificContainerMappingContent(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<ReplicationProviderSpecificContainerMappingContent>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
