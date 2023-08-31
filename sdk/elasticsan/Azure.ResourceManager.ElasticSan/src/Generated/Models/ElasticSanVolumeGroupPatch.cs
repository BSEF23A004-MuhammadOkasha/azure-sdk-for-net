// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ElasticSan.Models
{
    /// <summary> Volume Group request. </summary>
    public partial class ElasticSanVolumeGroupPatch
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ElasticSanVolumeGroupPatch"/>. </summary>
        public ElasticSanVolumeGroupPatch()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ElasticSanVolumeGroupPatch"/>. </summary>
        /// <param name="protocolType"> Type of storage target. </param>
        /// <param name="encryption"> Type of encryption. </param>
        /// <param name="networkAcls"> A collection of rules governing the accessibility from specific network locations. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ElasticSanVolumeGroupPatch(StorageTargetType? protocolType, ElasticSanEncryptionType? encryption, NetworkRuleSet networkAcls, Dictionary<string, BinaryData> rawData)
        {
            ProtocolType = protocolType;
            Encryption = encryption;
            NetworkAcls = networkAcls;
            _rawData = rawData;
        }

        /// <summary> Type of storage target. </summary>
        public StorageTargetType? ProtocolType { get; set; }
        /// <summary> Type of encryption. </summary>
        public ElasticSanEncryptionType? Encryption { get; set; }
        /// <summary> A collection of rules governing the accessibility from specific network locations. </summary>
        internal NetworkRuleSet NetworkAcls { get; set; }
        /// <summary> The list of virtual network rules. </summary>
        public IList<ElasticSanVirtualNetworkRule> VirtualNetworkRules
        {
            get
            {
                if (NetworkAcls is null)
                    NetworkAcls = new NetworkRuleSet();
                return NetworkAcls.VirtualNetworkRules;
            }
        }
    }
}
