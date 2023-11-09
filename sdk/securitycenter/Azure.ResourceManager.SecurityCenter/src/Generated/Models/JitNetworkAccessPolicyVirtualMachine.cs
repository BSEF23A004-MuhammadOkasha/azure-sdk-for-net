// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> The JitNetworkAccessPolicyVirtualMachine. </summary>
    public partial class JitNetworkAccessPolicyVirtualMachine
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="JitNetworkAccessPolicyVirtualMachine"/>. </summary>
        /// <param name="id"> Resource ID of the virtual machine that is linked to this policy. </param>
        /// <param name="ports"> Port configurations for the virtual machine. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> or <paramref name="ports"/> is null. </exception>
        public JitNetworkAccessPolicyVirtualMachine(ResourceIdentifier id, IEnumerable<JitNetworkAccessPortRule> ports)
        {
            Argument.AssertNotNull(id, nameof(id));
            Argument.AssertNotNull(ports, nameof(ports));

            Id = id;
            Ports = ports.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="JitNetworkAccessPolicyVirtualMachine"/>. </summary>
        /// <param name="id"> Resource ID of the virtual machine that is linked to this policy. </param>
        /// <param name="ports"> Port configurations for the virtual machine. </param>
        /// <param name="publicIPAddress"> Public IP address of the Azure Firewall that is linked to this policy, if applicable. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal JitNetworkAccessPolicyVirtualMachine(ResourceIdentifier id, IList<JitNetworkAccessPortRule> ports, string publicIPAddress, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            Ports = ports;
            PublicIPAddress = publicIPAddress;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="JitNetworkAccessPolicyVirtualMachine"/> for deserialization. </summary>
        internal JitNetworkAccessPolicyVirtualMachine()
        {
        }

        /// <summary> Resource ID of the virtual machine that is linked to this policy. </summary>
        public ResourceIdentifier Id { get; set; }
        /// <summary> Port configurations for the virtual machine. </summary>
        public IList<JitNetworkAccessPortRule> Ports { get; }
        /// <summary> Public IP address of the Azure Firewall that is linked to this policy, if applicable. </summary>
        public string PublicIPAddress { get; set; }
    }
}
