// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.BatchAI.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Details of volumes to mount on the cluster.
    /// </summary>
    public partial class MountVolumes
    {
        /// <summary>
        /// Initializes a new instance of the MountVolumes class.
        /// </summary>
        public MountVolumes()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MountVolumes class.
        /// </summary>
        /// <param name="azureFileShares">Azure File Share setup
        /// configuration.</param>
        /// <param name="azureBlobFileSystems">Azure Blob FileSystem setup
        /// configuration.</param>
        /// <param name="fileServers">References to a list of file servers that
        /// are mounted to the cluster node.</param>
        /// <param name="unmanagedFileSystems">References to a list of file
        /// servers that are mounted to the cluster node.</param>
        public MountVolumes(IList<AzureFileShareReference> azureFileShares = default(IList<AzureFileShareReference>), IList<AzureBlobFileSystemReference> azureBlobFileSystems = default(IList<AzureBlobFileSystemReference>), IList<FileServerReference> fileServers = default(IList<FileServerReference>), IList<UnmanagedFileSystemReference> unmanagedFileSystems = default(IList<UnmanagedFileSystemReference>))
        {
            AzureFileShares = azureFileShares;
            AzureBlobFileSystems = azureBlobFileSystems;
            FileServers = fileServers;
            UnmanagedFileSystems = unmanagedFileSystems;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets azure File Share setup configuration.
        /// </summary>
        /// <remarks>
        /// Azure File will be mounted to the cluster node.
        /// </remarks>
        [JsonProperty(PropertyName = "azureFileShares")]
        public IList<AzureFileShareReference> AzureFileShares { get; set; }

        /// <summary>
        /// Gets or sets azure Blob FileSystem setup configuration.
        /// </summary>
        /// <remarks>
        /// Azure Blob file system will be mounted to the cluster node.
        /// </remarks>
        [JsonProperty(PropertyName = "azureBlobFileSystems")]
        public IList<AzureBlobFileSystemReference> AzureBlobFileSystems { get; set; }

        /// <summary>
        /// Gets or sets references to a list of file servers that are mounted
        /// to the cluster node.
        /// </summary>
        [JsonProperty(PropertyName = "fileServers")]
        public IList<FileServerReference> FileServers { get; set; }

        /// <summary>
        /// Gets or sets references to a list of file servers that are mounted
        /// to the cluster node.
        /// </summary>
        [JsonProperty(PropertyName = "unmanagedFileSystems")]
        public IList<UnmanagedFileSystemReference> UnmanagedFileSystems { get; set; }

    }
}
