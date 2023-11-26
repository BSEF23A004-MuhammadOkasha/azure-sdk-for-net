// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DevCenter.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DevCenter
{
    /// <summary>
    /// A class representing the DevCenterCatalog data model.
    /// Represents a catalog.
    /// </summary>
    public partial class DevCenterCatalogData : ResourceData
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DevCenterCatalogData"/>. </summary>
        public DevCenterCatalogData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DevCenterCatalogData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="gitHub"> Properties for a GitHub catalog type. </param>
        /// <param name="adoGit"> Properties for an Azure DevOps catalog type. </param>
        /// <param name="provisioningState"> The provisioning state of the resource. </param>
        /// <param name="syncState"> The synchronization state of the catalog. </param>
        /// <param name="lastSyncOn"> When the catalog was last synced. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DevCenterCatalogData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, DevCenterGitCatalog gitHub, DevCenterGitCatalog adoGit, DevCenterProvisioningState? provisioningState, DevCenterCatalogSyncState? syncState, DateTimeOffset? lastSyncOn, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            GitHub = gitHub;
            AdoGit = adoGit;
            ProvisioningState = provisioningState;
            SyncState = syncState;
            LastSyncOn = lastSyncOn;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Properties for a GitHub catalog type. </summary>
        public DevCenterGitCatalog GitHub { get; set; }
        /// <summary> Properties for an Azure DevOps catalog type. </summary>
        public DevCenterGitCatalog AdoGit { get; set; }
        /// <summary> The provisioning state of the resource. </summary>
        public DevCenterProvisioningState? ProvisioningState { get; }
        /// <summary> The synchronization state of the catalog. </summary>
        public DevCenterCatalogSyncState? SyncState { get; }
        /// <summary> When the catalog was last synced. </summary>
        public DateTimeOffset? LastSyncOn { get; }
    }
}
