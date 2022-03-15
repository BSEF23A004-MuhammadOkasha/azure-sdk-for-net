// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing the ManagedInstance data model. </summary>
    public partial class ManagedInstanceData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of ManagedInstanceData. </summary>
        /// <param name="location"> The location. </param>
        public ManagedInstanceData(AzureLocation location) : base(location)
        {
            PrivateEndpointConnections = new ChangeTrackingList<ManagedInstancePecProperty>();
        }

        /// <summary> Initializes a new instance of ManagedInstanceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="identity"> The Azure Active Directory identity of the managed instance. </param>
        /// <param name="sku"> Managed instance SKU. Allowed values for sku.name: GP_Gen4, GP_Gen5, BC_Gen4, BC_Gen5. </param>
        /// <param name="provisioningState"></param>
        /// <param name="managedInstanceCreateMode">
        /// Specifies the mode of database creation.
        /// 
        /// Default: Regular instance creation.
        /// 
        /// Restore: Creates an instance by restoring a set of backups to specific point in time. RestorePointInTime and SourceManagedInstanceId must be specified.
        /// </param>
        /// <param name="fullyQualifiedDomainName"> The fully qualified domain name of the managed instance. </param>
        /// <param name="administratorLogin"> Administrator username for the managed instance. Can only be specified when the managed instance is being created (and is required for creation). </param>
        /// <param name="administratorLoginPassword"> The administrator login password (required for managed instance creation). </param>
        /// <param name="subnetId"> Subnet resource ID for the managed instance. </param>
        /// <param name="state"> The state of the managed instance. </param>
        /// <param name="licenseType"> The license type. Possible values are &apos;LicenseIncluded&apos; (regular price inclusive of a new SQL license) and &apos;BasePrice&apos; (discounted AHB price for bringing your own SQL licenses). </param>
        /// <param name="vCores"> The number of vCores. Allowed values: 8, 16, 24, 32, 40, 64, 80. </param>
        /// <param name="storageSizeInGB"> Storage size in GB. Minimum value: 32. Maximum value: 8192. Increments of 32 GB allowed only. </param>
        /// <param name="collation"> Collation of the managed instance. </param>
        /// <param name="dnsZone"> The Dns Zone that the managed instance is in. </param>
        /// <param name="dnsZonePartner"> The resource id of another managed instance whose DNS zone this managed instance will share after creation. </param>
        /// <param name="publicDataEndpointEnabled"> Whether or not the public data endpoint is enabled. </param>
        /// <param name="sourceManagedInstanceId"> The resource identifier of the source managed instance associated with create operation of this instance. </param>
        /// <param name="restorePointInTime"> Specifies the point in time (ISO8601 format) of the source database that will be restored to create the new database. </param>
        /// <param name="proxyOverride"> Connection type used for connecting to the instance. </param>
        /// <param name="timezoneId">
        /// Id of the timezone. Allowed values are timezones supported by Windows.
        /// Windows keeps details on supported timezones, including the id, in registry under
        /// KEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Time Zones.
        /// You can get those registry values via SQL Server by querying SELECT name AS timezone_id FROM sys.time_zone_info.
        /// List of Ids can also be obtained by executing [System.TimeZoneInfo]::GetSystemTimeZones() in PowerShell.
        /// An example of valid timezone id is &quot;Pacific Standard Time&quot; or &quot;W. Europe Standard Time&quot;.
        /// </param>
        /// <param name="instancePoolId"> The Id of the instance pool this managed server belongs to. </param>
        /// <param name="maintenanceConfigurationId"> Specifies maintenance configuration id to apply to this managed instance. </param>
        /// <param name="privateEndpointConnections"> List of private endpoint connections on a managed instance. </param>
        /// <param name="minimalTlsVersion"> Minimal TLS version. Allowed values: &apos;None&apos;, &apos;1.0&apos;, &apos;1.1&apos;, &apos;1.2&apos;. </param>
        /// <param name="storageAccountType"> The storage account type used to store backups for this instance. The options are LRS (LocallyRedundantStorage), ZRS (ZoneRedundantStorage) and GRS (GeoRedundantStorage). </param>
        /// <param name="zoneRedundant"> Whether or not the multi-az is enabled. </param>
        /// <param name="primaryUserAssignedIdentityId"> The resource id of a user assigned identity to be used by default. </param>
        /// <param name="keyId"> A CMK URI of the key to use for encryption. </param>
        /// <param name="administrators"> The Azure Active Directory administrator of the server. </param>
        internal ManagedInstanceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ManagedServiceIdentity identity, SqlSku sku, ManagedInstancePropertiesProvisioningState? provisioningState, ManagedServerCreateMode? managedInstanceCreateMode, string fullyQualifiedDomainName, string administratorLogin, string administratorLoginPassword, string subnetId, string state, ManagedInstanceLicenseType? licenseType, int? vCores, int? storageSizeInGB, string collation, string dnsZone, string dnsZonePartner, bool? publicDataEndpointEnabled, string sourceManagedInstanceId, DateTimeOffset? restorePointInTime, ManagedInstanceProxyOverride? proxyOverride, string timezoneId, string instancePoolId, string maintenanceConfigurationId, IReadOnlyList<ManagedInstancePecProperty> privateEndpointConnections, string minimalTlsVersion, StorageAccountType? storageAccountType, bool? zoneRedundant, string primaryUserAssignedIdentityId, string keyId, ManagedInstanceExternalAdministrator administrators) : base(id, name, resourceType, systemData, tags, location)
        {
            Identity = identity;
            Sku = sku;
            ProvisioningState = provisioningState;
            ManagedInstanceCreateMode = managedInstanceCreateMode;
            FullyQualifiedDomainName = fullyQualifiedDomainName;
            AdministratorLogin = administratorLogin;
            AdministratorLoginPassword = administratorLoginPassword;
            SubnetId = subnetId;
            State = state;
            LicenseType = licenseType;
            VCores = vCores;
            StorageSizeInGB = storageSizeInGB;
            Collation = collation;
            DnsZone = dnsZone;
            DnsZonePartner = dnsZonePartner;
            PublicDataEndpointEnabled = publicDataEndpointEnabled;
            SourceManagedInstanceId = sourceManagedInstanceId;
            RestorePointInTime = restorePointInTime;
            ProxyOverride = proxyOverride;
            TimezoneId = timezoneId;
            InstancePoolId = instancePoolId;
            MaintenanceConfigurationId = maintenanceConfigurationId;
            PrivateEndpointConnections = privateEndpointConnections;
            MinimalTlsVersion = minimalTlsVersion;
            StorageAccountType = storageAccountType;
            ZoneRedundant = zoneRedundant;
            PrimaryUserAssignedIdentityId = primaryUserAssignedIdentityId;
            KeyId = keyId;
            Administrators = administrators;
        }

        /// <summary> The Azure Active Directory identity of the managed instance. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> Managed instance SKU. Allowed values for sku.name: GP_Gen4, GP_Gen5, BC_Gen4, BC_Gen5. </summary>
        public SqlSku Sku { get; set; }
        /// <summary> Gets the provisioning state. </summary>
        public ManagedInstancePropertiesProvisioningState? ProvisioningState { get; }
        /// <summary>
        /// Specifies the mode of database creation.
        /// 
        /// Default: Regular instance creation.
        /// 
        /// Restore: Creates an instance by restoring a set of backups to specific point in time. RestorePointInTime and SourceManagedInstanceId must be specified.
        /// </summary>
        public ManagedServerCreateMode? ManagedInstanceCreateMode { get; set; }
        /// <summary> The fully qualified domain name of the managed instance. </summary>
        public string FullyQualifiedDomainName { get; }
        /// <summary> Administrator username for the managed instance. Can only be specified when the managed instance is being created (and is required for creation). </summary>
        public string AdministratorLogin { get; set; }
        /// <summary> The administrator login password (required for managed instance creation). </summary>
        public string AdministratorLoginPassword { get; set; }
        /// <summary> Subnet resource ID for the managed instance. </summary>
        public string SubnetId { get; set; }
        /// <summary> The state of the managed instance. </summary>
        public string State { get; }
        /// <summary> The license type. Possible values are &apos;LicenseIncluded&apos; (regular price inclusive of a new SQL license) and &apos;BasePrice&apos; (discounted AHB price for bringing your own SQL licenses). </summary>
        public ManagedInstanceLicenseType? LicenseType { get; set; }
        /// <summary> The number of vCores. Allowed values: 8, 16, 24, 32, 40, 64, 80. </summary>
        public int? VCores { get; set; }
        /// <summary> Storage size in GB. Minimum value: 32. Maximum value: 8192. Increments of 32 GB allowed only. </summary>
        public int? StorageSizeInGB { get; set; }
        /// <summary> Collation of the managed instance. </summary>
        public string Collation { get; set; }
        /// <summary> The Dns Zone that the managed instance is in. </summary>
        public string DnsZone { get; }
        /// <summary> The resource id of another managed instance whose DNS zone this managed instance will share after creation. </summary>
        public string DnsZonePartner { get; set; }
        /// <summary> Whether or not the public data endpoint is enabled. </summary>
        public bool? PublicDataEndpointEnabled { get; set; }
        /// <summary> The resource identifier of the source managed instance associated with create operation of this instance. </summary>
        public string SourceManagedInstanceId { get; set; }
        /// <summary> Specifies the point in time (ISO8601 format) of the source database that will be restored to create the new database. </summary>
        public DateTimeOffset? RestorePointInTime { get; set; }
        /// <summary> Connection type used for connecting to the instance. </summary>
        public ManagedInstanceProxyOverride? ProxyOverride { get; set; }
        /// <summary>
        /// Id of the timezone. Allowed values are timezones supported by Windows.
        /// Windows keeps details on supported timezones, including the id, in registry under
        /// KEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Time Zones.
        /// You can get those registry values via SQL Server by querying SELECT name AS timezone_id FROM sys.time_zone_info.
        /// List of Ids can also be obtained by executing [System.TimeZoneInfo]::GetSystemTimeZones() in PowerShell.
        /// An example of valid timezone id is &quot;Pacific Standard Time&quot; or &quot;W. Europe Standard Time&quot;.
        /// </summary>
        public string TimezoneId { get; set; }
        /// <summary> The Id of the instance pool this managed server belongs to. </summary>
        public string InstancePoolId { get; set; }
        /// <summary> Specifies maintenance configuration id to apply to this managed instance. </summary>
        public string MaintenanceConfigurationId { get; set; }
        /// <summary> List of private endpoint connections on a managed instance. </summary>
        public IReadOnlyList<ManagedInstancePecProperty> PrivateEndpointConnections { get; }
        /// <summary> Minimal TLS version. Allowed values: &apos;None&apos;, &apos;1.0&apos;, &apos;1.1&apos;, &apos;1.2&apos;. </summary>
        public string MinimalTlsVersion { get; set; }
        /// <summary> The storage account type used to store backups for this instance. The options are LRS (LocallyRedundantStorage), ZRS (ZoneRedundantStorage) and GRS (GeoRedundantStorage). </summary>
        public StorageAccountType? StorageAccountType { get; set; }
        /// <summary> Whether or not the multi-az is enabled. </summary>
        public bool? ZoneRedundant { get; set; }
        /// <summary> The resource id of a user assigned identity to be used by default. </summary>
        public string PrimaryUserAssignedIdentityId { get; set; }
        /// <summary> A CMK URI of the key to use for encryption. </summary>
        public string KeyId { get; set; }
        /// <summary> The Azure Active Directory administrator of the server. </summary>
        public ManagedInstanceExternalAdministrator Administrators { get; set; }
    }
}
