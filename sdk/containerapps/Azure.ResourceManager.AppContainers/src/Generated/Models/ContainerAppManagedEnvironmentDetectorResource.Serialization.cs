// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.AppContainers
{
    public partial class ContainerAppManagedEnvironmentDetectorResource : IJsonModel<ContainerAppDiagnosticData>
    {
        void IJsonModel<ContainerAppDiagnosticData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        ContainerAppDiagnosticData IJsonModel<ContainerAppDiagnosticData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<ContainerAppDiagnosticData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<ContainerAppDiagnosticData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        ContainerAppDiagnosticData IPersistableModel<ContainerAppDiagnosticData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<ContainerAppDiagnosticData>(data, options);
        }

        string IPersistableModel<ContainerAppDiagnosticData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
