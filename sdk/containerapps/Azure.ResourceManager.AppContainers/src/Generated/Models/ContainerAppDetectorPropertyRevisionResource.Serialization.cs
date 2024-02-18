// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.AppContainers
{
    public partial class ContainerAppDetectorPropertyRevisionResource : IJsonModel<ContainerAppRevisionData>
    {
        void IJsonModel<ContainerAppRevisionData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        ContainerAppRevisionData IJsonModel<ContainerAppRevisionData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<ContainerAppRevisionData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<ContainerAppRevisionData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        ContainerAppRevisionData IPersistableModel<ContainerAppRevisionData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<ContainerAppRevisionData>(data, options);
        }

        string IPersistableModel<ContainerAppRevisionData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
