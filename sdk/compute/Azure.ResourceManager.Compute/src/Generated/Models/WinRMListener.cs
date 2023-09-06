// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Describes Protocol and thumbprint of Windows Remote Management listener. </summary>
    public partial class WinRMListener
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="WinRMListener"/>. </summary>
        public WinRMListener()
        {
        }

        /// <summary> Initializes a new instance of <see cref="WinRMListener"/>. </summary>
        /// <param name="protocol"> Specifies the protocol of WinRM listener. Possible values are: **http,** **https.**. </param>
        /// <param name="certificateUri"> This is the URL of a certificate that has been uploaded to Key Vault as a secret. For adding a secret to the Key Vault, see [Add a key or secret to the key vault](https://docs.microsoft.com/azure/key-vault/key-vault-get-started/#add). In this case, your certificate needs to be the Base64 encoding of the following JSON Object which is encoded in UTF-8: &lt;br&gt;&lt;br&gt; {&lt;br&gt;  "data":"&lt;Base64-encoded-certificate&gt;",&lt;br&gt;  "dataType":"pfx",&lt;br&gt;  "password":"&lt;pfx-file-password&gt;"&lt;br&gt;} &lt;br&gt; To install certificates on a virtual machine it is recommended to use the [Azure Key Vault virtual machine extension for Linux](https://docs.microsoft.com/azure/virtual-machines/extensions/key-vault-linux) or the [Azure Key Vault virtual machine extension for Windows](https://docs.microsoft.com/azure/virtual-machines/extensions/key-vault-windows). </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal WinRMListener(WinRMListenerProtocolType? protocol, Uri certificateUri, Dictionary<string, BinaryData> rawData)
        {
            Protocol = protocol;
            CertificateUri = certificateUri;
            _rawData = rawData;
        }

        /// <summary> Specifies the protocol of WinRM listener. Possible values are: **http,** **https.**. </summary>
        public WinRMListenerProtocolType? Protocol { get; set; }
        /// <summary> This is the URL of a certificate that has been uploaded to Key Vault as a secret. For adding a secret to the Key Vault, see [Add a key or secret to the key vault](https://docs.microsoft.com/azure/key-vault/key-vault-get-started/#add). In this case, your certificate needs to be the Base64 encoding of the following JSON Object which is encoded in UTF-8: &lt;br&gt;&lt;br&gt; {&lt;br&gt;  "data":"&lt;Base64-encoded-certificate&gt;",&lt;br&gt;  "dataType":"pfx",&lt;br&gt;  "password":"&lt;pfx-file-password&gt;"&lt;br&gt;} &lt;br&gt; To install certificates on a virtual machine it is recommended to use the [Azure Key Vault virtual machine extension for Linux](https://docs.microsoft.com/azure/virtual-machines/extensions/key-vault-linux) or the [Azure Key Vault virtual machine extension for Windows](https://docs.microsoft.com/azure/virtual-machines/extensions/key-vault-windows). </summary>
        public Uri CertificateUri { get; set; }
    }
}
