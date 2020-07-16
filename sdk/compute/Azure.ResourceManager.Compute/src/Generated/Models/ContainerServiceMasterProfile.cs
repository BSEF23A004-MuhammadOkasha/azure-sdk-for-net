// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Profile for the container service master. </summary>
    public partial class ContainerServiceMasterProfile
    {
        /// <summary> Initializes a new instance of ContainerServiceMasterProfile. </summary>
        /// <param name="dnsPrefix"> DNS prefix to be used to create the FQDN for master. </param>
        public ContainerServiceMasterProfile(string dnsPrefix)
        {
            if (dnsPrefix == null)
            {
                throw new ArgumentNullException(nameof(dnsPrefix));
            }

            DnsPrefix = dnsPrefix;
        }

        /// <summary> Initializes a new instance of ContainerServiceMasterProfile. </summary>
        /// <param name="count"> Number of masters (VMs) in the container service cluster. Allowed values are 1, 3, and 5. The default value is 1. </param>
        /// <param name="dnsPrefix"> DNS prefix to be used to create the FQDN for master. </param>
        /// <param name="fqdn"> FQDN for the master. </param>
        internal ContainerServiceMasterProfile(Enum31? count, string dnsPrefix, string fqdn)
        {
            Count = count;
            DnsPrefix = dnsPrefix;
            Fqdn = fqdn;
        }

        /// <summary> Number of masters (VMs) in the container service cluster. Allowed values are 1, 3, and 5. The default value is 1. </summary>
        public Enum31? Count { get; set; }
        /// <summary> DNS prefix to be used to create the FQDN for master. </summary>
        public string DnsPrefix { get; set; }
        /// <summary> FQDN for the master. </summary>
        public string Fqdn { get; }
    }
}
