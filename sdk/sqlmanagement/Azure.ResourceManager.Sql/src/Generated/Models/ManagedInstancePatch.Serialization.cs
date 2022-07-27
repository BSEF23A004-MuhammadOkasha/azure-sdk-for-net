// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class ManagedInstancePatch : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku");
                writer.WriteObjectValue(Sku);
            }
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity");
                var serializeOptions = new JsonSerializerOptions { Converters = { new ManagedServiceIdentityTypeV3Converter() } };
                JsonSerializer.Serialize(writer, Identity, serializeOptions);
            }
            if (Optional.IsCollectionDefined(Tags))
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
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(ManagedInstanceCreateMode))
            {
                writer.WritePropertyName("managedInstanceCreateMode");
                writer.WriteStringValue(ManagedInstanceCreateMode.Value.ToString());
            }
            if (Optional.IsDefined(AdministratorLogin))
            {
                writer.WritePropertyName("administratorLogin");
                writer.WriteStringValue(AdministratorLogin);
            }
            if (Optional.IsDefined(AdministratorLoginPassword))
            {
                writer.WritePropertyName("administratorLoginPassword");
                writer.WriteStringValue(AdministratorLoginPassword);
            }
            if (Optional.IsDefined(SubnetId))
            {
                writer.WritePropertyName("subnetId");
                writer.WriteStringValue(SubnetId);
            }
            if (Optional.IsDefined(LicenseType))
            {
                writer.WritePropertyName("licenseType");
                writer.WriteStringValue(LicenseType.Value.ToString());
            }
            if (Optional.IsDefined(VCores))
            {
                writer.WritePropertyName("vCores");
                writer.WriteNumberValue(VCores.Value);
            }
            if (Optional.IsDefined(StorageSizeInGB))
            {
                writer.WritePropertyName("storageSizeInGB");
                writer.WriteNumberValue(StorageSizeInGB.Value);
            }
            if (Optional.IsDefined(Collation))
            {
                writer.WritePropertyName("collation");
                writer.WriteStringValue(Collation);
            }
            if (Optional.IsDefined(DnsZonePartner))
            {
                writer.WritePropertyName("dnsZonePartner");
                writer.WriteStringValue(DnsZonePartner);
            }
            if (Optional.IsDefined(IsPublicDataEndpointEnabled))
            {
                writer.WritePropertyName("publicDataEndpointEnabled");
                writer.WriteBooleanValue(IsPublicDataEndpointEnabled.Value);
            }
            if (Optional.IsDefined(SourceManagedInstanceId))
            {
                writer.WritePropertyName("sourceManagedInstanceId");
                writer.WriteStringValue(SourceManagedInstanceId);
            }
            if (Optional.IsDefined(RestorePointInTime))
            {
                writer.WritePropertyName("restorePointInTime");
                writer.WriteStringValue(RestorePointInTime.Value, "O");
            }
            if (Optional.IsDefined(ProxyOverride))
            {
                writer.WritePropertyName("proxyOverride");
                writer.WriteStringValue(ProxyOverride.Value.ToString());
            }
            if (Optional.IsDefined(TimezoneId))
            {
                writer.WritePropertyName("timezoneId");
                writer.WriteStringValue(TimezoneId);
            }
            if (Optional.IsDefined(InstancePoolId))
            {
                writer.WritePropertyName("instancePoolId");
                writer.WriteStringValue(InstancePoolId);
            }
            if (Optional.IsDefined(MaintenanceConfigurationId))
            {
                writer.WritePropertyName("maintenanceConfigurationId");
                writer.WriteStringValue(MaintenanceConfigurationId);
            }
            if (Optional.IsDefined(MinimalTlsVersion))
            {
                writer.WritePropertyName("minimalTlsVersion");
                writer.WriteStringValue(MinimalTlsVersion);
            }
            if (Optional.IsDefined(RequestedBackupStorageRedundancy))
            {
                writer.WritePropertyName("requestedBackupStorageRedundancy");
                writer.WriteStringValue(RequestedBackupStorageRedundancy.Value.ToString());
            }
            if (Optional.IsDefined(IsZoneRedundant))
            {
                writer.WritePropertyName("zoneRedundant");
                writer.WriteBooleanValue(IsZoneRedundant.Value);
            }
            if (Optional.IsDefined(PrimaryUserAssignedIdentityId))
            {
                writer.WritePropertyName("primaryUserAssignedIdentityId");
                writer.WriteStringValue(PrimaryUserAssignedIdentityId);
            }
            if (Optional.IsDefined(KeyId))
            {
                writer.WritePropertyName("keyId");
                writer.WriteStringValue(KeyId.AbsoluteUri);
            }
            if (Optional.IsDefined(Administrators))
            {
                writer.WritePropertyName("administrators");
                writer.WriteObjectValue(Administrators);
            }
            if (Optional.IsDefined(ServicePrincipal))
            {
                writer.WritePropertyName("servicePrincipal");
                writer.WriteObjectValue(ServicePrincipal);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }
    }
}
