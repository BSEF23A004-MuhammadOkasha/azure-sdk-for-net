// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Hci.Models
{
    /// <summary> The HostNetwork of a cluster. </summary>
    public partial class HciClusterHostNetwork
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

        /// <summary> Initializes a new instance of <see cref="HciClusterHostNetwork"/>. </summary>
        public HciClusterHostNetwork()
        {
            Intents = new ChangeTrackingList<HciClusterIntents>();
            StorageNetworks = new ChangeTrackingList<HciClusterStorageNetworks>();
        }

        /// <summary> Initializes a new instance of <see cref="HciClusterHostNetwork"/>. </summary>
        /// <param name="intents"> The network intents assigned to the network reference pattern used for the deployment. Each intent will define its own name, traffic type, adapter names, and overrides as recommended by your OEM. </param>
        /// <param name="storageNetworks"> List of StorageNetworks config to deploy AzureStackHCI Cluster. </param>
        /// <param name="storageConnectivitySwitchless"> Defines how the storage adapters between nodes are connected either switch or switch less.. </param>
        /// <param name="enableStorageAutoIP"> Optional parameter required only for 3 Nodes Switchless deployments. This allows users to specify IPs and Mask for Storage NICs when Network ATC is not assigning the IPs for storage automatically. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal HciClusterHostNetwork(IList<HciClusterIntents> intents, IList<HciClusterStorageNetworks> storageNetworks, bool? storageConnectivitySwitchless, bool? enableStorageAutoIP, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Intents = intents;
            StorageNetworks = storageNetworks;
            StorageConnectivitySwitchless = storageConnectivitySwitchless;
            EnableStorageAutoIP = enableStorageAutoIP;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The network intents assigned to the network reference pattern used for the deployment. Each intent will define its own name, traffic type, adapter names, and overrides as recommended by your OEM. </summary>
        [WirePath("intents")]
        public IList<HciClusterIntents> Intents { get; }
        /// <summary> List of StorageNetworks config to deploy AzureStackHCI Cluster. </summary>
        [WirePath("storageNetworks")]
        public IList<HciClusterStorageNetworks> StorageNetworks { get; }
        /// <summary> Defines how the storage adapters between nodes are connected either switch or switch less.. </summary>
        [WirePath("storageConnectivitySwitchless")]
        public bool? StorageConnectivitySwitchless { get; set; }
        /// <summary> Optional parameter required only for 3 Nodes Switchless deployments. This allows users to specify IPs and Mask for Storage NICs when Network ATC is not assigning the IPs for storage automatically. </summary>
        [WirePath("enableStorageAutoIp")]
        public bool? EnableStorageAutoIP { get; set; }
    }
}
