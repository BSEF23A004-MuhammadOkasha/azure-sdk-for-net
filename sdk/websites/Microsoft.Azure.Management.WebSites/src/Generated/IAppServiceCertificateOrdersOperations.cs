// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.WebSites
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// AppServiceCertificateOrdersOperations operations.
    /// </summary>
    public partial interface IAppServiceCertificateOrdersOperations
    {
        /// <summary>
        /// List all certificate orders in a subscription.
        /// </summary>
        /// <remarks>
        /// Description for List all certificate orders in a subscription.
        /// </remarks>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="DefaultErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<AppServiceCertificateOrder>>> ListWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Validate information for a certificate order.
        /// </summary>
        /// <remarks>
        /// Description for Validate information for a certificate order.
        /// </remarks>
        /// <param name='appServiceCertificateOrder'>
        /// Information for a certificate order.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="DefaultErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> ValidatePurchaseInformationWithHttpMessagesAsync(AppServiceCertificateOrder appServiceCertificateOrder, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get certificate orders in a resource group.
        /// </summary>
        /// <remarks>
        /// Description for Get certificate orders in a resource group.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// Name of the resource group to which the resource belongs.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="DefaultErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<AppServiceCertificateOrder>>> ListByResourceGroupWithHttpMessagesAsync(string resourceGroupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get a certificate order.
        /// </summary>
        /// <remarks>
        /// Description for Get a certificate order.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// Name of the resource group to which the resource belongs.
        /// </param>
        /// <param name='certificateOrderName'>
        /// Name of the certificate order..
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="DefaultErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<AppServiceCertificateOrder>> GetWithHttpMessagesAsync(string resourceGroupName, string certificateOrderName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Create or update a certificate purchase order.
        /// </summary>
        /// <remarks>
        /// Description for Create or update a certificate purchase order.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// Name of the resource group to which the resource belongs.
        /// </param>
        /// <param name='certificateOrderName'>
        /// Name of the certificate order.
        /// </param>
        /// <param name='certificateDistinguishedName'>
        /// Distinguished name to use for the certificate order.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="DefaultErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<AppServiceCertificateOrder>> CreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string certificateOrderName, AppServiceCertificateOrder certificateDistinguishedName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Delete an existing certificate order.
        /// </summary>
        /// <remarks>
        /// Description for Delete an existing certificate order.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// Name of the resource group to which the resource belongs.
        /// </param>
        /// <param name='certificateOrderName'>
        /// Name of the certificate order.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="DefaultErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string certificateOrderName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Create or update a certificate purchase order.
        /// </summary>
        /// <remarks>
        /// Description for Create or update a certificate purchase order.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// Name of the resource group to which the resource belongs.
        /// </param>
        /// <param name='certificateOrderName'>
        /// Name of the certificate order.
        /// </param>
        /// <param name='certificateDistinguishedName'>
        /// Distinguished name to use for the certificate order.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="DefaultErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<AppServiceCertificateOrder>> UpdateWithHttpMessagesAsync(string resourceGroupName, string certificateOrderName, AppServiceCertificateOrderPatchResource certificateDistinguishedName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// List all certificates associated with a certificate order.
        /// </summary>
        /// <remarks>
        /// Description for List all certificates associated with a certificate
        /// order.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// Name of the resource group to which the resource belongs.
        /// </param>
        /// <param name='certificateOrderName'>
        /// Name of the certificate order.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="DefaultErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<AppServiceCertificateResource>>> ListCertificatesWithHttpMessagesAsync(string resourceGroupName, string certificateOrderName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get the certificate associated with a certificate order.
        /// </summary>
        /// <remarks>
        /// Description for Get the certificate associated with a certificate
        /// order.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// Name of the resource group to which the resource belongs.
        /// </param>
        /// <param name='certificateOrderName'>
        /// Name of the certificate order.
        /// </param>
        /// <param name='name'>
        /// Name of the certificate.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="DefaultErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<AppServiceCertificateResource>> GetCertificateWithHttpMessagesAsync(string resourceGroupName, string certificateOrderName, string name, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates or updates a certificate and associates with key vault
        /// secret.
        /// </summary>
        /// <remarks>
        /// Description for Creates or updates a certificate and associates
        /// with key vault secret.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// Name of the resource group to which the resource belongs.
        /// </param>
        /// <param name='certificateOrderName'>
        /// Name of the certificate order.
        /// </param>
        /// <param name='name'>
        /// Name of the certificate.
        /// </param>
        /// <param name='keyVaultCertificate'>
        /// Key vault certificate resource Id.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="DefaultErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<AppServiceCertificateResource>> CreateOrUpdateCertificateWithHttpMessagesAsync(string resourceGroupName, string certificateOrderName, string name, AppServiceCertificateResource keyVaultCertificate, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Delete the certificate associated with a certificate order.
        /// </summary>
        /// <remarks>
        /// Description for Delete the certificate associated with a
        /// certificate order.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// Name of the resource group to which the resource belongs.
        /// </param>
        /// <param name='certificateOrderName'>
        /// Name of the certificate order.
        /// </param>
        /// <param name='name'>
        /// Name of the certificate.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="DefaultErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> DeleteCertificateWithHttpMessagesAsync(string resourceGroupName, string certificateOrderName, string name, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates or updates a certificate and associates with key vault
        /// secret.
        /// </summary>
        /// <remarks>
        /// Description for Creates or updates a certificate and associates
        /// with key vault secret.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// Name of the resource group to which the resource belongs.
        /// </param>
        /// <param name='certificateOrderName'>
        /// Name of the certificate order.
        /// </param>
        /// <param name='name'>
        /// Name of the certificate.
        /// </param>
        /// <param name='keyVaultCertificate'>
        /// Key vault certificate resource Id.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="DefaultErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<AppServiceCertificateResource>> UpdateCertificateWithHttpMessagesAsync(string resourceGroupName, string certificateOrderName, string name, AppServiceCertificatePatchResource keyVaultCertificate, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Reissue an existing certificate order.
        /// </summary>
        /// <remarks>
        /// Description for Reissue an existing certificate order.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// Name of the resource group to which the resource belongs.
        /// </param>
        /// <param name='certificateOrderName'>
        /// Name of the certificate order.
        /// </param>
        /// <param name='reissueCertificateOrderRequest'>
        /// Parameters for the reissue.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="DefaultErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> ReissueWithHttpMessagesAsync(string resourceGroupName, string certificateOrderName, ReissueCertificateOrderRequest reissueCertificateOrderRequest, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Renew an existing certificate order.
        /// </summary>
        /// <remarks>
        /// Description for Renew an existing certificate order.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// Name of the resource group to which the resource belongs.
        /// </param>
        /// <param name='certificateOrderName'>
        /// Name of the certificate order.
        /// </param>
        /// <param name='renewCertificateOrderRequest'>
        /// Renew parameters
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="DefaultErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> RenewWithHttpMessagesAsync(string resourceGroupName, string certificateOrderName, RenewCertificateOrderRequest renewCertificateOrderRequest, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Resend certificate email.
        /// </summary>
        /// <remarks>
        /// Description for Resend certificate email.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// Name of the resource group to which the resource belongs.
        /// </param>
        /// <param name='certificateOrderName'>
        /// Name of the certificate order.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="DefaultErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> ResendEmailWithHttpMessagesAsync(string resourceGroupName, string certificateOrderName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Verify domain ownership for this certificate order.
        /// </summary>
        /// <remarks>
        /// Description for Verify domain ownership for this certificate order.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// Name of the resource group to which the resource belongs.
        /// </param>
        /// <param name='certificateOrderName'>
        /// Name of the certificate order.
        /// </param>
        /// <param name='nameIdentifier'>
        /// Email address
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="DefaultErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> ResendRequestEmailsWithHttpMessagesAsync(string resourceGroupName, string certificateOrderName, NameIdentifier nameIdentifier, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Verify domain ownership for this certificate order.
        /// </summary>
        /// <remarks>
        /// Description for Verify domain ownership for this certificate order.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// Name of the resource group to which the resource belongs.
        /// </param>
        /// <param name='certificateOrderName'>
        /// Name of the certificate order.
        /// </param>
        /// <param name='siteSealRequest'>
        /// Site seal request.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="DefaultErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<SiteSeal>> RetrieveSiteSealWithHttpMessagesAsync(string resourceGroupName, string certificateOrderName, SiteSealRequest siteSealRequest, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Verify domain ownership for this certificate order.
        /// </summary>
        /// <remarks>
        /// Description for Verify domain ownership for this certificate order.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// Name of the resource group to which the resource belongs.
        /// </param>
        /// <param name='certificateOrderName'>
        /// Name of the certificate order.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="DefaultErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> VerifyDomainOwnershipWithHttpMessagesAsync(string resourceGroupName, string certificateOrderName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Retrieve the list of certificate actions.
        /// </summary>
        /// <remarks>
        /// Description for Retrieve the list of certificate actions.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// Name of the resource group to which the resource belongs.
        /// </param>
        /// <param name='name'>
        /// Name of the certificate order.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="DefaultErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IList<CertificateOrderAction>>> RetrieveCertificateActionsWithHttpMessagesAsync(string resourceGroupName, string name, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Retrieve email history.
        /// </summary>
        /// <remarks>
        /// Description for Retrieve email history.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// Name of the resource group to which the resource belongs.
        /// </param>
        /// <param name='name'>
        /// Name of the certificate order.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="DefaultErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IList<CertificateEmail>>> RetrieveCertificateEmailHistoryWithHttpMessagesAsync(string resourceGroupName, string name, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Create or update a certificate purchase order.
        /// </summary>
        /// <remarks>
        /// Description for Create or update a certificate purchase order.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// Name of the resource group to which the resource belongs.
        /// </param>
        /// <param name='certificateOrderName'>
        /// Name of the certificate order.
        /// </param>
        /// <param name='certificateDistinguishedName'>
        /// Distinguished name to use for the certificate order.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="DefaultErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<AppServiceCertificateOrder>> BeginCreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string certificateOrderName, AppServiceCertificateOrder certificateDistinguishedName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates or updates a certificate and associates with key vault
        /// secret.
        /// </summary>
        /// <remarks>
        /// Description for Creates or updates a certificate and associates
        /// with key vault secret.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// Name of the resource group to which the resource belongs.
        /// </param>
        /// <param name='certificateOrderName'>
        /// Name of the certificate order.
        /// </param>
        /// <param name='name'>
        /// Name of the certificate.
        /// </param>
        /// <param name='keyVaultCertificate'>
        /// Key vault certificate resource Id.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="DefaultErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<AppServiceCertificateResource>> BeginCreateOrUpdateCertificateWithHttpMessagesAsync(string resourceGroupName, string certificateOrderName, string name, AppServiceCertificateResource keyVaultCertificate, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// List all certificate orders in a subscription.
        /// </summary>
        /// <remarks>
        /// Description for List all certificate orders in a subscription.
        /// </remarks>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="DefaultErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<AppServiceCertificateOrder>>> ListNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get certificate orders in a resource group.
        /// </summary>
        /// <remarks>
        /// Description for Get certificate orders in a resource group.
        /// </remarks>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="DefaultErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<AppServiceCertificateOrder>>> ListByResourceGroupNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// List all certificates associated with a certificate order.
        /// </summary>
        /// <remarks>
        /// Description for List all certificates associated with a certificate
        /// order.
        /// </remarks>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="DefaultErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<AppServiceCertificateResource>>> ListCertificatesNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
