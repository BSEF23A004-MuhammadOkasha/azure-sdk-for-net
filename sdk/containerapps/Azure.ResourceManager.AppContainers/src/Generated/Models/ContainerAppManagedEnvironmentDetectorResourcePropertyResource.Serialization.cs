// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.AppContainers
{
    public partial class ContainerAppManagedEnvironmentDetectorResourcePropertyResource : IJsonModel<ContainerAppManagedEnvironmentData>
    {
        void IJsonModel<ContainerAppManagedEnvironmentData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        ContainerAppManagedEnvironmentData IJsonModel<ContainerAppManagedEnvironmentData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<ContainerAppManagedEnvironmentData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<ContainerAppManagedEnvironmentData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        ContainerAppManagedEnvironmentData IPersistableModel<ContainerAppManagedEnvironmentData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<ContainerAppManagedEnvironmentData>(data, options);
        }

        string IPersistableModel<ContainerAppManagedEnvironmentData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
