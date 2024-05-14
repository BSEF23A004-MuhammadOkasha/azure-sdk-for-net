// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.PolicyInsights.Models
{
    /// <summary> The policy details. </summary>
    public partial class PolicyDetails
    {
        /// <summary> Initializes a new instance of <see cref="PolicyDetails"/>. </summary>
        internal PolicyDetails()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PolicyDetails"/>. </summary>
        /// <param name="policyDefinitionId"> The ID of the policy definition. </param>
        /// <param name="policyAssignmentId"> The ID of the policy assignment. </param>
        /// <param name="policyAssignmentDisplayName"> The display name of the policy assignment. </param>
        /// <param name="policyAssignmentScope"> The scope of the policy assignment. </param>
        /// <param name="policySetDefinitionId"> The ID of the policy set definition. </param>
        /// <param name="policyDefinitionReferenceId"> The policy definition reference ID within the policy set definition. </param>
        internal PolicyDetails(ResourceIdentifier policyDefinitionId, ResourceIdentifier policyAssignmentId, string policyAssignmentDisplayName, string policyAssignmentScope, ResourceIdentifier policySetDefinitionId, string policyDefinitionReferenceId)
        {
            PolicyDefinitionId = policyDefinitionId;
            PolicyAssignmentId = policyAssignmentId;
            PolicyAssignmentDisplayName = policyAssignmentDisplayName;
            PolicyAssignmentScope = policyAssignmentScope;
            PolicySetDefinitionId = policySetDefinitionId;
            PolicyDefinitionReferenceId = policyDefinitionReferenceId;
        }

        /// <summary> The ID of the policy definition. </summary>
        public ResourceIdentifier PolicyDefinitionId { get; }
        /// <summary> The ID of the policy assignment. </summary>
        public ResourceIdentifier PolicyAssignmentId { get; }
        /// <summary> The display name of the policy assignment. </summary>
        public string PolicyAssignmentDisplayName { get; }
        /// <summary> The scope of the policy assignment. </summary>
        public string PolicyAssignmentScope { get; }
        /// <summary> The ID of the policy set definition. </summary>
        public ResourceIdentifier PolicySetDefinitionId { get; }
        /// <summary> The policy definition reference ID within the policy set definition. </summary>
        public string PolicyDefinitionReferenceId { get; }
    }
}
