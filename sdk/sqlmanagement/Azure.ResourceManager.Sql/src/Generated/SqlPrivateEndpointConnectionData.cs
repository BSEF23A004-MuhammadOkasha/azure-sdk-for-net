// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing the SqlPrivateEndpointConnection data model.
    /// A private endpoint connection
    /// </summary>
    public partial class SqlPrivateEndpointConnectionData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="SqlPrivateEndpointConnectionData"/>. </summary>
        public SqlPrivateEndpointConnectionData()
        {
            GroupIds = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="SqlPrivateEndpointConnectionData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="privateEndpoint"> Private endpoint which the connection belongs to. </param>
        /// <param name="groupIds"> Group IDs. </param>
        /// <param name="connectionState"> Connection state of the private endpoint connection. </param>
        /// <param name="provisioningState"> State of the private endpoint connection. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SqlPrivateEndpointConnectionData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, WritableSubResource privateEndpoint, IReadOnlyList<string> groupIds, SqlPrivateLinkServiceConnectionStateProperty connectionState, SqlPrivateEndpointProvisioningState? provisioningState, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            PrivateEndpoint = privateEndpoint;
            GroupIds = groupIds;
            ConnectionState = connectionState;
            ProvisioningState = provisioningState;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Private endpoint which the connection belongs to. </summary>
        internal WritableSubResource PrivateEndpoint { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier PrivateEndpointId
        {
            get => PrivateEndpoint is null ? default : PrivateEndpoint.Id;
            set
            {
                if (PrivateEndpoint is null)
                    PrivateEndpoint = new WritableSubResource();
                PrivateEndpoint.Id = value;
            }
        }

        /// <summary> Group IDs. </summary>
        public IReadOnlyList<string> GroupIds { get; }
        /// <summary> Connection state of the private endpoint connection. </summary>
        public SqlPrivateLinkServiceConnectionStateProperty ConnectionState { get; set; }
        /// <summary> State of the private endpoint connection. </summary>
        public SqlPrivateEndpointProvisioningState? ProvisioningState { get; }
    }
}
