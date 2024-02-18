// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.DataMigration
{
    public partial class ServiceProjectTaskResource : IJsonModel<ProjectTaskData>
    {
        void IJsonModel<ProjectTaskData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        ProjectTaskData IJsonModel<ProjectTaskData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<ProjectTaskData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<ProjectTaskData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        ProjectTaskData IPersistableModel<ProjectTaskData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<ProjectTaskData>(data, options);
        }

        string IPersistableModel<ProjectTaskData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
