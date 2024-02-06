// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(IntegrationRuntimeComputePropertiesConverter))]
    public partial class IntegrationRuntimeComputeProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location);
            }
            if (Optional.IsDefined(NodeSize))
            {
                writer.WritePropertyName("nodeSize"u8);
                writer.WriteStringValue(NodeSize);
            }
            if (Optional.IsDefined(NumberOfNodes))
            {
                writer.WritePropertyName("numberOfNodes"u8);
                writer.WriteNumberValue(NumberOfNodes.Value);
            }
            if (Optional.IsDefined(MaxParallelExecutionsPerNode))
            {
                writer.WritePropertyName("maxParallelExecutionsPerNode"u8);
                writer.WriteNumberValue(MaxParallelExecutionsPerNode.Value);
            }
            if (Optional.IsDefined(DataFlowProperties))
            {
                writer.WritePropertyName("dataFlowProperties"u8);
                writer.WriteObjectValue(DataFlowProperties);
            }
            if (Optional.IsDefined(VNetProperties))
            {
                writer.WritePropertyName("vNetProperties"u8);
                writer.WriteObjectValue(VNetProperties);
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static IntegrationRuntimeComputeProperties DeserializeIntegrationRuntimeComputeProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> location = default;
            Optional<string> nodeSize = default;
            Optional<int> numberOfNodes = default;
            Optional<int> maxParallelExecutionsPerNode = default;
            Optional<IntegrationRuntimeDataFlowProperties> dataFlowProperties = default;
            Optional<IntegrationRuntimeVNetProperties> vNetProperties = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("location"u8))
                {
                    location = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("nodeSize"u8))
                {
                    nodeSize = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("numberOfNodes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    numberOfNodes = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxParallelExecutionsPerNode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxParallelExecutionsPerNode = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("dataFlowProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataFlowProperties = IntegrationRuntimeDataFlowProperties.DeserializeIntegrationRuntimeDataFlowProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("vNetProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    vNetProperties = IntegrationRuntimeVNetProperties.DeserializeIntegrationRuntimeVNetProperties(property.Value);
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new IntegrationRuntimeComputeProperties(location.Value, nodeSize.Value, Optional.ToNullable(numberOfNodes), Optional.ToNullable(maxParallelExecutionsPerNode), dataFlowProperties.Value, vNetProperties.Value, additionalProperties);
        }

        internal partial class IntegrationRuntimeComputePropertiesConverter : JsonConverter<IntegrationRuntimeComputeProperties>
        {
            public override void Write(Utf8JsonWriter writer, IntegrationRuntimeComputeProperties model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }

            public override IntegrationRuntimeComputeProperties Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeIntegrationRuntimeComputeProperties(document.RootElement);
            }
        }
    }
}
