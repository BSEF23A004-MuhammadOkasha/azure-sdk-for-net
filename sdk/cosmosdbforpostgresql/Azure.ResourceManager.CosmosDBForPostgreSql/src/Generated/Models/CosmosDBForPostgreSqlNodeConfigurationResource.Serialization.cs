// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.CosmosDBForPostgreSql
{
    public partial class CosmosDBForPostgreSqlNodeConfigurationResource : IJsonModel<CosmosDBForPostgreSqlServerConfigurationData>
    {
        void IJsonModel<CosmosDBForPostgreSqlServerConfigurationData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        CosmosDBForPostgreSqlServerConfigurationData IJsonModel<CosmosDBForPostgreSqlServerConfigurationData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<CosmosDBForPostgreSqlServerConfigurationData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<CosmosDBForPostgreSqlServerConfigurationData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        CosmosDBForPostgreSqlServerConfigurationData IPersistableModel<CosmosDBForPostgreSqlServerConfigurationData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<CosmosDBForPostgreSqlServerConfigurationData>(data, options);
        }

        string IPersistableModel<CosmosDBForPostgreSqlServerConfigurationData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
