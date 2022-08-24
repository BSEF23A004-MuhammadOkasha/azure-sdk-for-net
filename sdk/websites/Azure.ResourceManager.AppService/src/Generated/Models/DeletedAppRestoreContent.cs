// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary>
    /// Details about restoring a deleted app.
    /// Serialized Name: DeletedAppRestoreRequest
    /// </summary>
    public partial class DeletedAppRestoreContent : ResourceData
    {
        /// <summary> Initializes a new instance of DeletedAppRestoreContent. </summary>
        public DeletedAppRestoreContent()
        {
        }

        /// <summary> Initializes a new instance of DeletedAppRestoreContent. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="deletedSiteId">
        /// ARM resource ID of the deleted app. Example:
        /// /subscriptions/{subId}/providers/Microsoft.Web/deletedSites/{deletedSiteId}
        /// Serialized Name: DeletedAppRestoreRequest.properties.deletedSiteId
        /// </param>
        /// <param name="recoverConfiguration">
        /// If true, deleted site configuration, in addition to content, will be restored.
        /// Serialized Name: DeletedAppRestoreRequest.properties.recoverConfiguration
        /// </param>
        /// <param name="snapshotTime">
        /// Point in time to restore the deleted app from, formatted as a DateTime string. 
        /// If unspecified, default value is the time that the app was deleted.
        /// Serialized Name: DeletedAppRestoreRequest.properties.snapshotTime
        /// </param>
        /// <param name="useDRSecondary">
        /// If true, the snapshot is retrieved from DRSecondary endpoint.
        /// Serialized Name: DeletedAppRestoreRequest.properties.useDRSecondary
        /// </param>
        /// <param name="kind">
        /// Kind of resource.
        /// Serialized Name: ProxyOnlyResource.kind
        /// </param>
        internal DeletedAppRestoreContent(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ResourceIdentifier deletedSiteId, bool? recoverConfiguration, string snapshotTime, bool? useDRSecondary, string kind) : base(id, name, resourceType, systemData)
        {
            DeletedSiteId = deletedSiteId;
            RecoverConfiguration = recoverConfiguration;
            SnapshotTime = snapshotTime;
            UseDRSecondary = useDRSecondary;
            Kind = kind;
        }

        /// <summary>
        /// ARM resource ID of the deleted app. Example:
        /// /subscriptions/{subId}/providers/Microsoft.Web/deletedSites/{deletedSiteId}
        /// Serialized Name: DeletedAppRestoreRequest.properties.deletedSiteId
        /// </summary>
        public ResourceIdentifier DeletedSiteId { get; set; }
        /// <summary>
        /// If true, deleted site configuration, in addition to content, will be restored.
        /// Serialized Name: DeletedAppRestoreRequest.properties.recoverConfiguration
        /// </summary>
        public bool? RecoverConfiguration { get; set; }
        /// <summary>
        /// Point in time to restore the deleted app from, formatted as a DateTime string. 
        /// If unspecified, default value is the time that the app was deleted.
        /// Serialized Name: DeletedAppRestoreRequest.properties.snapshotTime
        /// </summary>
        public string SnapshotTime { get; set; }
        /// <summary>
        /// If true, the snapshot is retrieved from DRSecondary endpoint.
        /// Serialized Name: DeletedAppRestoreRequest.properties.useDRSecondary
        /// </summary>
        public bool? UseDRSecondary { get; set; }
        /// <summary>
        /// Kind of resource.
        /// Serialized Name: ProxyOnlyResource.kind
        /// </summary>
        public string Kind { get; set; }
    }
}
