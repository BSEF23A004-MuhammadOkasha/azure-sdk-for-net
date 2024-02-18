// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.DataLakeStore
{
    public partial class DataLakeStoreVirtualNetworkRuleResource : IJsonModel<DataLakeStoreVirtualNetworkRuleData>
    {
        void IJsonModel<DataLakeStoreVirtualNetworkRuleData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        DataLakeStoreVirtualNetworkRuleData IJsonModel<DataLakeStoreVirtualNetworkRuleData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<DataLakeStoreVirtualNetworkRuleData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<DataLakeStoreVirtualNetworkRuleData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        DataLakeStoreVirtualNetworkRuleData IPersistableModel<DataLakeStoreVirtualNetworkRuleData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<DataLakeStoreVirtualNetworkRuleData>(data, options);
        }

        string IPersistableModel<DataLakeStoreVirtualNetworkRuleData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
