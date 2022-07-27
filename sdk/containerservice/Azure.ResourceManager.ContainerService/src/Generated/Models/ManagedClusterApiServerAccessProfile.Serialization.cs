// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerService.Models
{
    public partial class ManagedClusterApiServerAccessProfile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(AuthorizedIPRanges))
            {
                writer.WritePropertyName("authorizedIPRanges");
                writer.WriteStartArray();
                foreach (var item in AuthorizedIPRanges)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(EnablePrivateCluster))
            {
                writer.WritePropertyName("enablePrivateCluster");
                writer.WriteBooleanValue(EnablePrivateCluster.Value);
            }
            if (Optional.IsDefined(PrivateDnsZone))
            {
                writer.WritePropertyName("privateDNSZone");
                writer.WriteStringValue(PrivateDnsZone);
            }
            if (Optional.IsDefined(EnablePrivateClusterPublicFqdn))
            {
                writer.WritePropertyName("enablePrivateClusterPublicFQDN");
                writer.WriteBooleanValue(EnablePrivateClusterPublicFqdn.Value);
            }
            if (Optional.IsDefined(DisableRunCommand))
            {
                writer.WritePropertyName("disableRunCommand");
                writer.WriteBooleanValue(DisableRunCommand.Value);
            }
            writer.WriteEndObject();
        }

        internal static ManagedClusterApiServerAccessProfile DeserializeManagedClusterApiServerAccessProfile(JsonElement element)
        {
            Optional<IList<string>> authorizedIPRanges = default;
            Optional<bool> enablePrivateCluster = default;
            Optional<string> privateDnsZone = default;
            Optional<bool> enablePrivateClusterPublicFQDN = default;
            Optional<bool> disableRunCommand = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("authorizedIPRanges"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    authorizedIPRanges = array;
                    continue;
                }
                if (property.NameEquals("enablePrivateCluster"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    enablePrivateCluster = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("privateDNSZone"))
                {
                    privateDnsZone = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("enablePrivateClusterPublicFQDN"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    enablePrivateClusterPublicFQDN = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("disableRunCommand"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    disableRunCommand = property.Value.GetBoolean();
                    continue;
                }
            }
            return new ManagedClusterApiServerAccessProfile(Optional.ToList(authorizedIPRanges), Optional.ToNullable(enablePrivateCluster), privateDnsZone.Value, Optional.ToNullable(enablePrivateClusterPublicFQDN), Optional.ToNullable(disableRunCommand));
        }
    }
}
