// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    internal partial class PyTorch : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ProcessCountPerInstance))
            {
                if (ProcessCountPerInstance != null)
                {
                    writer.WritePropertyName("processCountPerInstance");
                    writer.WriteNumberValue(ProcessCountPerInstance.Value);
                }
                else
                {
                    writer.WriteNull("processCountPerInstance");
                }
            }
            writer.WritePropertyName("distributionType");
            writer.WriteStringValue(DistributionType.ToString());
            writer.WriteEndObject();
        }

        internal static PyTorch DeserializePyTorch(JsonElement element)
        {
            Optional<int?> processCountPerInstance = default;
            DistributionType distributionType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("processCountPerInstance"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        processCountPerInstance = null;
                        continue;
                    }
                    processCountPerInstance = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("distributionType"))
                {
                    distributionType = new DistributionType(property.Value.GetString());
                    continue;
                }
            }
            return new PyTorch(distributionType, Optional.ToNullable(processCountPerInstance));
        }
    }
}
