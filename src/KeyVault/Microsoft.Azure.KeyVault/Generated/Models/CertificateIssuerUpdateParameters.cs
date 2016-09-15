// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.KeyVault.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// The certificate issuer update parameters.
    /// </summary>
    public partial class CertificateIssuerUpdateParameters
    {
        /// <summary>
        /// Initializes a new instance of the
        /// CertificateIssuerUpdateParameters class.
        /// </summary>
        public CertificateIssuerUpdateParameters() { }

        /// <summary>
        /// Initializes a new instance of the
        /// CertificateIssuerUpdateParameters class.
        /// </summary>
        /// <param name="provider">The issuer provider.</param>
        /// <param name="credentials">The credentials to be used for the
        /// issuer.</param>
        /// <param name="organizationDetails">Details of the organization as
        /// provided to the issuer.</param>
        /// <param name="attributes">Attributes of the issuer object.</param>
        public CertificateIssuerUpdateParameters(string provider = default(string), IssuerCredentials credentials = default(IssuerCredentials), OrganizationDetails organizationDetails = default(OrganizationDetails), IssuerAttributes attributes = default(IssuerAttributes))
        {
            Provider = provider;
            Credentials = credentials;
            OrganizationDetails = organizationDetails;
            Attributes = attributes;
        }

        /// <summary>
        /// Gets or sets the issuer provider.
        /// </summary>
        [JsonProperty(PropertyName = "provider")]
        public string Provider { get; set; }

        /// <summary>
        /// Gets or sets the credentials to be used for the issuer.
        /// </summary>
        [JsonProperty(PropertyName = "credentials")]
        public IssuerCredentials Credentials { get; set; }

        /// <summary>
        /// Gets or sets details of the organization as provided to the issuer.
        /// </summary>
        [JsonProperty(PropertyName = "org_details")]
        public OrganizationDetails OrganizationDetails { get; set; }

        /// <summary>
        /// Gets or sets attributes of the issuer object.
        /// </summary>
        [JsonProperty(PropertyName = "attributes")]
        public IssuerAttributes Attributes { get; set; }

    }
}
