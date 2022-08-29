// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.DataShare.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataShare
{
    /// <summary> A class representing the Invitation data model. </summary>
    public partial class InvitationData : ResourceData
    {
        /// <summary> Initializes a new instance of InvitationData. </summary>
        public InvitationData()
        {
        }

        /// <summary> Initializes a new instance of InvitationData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="expireOn"> The expiration date for the invitation and share subscription. </param>
        /// <param name="invitationId"> unique invitation id. </param>
        /// <param name="invitationStatus"> The status of the invitation. </param>
        /// <param name="respondedOn"> The time the recipient responded to the invitation. </param>
        /// <param name="sentOn"> Gets the time at which the invitation was sent. </param>
        /// <param name="targetActiveDirectoryId"> The target Azure AD Id. Can&apos;t be combined with email. </param>
        /// <param name="targetEmail"> The email the invitation is directed to. </param>
        /// <param name="targetObjectId">
        /// The target user or application Id that invitation is being sent to.
        /// Must be specified along TargetActiveDirectoryId. This enables sending
        /// invitations to specific users or applications in an AD tenant.
        /// </param>
        /// <param name="userEmail"> Email of the user who created the resource. </param>
        /// <param name="userName"> Name of the user who created the resource. </param>
        internal InvitationData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, DateTimeOffset? expireOn, string invitationId, InvitationStatus? invitationStatus, DateTimeOffset? respondedOn, DateTimeOffset? sentOn, string targetActiveDirectoryId, string targetEmail, string targetObjectId, string userEmail, string userName) : base(id, name, resourceType, systemData)
        {
            ExpireOn = expireOn;
            InvitationId = invitationId;
            InvitationStatus = invitationStatus;
            RespondedOn = respondedOn;
            SentOn = sentOn;
            TargetActiveDirectoryId = targetActiveDirectoryId;
            TargetEmail = targetEmail;
            TargetObjectId = targetObjectId;
            UserEmail = userEmail;
            UserName = userName;
        }

        /// <summary> The expiration date for the invitation and share subscription. </summary>
        public DateTimeOffset? ExpireOn { get; set; }
        /// <summary> unique invitation id. </summary>
        public string InvitationId { get; }
        /// <summary> The status of the invitation. </summary>
        public InvitationStatus? InvitationStatus { get; }
        /// <summary> The time the recipient responded to the invitation. </summary>
        public DateTimeOffset? RespondedOn { get; }
        /// <summary> Gets the time at which the invitation was sent. </summary>
        public DateTimeOffset? SentOn { get; }
        /// <summary> The target Azure AD Id. Can&apos;t be combined with email. </summary>
        public string TargetActiveDirectoryId { get; set; }
        /// <summary> The email the invitation is directed to. </summary>
        public string TargetEmail { get; set; }
        /// <summary>
        /// The target user or application Id that invitation is being sent to.
        /// Must be specified along TargetActiveDirectoryId. This enables sending
        /// invitations to specific users or applications in an AD tenant.
        /// </summary>
        public string TargetObjectId { get; set; }
        /// <summary> Email of the user who created the resource. </summary>
        public string UserEmail { get; }
        /// <summary> Name of the user who created the resource. </summary>
        public string UserName { get; }
    }
}
