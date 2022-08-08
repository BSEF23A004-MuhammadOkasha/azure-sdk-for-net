// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ApiManagement
{
    /// <summary> A class representing the TenantAccessInfo data model. </summary>
    public partial class TenantAccessInfoData : ResourceData
    {
        /// <summary> Initializes a new instance of TenantAccessInfoData. </summary>
        public TenantAccessInfoData()
        {
        }

        /// <summary> Initializes a new instance of TenantAccessInfoData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="accessInfoType"> Access Information type (&apos;access&apos; or &apos;gitAccess&apos;). </param>
        /// <param name="principalId"> Principal (User) Identifier. </param>
        /// <param name="isDirectAccessEnabled"> Determines whether direct access is enabled. </param>
        internal TenantAccessInfoData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string accessInfoType, string principalId, bool? isDirectAccessEnabled) : base(id, name, resourceType, systemData)
        {
            AccessInfoType = accessInfoType;
            PrincipalId = principalId;
            IsDirectAccessEnabled = isDirectAccessEnabled;
        }

        /// <summary> Access Information type (&apos;access&apos; or &apos;gitAccess&apos;). </summary>
        public string AccessInfoType { get; set; }
        /// <summary> Principal (User) Identifier. </summary>
        public string PrincipalId { get; set; }
        /// <summary> Determines whether direct access is enabled. </summary>
        public bool? IsDirectAccessEnabled { get; set; }
    }
}
