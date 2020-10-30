// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    public partial class SapTablePartitionSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(PartitionColumnName))
            {
                writer.WritePropertyName("partitionColumnName");
                writer.WriteObjectValue(PartitionColumnName);
            }
            if (Optional.IsDefined(PartitionUpperBound))
            {
                writer.WritePropertyName("partitionUpperBound");
                writer.WriteObjectValue(PartitionUpperBound);
            }
            if (Optional.IsDefined(PartitionLowerBound))
            {
                writer.WritePropertyName("partitionLowerBound");
                writer.WriteObjectValue(PartitionLowerBound);
            }
            if (Optional.IsDefined(MaxPartitionsNumber))
            {
                writer.WritePropertyName("maxPartitionsNumber");
                writer.WriteObjectValue(MaxPartitionsNumber);
            }
            writer.WriteEndObject();
        }

        internal static SapTablePartitionSettings DeserializeSapTablePartitionSettings(JsonElement element)
        {
            Optional<object> partitionColumnName = default;
            Optional<object> partitionUpperBound = default;
            Optional<object> partitionLowerBound = default;
            Optional<object> maxPartitionsNumber = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("partitionColumnName"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    partitionColumnName = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("partitionUpperBound"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    partitionUpperBound = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("partitionLowerBound"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    partitionLowerBound = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("maxPartitionsNumber"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    maxPartitionsNumber = property.Value.GetObject();
                    continue;
                }
            }
            return new SapTablePartitionSettings(partitionColumnName.Value, partitionUpperBound.Value, partitionLowerBound.Value, maxPartitionsNumber.Value);
        }
    }
}
