// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class ProtectionContainerProperties
    {
        internal static ProtectionContainerProperties DeserializeProtectionContainerProperties(JsonElement element)
        {
            Optional<string> fabricFriendlyName = default;
            Optional<string> friendlyName = default;
            Optional<string> fabricType = default;
            Optional<int> protectedItemCount = default;
            Optional<string> pairingStatus = default;
            Optional<string> role = default;
            Optional<ProtectionContainerFabricSpecificDetails> fabricSpecificDetails = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("fabricFriendlyName"))
                {
                    fabricFriendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("friendlyName"))
                {
                    friendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fabricType"))
                {
                    fabricType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("protectedItemCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    protectedItemCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("pairingStatus"))
                {
                    pairingStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("role"))
                {
                    role = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fabricSpecificDetails"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    fabricSpecificDetails = ProtectionContainerFabricSpecificDetails.DeserializeProtectionContainerFabricSpecificDetails(property.Value);
                    continue;
                }
            }
            return new ProtectionContainerProperties(fabricFriendlyName.Value, friendlyName.Value, fabricType.Value, Optional.ToNullable(protectedItemCount), pairingStatus.Value, role.Value, fabricSpecificDetails.Value);
        }
    }
}
