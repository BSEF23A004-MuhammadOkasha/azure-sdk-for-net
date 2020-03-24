// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Storage.Models
{
    public partial class StorageAccount : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Sku != null)
            {
                writer.WritePropertyName("sku");
                writer.WriteObjectValue(Sku);
            }
            if (Kind != null)
            {
                writer.WritePropertyName("kind");
                writer.WriteStringValue(Kind.Value.ToString());
            }
            if (Identity != null)
            {
                writer.WritePropertyName("identity");
                writer.WriteObjectValue(Identity);
            }
            if (Tags != null)
            {
                writer.WritePropertyName("tags");
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location");
            writer.WriteStringValue(Location);
            if (Id != null)
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            if (Name != null)
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Type != null)
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(Type);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (ProvisioningState != null)
            {
                writer.WritePropertyName("provisioningState");
                writer.WriteStringValue(ProvisioningState.Value.ToSerialString());
            }
            if (PrimaryEndpoints != null)
            {
                writer.WritePropertyName("primaryEndpoints");
                writer.WriteObjectValue(PrimaryEndpoints);
            }
            if (PrimaryLocation != null)
            {
                writer.WritePropertyName("primaryLocation");
                writer.WriteStringValue(PrimaryLocation);
            }
            if (StatusOfPrimary != null)
            {
                writer.WritePropertyName("statusOfPrimary");
                writer.WriteStringValue(StatusOfPrimary.Value.ToSerialString());
            }
            if (LastGeoFailoverTime != null)
            {
                writer.WritePropertyName("lastGeoFailoverTime");
                writer.WriteStringValue(LastGeoFailoverTime.Value, "S");
            }
            if (SecondaryLocation != null)
            {
                writer.WritePropertyName("secondaryLocation");
                writer.WriteStringValue(SecondaryLocation);
            }
            if (StatusOfSecondary != null)
            {
                writer.WritePropertyName("statusOfSecondary");
                writer.WriteStringValue(StatusOfSecondary.Value.ToSerialString());
            }
            if (CreationTime != null)
            {
                writer.WritePropertyName("creationTime");
                writer.WriteStringValue(CreationTime.Value, "S");
            }
            if (CustomDomain != null)
            {
                writer.WritePropertyName("customDomain");
                writer.WriteObjectValue(CustomDomain);
            }
            if (SecondaryEndpoints != null)
            {
                writer.WritePropertyName("secondaryEndpoints");
                writer.WriteObjectValue(SecondaryEndpoints);
            }
            if (Encryption != null)
            {
                writer.WritePropertyName("encryption");
                writer.WriteObjectValue(Encryption);
            }
            if (AccessTier != null)
            {
                writer.WritePropertyName("accessTier");
                writer.WriteStringValue(AccessTier.Value.ToSerialString());
            }
            if (AzureFilesIdentityBasedAuthentication != null)
            {
                writer.WritePropertyName("azureFilesIdentityBasedAuthentication");
                writer.WriteObjectValue(AzureFilesIdentityBasedAuthentication);
            }
            if (EnableHttpsTrafficOnly != null)
            {
                writer.WritePropertyName("supportsHttpsTrafficOnly");
                writer.WriteBooleanValue(EnableHttpsTrafficOnly.Value);
            }
            if (NetworkRuleSet != null)
            {
                writer.WritePropertyName("networkAcls");
                writer.WriteObjectValue(NetworkRuleSet);
            }
            if (IsHnsEnabled != null)
            {
                writer.WritePropertyName("isHnsEnabled");
                writer.WriteBooleanValue(IsHnsEnabled.Value);
            }
            if (GeoReplicationStats != null)
            {
                writer.WritePropertyName("geoReplicationStats");
                writer.WriteObjectValue(GeoReplicationStats);
            }
            if (FailoverInProgress != null)
            {
                writer.WritePropertyName("failoverInProgress");
                writer.WriteBooleanValue(FailoverInProgress.Value);
            }
            if (LargeFileSharesState != null)
            {
                writer.WritePropertyName("largeFileSharesState");
                writer.WriteStringValue(LargeFileSharesState.Value.ToString());
            }
            if (PrivateEndpointConnections != null)
            {
                writer.WritePropertyName("privateEndpointConnections");
                writer.WriteStartArray();
                foreach (var item in PrivateEndpointConnections)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (RoutingPreference != null)
            {
                writer.WritePropertyName("routingPreference");
                writer.WriteObjectValue(RoutingPreference);
            }
            if (BlobRestoreStatus != null)
            {
                writer.WritePropertyName("blobRestoreStatus");
                writer.WriteObjectValue(BlobRestoreStatus);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static StorageAccount DeserializeStorageAccount(JsonElement element)
        {
            Sku sku = default;
            Kind? kind = default;
            Identity identity = default;
            IDictionary<string, string> tags = default;
            string location = default;
            string id = default;
            string name = default;
            string type = default;
            ProvisioningState? provisioningState = default;
            Endpoints primaryEndpoints = default;
            string primaryLocation = default;
            AccountStatus? statusOfPrimary = default;
            DateTimeOffset? lastGeoFailoverTime = default;
            string secondaryLocation = default;
            AccountStatus? statusOfSecondary = default;
            DateTimeOffset? creationTime = default;
            CustomDomain customDomain = default;
            Endpoints secondaryEndpoints = default;
            Encryption encryption = default;
            AccessTier? accessTier = default;
            AzureFilesIdentityBasedAuthentication azureFilesIdentityBasedAuthentication = default;
            bool? supportsHttpsTrafficOnly = default;
            NetworkRuleSet networkAcls = default;
            bool? isHnsEnabled = default;
            GeoReplicationStats geoReplicationStats = default;
            bool? failoverInProgress = default;
            LargeFileSharesState? largeFileSharesState = default;
            IList<PrivateEndpointConnection> privateEndpointConnections = default;
            RoutingPreference routingPreference = default;
            BlobRestoreStatus blobRestoreStatus = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sku = Sku.DeserializeSku(property.Value);
                    continue;
                }
                if (property.NameEquals("kind"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    kind = new Kind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("identity"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identity = Identity.DeserializeIdentity(property.Value);
                    continue;
                }
                if (property.NameEquals("tags"))
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
                if (property.NameEquals("location"))
                {
                    location = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = property0.Value.GetString().ToProvisioningState();
                            continue;
                        }
                        if (property0.NameEquals("primaryEndpoints"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            primaryEndpoints = Endpoints.DeserializeEndpoints(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("primaryLocation"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            primaryLocation = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("statusOfPrimary"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            statusOfPrimary = property0.Value.GetString().ToAccountStatus();
                            continue;
                        }
                        if (property0.NameEquals("lastGeoFailoverTime"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastGeoFailoverTime = property0.Value.GetDateTimeOffset("S");
                            continue;
                        }
                        if (property0.NameEquals("secondaryLocation"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            secondaryLocation = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("statusOfSecondary"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            statusOfSecondary = property0.Value.GetString().ToAccountStatus();
                            continue;
                        }
                        if (property0.NameEquals("creationTime"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            creationTime = property0.Value.GetDateTimeOffset("S");
                            continue;
                        }
                        if (property0.NameEquals("customDomain"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            customDomain = CustomDomain.DeserializeCustomDomain(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("secondaryEndpoints"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            secondaryEndpoints = Endpoints.DeserializeEndpoints(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("encryption"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            encryption = Encryption.DeserializeEncryption(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("accessTier"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            accessTier = property0.Value.GetString().ToAccessTier();
                            continue;
                        }
                        if (property0.NameEquals("azureFilesIdentityBasedAuthentication"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            azureFilesIdentityBasedAuthentication = AzureFilesIdentityBasedAuthentication.DeserializeAzureFilesIdentityBasedAuthentication(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("supportsHttpsTrafficOnly"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            supportsHttpsTrafficOnly = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("networkAcls"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            networkAcls = NetworkRuleSet.DeserializeNetworkRuleSet(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("isHnsEnabled"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isHnsEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("geoReplicationStats"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            geoReplicationStats = GeoReplicationStats.DeserializeGeoReplicationStats(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("failoverInProgress"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            failoverInProgress = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("largeFileSharesState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            largeFileSharesState = new LargeFileSharesState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("privateEndpointConnections"))
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
                        if (property0.NameEquals("routingPreference"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            routingPreference = RoutingPreference.DeserializeRoutingPreference(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("blobRestoreStatus"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            blobRestoreStatus = BlobRestoreStatus.DeserializeBlobRestoreStatus(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new StorageAccount(sku, kind, identity, provisioningState, primaryEndpoints, primaryLocation, statusOfPrimary, lastGeoFailoverTime, secondaryLocation, statusOfSecondary, creationTime, customDomain, secondaryEndpoints, encryption, accessTier, azureFilesIdentityBasedAuthentication, supportsHttpsTrafficOnly, networkAcls, isHnsEnabled, geoReplicationStats, failoverInProgress, largeFileSharesState, privateEndpointConnections, routingPreference, blobRestoreStatus, tags, location, id, name, type);
        }
    }
}
