// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary>
    /// ARM resource for a certificate order that is purchased through Azure.
    /// Serialized Name: AppServiceCertificateOrderPatchResource
    /// </summary>
    public partial class AppServiceCertificateOrderPatch : ResourceData
    {
        /// <summary> Initializes a new instance of AppServiceCertificateOrderPatch. </summary>
        public AppServiceCertificateOrderPatch()
        {
            Certificates = new ChangeTrackingDictionary<string, AppServiceCertificateProperties>();
            AppServiceCertificateNotRenewableReasons = new ChangeTrackingList<AppServiceCertificateNotRenewableReason>();
        }

        /// <summary> Initializes a new instance of AppServiceCertificateOrderPatch. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="certificates">
        /// State of the Key Vault secret.
        /// Serialized Name: AppServiceCertificateOrderPatchResource.properties.certificates
        /// </param>
        /// <param name="distinguishedName">
        /// Certificate distinguished name.
        /// Serialized Name: AppServiceCertificateOrderPatchResource.properties.distinguishedName
        /// </param>
        /// <param name="domainVerificationToken">
        /// Domain verification token.
        /// Serialized Name: AppServiceCertificateOrderPatchResource.properties.domainVerificationToken
        /// </param>
        /// <param name="validityInYears">
        /// Duration in years (must be 1).
        /// Serialized Name: AppServiceCertificateOrderPatchResource.properties.validityInYears
        /// </param>
        /// <param name="keySize">
        /// Certificate key size.
        /// Serialized Name: AppServiceCertificateOrderPatchResource.properties.keySize
        /// </param>
        /// <param name="productType">
        /// Certificate product type.
        /// Serialized Name: AppServiceCertificateOrderPatchResource.properties.productType
        /// </param>
        /// <param name="isAutoRenew">
        /// &lt;code&gt;true&lt;/code&gt; if the certificate should be automatically renewed when it expires; otherwise, &lt;code&gt;false&lt;/code&gt;.
        /// Serialized Name: AppServiceCertificateOrderPatchResource.properties.autoRenew
        /// </param>
        /// <param name="provisioningState">
        /// Status of certificate order.
        /// Serialized Name: AppServiceCertificateOrderPatchResource.properties.provisioningState
        /// </param>
        /// <param name="status">
        /// Current order status.
        /// Serialized Name: AppServiceCertificateOrderPatchResource.properties.status
        /// </param>
        /// <param name="signedCertificate">
        /// Signed certificate.
        /// Serialized Name: AppServiceCertificateOrderPatchResource.properties.signedCertificate
        /// </param>
        /// <param name="csr">
        /// Last CSR that was created for this order.
        /// Serialized Name: AppServiceCertificateOrderPatchResource.properties.csr
        /// </param>
        /// <param name="intermediate">
        /// Intermediate certificate.
        /// Serialized Name: AppServiceCertificateOrderPatchResource.properties.intermediate
        /// </param>
        /// <param name="root">
        /// Root certificate.
        /// Serialized Name: AppServiceCertificateOrderPatchResource.properties.root
        /// </param>
        /// <param name="serialNumber">
        /// Current serial number of the certificate.
        /// Serialized Name: AppServiceCertificateOrderPatchResource.properties.serialNumber
        /// </param>
        /// <param name="lastCertificateIssuanceOn">
        /// Certificate last issuance time.
        /// Serialized Name: AppServiceCertificateOrderPatchResource.properties.lastCertificateIssuanceTime
        /// </param>
        /// <param name="expireOn">
        /// Certificate expiration time.
        /// Serialized Name: AppServiceCertificateOrderPatchResource.properties.expirationTime
        /// </param>
        /// <param name="isPrivateKeyExternal">
        /// &lt;code&gt;true&lt;/code&gt; if private key is external; otherwise, &lt;code&gt;false&lt;/code&gt;.
        /// Serialized Name: AppServiceCertificateOrderPatchResource.properties.isPrivateKeyExternal
        /// </param>
        /// <param name="appServiceCertificateNotRenewableReasons">
        /// Reasons why App Service Certificate is not renewable at the current moment.
        /// Serialized Name: AppServiceCertificateOrderPatchResource.properties.appServiceCertificateNotRenewableReasons
        /// </param>
        /// <param name="nextAutoRenewalTimeStamp">
        /// Time stamp when the certificate would be auto renewed next
        /// Serialized Name: AppServiceCertificateOrderPatchResource.properties.nextAutoRenewalTimeStamp
        /// </param>
        /// <param name="contact">
        /// Contact info
        /// Serialized Name: AppServiceCertificateOrderPatchResource.properties.contact
        /// </param>
        /// <param name="kind">
        /// Kind of resource.
        /// Serialized Name: ProxyOnlyResource.kind
        /// </param>
        internal AppServiceCertificateOrderPatch(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, AppServiceCertificateProperties> certificates, string distinguishedName, string domainVerificationToken, int? validityInYears, int? keySize, CertificateProductType? productType, bool? isAutoRenew, ProvisioningState? provisioningState, CertificateOrderStatus? status, CertificateDetails signedCertificate, string csr, CertificateDetails intermediate, CertificateDetails root, string serialNumber, DateTimeOffset? lastCertificateIssuanceOn, DateTimeOffset? expireOn, bool? isPrivateKeyExternal, IReadOnlyList<AppServiceCertificateNotRenewableReason> appServiceCertificateNotRenewableReasons, DateTimeOffset? nextAutoRenewalTimeStamp, CertificateOrderContact contact, string kind) : base(id, name, resourceType, systemData)
        {
            Certificates = certificates;
            DistinguishedName = distinguishedName;
            DomainVerificationToken = domainVerificationToken;
            ValidityInYears = validityInYears;
            KeySize = keySize;
            ProductType = productType;
            IsAutoRenew = isAutoRenew;
            ProvisioningState = provisioningState;
            Status = status;
            SignedCertificate = signedCertificate;
            Csr = csr;
            Intermediate = intermediate;
            Root = root;
            SerialNumber = serialNumber;
            LastCertificateIssuanceOn = lastCertificateIssuanceOn;
            ExpireOn = expireOn;
            IsPrivateKeyExternal = isPrivateKeyExternal;
            AppServiceCertificateNotRenewableReasons = appServiceCertificateNotRenewableReasons;
            NextAutoRenewalTimeStamp = nextAutoRenewalTimeStamp;
            Contact = contact;
            Kind = kind;
        }

        /// <summary>
        /// State of the Key Vault secret.
        /// Serialized Name: AppServiceCertificateOrderPatchResource.properties.certificates
        /// </summary>
        public IDictionary<string, AppServiceCertificateProperties> Certificates { get; }
        /// <summary>
        /// Certificate distinguished name.
        /// Serialized Name: AppServiceCertificateOrderPatchResource.properties.distinguishedName
        /// </summary>
        public string DistinguishedName { get; set; }
        /// <summary>
        /// Domain verification token.
        /// Serialized Name: AppServiceCertificateOrderPatchResource.properties.domainVerificationToken
        /// </summary>
        public string DomainVerificationToken { get; }
        /// <summary>
        /// Duration in years (must be 1).
        /// Serialized Name: AppServiceCertificateOrderPatchResource.properties.validityInYears
        /// </summary>
        public int? ValidityInYears { get; set; }
        /// <summary>
        /// Certificate key size.
        /// Serialized Name: AppServiceCertificateOrderPatchResource.properties.keySize
        /// </summary>
        public int? KeySize { get; set; }
        /// <summary>
        /// Certificate product type.
        /// Serialized Name: AppServiceCertificateOrderPatchResource.properties.productType
        /// </summary>
        public CertificateProductType? ProductType { get; set; }
        /// <summary>
        /// &lt;code&gt;true&lt;/code&gt; if the certificate should be automatically renewed when it expires; otherwise, &lt;code&gt;false&lt;/code&gt;.
        /// Serialized Name: AppServiceCertificateOrderPatchResource.properties.autoRenew
        /// </summary>
        public bool? IsAutoRenew { get; set; }
        /// <summary>
        /// Status of certificate order.
        /// Serialized Name: AppServiceCertificateOrderPatchResource.properties.provisioningState
        /// </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary>
        /// Current order status.
        /// Serialized Name: AppServiceCertificateOrderPatchResource.properties.status
        /// </summary>
        public CertificateOrderStatus? Status { get; }
        /// <summary>
        /// Signed certificate.
        /// Serialized Name: AppServiceCertificateOrderPatchResource.properties.signedCertificate
        /// </summary>
        public CertificateDetails SignedCertificate { get; }
        /// <summary>
        /// Last CSR that was created for this order.
        /// Serialized Name: AppServiceCertificateOrderPatchResource.properties.csr
        /// </summary>
        public string Csr { get; set; }
        /// <summary>
        /// Intermediate certificate.
        /// Serialized Name: AppServiceCertificateOrderPatchResource.properties.intermediate
        /// </summary>
        public CertificateDetails Intermediate { get; }
        /// <summary>
        /// Root certificate.
        /// Serialized Name: AppServiceCertificateOrderPatchResource.properties.root
        /// </summary>
        public CertificateDetails Root { get; }
        /// <summary>
        /// Current serial number of the certificate.
        /// Serialized Name: AppServiceCertificateOrderPatchResource.properties.serialNumber
        /// </summary>
        public string SerialNumber { get; }
        /// <summary>
        /// Certificate last issuance time.
        /// Serialized Name: AppServiceCertificateOrderPatchResource.properties.lastCertificateIssuanceTime
        /// </summary>
        public DateTimeOffset? LastCertificateIssuanceOn { get; }
        /// <summary>
        /// Certificate expiration time.
        /// Serialized Name: AppServiceCertificateOrderPatchResource.properties.expirationTime
        /// </summary>
        public DateTimeOffset? ExpireOn { get; }
        /// <summary>
        /// &lt;code&gt;true&lt;/code&gt; if private key is external; otherwise, &lt;code&gt;false&lt;/code&gt;.
        /// Serialized Name: AppServiceCertificateOrderPatchResource.properties.isPrivateKeyExternal
        /// </summary>
        public bool? IsPrivateKeyExternal { get; }
        /// <summary>
        /// Reasons why App Service Certificate is not renewable at the current moment.
        /// Serialized Name: AppServiceCertificateOrderPatchResource.properties.appServiceCertificateNotRenewableReasons
        /// </summary>
        public IReadOnlyList<AppServiceCertificateNotRenewableReason> AppServiceCertificateNotRenewableReasons { get; }
        /// <summary>
        /// Time stamp when the certificate would be auto renewed next
        /// Serialized Name: AppServiceCertificateOrderPatchResource.properties.nextAutoRenewalTimeStamp
        /// </summary>
        public DateTimeOffset? NextAutoRenewalTimeStamp { get; }
        /// <summary>
        /// Contact info
        /// Serialized Name: AppServiceCertificateOrderPatchResource.properties.contact
        /// </summary>
        public CertificateOrderContact Contact { get; }
        /// <summary>
        /// Kind of resource.
        /// Serialized Name: ProxyOnlyResource.kind
        /// </summary>
        public string Kind { get; set; }
    }
}
