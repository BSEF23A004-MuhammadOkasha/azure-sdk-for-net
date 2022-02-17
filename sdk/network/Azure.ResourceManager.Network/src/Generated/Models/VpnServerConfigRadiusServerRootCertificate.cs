// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Properties of Radius Server root certificate of VpnServerConfiguration. </summary>
    public partial class VpnServerConfigRadiusServerRootCertificate
    {
        /// <summary> Initializes a new instance of VpnServerConfigRadiusServerRootCertificate. </summary>
        public VpnServerConfigRadiusServerRootCertificate()
        {
        }

        /// <summary> Initializes a new instance of VpnServerConfigRadiusServerRootCertificate. </summary>
        /// <param name="name"> The certificate name. </param>
        /// <param name="publicCertData"> The certificate public data. </param>
        internal VpnServerConfigRadiusServerRootCertificate(string name, string publicCertData)
        {
            Name = name;
            PublicCertData = publicCertData;
        }

        /// <summary> The certificate name. </summary>
        public string Name { get; set; }
        /// <summary> The certificate public data. </summary>
        public string PublicCertData { get; set; }
    }
}
