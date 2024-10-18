// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.ContainerOrchestratorRuntime
{
    public partial class ConnectedClusterServiceResource : IJsonModel<ConnectedClusterServiceData>
    {
        void IJsonModel<ConnectedClusterServiceData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<ConnectedClusterServiceData>)Data).Write(writer, options);

        ConnectedClusterServiceData IJsonModel<ConnectedClusterServiceData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<ConnectedClusterServiceData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<ConnectedClusterServiceData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        ConnectedClusterServiceData IPersistableModel<ConnectedClusterServiceData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<ConnectedClusterServiceData>(data, options);

        string IPersistableModel<ConnectedClusterServiceData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<ConnectedClusterServiceData>)Data).GetFormatFromOptions(options);
    }
}
