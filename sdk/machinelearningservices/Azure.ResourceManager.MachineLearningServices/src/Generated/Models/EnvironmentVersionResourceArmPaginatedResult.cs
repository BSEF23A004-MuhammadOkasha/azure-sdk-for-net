// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.MachineLearningServices;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> A paginated list of EnvironmentVersion entities. </summary>
    internal partial class EnvironmentVersionResourceArmPaginatedResult
    {
        /// <summary> Initializes a new instance of EnvironmentVersionResourceArmPaginatedResult. </summary>
        internal EnvironmentVersionResourceArmPaginatedResult()
        {
            Value = new ChangeTrackingList<EnvironmentVersionDataData>();
        }

        /// <summary> Initializes a new instance of EnvironmentVersionResourceArmPaginatedResult. </summary>
        /// <param name="nextLink"> The link to the next page of EnvironmentVersion objects. If null, there are no additional pages. </param>
        /// <param name="value"> An array of objects of type EnvironmentVersion. </param>
        internal EnvironmentVersionResourceArmPaginatedResult(string nextLink, IReadOnlyList<EnvironmentVersionDataData> value)
        {
            NextLink = nextLink;
            Value = value;
        }

        /// <summary> The link to the next page of EnvironmentVersion objects. If null, there are no additional pages. </summary>
        public string NextLink { get; }
        /// <summary> An array of objects of type EnvironmentVersion. </summary>
        public IReadOnlyList<EnvironmentVersionDataData> Value { get; }
    }
}
