// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Compute
{
    public partial class RestorePointGroupResource : IJsonModel<RestorePointGroupData>
    {
        void IJsonModel<RestorePointGroupData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        RestorePointGroupData IJsonModel<RestorePointGroupData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<RestorePointGroupData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<RestorePointGroupData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        RestorePointGroupData IPersistableModel<RestorePointGroupData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<RestorePointGroupData>(data, options);
        }

        string IPersistableModel<RestorePointGroupData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
