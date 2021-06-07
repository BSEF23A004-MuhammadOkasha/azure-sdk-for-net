// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace OperationalInsightsManagementClient.Models
{
    /// <summary> The private link scope resource reference. </summary>
    public partial class PrivateLinkScopedResource
    {
        /// <summary> Initializes a new instance of PrivateLinkScopedResource. </summary>
        internal PrivateLinkScopedResource()
        {
        }

        /// <summary> Initializes a new instance of PrivateLinkScopedResource. </summary>
        /// <param name="resourceId"> The full resource Id of the private link scope resource. </param>
        /// <param name="scopeId"> The private link scope unique Identifier. </param>
        internal PrivateLinkScopedResource(string resourceId, string scopeId)
        {
            ResourceId = resourceId;
            ScopeId = scopeId;
        }

        /// <summary> The full resource Id of the private link scope resource. </summary>
        public string ResourceId { get; }
        /// <summary> The private link scope unique Identifier. </summary>
        public string ScopeId { get; }
    }
}
