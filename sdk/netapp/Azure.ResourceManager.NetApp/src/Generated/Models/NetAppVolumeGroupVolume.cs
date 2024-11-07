// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.NetApp.Models
{
    /// <summary> Volume resource. </summary>
    public partial class NetAppVolumeGroupVolume
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="NetAppVolumeGroupVolume"/>. </summary>
        /// <param name="creationToken"> A unique file path for the volume. Used when creating mount targets. </param>
        /// <param name="usageThreshold"> Maximum storage quota allowed for a file system in bytes. This is a soft quota used for alerting only. For regular volumes, valid values are in the range 50GiB to 100TiB. For large volumes, valid values are in the range 100TiB to 1PiB, and on an exceptional basis, from to 2400GiB to 2400TiB. Values expressed in bytes as multiples of 1 GiB. </param>
        /// <param name="subnetId"> The Azure Resource URI for a delegated subnet. Must have the delegation Microsoft.NetApp/volumes. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="creationToken"/> or <paramref name="subnetId"/> is null. </exception>
        public NetAppVolumeGroupVolume(string creationToken, long usageThreshold, ResourceIdentifier subnetId)
        {
            Argument.AssertNotNull(creationToken, nameof(creationToken));
            Argument.AssertNotNull(subnetId, nameof(subnetId));

            Tags = new ChangeTrackingDictionary<string, string>();
            Zones = new ChangeTrackingList<string>();
            CreationToken = creationToken;
            UsageThreshold = usageThreshold;
            ProtocolTypes = new ChangeTrackingList<string>();
            SubnetId = subnetId;
            MountTargets = new ChangeTrackingList<NetAppVolumeMountTarget>();
            DataStoreResourceId = new ChangeTrackingList<ResourceIdentifier>();
            PlacementRules = new ChangeTrackingList<NetAppVolumePlacementRule>();
        }

        /// <summary> Initializes a new instance of <see cref="NetAppVolumeGroupVolume"/>. </summary>
        /// <param name="id"> Resource Id. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="zones"> Availability Zone. </param>
        /// <param name="fileSystemId"> Unique FileSystem Identifier. </param>
        /// <param name="creationToken"> A unique file path for the volume. Used when creating mount targets. </param>
        /// <param name="serviceLevel"> The service level of the file system. </param>
        /// <param name="usageThreshold"> Maximum storage quota allowed for a file system in bytes. This is a soft quota used for alerting only. For regular volumes, valid values are in the range 50GiB to 100TiB. For large volumes, valid values are in the range 100TiB to 1PiB, and on an exceptional basis, from to 2400GiB to 2400TiB. Values expressed in bytes as multiples of 1 GiB. </param>
        /// <param name="exportPolicy"> Set of export policy rules. </param>
        /// <param name="protocolTypes"> Set of protocol types, default NFSv3, CIFS for SMB protocol. </param>
        /// <param name="provisioningState"> Azure lifecycle management. </param>
        /// <param name="snapshotId"> Resource identifier used to identify the Snapshot. </param>
        /// <param name="deleteBaseSnapshot"> If enabled (true) the snapshot the volume was created from will be automatically deleted after the volume create operation has finished.  Defaults to false. </param>
        /// <param name="backupId"> Resource identifier used to identify the Backup. </param>
        /// <param name="baremetalTenantId"> Unique Baremetal Tenant Identifier. </param>
        /// <param name="subnetId"> The Azure Resource URI for a delegated subnet. Must have the delegation Microsoft.NetApp/volumes. </param>
        /// <param name="networkFeatures"> The original value of the network features type available to the volume at the time it was created. </param>
        /// <param name="effectiveNetworkFeatures"> The effective value of the network features type available to the volume, or current effective state of update. </param>
        /// <param name="networkSiblingSetId"> Network Sibling Set ID for the the group of volumes sharing networking resources. </param>
        /// <param name="storageToNetworkProximity"> Provides storage to network proximity information for the volume. </param>
        /// <param name="mountTargets"> List of mount targets. </param>
        /// <param name="volumeType"> What type of volume is this. For destination volumes in Cross Region Replication, set type to DataProtection. For creating clone volume, set type to ShortTermClone. </param>
        /// <param name="dataProtection"> DataProtection type volumes include an object containing details of the replication. </param>
        /// <param name="acceptGrowCapacityPoolForShortTermCloneSplit"> While auto splitting the short term clone volume, if the parent pool does not have enough space to accommodate the volume after split, it will be automatically resized, which will lead to increased billing. To accept capacity pool size auto grow and create a short term clone volume, set the property as accepted. </param>
        /// <param name="isRestoring"> Restoring. </param>
        /// <param name="isSnapshotDirectoryVisible"> If enabled (true) the volume will contain a read-only snapshot directory which provides access to each of the volume's snapshots (defaults to true). </param>
        /// <param name="isKerberosEnabled"> Describe if a volume is KerberosEnabled. To be use with swagger version 2020-05-01 or later. </param>
        /// <param name="securityStyle"> The security style of volume, default unix, defaults to ntfs for dual protocol or CIFS protocol. </param>
        /// <param name="isSmbEncryptionEnabled"> Enables encryption for in-flight smb3 data. Only applicable for SMB/DualProtocol volume. To be used with swagger version 2020-08-01 or later. </param>
        /// <param name="smbAccessBasedEnumeration"> Enables access-based enumeration share property for SMB Shares. Only applicable for SMB/DualProtocol volume. </param>
        /// <param name="smbNonBrowsable"> Enables non-browsable property for SMB Shares. Only applicable for SMB/DualProtocol volume. </param>
        /// <param name="isSmbContinuouslyAvailable"> Enables continuously available share property for smb volume. Only applicable for SMB volume. </param>
        /// <param name="throughputMibps"> Maximum throughput in MiB/s that can be achieved by this volume and this will be accepted as input only for manual qosType volume. </param>
        /// <param name="actualThroughputMibps"> Actual throughput in MiB/s for auto qosType volumes calculated based on size and serviceLevel. </param>
        /// <param name="encryptionKeySource"> Source of key used to encrypt data in volume. Applicable if NetApp account has encryption.keySource = 'Microsoft.KeyVault'. Possible values (case-insensitive) are: 'Microsoft.NetApp, Microsoft.KeyVault'. </param>
        /// <param name="keyVaultPrivateEndpointResourceId"> The resource ID of private endpoint for KeyVault. It must reside in the same VNET as the volume. Only applicable if encryptionKeySource = 'Microsoft.KeyVault'. </param>
        /// <param name="isLdapEnabled"> Specifies whether LDAP is enabled or not for a given NFS volume. </param>
        /// <param name="isCoolAccessEnabled"> Specifies whether Cool Access(tiering) is enabled for the volume. </param>
        /// <param name="coolnessPeriod"> Specifies the number of days after which data that is not accessed by clients will be tiered. </param>
        /// <param name="coolAccessRetrievalPolicy">
        /// coolAccessRetrievalPolicy determines the data retrieval behavior from the cool tier to standard storage based on the read pattern for cool access enabled volumes. The possible values for this field are:
        ///  Default - Data will be pulled from cool tier to standard storage on random reads. This policy is the default.
        ///  OnRead - All client-driven data read is pulled from cool tier to standard storage on both sequential and random reads.
        ///  Never - No client-driven data is pulled from cool tier to standard storage.
        /// </param>
        /// <param name="unixPermissions"> UNIX permissions for NFS volume accepted in octal 4 digit format. First digit selects the set user ID(4), set group ID (2) and sticky (1) attributes. Second digit selects permission for the owner of the file: read (4), write (2) and execute (1). Third selects permissions for other users in the same group. the fourth for other users not in the group. 0755 - gives read/write/execute permissions to owner and read/execute to group and other users.  Avoid passing null value for unixPermissions in volume update operation, As per the behavior, If Null value is passed then user-visible unixPermissions value will became null, and user will not be able to get unixPermissions value. On safer side, actual unixPermissions value on volume will remain as its last saved value only. </param>
        /// <param name="cloneProgress"> When a volume is being restored from another volume's snapshot, will show the percentage completion of this cloning process. When this value is empty/null there is no cloning process currently happening on this volume. This value will update every 5 minutes during cloning. </param>
        /// <param name="fileAccessLogs"> Flag indicating whether file access logs are enabled for the volume, based on active diagnostic settings present on the volume. </param>
        /// <param name="avsDataStore"> Specifies whether the volume is enabled for Azure VMware Solution (AVS) datastore purpose. </param>
        /// <param name="dataStoreResourceId"> Data store resource unique identifier. </param>
        /// <param name="isDefaultQuotaEnabled"> Specifies if default quota is enabled for the volume. </param>
        /// <param name="defaultUserQuotaInKiBs"> Default user quota for volume in KiBs. If isDefaultQuotaEnabled is set, the minimum value of 4 KiBs applies . </param>
        /// <param name="defaultGroupQuotaInKiBs"> Default group quota for volume in KiBs. If isDefaultQuotaEnabled is set, the minimum value of 4 KiBs applies. </param>
        /// <param name="maximumNumberOfFiles"> Maximum number of files allowed. Needs a service request in order to be changed. Only allowed to be changed if volume quota is more than 4TiB. </param>
        /// <param name="volumeGroupName"> Volume Group Name. </param>
        /// <param name="capacityPoolResourceId"> Pool Resource Id used in case of creating a volume through volume group. </param>
        /// <param name="proximityPlacementGroupId"> Proximity placement group associated with the volume. </param>
        /// <param name="t2Network"> T2 network information. </param>
        /// <param name="volumeSpecName"> Volume spec name is the application specific designation or identifier for the particular volume in a volume group for e.g. data, log. </param>
        /// <param name="isEncrypted"> Specifies if the volume is encrypted or not. Only available on volumes created or updated after 2022-01-01. </param>
        /// <param name="placementRules"> Application specific placement rules for the particular volume. </param>
        /// <param name="enableSubvolumes"> Flag indicating whether subvolume operations are enabled on the volume. </param>
        /// <param name="provisionedAvailabilityZone"> The availability zone where the volume is provisioned. This refers to the logical availability zone where the volume resides. </param>
        /// <param name="isLargeVolume"> Specifies whether volume is a Large Volume or Regular Volume. </param>
        /// <param name="originatingResourceId"> Id of the snapshot or backup that the volume is restored from. </param>
        /// <param name="inheritedSizeInBytes"> Space shared by short term clone volume with parent volume in bytes. </param>
        /// <param name="language"> Language supported for volume. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NetAppVolumeGroupVolume(ResourceIdentifier id, string name, ResourceType? resourceType, IDictionary<string, string> tags, IList<string> zones, Guid? fileSystemId, string creationToken, NetAppFileServiceLevel? serviceLevel, long usageThreshold, VolumePropertiesExportPolicy exportPolicy, IList<string> protocolTypes, string provisioningState, string snapshotId, bool? deleteBaseSnapshot, string backupId, string baremetalTenantId, ResourceIdentifier subnetId, NetAppNetworkFeature? networkFeatures, NetAppNetworkFeature? effectiveNetworkFeatures, Guid? networkSiblingSetId, NetAppVolumeStorageToNetworkProximity? storageToNetworkProximity, IReadOnlyList<NetAppVolumeMountTarget> mountTargets, string volumeType, NetAppVolumeDataProtection dataProtection, AcceptGrowCapacityPoolForShortTermCloneSplit? acceptGrowCapacityPoolForShortTermCloneSplit, bool? isRestoring, bool? isSnapshotDirectoryVisible, bool? isKerberosEnabled, NetAppVolumeSecurityStyle? securityStyle, bool? isSmbEncryptionEnabled, SmbAccessBasedEnumeration? smbAccessBasedEnumeration, SmbNonBrowsable? smbNonBrowsable, bool? isSmbContinuouslyAvailable, float? throughputMibps, float? actualThroughputMibps, NetAppEncryptionKeySource? encryptionKeySource, ResourceIdentifier keyVaultPrivateEndpointResourceId, bool? isLdapEnabled, bool? isCoolAccessEnabled, int? coolnessPeriod, CoolAccessRetrievalPolicy? coolAccessRetrievalPolicy, string unixPermissions, int? cloneProgress, NetAppFileAccessLog? fileAccessLogs, NetAppAvsDataStore? avsDataStore, IReadOnlyList<ResourceIdentifier> dataStoreResourceId, bool? isDefaultQuotaEnabled, long? defaultUserQuotaInKiBs, long? defaultGroupQuotaInKiBs, long? maximumNumberOfFiles, string volumeGroupName, ResourceIdentifier capacityPoolResourceId, ResourceIdentifier proximityPlacementGroupId, string t2Network, string volumeSpecName, bool? isEncrypted, IList<NetAppVolumePlacementRule> placementRules, EnableNetAppSubvolume? enableSubvolumes, string provisionedAvailabilityZone, bool? isLargeVolume, ResourceIdentifier originatingResourceId, long? inheritedSizeInBytes, VolumeLanguage? language, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            Name = name;
            ResourceType = resourceType;
            Tags = tags;
            Zones = zones;
            FileSystemId = fileSystemId;
            CreationToken = creationToken;
            ServiceLevel = serviceLevel;
            UsageThreshold = usageThreshold;
            ExportPolicy = exportPolicy;
            ProtocolTypes = protocolTypes;
            ProvisioningState = provisioningState;
            SnapshotId = snapshotId;
            DeleteBaseSnapshot = deleteBaseSnapshot;
            BackupId = backupId;
            BaremetalTenantId = baremetalTenantId;
            SubnetId = subnetId;
            NetworkFeatures = networkFeatures;
            EffectiveNetworkFeatures = effectiveNetworkFeatures;
            NetworkSiblingSetId = networkSiblingSetId;
            StorageToNetworkProximity = storageToNetworkProximity;
            MountTargets = mountTargets;
            VolumeType = volumeType;
            DataProtection = dataProtection;
            AcceptGrowCapacityPoolForShortTermCloneSplit = acceptGrowCapacityPoolForShortTermCloneSplit;
            IsRestoring = isRestoring;
            IsSnapshotDirectoryVisible = isSnapshotDirectoryVisible;
            IsKerberosEnabled = isKerberosEnabled;
            SecurityStyle = securityStyle;
            IsSmbEncryptionEnabled = isSmbEncryptionEnabled;
            SmbAccessBasedEnumeration = smbAccessBasedEnumeration;
            SmbNonBrowsable = smbNonBrowsable;
            IsSmbContinuouslyAvailable = isSmbContinuouslyAvailable;
            ThroughputMibps = throughputMibps;
            ActualThroughputMibps = actualThroughputMibps;
            EncryptionKeySource = encryptionKeySource;
            KeyVaultPrivateEndpointResourceId = keyVaultPrivateEndpointResourceId;
            IsLdapEnabled = isLdapEnabled;
            IsCoolAccessEnabled = isCoolAccessEnabled;
            CoolnessPeriod = coolnessPeriod;
            CoolAccessRetrievalPolicy = coolAccessRetrievalPolicy;
            UnixPermissions = unixPermissions;
            CloneProgress = cloneProgress;
            FileAccessLogs = fileAccessLogs;
            AvsDataStore = avsDataStore;
            DataStoreResourceId = dataStoreResourceId;
            IsDefaultQuotaEnabled = isDefaultQuotaEnabled;
            DefaultUserQuotaInKiBs = defaultUserQuotaInKiBs;
            DefaultGroupQuotaInKiBs = defaultGroupQuotaInKiBs;
            MaximumNumberOfFiles = maximumNumberOfFiles;
            VolumeGroupName = volumeGroupName;
            CapacityPoolResourceId = capacityPoolResourceId;
            ProximityPlacementGroupId = proximityPlacementGroupId;
            T2Network = t2Network;
            VolumeSpecName = volumeSpecName;
            IsEncrypted = isEncrypted;
            PlacementRules = placementRules;
            EnableSubvolumes = enableSubvolumes;
            ProvisionedAvailabilityZone = provisionedAvailabilityZone;
            IsLargeVolume = isLargeVolume;
            OriginatingResourceId = originatingResourceId;
            InheritedSizeInBytes = inheritedSizeInBytes;
            Language = language;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="NetAppVolumeGroupVolume"/> for deserialization. </summary>
        internal NetAppVolumeGroupVolume()
        {
        }

        /// <summary> Resource Id. </summary>
        public ResourceIdentifier Id { get; }
        /// <summary> Resource name. </summary>
        public string Name { get; set; }
        /// <summary> Resource type. </summary>
        public ResourceType? ResourceType { get; }
        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> Availability Zone. </summary>
        public IList<string> Zones { get; }
        /// <summary> Unique FileSystem Identifier. </summary>
        public Guid? FileSystemId { get; }
        /// <summary> A unique file path for the volume. Used when creating mount targets. </summary>
        public string CreationToken { get; set; }
        /// <summary> The service level of the file system. </summary>
        public NetAppFileServiceLevel? ServiceLevel { get; set; }
        /// <summary> Maximum storage quota allowed for a file system in bytes. This is a soft quota used for alerting only. For regular volumes, valid values are in the range 50GiB to 100TiB. For large volumes, valid values are in the range 100TiB to 1PiB, and on an exceptional basis, from to 2400GiB to 2400TiB. Values expressed in bytes as multiples of 1 GiB. </summary>
        public long UsageThreshold { get; set; }
        /// <summary> Set of export policy rules. </summary>
        internal VolumePropertiesExportPolicy ExportPolicy { get; set; }
        /// <summary> Export policy rule. </summary>
        public IList<NetAppVolumeExportPolicyRule> ExportRules
        {
            get
            {
                if (ExportPolicy is null)
                    ExportPolicy = new VolumePropertiesExportPolicy();
                return ExportPolicy.Rules;
            }
        }

        /// <summary> Set of protocol types, default NFSv3, CIFS for SMB protocol. </summary>
        public IList<string> ProtocolTypes { get; }
        /// <summary> Azure lifecycle management. </summary>
        public string ProvisioningState { get; }
        /// <summary> Resource identifier used to identify the Snapshot. </summary>
        public string SnapshotId { get; set; }
        /// <summary> If enabled (true) the snapshot the volume was created from will be automatically deleted after the volume create operation has finished.  Defaults to false. </summary>
        public bool? DeleteBaseSnapshot { get; set; }
        /// <summary> Resource identifier used to identify the Backup. </summary>
        public string BackupId { get; set; }
        /// <summary> Unique Baremetal Tenant Identifier. </summary>
        public string BaremetalTenantId { get; }
        /// <summary> The Azure Resource URI for a delegated subnet. Must have the delegation Microsoft.NetApp/volumes. </summary>
        public ResourceIdentifier SubnetId { get; set; }
        /// <summary> The original value of the network features type available to the volume at the time it was created. </summary>
        public NetAppNetworkFeature? NetworkFeatures { get; set; }
        /// <summary> The effective value of the network features type available to the volume, or current effective state of update. </summary>
        public NetAppNetworkFeature? EffectiveNetworkFeatures { get; }
        /// <summary> Network Sibling Set ID for the the group of volumes sharing networking resources. </summary>
        public Guid? NetworkSiblingSetId { get; }
        /// <summary> Provides storage to network proximity information for the volume. </summary>
        public NetAppVolumeStorageToNetworkProximity? StorageToNetworkProximity { get; }
        /// <summary> List of mount targets. </summary>
        public IReadOnlyList<NetAppVolumeMountTarget> MountTargets { get; }
        /// <summary> What type of volume is this. For destination volumes in Cross Region Replication, set type to DataProtection. For creating clone volume, set type to ShortTermClone. </summary>
        public string VolumeType { get; set; }
        /// <summary> DataProtection type volumes include an object containing details of the replication. </summary>
        public NetAppVolumeDataProtection DataProtection { get; set; }
        /// <summary> While auto splitting the short term clone volume, if the parent pool does not have enough space to accommodate the volume after split, it will be automatically resized, which will lead to increased billing. To accept capacity pool size auto grow and create a short term clone volume, set the property as accepted. </summary>
        public AcceptGrowCapacityPoolForShortTermCloneSplit? AcceptGrowCapacityPoolForShortTermCloneSplit { get; set; }
        /// <summary> Restoring. </summary>
        public bool? IsRestoring { get; set; }
        /// <summary> If enabled (true) the volume will contain a read-only snapshot directory which provides access to each of the volume's snapshots (defaults to true). </summary>
        public bool? IsSnapshotDirectoryVisible { get; set; }
        /// <summary> Describe if a volume is KerberosEnabled. To be use with swagger version 2020-05-01 or later. </summary>
        public bool? IsKerberosEnabled { get; set; }
        /// <summary> The security style of volume, default unix, defaults to ntfs for dual protocol or CIFS protocol. </summary>
        public NetAppVolumeSecurityStyle? SecurityStyle { get; set; }
        /// <summary> Enables encryption for in-flight smb3 data. Only applicable for SMB/DualProtocol volume. To be used with swagger version 2020-08-01 or later. </summary>
        public bool? IsSmbEncryptionEnabled { get; set; }
        /// <summary> Enables access-based enumeration share property for SMB Shares. Only applicable for SMB/DualProtocol volume. </summary>
        public SmbAccessBasedEnumeration? SmbAccessBasedEnumeration { get; set; }
        /// <summary> Enables non-browsable property for SMB Shares. Only applicable for SMB/DualProtocol volume. </summary>
        public SmbNonBrowsable? SmbNonBrowsable { get; set; }
        /// <summary> Enables continuously available share property for smb volume. Only applicable for SMB volume. </summary>
        public bool? IsSmbContinuouslyAvailable { get; set; }
        /// <summary> Maximum throughput in MiB/s that can be achieved by this volume and this will be accepted as input only for manual qosType volume. </summary>
        public float? ThroughputMibps { get; set; }
        /// <summary> Actual throughput in MiB/s for auto qosType volumes calculated based on size and serviceLevel. </summary>
        public float? ActualThroughputMibps { get; }
        /// <summary> Source of key used to encrypt data in volume. Applicable if NetApp account has encryption.keySource = 'Microsoft.KeyVault'. Possible values (case-insensitive) are: 'Microsoft.NetApp, Microsoft.KeyVault'. </summary>
        public NetAppEncryptionKeySource? EncryptionKeySource { get; set; }
        /// <summary> The resource ID of private endpoint for KeyVault. It must reside in the same VNET as the volume. Only applicable if encryptionKeySource = 'Microsoft.KeyVault'. </summary>
        public ResourceIdentifier KeyVaultPrivateEndpointResourceId { get; set; }
        /// <summary> Specifies whether LDAP is enabled or not for a given NFS volume. </summary>
        public bool? IsLdapEnabled { get; set; }
        /// <summary> Specifies whether Cool Access(tiering) is enabled for the volume. </summary>
        public bool? IsCoolAccessEnabled { get; set; }
        /// <summary> Specifies the number of days after which data that is not accessed by clients will be tiered. </summary>
        public int? CoolnessPeriod { get; set; }
        /// <summary>
        /// coolAccessRetrievalPolicy determines the data retrieval behavior from the cool tier to standard storage based on the read pattern for cool access enabled volumes. The possible values for this field are:
        ///  Default - Data will be pulled from cool tier to standard storage on random reads. This policy is the default.
        ///  OnRead - All client-driven data read is pulled from cool tier to standard storage on both sequential and random reads.
        ///  Never - No client-driven data is pulled from cool tier to standard storage.
        /// </summary>
        public CoolAccessRetrievalPolicy? CoolAccessRetrievalPolicy { get; set; }
        /// <summary> UNIX permissions for NFS volume accepted in octal 4 digit format. First digit selects the set user ID(4), set group ID (2) and sticky (1) attributes. Second digit selects permission for the owner of the file: read (4), write (2) and execute (1). Third selects permissions for other users in the same group. the fourth for other users not in the group. 0755 - gives read/write/execute permissions to owner and read/execute to group and other users.  Avoid passing null value for unixPermissions in volume update operation, As per the behavior, If Null value is passed then user-visible unixPermissions value will became null, and user will not be able to get unixPermissions value. On safer side, actual unixPermissions value on volume will remain as its last saved value only. </summary>
        public string UnixPermissions { get; set; }
        /// <summary> When a volume is being restored from another volume's snapshot, will show the percentage completion of this cloning process. When this value is empty/null there is no cloning process currently happening on this volume. This value will update every 5 minutes during cloning. </summary>
        public int? CloneProgress { get; }
        /// <summary> Flag indicating whether file access logs are enabled for the volume, based on active diagnostic settings present on the volume. </summary>
        public NetAppFileAccessLog? FileAccessLogs { get; }
        /// <summary> Specifies whether the volume is enabled for Azure VMware Solution (AVS) datastore purpose. </summary>
        public NetAppAvsDataStore? AvsDataStore { get; set; }
        /// <summary> Data store resource unique identifier. </summary>
        public IReadOnlyList<ResourceIdentifier> DataStoreResourceId { get; }
        /// <summary> Specifies if default quota is enabled for the volume. </summary>
        public bool? IsDefaultQuotaEnabled { get; set; }
        /// <summary> Default user quota for volume in KiBs. If isDefaultQuotaEnabled is set, the minimum value of 4 KiBs applies . </summary>
        public long? DefaultUserQuotaInKiBs { get; set; }
        /// <summary> Default group quota for volume in KiBs. If isDefaultQuotaEnabled is set, the minimum value of 4 KiBs applies. </summary>
        public long? DefaultGroupQuotaInKiBs { get; set; }
        /// <summary> Maximum number of files allowed. Needs a service request in order to be changed. Only allowed to be changed if volume quota is more than 4TiB. </summary>
        public long? MaximumNumberOfFiles { get; }
        /// <summary> Volume Group Name. </summary>
        public string VolumeGroupName { get; }
        /// <summary> Pool Resource Id used in case of creating a volume through volume group. </summary>
        public ResourceIdentifier CapacityPoolResourceId { get; set; }
        /// <summary> Proximity placement group associated with the volume. </summary>
        public ResourceIdentifier ProximityPlacementGroupId { get; set; }
        /// <summary> T2 network information. </summary>
        public string T2Network { get; }
        /// <summary> Volume spec name is the application specific designation or identifier for the particular volume in a volume group for e.g. data, log. </summary>
        public string VolumeSpecName { get; set; }
        /// <summary> Specifies if the volume is encrypted or not. Only available on volumes created or updated after 2022-01-01. </summary>
        public bool? IsEncrypted { get; }
        /// <summary> Application specific placement rules for the particular volume. </summary>
        public IList<NetAppVolumePlacementRule> PlacementRules { get; }
        /// <summary> Flag indicating whether subvolume operations are enabled on the volume. </summary>
        public EnableNetAppSubvolume? EnableSubvolumes { get; set; }
        /// <summary> The availability zone where the volume is provisioned. This refers to the logical availability zone where the volume resides. </summary>
        public string ProvisionedAvailabilityZone { get; }
        /// <summary> Specifies whether volume is a Large Volume or Regular Volume. </summary>
        public bool? IsLargeVolume { get; set; }
        /// <summary> Id of the snapshot or backup that the volume is restored from. </summary>
        public ResourceIdentifier OriginatingResourceId { get; }
        /// <summary> Space shared by short term clone volume with parent volume in bytes. </summary>
        public long? InheritedSizeInBytes { get; }
        /// <summary> Language supported for volume. </summary>
        public VolumeLanguage? Language { get; set; }
    }
}
