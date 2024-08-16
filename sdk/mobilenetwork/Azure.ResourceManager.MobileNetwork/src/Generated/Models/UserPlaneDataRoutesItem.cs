// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.MobileNetwork.Models
{
    /// <summary>
    /// The UserPlaneDataRoutesItem.
    /// Serialized Name: UserPlaneDataRoutesItem
    /// </summary>
    public partial class UserPlaneDataRoutesItem
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

        /// <summary> Initializes a new instance of <see cref="UserPlaneDataRoutesItem"/>. </summary>
        public UserPlaneDataRoutesItem()
        {
            Routes = new ChangeTrackingList<MobileNetworkIPv4Route>();
        }

        /// <summary> Initializes a new instance of <see cref="UserPlaneDataRoutesItem"/>. </summary>
        /// <param name="attachedDataNetwork">
        /// Reference to an attached data network resource.
        /// Serialized Name: UserPlaneDataRoutesItem.attachedDataNetwork
        /// </param>
        /// <param name="routes">
        /// A list of IPv4 routes.
        /// Serialized Name: UserPlaneDataRoutesItem.routes
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UserPlaneDataRoutesItem(WritableSubResource attachedDataNetwork, IList<MobileNetworkIPv4Route> routes, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AttachedDataNetwork = attachedDataNetwork;
            Routes = routes;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// Reference to an attached data network resource.
        /// Serialized Name: UserPlaneDataRoutesItem.attachedDataNetwork
        /// </summary>
        internal WritableSubResource AttachedDataNetwork { get; set; }
        /// <summary> Gets or sets Id. </summary>
        [WirePath("attachedDataNetwork.id")]
        public ResourceIdentifier AttachedDataNetworkId
        {
            get => AttachedDataNetwork is null ? default : AttachedDataNetwork.Id;
            set
            {
                if (AttachedDataNetwork is null)
                    AttachedDataNetwork = new WritableSubResource();
                AttachedDataNetwork.Id = value;
            }
        }

        /// <summary>
        /// A list of IPv4 routes.
        /// Serialized Name: UserPlaneDataRoutesItem.routes
        /// </summary>
        [WirePath("routes")]
        public IList<MobileNetworkIPv4Route> Routes { get; }
    }
}
