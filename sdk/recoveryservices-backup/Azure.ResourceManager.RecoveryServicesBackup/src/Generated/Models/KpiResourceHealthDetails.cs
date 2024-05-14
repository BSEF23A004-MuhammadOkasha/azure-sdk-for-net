// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> KPI Resource Health Details. </summary>
    public partial class KpiResourceHealthDetails
    {
        /// <summary> Initializes a new instance of <see cref="KpiResourceHealthDetails"/>. </summary>
        public KpiResourceHealthDetails()
        {
            ResourceHealthDetails = new ChangeTrackingList<ResourceHealthDetails>();
        }

        /// <summary> Initializes a new instance of <see cref="KpiResourceHealthDetails"/>. </summary>
        /// <param name="resourceHealthStatus"> Resource Health Status. </param>
        /// <param name="resourceHealthDetails"> Resource Health Status. </param>
        internal KpiResourceHealthDetails(ResourceHealthStatus? resourceHealthStatus, IList<ResourceHealthDetails> resourceHealthDetails)
        {
            ResourceHealthStatus = resourceHealthStatus;
            ResourceHealthDetails = resourceHealthDetails;
        }

        /// <summary> Resource Health Status. </summary>
        public ResourceHealthStatus? ResourceHealthStatus { get; set; }
        /// <summary> Resource Health Status. </summary>
        public IList<ResourceHealthDetails> ResourceHealthDetails { get; }
    }
}
