// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DevTestLabs.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A Disk.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class DiskFragment : UpdateResource
    {
        /// <summary>
        /// Initializes a new instance of the DiskFragment class.
        /// </summary>
        public DiskFragment()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DiskFragment class.
        /// </summary>
        /// <param name="tags">The tags of the resource.</param>
        /// <param name="diskType">The storage type for the disk (i.e.
        /// Standard, Premium). Possible values include: 'Standard',
        /// 'Premium'</param>
        /// <param name="diskSizeGiB">The size of the disk in
        /// GibiBytes.</param>
        /// <param name="leasedByLabVmId">The resource ID of the VM to which
        /// this disk is leased.</param>
        /// <param name="diskBlobName">When backed by a blob, the name of the
        /// VHD blob without extension.</param>
        /// <param name="diskUri">When backed by a blob, the URI of underlying
        /// blob.</param>
        /// <param name="hostCaching">The host caching policy of the disk (i.e.
        /// None, ReadOnly, ReadWrite).</param>
        /// <param name="managedDiskId">When backed by managed disk, this is
        /// the ID of the compute disk resource.</param>
        public DiskFragment(IDictionary<string, string> tags = default(IDictionary<string, string>), string diskType = default(string), int? diskSizeGiB = default(int?), string leasedByLabVmId = default(string), string diskBlobName = default(string), string diskUri = default(string), string hostCaching = default(string), string managedDiskId = default(string))
            : base(tags)
        {
            DiskType = diskType;
            DiskSizeGiB = diskSizeGiB;
            LeasedByLabVmId = leasedByLabVmId;
            DiskBlobName = diskBlobName;
            DiskUri = diskUri;
            HostCaching = hostCaching;
            ManagedDiskId = managedDiskId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the storage type for the disk (i.e. Standard,
        /// Premium). Possible values include: 'Standard', 'Premium'
        /// </summary>
        [JsonProperty(PropertyName = "properties.diskType")]
        public string DiskType { get; set; }

        /// <summary>
        /// Gets or sets the size of the disk in GibiBytes.
        /// </summary>
        [JsonProperty(PropertyName = "properties.diskSizeGiB")]
        public int? DiskSizeGiB { get; set; }

        /// <summary>
        /// Gets or sets the resource ID of the VM to which this disk is
        /// leased.
        /// </summary>
        [JsonProperty(PropertyName = "properties.leasedByLabVmId")]
        public string LeasedByLabVmId { get; set; }

        /// <summary>
        /// Gets or sets when backed by a blob, the name of the VHD blob
        /// without extension.
        /// </summary>
        [JsonProperty(PropertyName = "properties.diskBlobName")]
        public string DiskBlobName { get; set; }

        /// <summary>
        /// Gets or sets when backed by a blob, the URI of underlying blob.
        /// </summary>
        [JsonProperty(PropertyName = "properties.diskUri")]
        public string DiskUri { get; set; }

        /// <summary>
        /// Gets or sets the host caching policy of the disk (i.e. None,
        /// ReadOnly, ReadWrite).
        /// </summary>
        [JsonProperty(PropertyName = "properties.hostCaching")]
        public string HostCaching { get; set; }

        /// <summary>
        /// Gets or sets when backed by managed disk, this is the ID of the
        /// compute disk resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.managedDiskId")]
        public string ManagedDiskId { get; set; }

    }
}
