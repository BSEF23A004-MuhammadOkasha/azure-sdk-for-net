// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.MachineLearningServices;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> A paginated list of OnlineDeployment entities. </summary>
    internal partial class OnlineDeploymentTrackedResourceArmPaginatedResult
    {
        /// <summary> Initializes a new instance of OnlineDeploymentTrackedResourceArmPaginatedResult. </summary>
        internal OnlineDeploymentTrackedResourceArmPaginatedResult()
        {
            Value = new ChangeTrackingList<OnlineDeploymentDataData>();
        }

        /// <summary> Initializes a new instance of OnlineDeploymentTrackedResourceArmPaginatedResult. </summary>
        /// <param name="nextLink"> The link to the next page of OnlineDeployment objects. If null, there are no additional pages. </param>
        /// <param name="value"> An array of objects of type OnlineDeployment. </param>
        internal OnlineDeploymentTrackedResourceArmPaginatedResult(string nextLink, IReadOnlyList<OnlineDeploymentDataData> value)
        {
            NextLink = nextLink;
            Value = value;
        }

        /// <summary> The link to the next page of OnlineDeployment objects. If null, there are no additional pages. </summary>
        public string NextLink { get; }
        /// <summary> An array of objects of type OnlineDeployment. </summary>
        public IReadOnlyList<OnlineDeploymentDataData> Value { get; }
    }
}
