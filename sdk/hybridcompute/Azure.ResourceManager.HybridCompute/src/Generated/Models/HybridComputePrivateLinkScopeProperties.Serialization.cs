// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridCompute.Models
{
    public partial class HybridComputePrivateLinkScopeProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(PublicNetworkAccess))
            {
                writer.WritePropertyName("publicNetworkAccess"u8);
                writer.WriteStringValue(PublicNetworkAccess.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static HybridComputePrivateLinkScopeProperties DeserializeHybridComputePrivateLinkScopeProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<HybridComputePublicNetworkAccessType> publicNetworkAccess = default;
            Optional<string> provisioningState = default;
            Optional<string> privateLinkScopeId = default;
            Optional<IReadOnlyList<PrivateEndpointConnectionDataModel>> privateEndpointConnections = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("publicNetworkAccess"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    publicNetworkAccess = new HybridComputePublicNetworkAccessType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    provisioningState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("privateLinkScopeId"u8))
                {
                    privateLinkScopeId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("privateEndpointConnections"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PrivateEndpointConnectionDataModel> array = new List<PrivateEndpointConnectionDataModel>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PrivateEndpointConnectionDataModel.DeserializePrivateEndpointConnectionDataModel(item));
                    }
                    privateEndpointConnections = array;
                    continue;
                }
            }
            return new HybridComputePrivateLinkScopeProperties(Optional.ToNullable(publicNetworkAccess), provisioningState.Value, privateLinkScopeId.Value, Optional.ToList(privateEndpointConnections));
        }
    }
}
