// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Datadog
{
    public partial class DatadogMonitorResource : IJsonModel<DatadogMonitorResourceData>
    {
        void IJsonModel<DatadogMonitorResourceData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        DatadogMonitorResourceData IJsonModel<DatadogMonitorResourceData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<DatadogMonitorResourceData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<DatadogMonitorResourceData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        DatadogMonitorResourceData IPersistableModel<DatadogMonitorResourceData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<DatadogMonitorResourceData>(data, options);
        }

        string IPersistableModel<DatadogMonitorResourceData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
