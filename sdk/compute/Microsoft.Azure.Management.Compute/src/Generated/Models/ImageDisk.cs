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
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Describes a image disk.
    /// </summary>
    public partial class ImageDisk
    {
        /// <summary>
        /// Initializes a new instance of the ImageDisk class.
        /// </summary>
        public ImageDisk()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ImageDisk class.
        /// </summary>
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
        /// for the managed disk. NOTE: UltraSSD_LRS can only be used with data
        /// disks, it cannot be used with OS Disk. Possible values include:
        /// 'Standard_LRS', 'Premium_LRS', 'StandardSSD_LRS', 'UltraSSD_LRS',
        /// 'Premium_ZRS', 'StandardSSD_ZRS'</param>
        /// <param name="diskEncryptionSet">Specifies the customer managed disk
        /// encryption set resource id for the managed image disk.</param>
        public ImageDisk(SubResource snapshot = default(SubResource), SubResource managedDisk = default(SubResource), string blobUri = default(string), CachingTypes? caching = default(CachingTypes?), int? diskSizeGB = default(int?), string storageAccountType = default(string), DiskEncryptionSetParameters diskEncryptionSet = default(DiskEncryptionSetParameters))
        {
            Snapshot = snapshot;
            ManagedDisk = managedDisk;
            BlobUri = blobUri;
            Caching = caching;
            DiskSizeGB = diskSizeGB;
            StorageAccountType = storageAccountType;
            DiskEncryptionSet = diskEncryptionSet;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

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
        /// disk. NOTE: UltraSSD_LRS can only be used with data disks, it
        /// cannot be used with OS Disk. Possible values include:
        /// 'Standard_LRS', 'Premium_LRS', 'StandardSSD_LRS', 'UltraSSD_LRS',
        /// 'Premium_ZRS', 'StandardSSD_ZRS'
        /// </summary>
        [JsonProperty(PropertyName = "storageAccountType")]
        public string StorageAccountType { get; set; }

        /// <summary>
        /// Gets or sets specifies the customer managed disk encryption set
        /// resource id for the managed image disk.
        /// </summary>
        [JsonProperty(PropertyName = "diskEncryptionSet")]
        public DiskEncryptionSetParameters DiskEncryptionSet { get; set; }

    }
}
