// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Authorization;

namespace Azure.ResourceManager.Authorization.Models
{
    /// <summary> Role management policy assignment list operation result. </summary>
    internal partial class RoleManagementPolicyAssignmentListResult
    {
        /// <summary> Initializes a new instance of RoleManagementPolicyAssignmentListResult. </summary>
        internal RoleManagementPolicyAssignmentListResult()
        {
            Value = new ChangeTrackingList<RoleManagementPolicyAssignmentData>();
        }

        /// <summary> Initializes a new instance of RoleManagementPolicyAssignmentListResult. </summary>
        /// <param name="value"> Role management policy assignment list. </param>
        /// <param name="nextLink"> The URL to use for getting the next set of results. </param>
        internal RoleManagementPolicyAssignmentListResult(IReadOnlyList<RoleManagementPolicyAssignmentData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Role management policy assignment list. </summary>
        public IReadOnlyList<RoleManagementPolicyAssignmentData> Value { get; }
        /// <summary> The URL to use for getting the next set of results. </summary>
        public string NextLink { get; }
    }
}
