// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> Certificate datastore credentials configuration. </summary>
    public partial class CertificateDatastoreCredentials : DatastoreCredentials
    {
        /// <summary> Initializes a new instance of CertificateDatastoreCredentials. </summary>
        /// <param name="clientId"> Service principal client ID. </param>
        /// <param name="secrets"> Service principal secrets. </param>
        /// <param name="tenantId"> ID of the tenant to which the service principal belongs. </param>
        /// <param name="thumbprint"> Thumbprint of the certificate used for authentication. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="secrets"/> or <paramref name="thumbprint"/> is null. </exception>
        public CertificateDatastoreCredentials(Guid clientId, CertificateDatastoreSecrets secrets, Guid tenantId, string thumbprint)
        {
            if (secrets == null)
            {
                throw new ArgumentNullException(nameof(secrets));
            }
            if (thumbprint == null)
            {
                throw new ArgumentNullException(nameof(thumbprint));
            }

            ClientId = clientId;
            Secrets = secrets;
            TenantId = tenantId;
            Thumbprint = thumbprint;
            CredentialsType = CredentialsType.Certificate;
        }

        /// <summary> Initializes a new instance of CertificateDatastoreCredentials. </summary>
        /// <param name="credentialsType"> Credential type used to authentication with storage. </param>
        /// <param name="authorityUrl"> Authority URL used for authentication. </param>
        /// <param name="clientId"> Service principal client ID. </param>
        /// <param name="resourceUrl"> Resource the service principal has access to. </param>
        /// <param name="secrets"> Service principal secrets. </param>
        /// <param name="tenantId"> ID of the tenant to which the service principal belongs. </param>
        /// <param name="thumbprint"> Thumbprint of the certificate used for authentication. </param>
        internal CertificateDatastoreCredentials(CredentialsType credentialsType, string authorityUrl, Guid clientId, string resourceUrl, CertificateDatastoreSecrets secrets, Guid tenantId, string thumbprint) : base(credentialsType)
        {
            AuthorityUrl = authorityUrl;
            ClientId = clientId;
            ResourceUrl = resourceUrl;
            Secrets = secrets;
            TenantId = tenantId;
            Thumbprint = thumbprint;
            CredentialsType = credentialsType;
        }

        /// <summary> Authority URL used for authentication. </summary>
        public string AuthorityUrl { get; set; }
        /// <summary> Service principal client ID. </summary>
        public Guid ClientId { get; set; }
        /// <summary> Resource the service principal has access to. </summary>
        public string ResourceUrl { get; set; }
        /// <summary> Service principal secrets. </summary>
        public CertificateDatastoreSecrets Secrets { get; set; }
        /// <summary> ID of the tenant to which the service principal belongs. </summary>
        public Guid TenantId { get; set; }
        /// <summary> Thumbprint of the certificate used for authentication. </summary>
        public string Thumbprint { get; set; }
    }
}
