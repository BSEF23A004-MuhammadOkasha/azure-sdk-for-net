// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.MobileNetwork.Models
{
    /// <summary> The packet core to delete under a site. </summary>
    public partial class SiteDeletePacketCore
    {
        /// <summary> Initializes a new instance of <see cref="SiteDeletePacketCore"/>. </summary>
        public SiteDeletePacketCore()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SiteDeletePacketCore"/>. </summary>
        /// <param name="packetCore"> Reference to an packet core control plane resource. </param>
        internal SiteDeletePacketCore(SubResource packetCore)
        {
            PacketCore = packetCore;
        }

        /// <summary> Reference to an packet core control plane resource. </summary>
        internal SubResource PacketCore { get; set; }
        /// <summary> Gets Id. </summary>
        public ResourceIdentifier PacketCoreId
        {
            get => PacketCore is null ? default : PacketCore.Id;
        }
    }
}
