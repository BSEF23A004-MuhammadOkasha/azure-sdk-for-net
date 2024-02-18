// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Compute
{
    public partial class DedicatedHostGroupResource : IJsonModel<DedicatedHostGroupData>
    {
        void IJsonModel<DedicatedHostGroupData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        DedicatedHostGroupData IJsonModel<DedicatedHostGroupData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<DedicatedHostGroupData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<DedicatedHostGroupData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        DedicatedHostGroupData IPersistableModel<DedicatedHostGroupData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<DedicatedHostGroupData>(data, options);
        }

        string IPersistableModel<DedicatedHostGroupData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
