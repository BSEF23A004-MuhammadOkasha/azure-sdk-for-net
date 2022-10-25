// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class RecoveryServicesBackupPrivateEndpointConnection : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState");
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Optional.IsDefined(PrivateEndpoint))
            {
                writer.WritePropertyName("privateEndpoint");
                JsonSerializer.Serialize(writer, PrivateEndpoint);
            }
            if (Optional.IsDefined(PrivateLinkServiceConnectionState))
            {
                writer.WritePropertyName("privateLinkServiceConnectionState");
                writer.WriteObjectValue(PrivateLinkServiceConnectionState);
            }
            writer.WriteEndObject();
        }

        internal static RecoveryServicesBackupPrivateEndpointConnection DeserializeRecoveryServicesBackupPrivateEndpointConnection(JsonElement element)
        {
            Optional<ProvisioningState> provisioningState = default;
            Optional<WritableSubResource> privateEndpoint = default;
            Optional<RecoveryServicesBackupPrivateLinkServiceConnectionState> privateLinkServiceConnectionState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisioningState"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    provisioningState = new ProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("privateEndpoint"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    privateEndpoint = JsonSerializer.Deserialize<WritableSubResource>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("privateLinkServiceConnectionState"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    privateLinkServiceConnectionState = RecoveryServicesBackupPrivateLinkServiceConnectionState.DeserializeRecoveryServicesBackupPrivateLinkServiceConnectionState(property.Value);
                    continue;
                }
            }
            return new RecoveryServicesBackupPrivateEndpointConnection(Optional.ToNullable(provisioningState), privateEndpoint, privateLinkServiceConnectionState.Value);
        }
    }
}
