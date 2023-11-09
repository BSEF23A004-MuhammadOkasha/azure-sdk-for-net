// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> An update request for an Azure SQL Database managed instance. </summary>
    public partial class ManagedInstancePatch
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ManagedInstancePatch"/>. </summary>
        public ManagedInstancePatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
            PrivateEndpointConnections = new ChangeTrackingList<ManagedInstancePecProperty>();
        }

        /// <summary> Initializes a new instance of <see cref="ManagedInstancePatch"/>. </summary>
        /// <param name="sku"> Managed instance sku. </param>
        /// <param name="identity"> Managed instance identity. </param>
        /// <param name="tags"> Resource tags. </param>
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
        /// <param name="licenseType"> The license type. Possible values are 'LicenseIncluded' (regular price inclusive of a new SQL license) and 'BasePrice' (discounted AHB price for bringing your own SQL licenses). </param>
        /// <param name="vCores"> The number of vCores. Allowed values: 8, 16, 24, 32, 40, 64, 80. </param>
        /// <param name="storageSizeInGB"> Storage size in GB. Minimum value: 32. Maximum value: 16384. Increments of 32 GB allowed only. Maximum value depends on the selected hardware family and number of vCores. </param>
        /// <param name="collation"> Collation of the managed instance. </param>
        /// <param name="dnsZone"> The Dns Zone that the managed instance is in. </param>
        /// <param name="managedDnsZonePartner"> The resource id of another managed instance whose DNS zone this managed instance will share after creation. </param>
        /// <param name="isPublicDataEndpointEnabled"> Whether or not the public data endpoint is enabled. </param>
        /// <param name="sourceManagedInstanceId"> The resource identifier of the source managed instance associated with create operation of this instance. </param>
        /// <param name="restorePointInTime"> Specifies the point in time (ISO8601 format) of the source database that will be restored to create the new database. </param>
        /// <param name="proxyOverride"> Connection type used for connecting to the instance. </param>
        /// <param name="timezoneId">
        /// Id of the timezone. Allowed values are timezones supported by Windows.
        /// Windows keeps details on supported timezones, including the id, in registry under
        /// KEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Time Zones.
        /// You can get those registry values via SQL Server by querying SELECT name AS timezone_id FROM sys.time_zone_info.
        /// List of Ids can also be obtained by executing [System.TimeZoneInfo]::GetSystemTimeZones() in PowerShell.
        /// An example of valid timezone id is "Pacific Standard Time" or "W. Europe Standard Time".
        /// </param>
        /// <param name="instancePoolId"> The Id of the instance pool this managed server belongs to. </param>
        /// <param name="maintenanceConfigurationId"> Specifies maintenance configuration id to apply to this managed instance. </param>
        /// <param name="privateEndpointConnections"> List of private endpoint connections on a managed instance. </param>
        /// <param name="minimalTlsVersion"> Minimal TLS version. Allowed values: 'None', '1.0', '1.1', '1.2'. </param>
        /// <param name="currentBackupStorageRedundancy"> The storage account type used to store backups for this instance. The options are Local (LocallyRedundantStorage), Zone (ZoneRedundantStorage), Geo (GeoRedundantStorage) and GeoZone(GeoZoneRedundantStorage). </param>
        /// <param name="requestedBackupStorageRedundancy"> The storage account type to be used to store backups for this instance. The options are Local (LocallyRedundantStorage), Zone (ZoneRedundantStorage), Geo (GeoRedundantStorage) and GeoZone(GeoZoneRedundantStorage). </param>
        /// <param name="isZoneRedundant"> Whether or not the multi-az is enabled. </param>
        /// <param name="primaryUserAssignedIdentityId"> The resource id of a user assigned identity to be used by default. </param>
        /// <param name="keyId"> A CMK URI of the key to use for encryption. </param>
        /// <param name="administrators"> The Azure Active Directory administrator of the instance. This can only be used at instance create time. If used for instance update, it will be ignored or it will result in an error. For updates individual APIs will need to be used. </param>
        /// <param name="servicePrincipal"> The managed instance's service principal. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ManagedInstancePatch(SqlSku sku, ManagedServiceIdentity identity, IDictionary<string, string> tags, ManagedInstancePropertiesProvisioningState? provisioningState, ManagedServerCreateMode? managedInstanceCreateMode, string fullyQualifiedDomainName, string administratorLogin, string administratorLoginPassword, ResourceIdentifier subnetId, string state, ManagedInstanceLicenseType? licenseType, int? vCores, int? storageSizeInGB, string collation, string dnsZone, ResourceIdentifier managedDnsZonePartner, bool? isPublicDataEndpointEnabled, ResourceIdentifier sourceManagedInstanceId, DateTimeOffset? restorePointInTime, ManagedInstanceProxyOverride? proxyOverride, string timezoneId, ResourceIdentifier instancePoolId, ResourceIdentifier maintenanceConfigurationId, IReadOnlyList<ManagedInstancePecProperty> privateEndpointConnections, string minimalTlsVersion, SqlBackupStorageRedundancy? currentBackupStorageRedundancy, SqlBackupStorageRedundancy? requestedBackupStorageRedundancy, bool? isZoneRedundant, ResourceIdentifier primaryUserAssignedIdentityId, Uri keyId, ManagedInstanceExternalAdministrator administrators, SqlServicePrincipal servicePrincipal, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Sku = sku;
            Identity = identity;
            Tags = tags;
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
            ManagedDnsZonePartner = managedDnsZonePartner;
            IsPublicDataEndpointEnabled = isPublicDataEndpointEnabled;
            SourceManagedInstanceId = sourceManagedInstanceId;
            RestorePointInTime = restorePointInTime;
            ProxyOverride = proxyOverride;
            TimezoneId = timezoneId;
            InstancePoolId = instancePoolId;
            MaintenanceConfigurationId = maintenanceConfigurationId;
            PrivateEndpointConnections = privateEndpointConnections;
            MinimalTlsVersion = minimalTlsVersion;
            CurrentBackupStorageRedundancy = currentBackupStorageRedundancy;
            RequestedBackupStorageRedundancy = requestedBackupStorageRedundancy;
            IsZoneRedundant = isZoneRedundant;
            PrimaryUserAssignedIdentityId = primaryUserAssignedIdentityId;
            KeyId = keyId;
            Administrators = administrators;
            ServicePrincipal = servicePrincipal;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Managed instance sku. </summary>
        public SqlSku Sku { get; set; }
        /// <summary> Managed instance identity. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
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
        public ResourceIdentifier SubnetId { get; set; }
        /// <summary> The state of the managed instance. </summary>
        public string State { get; }
        /// <summary> The license type. Possible values are 'LicenseIncluded' (regular price inclusive of a new SQL license) and 'BasePrice' (discounted AHB price for bringing your own SQL licenses). </summary>
        public ManagedInstanceLicenseType? LicenseType { get; set; }
        /// <summary> The number of vCores. Allowed values: 8, 16, 24, 32, 40, 64, 80. </summary>
        public int? VCores { get; set; }
        /// <summary> Storage size in GB. Minimum value: 32. Maximum value: 16384. Increments of 32 GB allowed only. Maximum value depends on the selected hardware family and number of vCores. </summary>
        public int? StorageSizeInGB { get; set; }
        /// <summary> Collation of the managed instance. </summary>
        public string Collation { get; set; }
        /// <summary> The Dns Zone that the managed instance is in. </summary>
        public string DnsZone { get; }
        /// <summary> The resource id of another managed instance whose DNS zone this managed instance will share after creation. </summary>
        public ResourceIdentifier ManagedDnsZonePartner { get; set; }
        /// <summary> Whether or not the public data endpoint is enabled. </summary>
        public bool? IsPublicDataEndpointEnabled { get; set; }
        /// <summary> The resource identifier of the source managed instance associated with create operation of this instance. </summary>
        public ResourceIdentifier SourceManagedInstanceId { get; set; }
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
        /// An example of valid timezone id is "Pacific Standard Time" or "W. Europe Standard Time".
        /// </summary>
        public string TimezoneId { get; set; }
        /// <summary> The Id of the instance pool this managed server belongs to. </summary>
        public ResourceIdentifier InstancePoolId { get; set; }
        /// <summary> Specifies maintenance configuration id to apply to this managed instance. </summary>
        public ResourceIdentifier MaintenanceConfigurationId { get; set; }
        /// <summary> List of private endpoint connections on a managed instance. </summary>
        public IReadOnlyList<ManagedInstancePecProperty> PrivateEndpointConnections { get; }
        /// <summary> Minimal TLS version. Allowed values: 'None', '1.0', '1.1', '1.2'. </summary>
        public string MinimalTlsVersion { get; set; }
        /// <summary> The storage account type used to store backups for this instance. The options are Local (LocallyRedundantStorage), Zone (ZoneRedundantStorage), Geo (GeoRedundantStorage) and GeoZone(GeoZoneRedundantStorage). </summary>
        public SqlBackupStorageRedundancy? CurrentBackupStorageRedundancy { get; }
        /// <summary> The storage account type to be used to store backups for this instance. The options are Local (LocallyRedundantStorage), Zone (ZoneRedundantStorage), Geo (GeoRedundantStorage) and GeoZone(GeoZoneRedundantStorage). </summary>
        public SqlBackupStorageRedundancy? RequestedBackupStorageRedundancy { get; set; }
        /// <summary> Whether or not the multi-az is enabled. </summary>
        public bool? IsZoneRedundant { get; set; }
        /// <summary> The resource id of a user assigned identity to be used by default. </summary>
        public ResourceIdentifier PrimaryUserAssignedIdentityId { get; set; }
        /// <summary> A CMK URI of the key to use for encryption. </summary>
        public Uri KeyId { get; set; }
        /// <summary> The Azure Active Directory administrator of the instance. This can only be used at instance create time. If used for instance update, it will be ignored or it will result in an error. For updates individual APIs will need to be used. </summary>
        public ManagedInstanceExternalAdministrator Administrators { get; set; }
        /// <summary> The managed instance's service principal. </summary>
        public SqlServicePrincipal ServicePrincipal { get; set; }
    }
}
