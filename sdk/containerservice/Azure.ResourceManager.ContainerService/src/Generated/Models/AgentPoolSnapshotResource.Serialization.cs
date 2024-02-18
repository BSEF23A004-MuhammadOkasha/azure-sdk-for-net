// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.ContainerService
{
    public partial class AgentPoolSnapshotResource : IJsonModel<AgentPoolSnapshotData>
    {
        void IJsonModel<AgentPoolSnapshotData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        AgentPoolSnapshotData IJsonModel<AgentPoolSnapshotData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<AgentPoolSnapshotData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<AgentPoolSnapshotData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        AgentPoolSnapshotData IPersistableModel<AgentPoolSnapshotData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<AgentPoolSnapshotData>(data, options);
        }

        string IPersistableModel<AgentPoolSnapshotData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
