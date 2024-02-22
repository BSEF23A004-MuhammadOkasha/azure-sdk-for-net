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
    [JsonConverter(typeof(WorkspaceConverter))]
    public partial class Workspace : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity"u8);
                writer.WriteObjectValue(Identity);
            }
            if (!(Tags is ChangeTrackingDictionary<string, string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(DefaultDataLakeStorage))
            {
                writer.WritePropertyName("defaultDataLakeStorage"u8);
                writer.WriteObjectValue(DefaultDataLakeStorage);
            }
            if (Optional.IsDefined(SqlAdministratorLoginPassword))
            {
                writer.WritePropertyName("sqlAdministratorLoginPassword"u8);
                writer.WriteStringValue(SqlAdministratorLoginPassword);
            }
            if (Optional.IsDefined(ManagedResourceGroupName))
            {
                writer.WritePropertyName("managedResourceGroupName"u8);
                writer.WriteStringValue(ManagedResourceGroupName);
            }
            if (Optional.IsDefined(SqlAdministratorLogin))
            {
                writer.WritePropertyName("sqlAdministratorLogin"u8);
                writer.WriteStringValue(SqlAdministratorLogin);
            }
            if (Optional.IsDefined(VirtualNetworkProfile))
            {
                writer.WritePropertyName("virtualNetworkProfile"u8);
                writer.WriteObjectValue(VirtualNetworkProfile);
            }
            if (!(ConnectivityEndpoints is ChangeTrackingDictionary<string, string> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("connectivityEndpoints"u8);
                writer.WriteStartObject();
                foreach (var item in ConnectivityEndpoints)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(ManagedVirtualNetwork))
            {
                writer.WritePropertyName("managedVirtualNetwork"u8);
                writer.WriteStringValue(ManagedVirtualNetwork);
            }
            if (!(PrivateEndpointConnections is ChangeTrackingList<PrivateEndpointConnection> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("privateEndpointConnections"u8);
                writer.WriteStartArray();
                foreach (var item in PrivateEndpointConnections)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Encryption))
            {
                writer.WritePropertyName("encryption"u8);
                writer.WriteObjectValue(Encryption);
            }
            if (Optional.IsDefined(ManagedVirtualNetworkSettings))
            {
                writer.WritePropertyName("managedVirtualNetworkSettings"u8);
                writer.WriteObjectValue(ManagedVirtualNetworkSettings);
            }
            if (Optional.IsDefined(WorkspaceRepositoryConfiguration))
            {
                writer.WritePropertyName("workspaceRepositoryConfiguration"u8);
                writer.WriteObjectValue(WorkspaceRepositoryConfiguration);
            }
            if (Optional.IsDefined(PurviewConfiguration))
            {
                writer.WritePropertyName("purviewConfiguration"u8);
                writer.WriteObjectValue(PurviewConfiguration);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static Workspace DeserializeWorkspace(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ManagedIdentity> identity = default;
            Optional<IDictionary<string, string>> tags = default;
            string location = default;
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<string> type = default;
            Optional<DataLakeStorageAccountDetails> defaultDataLakeStorage = default;
            Optional<string> sqlAdministratorLoginPassword = default;
            Optional<string> managedResourceGroupName = default;
            Optional<string> provisioningState = default;
            Optional<string> sqlAdministratorLogin = default;
            Optional<VirtualNetworkProfile> virtualNetworkProfile = default;
            Optional<IDictionary<string, string>> connectivityEndpoints = default;
            Optional<string> managedVirtualNetwork = default;
            Optional<IList<PrivateEndpointConnection>> privateEndpointConnections = default;
            Optional<EncryptionDetails> encryption = default;
            Optional<Guid> workspaceUID = default;
            Optional<IReadOnlyDictionary<string, object>> extraProperties = default;
            Optional<ManagedVirtualNetworkSettings> managedVirtualNetworkSettings = default;
            Optional<WorkspaceRepositoryConfiguration> workspaceRepositoryConfiguration = default;
            Optional<PurviewConfiguration> purviewConfiguration = default;
            Optional<string> adlaResourceId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identity = ManagedIdentity.DeserializeManagedIdentity(property.Value);
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("defaultDataLakeStorage"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            defaultDataLakeStorage = DataLakeStorageAccountDetails.DeserializeDataLakeStorageAccountDetails(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("sqlAdministratorLoginPassword"u8))
                        {
                            sqlAdministratorLoginPassword = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("managedResourceGroupName"u8))
                        {
                            managedResourceGroupName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("sqlAdministratorLogin"u8))
                        {
                            sqlAdministratorLogin = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("virtualNetworkProfile"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            virtualNetworkProfile = VirtualNetworkProfile.DeserializeVirtualNetworkProfile(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("connectivityEndpoints"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, string> dictionary = new Dictionary<string, string>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, property1.Value.GetString());
                            }
                            connectivityEndpoints = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("managedVirtualNetwork"u8))
                        {
                            managedVirtualNetwork = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("privateEndpointConnections"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<PrivateEndpointConnection> array = new List<PrivateEndpointConnection>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(PrivateEndpointConnection.DeserializePrivateEndpointConnection(item));
                            }
                            privateEndpointConnections = array;
                            continue;
                        }
                        if (property0.NameEquals("encryption"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            encryption = EncryptionDetails.DeserializeEncryptionDetails(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("workspaceUID"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            workspaceUID = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("extraProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, object> dictionary = new Dictionary<string, object>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                if (property1.Value.ValueKind == JsonValueKind.Null)
                                {
                                    dictionary.Add(property1.Name, null);
                                }
                                else
                                {
                                    dictionary.Add(property1.Name, property1.Value.GetObject());
                                }
                            }
                            extraProperties = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("managedVirtualNetworkSettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            managedVirtualNetworkSettings = ManagedVirtualNetworkSettings.DeserializeManagedVirtualNetworkSettings(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("workspaceRepositoryConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            workspaceRepositoryConfiguration = WorkspaceRepositoryConfiguration.DeserializeWorkspaceRepositoryConfiguration(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("purviewConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            purviewConfiguration = PurviewConfiguration.DeserializePurviewConfiguration(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("adlaResourceId"u8))
                        {
                            adlaResourceId = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new Workspace(id.Value, name.Value, type.Value, Optional.ToDictionary(tags), location, identity.Value, defaultDataLakeStorage.Value, sqlAdministratorLoginPassword.Value, managedResourceGroupName.Value, provisioningState.Value, sqlAdministratorLogin.Value, virtualNetworkProfile.Value, Optional.ToDictionary(connectivityEndpoints), managedVirtualNetwork.Value, Optional.ToList(privateEndpointConnections), encryption.Value, Optional.ToNullable(workspaceUID), Optional.ToDictionary(extraProperties), managedVirtualNetworkSettings.Value, workspaceRepositoryConfiguration.Value, purviewConfiguration.Value, adlaResourceId.Value);
        }

        internal partial class WorkspaceConverter : JsonConverter<Workspace>
        {
            public override void Write(Utf8JsonWriter writer, Workspace model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override Workspace Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeWorkspace(document.RootElement);
            }
        }
    }
}
