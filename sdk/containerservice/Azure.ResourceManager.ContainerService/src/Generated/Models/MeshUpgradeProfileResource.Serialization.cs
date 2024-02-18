// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.ContainerService
{
    public partial class MeshUpgradeProfileResource : IJsonModel<MeshUpgradeProfileData>
    {
        void IJsonModel<MeshUpgradeProfileData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        MeshUpgradeProfileData IJsonModel<MeshUpgradeProfileData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<MeshUpgradeProfileData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<MeshUpgradeProfileData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        MeshUpgradeProfileData IPersistableModel<MeshUpgradeProfileData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<MeshUpgradeProfileData>(data, options);
        }

        string IPersistableModel<MeshUpgradeProfileData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
