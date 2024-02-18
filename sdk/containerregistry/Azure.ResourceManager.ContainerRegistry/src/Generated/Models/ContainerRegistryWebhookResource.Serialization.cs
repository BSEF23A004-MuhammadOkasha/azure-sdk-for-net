// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.ContainerRegistry
{
    public partial class ContainerRegistryWebhookResource : IJsonModel<ContainerRegistryWebhookData>
    {
        void IJsonModel<ContainerRegistryWebhookData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        ContainerRegistryWebhookData IJsonModel<ContainerRegistryWebhookData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<ContainerRegistryWebhookData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<ContainerRegistryWebhookData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        ContainerRegistryWebhookData IPersistableModel<ContainerRegistryWebhookData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<ContainerRegistryWebhookData>(data, options);
        }

        string IPersistableModel<ContainerRegistryWebhookData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
