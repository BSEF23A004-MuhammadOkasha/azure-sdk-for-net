// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.KeyVault.Models
{
    using Azure;
    using KeyVault;
    using Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The certificate import parameters.
    /// </summary>
    public partial class CertificateImportParameters
    {
        /// <summary>
        /// Initializes a new instance of the CertificateImportParameters
        /// class.
        /// </summary>
        public CertificateImportParameters() { }

        /// <summary>
        /// Initializes a new instance of the CertificateImportParameters
        /// class.
        /// </summary>
        /// <param name="base64EncodedCertificate">Base64 encoded
        /// representation of the certificate object to import. This
        /// certificate needs to contain the private key.</param>
        /// <param name="password">If the private key in
        /// base64EncodedCertificate is encrypted, the password used for
        /// encryption.</param>
        /// <param name="certificatePolicy">The management policy for the
        /// certificate.</param>
        /// <param name="certificateAttributes">The attributes of the
        /// certificate (optional).</param>
        /// <param name="tags">Application specific metadata in the form of
        /// key-value pairs.</param>
        public CertificateImportParameters(string base64EncodedCertificate, string password = default(string), CertificatePolicy certificatePolicy = default(CertificatePolicy), CertificateAttributes certificateAttributes = default(CertificateAttributes), IDictionary<string, string> tags = default(IDictionary<string, string>))
        {
            Base64EncodedCertificate = base64EncodedCertificate;
            Password = password;
            CertificatePolicy = certificatePolicy;
            CertificateAttributes = certificateAttributes;
            Tags = tags;
        }

        /// <summary>
        /// Gets or sets base64 encoded representation of the certificate
        /// object to import. This certificate needs to contain the private
        /// key.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Base64EncodedCertificate { get; set; }

        /// <summary>
        /// Gets or sets if the private key in base64EncodedCertificate is
        /// encrypted, the password used for encryption.
        /// </summary>
        [JsonProperty(PropertyName = "pwd")]
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets the management policy for the certificate.
        /// </summary>
        [JsonProperty(PropertyName = "policy")]
        public CertificatePolicy CertificatePolicy { get; set; }

        /// <summary>
        /// Gets or sets the attributes of the certificate (optional).
        /// </summary>
        [JsonProperty(PropertyName = "attributes")]
        public CertificateAttributes CertificateAttributes { get; set; }

        /// <summary>
        /// Gets or sets application specific metadata in the form of key-value
        /// pairs.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Base64EncodedCertificate == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Base64EncodedCertificate");
            }
            if (CertificatePolicy != null)
            {
                CertificatePolicy.Validate();
            }
        }
    }
}

