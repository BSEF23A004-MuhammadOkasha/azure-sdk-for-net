// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ConnectedVMwarevSphere.Models
{
    /// <summary> Defines the update resource properties. </summary>
    internal partial class NetworkProfileUpdate
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="NetworkProfileUpdate"/>. </summary>
        public NetworkProfileUpdate()
        {
            NetworkInterfaces = new ChangeTrackingList<NetworkInterfaceUpdate>();
        }

        /// <summary> Initializes a new instance of <see cref="NetworkProfileUpdate"/>. </summary>
        /// <param name="networkInterfaces"> Gets or sets the list of network interfaces associated with the virtual machine. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal NetworkProfileUpdate(IList<NetworkInterfaceUpdate> networkInterfaces, Dictionary<string, BinaryData> rawData)
        {
            NetworkInterfaces = networkInterfaces;
            _rawData = rawData;
        }

        /// <summary> Gets or sets the list of network interfaces associated with the virtual machine. </summary>
        public IList<NetworkInterfaceUpdate> NetworkInterfaces { get; }
    }
}
