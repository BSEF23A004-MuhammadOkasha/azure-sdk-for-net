// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.DataShare
{
    public partial class DataShareResource : IJsonModel<DataShareData>
    {
        void IJsonModel<DataShareData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        DataShareData IJsonModel<DataShareData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<DataShareData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<DataShareData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        DataShareData IPersistableModel<DataShareData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<DataShareData>(data, options);
        }

        string IPersistableModel<DataShareData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
