// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Compute
{
    public partial class DiskImageResource : IJsonModel<DiskImageData>
    {
        void IJsonModel<DiskImageData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        DiskImageData IJsonModel<DiskImageData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<DiskImageData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<DiskImageData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        DiskImageData IPersistableModel<DiskImageData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<DiskImageData>(data, options);
        }

        string IPersistableModel<DiskImageData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
