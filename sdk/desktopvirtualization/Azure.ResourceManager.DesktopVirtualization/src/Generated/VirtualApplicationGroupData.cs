// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DesktopVirtualization.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DesktopVirtualization
{
    /// <summary> A class representing the VirtualApplicationGroup data model. </summary>
    public partial class VirtualApplicationGroupData : ResourceModelWithAllowedPropertySet
    {
        /// <summary> Initializes a new instance of VirtualApplicationGroupData. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="hostPoolArmPath"> HostPool arm path of ApplicationGroup. </param>
        /// <param name="applicationGroupType"> Resource Type of ApplicationGroup. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="hostPoolArmPath"/> is null. </exception>
        public VirtualApplicationGroupData(AzureLocation location, string hostPoolArmPath, ApplicationGroupType applicationGroupType) : base(location)
        {
            if (hostPoolArmPath == null)
            {
                throw new ArgumentNullException(nameof(hostPoolArmPath));
            }

            HostPoolArmPath = hostPoolArmPath;
            ApplicationGroupType = applicationGroupType;
        }

        /// <summary> Initializes a new instance of VirtualApplicationGroupData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="managedBy"> The fully qualified resource ID of the resource that manages this resource. Indicates if this resource is managed by another Azure resource. If this is present, complete mode deployment will not delete the resource if it is removed from the template since it is managed by another resource. </param>
        /// <param name="kind"> Metadata used by portal/tooling/etc to render different UX experiences for resources of the same type; e.g. ApiApps are a kind of Microsoft.Web/sites type.  If supported, the resource provider must validate and persist this value. </param>
        /// <param name="etag"> The etag field is *not* required. If it is provided in the response body, it must also be provided as a header per the normal etag convention.  Entity tags are used for comparing two or more entities from the same requested resource. HTTP/1.1 uses entity tags in the etag (section 14.19), If-Match (section 14.24), If-None-Match (section 14.26), and If-Range (section 14.27) header fields. </param>
        /// <param name="identity"></param>
        /// <param name="sku"></param>
        /// <param name="plan"></param>
        /// <param name="objectId"> ObjectId of ApplicationGroup. (internal use). </param>
        /// <param name="description"> Description of ApplicationGroup. </param>
        /// <param name="friendlyName"> Friendly name of ApplicationGroup. </param>
        /// <param name="hostPoolArmPath"> HostPool arm path of ApplicationGroup. </param>
        /// <param name="workspaceArmPath"> Workspace arm path of ApplicationGroup. </param>
        /// <param name="applicationGroupType"> Resource Type of ApplicationGroup. </param>
        /// <param name="migrationRequest"> The registration info of HostPool. </param>
        /// <param name="cloudPcResource"> Is cloud pc resource. </param>
        internal VirtualApplicationGroupData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, string managedBy, string kind, string etag, ResourceModelWithAllowedPropertySetIdentity identity, ResourceModelWithAllowedPropertySetSku sku, ArmPlan plan, string objectId, string description, string friendlyName, string hostPoolArmPath, string workspaceArmPath, ApplicationGroupType applicationGroupType, MigrationRequestProperties migrationRequest, bool? cloudPcResource) : base(id, name, resourceType, systemData, tags, location, managedBy, kind, etag, identity, sku, plan)
        {
            ObjectId = objectId;
            Description = description;
            FriendlyName = friendlyName;
            HostPoolArmPath = hostPoolArmPath;
            WorkspaceArmPath = workspaceArmPath;
            ApplicationGroupType = applicationGroupType;
            MigrationRequest = migrationRequest;
            CloudPcResource = cloudPcResource;
        }

        /// <summary> ObjectId of ApplicationGroup. (internal use). </summary>
        public string ObjectId { get; }
        /// <summary> Description of ApplicationGroup. </summary>
        public string Description { get; set; }
        /// <summary> Friendly name of ApplicationGroup. </summary>
        public string FriendlyName { get; set; }
        /// <summary> HostPool arm path of ApplicationGroup. </summary>
        public string HostPoolArmPath { get; set; }
        /// <summary> Workspace arm path of ApplicationGroup. </summary>
        public string WorkspaceArmPath { get; }
        /// <summary> Resource Type of ApplicationGroup. </summary>
        public ApplicationGroupType ApplicationGroupType { get; set; }
        /// <summary> The registration info of HostPool. </summary>
        public MigrationRequestProperties MigrationRequest { get; set; }
        /// <summary> Is cloud pc resource. </summary>
        public bool? CloudPcResource { get; }
    }
}
