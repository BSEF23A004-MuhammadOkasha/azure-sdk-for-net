// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.DataBoxEdge
{
    public partial class DiagnosticRemoteSupportSettingResource : IJsonModel<DiagnosticRemoteSupportSettingData>
    {
        void IJsonModel<DiagnosticRemoteSupportSettingData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        DiagnosticRemoteSupportSettingData IJsonModel<DiagnosticRemoteSupportSettingData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<DiagnosticRemoteSupportSettingData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<DiagnosticRemoteSupportSettingData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        DiagnosticRemoteSupportSettingData IPersistableModel<DiagnosticRemoteSupportSettingData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<DiagnosticRemoteSupportSettingData>(data, options);
        }

        string IPersistableModel<DiagnosticRemoteSupportSettingData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
