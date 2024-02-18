// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.CustomerInsights
{
    public partial class ViewResourceFormatResource : IJsonModel<ViewResourceFormatData>
    {
        void IJsonModel<ViewResourceFormatData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        ViewResourceFormatData IJsonModel<ViewResourceFormatData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<ViewResourceFormatData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<ViewResourceFormatData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        ViewResourceFormatData IPersistableModel<ViewResourceFormatData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<ViewResourceFormatData>(data, options);
        }

        string IPersistableModel<ViewResourceFormatData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
