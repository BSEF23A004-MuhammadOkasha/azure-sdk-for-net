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
    /// The instance view of a disk restore point.
    /// </summary>
    public partial class DiskRestorePointReplicationStatus
    {
        /// <summary>
        /// Initializes a new instance of the DiskRestorePointReplicationStatus
        /// class.
        /// </summary>
        public DiskRestorePointReplicationStatus()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DiskRestorePointReplicationStatus
        /// class.
        /// </summary>
        /// <param name="status">The resource status information.</param>
        /// <param name="completionPercent">Replication completion
        /// percentage.</param>
        public DiskRestorePointReplicationStatus(InstanceViewStatus status = default(InstanceViewStatus), int? completionPercent = default(int?))
        {
            Status = status;
            CompletionPercent = completionPercent;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the resource status information.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public InstanceViewStatus Status { get; set; }

        /// <summary>
        /// Gets or sets replication completion percentage.
        /// </summary>
        [JsonProperty(PropertyName = "completionPercent")]
        public int? CompletionPercent { get; set; }

    }
}
