// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.CustomerInsights
{
    public partial class RoleAssignmentResourceFormatResource : IJsonModel<RoleAssignmentResourceFormatData>
    {
        void IJsonModel<RoleAssignmentResourceFormatData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        RoleAssignmentResourceFormatData IJsonModel<RoleAssignmentResourceFormatData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<RoleAssignmentResourceFormatData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<RoleAssignmentResourceFormatData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        RoleAssignmentResourceFormatData IPersistableModel<RoleAssignmentResourceFormatData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<RoleAssignmentResourceFormatData>(data, options);
        }

        string IPersistableModel<RoleAssignmentResourceFormatData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
