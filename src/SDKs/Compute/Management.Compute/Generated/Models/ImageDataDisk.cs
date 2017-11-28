// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Compute;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Describes a data disk.
    /// </summary>
    public partial class ImageDataDisk
    {
        /// <summary>
        /// Initializes a new instance of the ImageDataDisk class.
        /// </summary>
        public ImageDataDisk()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ImageDataDisk class.
        /// </summary>
        /// <param name="lun">Specifies the logical unit number of the data
        /// disk. This value is used to identify data disks within the VM and
        /// therefore must be unique for each data disk attached to a
        /// VM.</param>
        /// <param name="snapshot">The snapshot.</param>
        /// <param name="managedDisk">The managedDisk.</param>
        /// <param name="blobUri">The Virtual Hard Disk.</param>
        /// <param name="caching">Specifies the caching requirements.
        /// &lt;br&gt;&lt;br&gt; Possible values are: &lt;br&gt;&lt;br&gt;
        /// **None** &lt;br&gt;&lt;br&gt; **ReadOnly** &lt;br&gt;&lt;br&gt;
        /// **ReadWrite** &lt;br&gt;&lt;br&gt; Default: **None for Standard
        /// storage. ReadOnly for Premium storage**. Possible values include:
        /// 'None', 'ReadOnly', 'ReadWrite'</param>
        /// <param name="diskSizeGB">Specifies the size of empty data disks in
        /// gigabytes. This element can be used to overwrite the name of the
        /// disk in a virtual machine image. &lt;br&gt;&lt;br&gt; This value
        /// cannot be larger than 1023 GB</param>
        /// <param name="storageAccountType">Specifies the storage account type
        /// for the managed disk. Possible values are: Standard_LRS or
        /// Premium_LRS. Possible values include: 'Standard_LRS',
        /// 'Premium_LRS'</param>
        public ImageDataDisk(int lun, SubResource snapshot = default(SubResource), SubResource managedDisk = default(SubResource), string blobUri = default(string), CachingTypes? caching = default(CachingTypes?), int? diskSizeGB = default(int?), StorageAccountTypes? storageAccountType = default(StorageAccountTypes?))
        {
            Lun = lun;
            Snapshot = snapshot;
            ManagedDisk = managedDisk;
            BlobUri = blobUri;
            Caching = caching;
            DiskSizeGB = diskSizeGB;
            StorageAccountType = storageAccountType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets specifies the logical unit number of the data disk.
        /// This value is used to identify data disks within the VM and
        /// therefore must be unique for each data disk attached to a VM.
        /// </summary>
        [JsonProperty(PropertyName = "lun")]
        public int Lun { get; set; }

        /// <summary>
        /// Gets or sets the snapshot.
        /// </summary>
        [JsonProperty(PropertyName = "snapshot")]
        public SubResource Snapshot { get; set; }

        /// <summary>
        /// Gets or sets the managedDisk.
        /// </summary>
        [JsonProperty(PropertyName = "managedDisk")]
        public SubResource ManagedDisk { get; set; }

        /// <summary>
        /// Gets or sets the Virtual Hard Disk.
        /// </summary>
        [JsonProperty(PropertyName = "blobUri")]
        public string BlobUri { get; set; }

        /// <summary>
        /// Gets or sets specifies the caching requirements.
        /// &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; Possible values are:
        /// &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; **None**
        /// &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; **ReadOnly**
        /// &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; **ReadWrite**
        /// &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; Default: **None for Standard
        /// storage. ReadOnly for Premium storage**. Possible values include:
        /// 'None', 'ReadOnly', 'ReadWrite'
        /// </summary>
        [JsonProperty(PropertyName = "caching")]
        public CachingTypes? Caching { get; set; }

        /// <summary>
        /// Gets or sets specifies the size of empty data disks in gigabytes.
        /// This element can be used to overwrite the name of the disk in a
        /// virtual machine image. &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; This
        /// value cannot be larger than 1023 GB
        /// </summary>
        [JsonProperty(PropertyName = "diskSizeGB")]
        public int? DiskSizeGB { get; set; }

        /// <summary>
        /// Gets or sets specifies the storage account type for the managed
        /// disk. Possible values are: Standard_LRS or Premium_LRS. Possible
        /// values include: 'Standard_LRS', 'Premium_LRS'
        /// </summary>
        [JsonProperty(PropertyName = "storageAccountType")]
        public StorageAccountTypes? StorageAccountType { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}
