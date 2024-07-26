// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A class representing the StaticSiteLinkedBackend data model.
    /// Static Site Linked Backend ARM resource.
    /// </summary>
    public partial class StaticSiteLinkedBackendData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="StaticSiteLinkedBackendData"/>. </summary>
        public StaticSiteLinkedBackendData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="StaticSiteLinkedBackendData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="backendResourceId"> The resource id of the backend linked to the static site. </param>
        /// <param name="region"> The region of the backend linked to the static site. </param>
        /// <param name="createdOn"> The date and time on which the backend was linked to the static site. </param>
        /// <param name="provisioningState"> The provisioning state of the linking process. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal StaticSiteLinkedBackendData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ResourceIdentifier backendResourceId, string region, DateTimeOffset? createdOn, string provisioningState, string kind, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            BackendResourceId = backendResourceId;
            Region = region;
            CreatedOn = createdOn;
            ProvisioningState = provisioningState;
            Kind = kind;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The resource id of the backend linked to the static site. </summary>
        [WirePath("properties.backendResourceId")]
        public ResourceIdentifier BackendResourceId { get; set; }
        /// <summary> The region of the backend linked to the static site. </summary>
        [WirePath("properties.region")]
        public string Region { get; set; }
        /// <summary> The date and time on which the backend was linked to the static site. </summary>
        [WirePath("properties.createdOn")]
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> The provisioning state of the linking process. </summary>
        [WirePath("properties.provisioningState")]
        public string ProvisioningState { get; }
        /// <summary> Kind of resource. </summary>
        [WirePath("kind")]
        public string Kind { get; set; }
    }
}
