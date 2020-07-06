// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Security.KeyVault.Models
{
    /// <summary> The issuer for Key Vault certificate. </summary>
    public partial class IssuerBundle
    {
        /// <summary> Initializes a new instance of IssuerBundle. </summary>
        internal IssuerBundle()
        {
        }

        /// <summary> Initializes a new instance of IssuerBundle. </summary>
        /// <param name="id"> Identifier for the issuer object. </param>
        /// <param name="provider"> The issuer provider. </param>
        /// <param name="credentials"> The credentials to be used for the issuer. </param>
        /// <param name="organizationDetails"> Details of the organization as provided to the issuer. </param>
        /// <param name="attributes"> Attributes of the issuer object. </param>
        internal IssuerBundle(string id, string provider, IssuerCredentials credentials, OrganizationDetails organizationDetails, IssuerAttributes attributes)
        {
            Id = id;
            Provider = provider;
            Credentials = credentials;
            OrganizationDetails = organizationDetails;
            Attributes = attributes;
        }

        /// <summary> Identifier for the issuer object. </summary>
        public string Id { get; }
        /// <summary> The issuer provider. </summary>
        public string Provider { get; }
        /// <summary> The credentials to be used for the issuer. </summary>
        public IssuerCredentials Credentials { get; }
        /// <summary> Details of the organization as provided to the issuer. </summary>
        public OrganizationDetails OrganizationDetails { get; }
        /// <summary> Attributes of the issuer object. </summary>
        public IssuerAttributes Attributes { get; }
    }
}
