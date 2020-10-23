// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Disk resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Disk : Resource
    {
        /// <summary>
        /// Initializes a new instance of the Disk class.
        /// </summary>
        public Disk()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Disk class.
        /// </summary>
        /// <param name="location">Resource location</param>
        /// <param name="creationData">Disk source information. CreationData
        /// information cannot be changed after the disk has been
        /// created.</param>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource name</param>
        /// <param name="type">Resource type</param>
        /// <param name="tags">Resource tags</param>
        /// <param name="managedBy">A relative URI containing the ID of the VM
        /// that has the disk attached.</param>
        /// <param name="managedByExtended">List of relative URIs containing
        /// the IDs of the VMs that have the disk attached. maxShares should be
        /// set to a value greater than one for disks to allow attaching them
        /// to multiple VMs.</param>
        /// <param name="zones">The Logical zone list for Disk.</param>
        /// <param name="timeCreated">The time when the disk was
        /// created.</param>
        /// <param name="osType">The Operating System type. Possible values
        /// include: 'Windows', 'Linux'</param>
        /// <param name="hyperVGeneration">The hypervisor generation of the
        /// Virtual Machine. Applicable to OS disks only. Possible values
        /// include: 'V1', 'V2'</param>
        /// <param name="diskSizeGB">If creationData.createOption is Empty,
        /// this field is mandatory and it indicates the size of the disk to
        /// create. If this field is present for updates or creation with other
        /// options, it indicates a resize. Resizes are only allowed if the
        /// disk is not attached to a running VM, and can only increase the
        /// disk's size.</param>
        /// <param name="diskSizeBytes">The size of the disk in bytes. This
        /// field is read only.</param>
        /// <param name="uniqueId">Unique Guid identifying the
        /// resource.</param>
        /// <param name="encryptionSettingsCollection">Encryption settings
        /// collection used for Azure Disk Encryption, can contain multiple
        /// encryption settings per disk or snapshot.</param>
        /// <param name="provisioningState">The disk provisioning
        /// state.</param>
        /// <param name="diskIOPSReadWrite">The number of IOPS allowed for this
        /// disk; only settable for UltraSSD disks. One operation can transfer
        /// between 4k and 256k bytes.</param>
        /// <param name="diskMBpsReadWrite">The bandwidth allowed for this
        /// disk; only settable for UltraSSD disks. MBps means millions of
        /// bytes per second - MB here uses the ISO notation, of powers of
        /// 10.</param>
        /// <param name="diskIOPSReadOnly">The total number of IOPS that will
        /// be allowed across all VMs mounting the shared disk as ReadOnly. One
        /// operation can transfer between 4k and 256k bytes.</param>
        /// <param name="diskMBpsReadOnly">The total throughput (MBps) that
        /// will be allowed across all VMs mounting the shared disk as
        /// ReadOnly. MBps means millions of bytes per second - MB here uses
        /// the ISO notation, of powers of 10.</param>
        /// <param name="diskState">The state of the disk. Possible values
        /// include: 'Unattached', 'Attached', 'Reserved', 'ActiveSAS',
        /// 'ReadyToUpload', 'ActiveUpload'</param>
        /// <param name="encryption">Encryption property can be used to encrypt
        /// data at rest with customer managed keys or platform managed
        /// keys.</param>
        /// <param name="maxShares">The maximum number of VMs that can attach
        /// to the disk at the same time. Value greater than one indicates a
        /// disk that can be mounted on multiple VMs at the same time.</param>
        /// <param name="shareInfo">Details of the list of all VMs that have
        /// the disk attached. maxShares should be set to a value greater than
        /// one for disks to allow attaching them to multiple VMs.</param>
        /// <param name="networkAccessPolicy">Possible values include:
        /// 'AllowAll', 'AllowPrivate', 'DenyAll'</param>
        /// <param name="diskAccessId">ARM id of the DiskAccess resource for
        /// using private endpoints on disks.</param>
        /// <param name="tier">Performance tier of the disk (e.g, P4, S10) as
        /// described here:
        /// https://azure.microsoft.com/en-us/pricing/details/managed-disks/.
        /// Does not apply to Ultra disks.</param>
        public Disk(string location, CreationData creationData, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string managedBy = default(string), IList<string> managedByExtended = default(IList<string>), DiskSku sku = default(DiskSku), IList<string> zones = default(IList<string>), System.DateTime? timeCreated = default(System.DateTime?), OperatingSystemTypes? osType = default(OperatingSystemTypes?), string hyperVGeneration = default(string), int? diskSizeGB = default(int?), long? diskSizeBytes = default(long?), string uniqueId = default(string), EncryptionSettingsCollection encryptionSettingsCollection = default(EncryptionSettingsCollection), string provisioningState = default(string), long? diskIOPSReadWrite = default(long?), long? diskMBpsReadWrite = default(long?), long? diskIOPSReadOnly = default(long?), long? diskMBpsReadOnly = default(long?), string diskState = default(string), Encryption encryption = default(Encryption), int? maxShares = default(int?), IList<ShareInfoElement> shareInfo = default(IList<ShareInfoElement>), string networkAccessPolicy = default(string), string diskAccessId = default(string), string tier = default(string))
            : base(location, id, name, type, tags)
        {
            ManagedBy = managedBy;
            ManagedByExtended = managedByExtended;
            Sku = sku;
            Zones = zones;
            TimeCreated = timeCreated;
            OsType = osType;
            HyperVGeneration = hyperVGeneration;
            CreationData = creationData;
            DiskSizeGB = diskSizeGB;
            DiskSizeBytes = diskSizeBytes;
            UniqueId = uniqueId;
            EncryptionSettingsCollection = encryptionSettingsCollection;
            ProvisioningState = provisioningState;
            DiskIOPSReadWrite = diskIOPSReadWrite;
            DiskMBpsReadWrite = diskMBpsReadWrite;
            DiskIOPSReadOnly = diskIOPSReadOnly;
            DiskMBpsReadOnly = diskMBpsReadOnly;
            DiskState = diskState;
            Encryption = encryption;
            MaxShares = maxShares;
            ShareInfo = shareInfo;
            NetworkAccessPolicy = networkAccessPolicy;
            DiskAccessId = diskAccessId;
            Tier = tier;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets a relative URI containing the ID of the VM that has the disk
        /// attached.
        /// </summary>
        [JsonProperty(PropertyName = "managedBy")]
        public string ManagedBy { get; private set; }

        /// <summary>
        /// Gets list of relative URIs containing the IDs of the VMs that have
        /// the disk attached. maxShares should be set to a value greater than
        /// one for disks to allow attaching them to multiple VMs.
        /// </summary>
        [JsonProperty(PropertyName = "managedByExtended")]
        public IList<string> ManagedByExtended { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public DiskSku Sku { get; set; }

        /// <summary>
        /// Gets or sets the Logical zone list for Disk.
        /// </summary>
        [JsonProperty(PropertyName = "zones")]
        public IList<string> Zones { get; set; }

        /// <summary>
        /// Gets the time when the disk was created.
        /// </summary>
        [JsonProperty(PropertyName = "properties.timeCreated")]
        public System.DateTime? TimeCreated { get; private set; }

        /// <summary>
        /// Gets or sets the Operating System type. Possible values include:
        /// 'Windows', 'Linux'
        /// </summary>
        [JsonProperty(PropertyName = "properties.osType")]
        public OperatingSystemTypes? OsType { get; set; }

        /// <summary>
        /// Gets or sets the hypervisor generation of the Virtual Machine.
        /// Applicable to OS disks only. Possible values include: 'V1', 'V2'
        /// </summary>
        [JsonProperty(PropertyName = "properties.hyperVGeneration")]
        public string HyperVGeneration { get; set; }

        /// <summary>
        /// Gets or sets disk source information. CreationData information
        /// cannot be changed after the disk has been created.
        /// </summary>
        [JsonProperty(PropertyName = "properties.creationData")]
        public CreationData CreationData { get; set; }

        /// <summary>
        /// Gets or sets if creationData.createOption is Empty, this field is
        /// mandatory and it indicates the size of the disk to create. If this
        /// field is present for updates or creation with other options, it
        /// indicates a resize. Resizes are only allowed if the disk is not
        /// attached to a running VM, and can only increase the disk's size.
        /// </summary>
        [JsonProperty(PropertyName = "properties.diskSizeGB")]
        public int? DiskSizeGB { get; set; }

        /// <summary>
        /// Gets the size of the disk in bytes. This field is read only.
        /// </summary>
        [JsonProperty(PropertyName = "properties.diskSizeBytes")]
        public long? DiskSizeBytes { get; private set; }

        /// <summary>
        /// Gets unique Guid identifying the resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.uniqueId")]
        public string UniqueId { get; private set; }

        /// <summary>
        /// Gets or sets encryption settings collection used for Azure Disk
        /// Encryption, can contain multiple encryption settings per disk or
        /// snapshot.
        /// </summary>
        [JsonProperty(PropertyName = "properties.encryptionSettingsCollection")]
        public EncryptionSettingsCollection EncryptionSettingsCollection { get; set; }

        /// <summary>
        /// Gets the disk provisioning state.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets the number of IOPS allowed for this disk; only
        /// settable for UltraSSD disks. One operation can transfer between 4k
        /// and 256k bytes.
        /// </summary>
        [JsonProperty(PropertyName = "properties.diskIOPSReadWrite")]
        public long? DiskIOPSReadWrite { get; set; }

        /// <summary>
        /// Gets or sets the bandwidth allowed for this disk; only settable for
        /// UltraSSD disks. MBps means millions of bytes per second - MB here
        /// uses the ISO notation, of powers of 10.
        /// </summary>
        [JsonProperty(PropertyName = "properties.diskMBpsReadWrite")]
        public long? DiskMBpsReadWrite { get; set; }

        /// <summary>
        /// Gets or sets the total number of IOPS that will be allowed across
        /// all VMs mounting the shared disk as ReadOnly. One operation can
        /// transfer between 4k and 256k bytes.
        /// </summary>
        [JsonProperty(PropertyName = "properties.diskIOPSReadOnly")]
        public long? DiskIOPSReadOnly { get; set; }

        /// <summary>
        /// Gets or sets the total throughput (MBps) that will be allowed
        /// across all VMs mounting the shared disk as ReadOnly. MBps means
        /// millions of bytes per second - MB here uses the ISO notation, of
        /// powers of 10.
        /// </summary>
        [JsonProperty(PropertyName = "properties.diskMBpsReadOnly")]
        public long? DiskMBpsReadOnly { get; set; }

        /// <summary>
        /// Gets or sets the state of the disk. Possible values include:
        /// 'Unattached', 'Attached', 'Reserved', 'ActiveSAS', 'ReadyToUpload',
        /// 'ActiveUpload'
        /// </summary>
        [JsonProperty(PropertyName = "properties.diskState")]
        public string DiskState { get; set; }

        /// <summary>
        /// Gets or sets encryption property can be used to encrypt data at
        /// rest with customer managed keys or platform managed keys.
        /// </summary>
        [JsonProperty(PropertyName = "properties.encryption")]
        public Encryption Encryption { get; set; }

        /// <summary>
        /// Gets or sets the maximum number of VMs that can attach to the disk
        /// at the same time. Value greater than one indicates a disk that can
        /// be mounted on multiple VMs at the same time.
        /// </summary>
        [JsonProperty(PropertyName = "properties.maxShares")]
        public int? MaxShares { get; set; }

        /// <summary>
        /// Gets details of the list of all VMs that have the disk attached.
        /// maxShares should be set to a value greater than one for disks to
        /// allow attaching them to multiple VMs.
        /// </summary>
        [JsonProperty(PropertyName = "properties.shareInfo")]
        public IList<ShareInfoElement> ShareInfo { get; private set; }

        /// <summary>
        /// Gets or sets possible values include: 'AllowAll', 'AllowPrivate',
        /// 'DenyAll'
        /// </summary>
        [JsonProperty(PropertyName = "properties.networkAccessPolicy")]
        public string NetworkAccessPolicy { get; set; }

        /// <summary>
        /// Gets or sets ARM id of the DiskAccess resource for using private
        /// endpoints on disks.
        /// </summary>
        [JsonProperty(PropertyName = "properties.diskAccessId")]
        public string DiskAccessId { get; set; }

        /// <summary>
        /// Gets or sets performance tier of the disk (e.g, P4, S10) as
        /// described here:
        /// https://azure.microsoft.com/en-us/pricing/details/managed-disks/.
        /// Does not apply to Ultra disks.
        /// </summary>
        [JsonProperty(PropertyName = "properties.tier")]
        public string Tier { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (CreationData == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "CreationData");
            }
            if (CreationData != null)
            {
                CreationData.Validate();
            }
            if (EncryptionSettingsCollection != null)
            {
                EncryptionSettingsCollection.Validate();
            }
        }
    }
}
