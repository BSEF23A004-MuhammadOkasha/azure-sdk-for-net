// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.ManagementPartner.Mocking;
using Azure.ResourceManager.ManagementPartner.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.ManagementPartner
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.ManagementPartner. </summary>
    public static partial class ManagementPartnerExtensions
    {
        private static ManagementPartnerArmClientMockingExtension GetManagementPartnerArmClientMockingExtension(ArmClient client)
        {
            return client.GetCachedClient(client =>
            {
                return new ManagementPartnerArmClientMockingExtension(client);
            });
        }

        private static ManagementPartnerTenantMockingExtension GetManagementPartnerTenantMockingExtension(ArmResource resource)
        {
            return resource.GetCachedClient(client =>
            {
                return new ManagementPartnerTenantMockingExtension(client, resource.Id);
            });
        }

        #region PartnerResponseResource
        /// <summary>
        /// Gets an object representing a <see cref="PartnerResponseResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PartnerResponseResource.CreateResourceIdentifier" /> to create a <see cref="PartnerResponseResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PartnerResponseResource" /> object. </returns>
        public static PartnerResponseResource GetPartnerResponseResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetManagementPartnerArmClientMockingExtension(client).GetPartnerResponseResource(id);
        }
        #endregion

        /// <summary> Gets a collection of PartnerResponseResources in the TenantResource. </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of PartnerResponseResources and their operations over a PartnerResponseResource. </returns>
        public static PartnerResponseCollection GetPartnerResponses(this TenantResource tenantResource)
        {
            return GetManagementPartnerTenantMockingExtension(tenantResource).GetPartnerResponses();
        }

        /// <summary>
        /// Get the management partner using the partnerId, objectId and tenantId.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.ManagementPartner/partners/{partnerId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Partner_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="partnerId"> Id of the Partner. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="partnerId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="partnerId"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<PartnerResponseResource>> GetPartnerResponseAsync(this TenantResource tenantResource, string partnerId, CancellationToken cancellationToken = default)
        {
            return await GetManagementPartnerTenantMockingExtension(tenantResource).GetPartnerResponseAsync(partnerId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get the management partner using the partnerId, objectId and tenantId.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.ManagementPartner/partners/{partnerId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Partner_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="partnerId"> Id of the Partner. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="partnerId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="partnerId"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<PartnerResponseResource> GetPartnerResponse(this TenantResource tenantResource, string partnerId, CancellationToken cancellationToken = default)
        {
            return GetManagementPartnerTenantMockingExtension(tenantResource).GetPartnerResponse(partnerId, cancellationToken);
        }

        /// <summary>
        /// List all the operations.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.ManagementPartner/operations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Operation_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="OperationResponse" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<OperationResponse> GetOperationsAsync(this TenantResource tenantResource, CancellationToken cancellationToken = default)
        {
            return GetManagementPartnerTenantMockingExtension(tenantResource).GetOperationsAsync(cancellationToken);
        }

        /// <summary>
        /// List all the operations.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.ManagementPartner/operations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Operation_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="OperationResponse" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<OperationResponse> GetOperations(this TenantResource tenantResource, CancellationToken cancellationToken = default)
        {
            return GetManagementPartnerTenantMockingExtension(tenantResource).GetOperations(cancellationToken);
        }
    }
}
