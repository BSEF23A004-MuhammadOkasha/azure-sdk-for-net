// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    internal partial class IntegrationRuntimeCustomerVirtualNetwork : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(SubnetId))
            {
                writer.WritePropertyName("subnetId");
                writer.WriteStringValue(SubnetId);
            }
            writer.WriteEndObject();
        }

        internal static IntegrationRuntimeCustomerVirtualNetwork DeserializeIntegrationRuntimeCustomerVirtualNetwork(JsonElement element)
        {
            Optional<ResourceIdentifier> subnetId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("subnetId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    subnetId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
            }
            return new IntegrationRuntimeCustomerVirtualNetwork(subnetId.Value);
        }
    }
}
