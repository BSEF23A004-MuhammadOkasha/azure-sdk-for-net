// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Trusted Root certificates of an application gateway. </summary>
    public partial class ApplicationGatewayTrustedRootCertificate : SubResource
    {
        /// <summary> Initializes a new instance of ApplicationGatewayTrustedRootCertificate. </summary>
        public ApplicationGatewayTrustedRootCertificate()
        {
        }

        /// <summary> Initializes a new instance of ApplicationGatewayTrustedRootCertificate. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Name of the trusted root certificate that is unique within an Application Gateway. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="resourceType"> Type of the resource. </param>
        /// <param name="data"> Certificate public data. </param>
        /// <param name="keyVaultSecretId"> Secret Id of (base-64 encoded unencrypted pfx) &apos;Secret&apos; or &apos;Certificate&apos; object stored in KeyVault. </param>
        /// <param name="provisioningState"> The provisioning state of the trusted root certificate resource. </param>
        internal ApplicationGatewayTrustedRootCertificate(string id, string name, string etag, string resourceType, string data, string keyVaultSecretId, ProvisioningState? provisioningState) : base(id)
        {
            Name = name;
            Etag = etag;
            ResourceType = resourceType;
            Data = data;
            KeyVaultSecretId = keyVaultSecretId;
            ProvisioningState = provisioningState;
        }

        /// <summary> Name of the trusted root certificate that is unique within an Application Gateway. </summary>
        public string Name { get; set; }
        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; }
        /// <summary> Type of the resource. </summary>
        public string ResourceType { get; }
        /// <summary> Certificate public data. </summary>
        public string Data { get; set; }
        /// <summary> Secret Id of (base-64 encoded unencrypted pfx) &apos;Secret&apos; or &apos;Certificate&apos; object stored in KeyVault. </summary>
        public string KeyVaultSecretId { get; set; }
        /// <summary> The provisioning state of the trusted root certificate resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
    }
}
