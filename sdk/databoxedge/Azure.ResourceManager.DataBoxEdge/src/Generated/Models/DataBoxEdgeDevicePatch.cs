// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DataBoxEdge;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    /// <summary> The Data Box Edge/Gateway device patch. </summary>
    public partial class DataBoxEdgeDevicePatch
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

        /// <summary> Initializes a new instance of <see cref="DataBoxEdgeDevicePatch"/>. </summary>
        public DataBoxEdgeDevicePatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="DataBoxEdgeDevicePatch"/>. </summary>
        /// <param name="tags"> The tags attached to the Data Box Edge/Gateway resource. </param>
        /// <param name="identity"> Msi identity of the resource. Current supported identity types: None, SystemAssigned, UserAssigned. </param>
        /// <param name="edgeProfile"> Edge Profile property of the Data Box Edge/Gateway device. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DataBoxEdgeDevicePatch(IDictionary<string, string> tags, ManagedServiceIdentity identity, EdgeProfilePatch edgeProfile, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Tags = tags;
            Identity = identity;
            EdgeProfile = edgeProfile;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The tags attached to the Data Box Edge/Gateway resource. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> Msi identity of the resource. Current supported identity types: None, SystemAssigned, UserAssigned. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> Edge Profile property of the Data Box Edge/Gateway device. </summary>
        internal EdgeProfilePatch EdgeProfile { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier SubscriptionId
        {
            get => EdgeProfile is null ? default : EdgeProfile.SubscriptionId;
            set
            {
                if (EdgeProfile is null)
                    EdgeProfile = new EdgeProfilePatch();
                EdgeProfile.SubscriptionId = value;
            }
        }
    }
}
