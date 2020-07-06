// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Security.KeyVault.Models
{
    /// <summary> A certificate bundle consists of a certificate (X509) plus its attributes. </summary>
    public partial class CertificateBundle
    {
        /// <summary> Initializes a new instance of CertificateBundle. </summary>
        internal CertificateBundle()
        {
        }

        /// <summary> Initializes a new instance of CertificateBundle. </summary>
        /// <param name="id"> The certificate id. </param>
        /// <param name="kid"> The key id. </param>
        /// <param name="sid"> The secret id. </param>
        /// <param name="x509Thumbprint"> Thumbprint of the certificate. </param>
        /// <param name="policy"> The management policy. </param>
        /// <param name="cer"> CER contents of x509 certificate. </param>
        /// <param name="contentType"> The content type of the secret. </param>
        /// <param name="attributes"> The certificate attributes. </param>
        /// <param name="tags"> Application specific metadata in the form of key-value pairs. </param>
        internal CertificateBundle(string id, string kid, string sid, byte[] x509Thumbprint, CertificatePolicy policy, byte[] cer, string contentType, CertificateAttributes attributes, IReadOnlyDictionary<string, string> tags)
        {
            Id = id;
            Kid = kid;
            Sid = sid;
            X509Thumbprint = x509Thumbprint;
            Policy = policy;
            Cer = cer;
            ContentType = contentType;
            Attributes = attributes;
            Tags = tags;
        }

        /// <summary> The certificate id. </summary>
        public string Id { get; }
        /// <summary> The key id. </summary>
        public string Kid { get; }
        /// <summary> The secret id. </summary>
        public string Sid { get; }
        /// <summary> Thumbprint of the certificate. </summary>
        public byte[] X509Thumbprint { get; }
        /// <summary> The management policy. </summary>
        public CertificatePolicy Policy { get; }
        /// <summary> CER contents of x509 certificate. </summary>
        public byte[] Cer { get; }
        /// <summary> The content type of the secret. </summary>
        public string ContentType { get; }
        /// <summary> The certificate attributes. </summary>
        public CertificateAttributes Attributes { get; }
        /// <summary> Application specific metadata in the form of key-value pairs. </summary>
        public IReadOnlyDictionary<string, string> Tags { get; }
    }
}
