// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DeviceProvisioningServices
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// DpsCertificateOperations operations.
    /// </summary>
    public partial interface IDpsCertificateOperations
    {
        /// <summary>
        /// Get the certificate from the provisioning service.
        /// </summary>
        /// <param name='certificateName'>
        /// Name of the certificate to retrieve.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Resource group identifier.
        /// </param>
        /// <param name='provisioningServiceName'>
        /// Name of the provisioning service the certificate is associated
        /// with.
        /// </param>
        /// <param name='ifMatch'>
        /// ETag of the certificate.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorDetailsException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<CertificateResponse>> GetWithHttpMessagesAsync(string certificateName, string resourceGroupName, string provisioningServiceName, string ifMatch = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Upload the certificate to the provisioning service.
        /// </summary>
        /// <remarks>
        /// Add new certificate or update an existing certificate.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// Resource group identifier.
        /// </param>
        /// <param name='provisioningServiceName'>
        /// The name of the provisioning service.
        /// </param>
        /// <param name='certificateName'>
        /// The name of the certificate create or update.
        /// </param>
        /// <param name='certificateDescription'>
        /// The certificate body.
        /// </param>
        /// <param name='ifMatch'>
        /// ETag of the certificate. This is required to update an existing
        /// certificate, and ignored while creating a brand new certificate.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorDetailsException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<CertificateResponse>> CreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string provisioningServiceName, string certificateName, CertificateBodyDescription certificateDescription, string ifMatch = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Delete the Provisioning Service Certificate.
        /// </summary>
        /// <remarks>
        /// Deletes the specified certificate associated with the Provisioning
        /// Service
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// Resource group identifier.
        /// </param>
        /// <param name='ifMatch'>
        /// ETag of the certificate
        /// </param>
        /// <param name='provisioningServiceName'>
        /// The name of the provisioning service.
        /// </param>
        /// <param name='certificateName'>
        /// This is a mandatory field, and is the logical name of the
        /// certificate that the provisioning service will access by.
        /// </param>
        /// <param name='certificatename'>
        /// This is optional, and it is the Common Name of the certificate.
        /// </param>
        /// <param name='certificaterawBytes'>
        /// Raw data within the certificate.
        /// </param>
        /// <param name='certificateisVerified'>
        /// Indicates if certificate has been verified by owner of the private
        /// key.
        /// </param>
        /// <param name='certificatepurpose'>
        /// A description that mentions the purpose of the certificate.
        /// Possible values include: 'clientAuthentication',
        /// 'serverAuthentication'
        /// </param>
        /// <param name='certificatecreated'>
        /// Time the certificate is created.
        /// </param>
        /// <param name='certificatelastUpdated'>
        /// Time the certificate is last updated.
        /// </param>
        /// <param name='certificatehasPrivateKey'>
        /// Indicates if the certificate contains a private key.
        /// </param>
        /// <param name='certificatenonce'>
        /// Random number generated to indicate Proof of Possession.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorDetailsException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string ifMatch, string provisioningServiceName, string certificateName, string certificatename = default(string), byte[] certificaterawBytes = default(byte[]), bool? certificateisVerified = default(bool?), string certificatepurpose = default(string), System.DateTime? certificatecreated = default(System.DateTime?), System.DateTime? certificatelastUpdated = default(System.DateTime?), bool? certificatehasPrivateKey = default(bool?), string certificatenonce = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get all the certificates tied to the provisioning service.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of resource group.
        /// </param>
        /// <param name='provisioningServiceName'>
        /// Name of provisioning service to retrieve certificates for.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorDetailsException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<CertificateListDescription>> ListWithHttpMessagesAsync(string resourceGroupName, string provisioningServiceName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Generate verification code for Proof of Possession.
        /// </summary>
        /// <param name='certificateName'>
        /// The mandatory logical name of the certificate, that the
        /// provisioning service uses to access.
        /// </param>
        /// <param name='ifMatch'>
        /// ETag of the certificate. This is required to update an existing
        /// certificate, and ignored while creating a brand new certificate.
        /// </param>
        /// <param name='resourceGroupName'>
        /// name of resource group.
        /// </param>
        /// <param name='provisioningServiceName'>
        /// Name of provisioning service.
        /// </param>
        /// <param name='certificatename'>
        /// Common Name for the certificate.
        /// </param>
        /// <param name='certificaterawBytes'>
        /// Raw data of certificate.
        /// </param>
        /// <param name='certificateisVerified'>
        /// Indicates if the certificate has been verified by owner of the
        /// private key.
        /// </param>
        /// <param name='certificatepurpose'>
        /// Description mentioning the purpose of the certificate. Possible
        /// values include: 'clientAuthentication', 'serverAuthentication'
        /// </param>
        /// <param name='certificatecreated'>
        /// Certificate creation time.
        /// </param>
        /// <param name='certificatelastUpdated'>
        /// Certificate last updated time.
        /// </param>
        /// <param name='certificatehasPrivateKey'>
        /// Indicates if the certificate contains private key.
        /// </param>
        /// <param name='certificatenonce'>
        /// Random number generated to indicate Proof of Possession.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorDetailsException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<VerificationCodeResponse>> GenerateVerificationCodeWithHttpMessagesAsync(string certificateName, string ifMatch, string resourceGroupName, string provisioningServiceName, string certificatename = default(string), byte[] certificaterawBytes = default(byte[]), bool? certificateisVerified = default(bool?), string certificatepurpose = default(string), System.DateTime? certificatecreated = default(System.DateTime?), System.DateTime? certificatelastUpdated = default(System.DateTime?), bool? certificatehasPrivateKey = default(bool?), string certificatenonce = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Verify certificate's private key possession.
        /// </summary>
        /// <remarks>
        /// Verifies the certificate's private key possession by providing the
        /// leaf cert issued by the verifying pre uploaded certificate.
        /// </remarks>
        /// <param name='certificateName'>
        /// The mandatory logical name of the certificate, that the
        /// provisioning service uses to access.
        /// </param>
        /// <param name='ifMatch'>
        /// ETag of the certificate.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Resource group name.
        /// </param>
        /// <param name='provisioningServiceName'>
        /// Provisioning service name.
        /// </param>
        /// <param name='certificatename'>
        /// Common Name for the certificate.
        /// </param>
        /// <param name='certificaterawBytes'>
        /// Raw data of certificate.
        /// </param>
        /// <param name='certificateisVerified'>
        /// Indicates if the certificate has been verified by owner of the
        /// private key.
        /// </param>
        /// <param name='certificatepurpose'>
        /// Describe the purpose of the certificate. Possible values include:
        /// 'clientAuthentication', 'serverAuthentication'
        /// </param>
        /// <param name='certificatecreated'>
        /// Certificate creation time.
        /// </param>
        /// <param name='certificatelastUpdated'>
        /// Certificate last updated time.
        /// </param>
        /// <param name='certificatehasPrivateKey'>
        /// Indicates if the certificate contains private key.
        /// </param>
        /// <param name='certificatenonce'>
        /// Random number generated to indicate Proof of Possession.
        /// </param>
        /// <param name='certificate'>
        /// base-64 representation of X509 certificate .cer file or just .pem
        /// file content.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorDetailsException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<CertificateResponse>> VerifyCertificateWithHttpMessagesAsync(string certificateName, string ifMatch, string resourceGroupName, string provisioningServiceName, string certificatename = default(string), byte[] certificaterawBytes = default(byte[]), bool? certificateisVerified = default(bool?), string certificatepurpose = default(string), System.DateTime? certificatecreated = default(System.DateTime?), System.DateTime? certificatelastUpdated = default(System.DateTime?), bool? certificatehasPrivateKey = default(bool?), string certificatenonce = default(string), string certificate = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
