// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Static sites user roles invitation link resource. </summary>
    public partial class StaticSiteUserInvitationResponseInfo : ResourceData
    {
        /// <summary> Initializes a new instance of StaticSiteUserInvitationResponseInfo. </summary>
        public StaticSiteUserInvitationResponseInfo()
        {
        }

        /// <summary> Initializes a new instance of StaticSiteUserInvitationResponseInfo. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="expiresOn"> The expiration time of the invitation. </param>
        /// <param name="invitationUri"> The url for the invitation link. </param>
        /// <param name="kind"> Kind of resource. </param>
        internal StaticSiteUserInvitationResponseInfo(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, DateTimeOffset? expiresOn, Uri invitationUri, string kind) : base(id, name, resourceType, systemData)
        {
            ExpiresOn = expiresOn;
            InvitationUri = invitationUri;
            Kind = kind;
        }

        /// <summary> The expiration time of the invitation. </summary>
        public DateTimeOffset? ExpiresOn { get; }
        /// <summary> The url for the invitation link. </summary>
        public Uri InvitationUri { get; }
        /// <summary> Kind of resource. </summary>
        public string Kind { get; set; }
    }
}
