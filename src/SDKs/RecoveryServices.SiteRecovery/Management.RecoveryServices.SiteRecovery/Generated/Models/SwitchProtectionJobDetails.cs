// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.RecoveryServices;
    using Microsoft.Azure.Management.RecoveryServices.SiteRecovery;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// This class represents details for switch protection job.
    /// </summary>
    public partial class SwitchProtectionJobDetails : JobDetails
    {
        /// <summary>
        /// Initializes a new instance of the SwitchProtectionJobDetails class.
        /// </summary>
        public SwitchProtectionJobDetails()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SwitchProtectionJobDetails class.
        /// </summary>
        /// <param name="affectedObjectDetails">The affected object properties
        /// like source server, source cloud, target
        /// server, target cloud etc. based on the workflow object
        /// details.</param>
        /// <param name="newReplicationProtectedItemId">ARM Id of the new
        /// replication protected item.</param>
        public SwitchProtectionJobDetails(IDictionary<string, string> affectedObjectDetails = default(IDictionary<string, string>), string newReplicationProtectedItemId = default(string))
            : base(affectedObjectDetails)
        {
            NewReplicationProtectedItemId = newReplicationProtectedItemId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets ARM Id of the new replication protected item.
        /// </summary>
        [JsonProperty(PropertyName = "newReplicationProtectedItemId")]
        public string NewReplicationProtectedItemId { get; set; }

    }
}
