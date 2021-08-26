// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Management.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Management
{
    /// <summary> The management group details. </summary>
    public partial class ManagementGroupData : Resource
    {
        /// <summary> Initializes a new instance of ManagementGroup. </summary>
        internal ManagementGroupData()
        {
            Children = new ChangeTrackingList<ManagementGroupChildInfo>();
        }

        /// <summary> Initializes a new instance of ManagementGroup. </summary>
        /// <param name="id"> The fully qualified ID for the management group.  For example, /providers/Microsoft.Management/managementGroups/0000000-0000-0000-0000-000000000000. </param>
        /// <param name="type"> The type of the resource.  For example, Microsoft.Management/managementGroups. </param>
        /// <param name="name"> The name of the management group. For example, 00000000-0000-0000-0000-000000000000. </param>
        /// <param name="tenantId"> The AAD Tenant ID associated with the management group. For example, 00000000-0000-0000-0000-000000000000. </param>
        /// <param name="displayName"> The friendly name of the management group. </param>
        /// <param name="details"> The details of a management group. </param>
        /// <param name="children"> The list of children. </param>
        internal ManagementGroupData(string id, string type, string name, string tenantId, string displayName, ManagementGroupDetails details, IReadOnlyList<ManagementGroupChildInfo> children)
            :base(id, name, type)
        {
            TenantId = tenantId;
            DisplayName = displayName;
            Details = details;
            Children = children;
        }

        /// <summary> The AAD Tenant ID associated with the management group. For example, 00000000-0000-0000-0000-000000000000. </summary>
        public string TenantId { get; }
        /// <summary> The friendly name of the management group. </summary>
        public string DisplayName { get; }
        /// <summary> The details of a management group. </summary>
        public ManagementGroupDetails Details { get; }
        /// <summary> The list of children. </summary>
        public IReadOnlyList<ManagementGroupChildInfo> Children { get; }
    }
}
