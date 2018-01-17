// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Search
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// ServicesOperations operations.
    /// </summary>
    public partial interface IServicesOperations
    {
        /// <summary>
        /// Creates or updates a Search service in the given resource group. If
        /// the Search service already exists, all properties will be updated
        /// with the given values.
        /// <see href="https://aka.ms/search-manage" />
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the current subscription. You
        /// can obtain this value from the Azure Resource Manager API or the
        /// portal.
        /// </param>
        /// <param name='searchServiceName'>
        /// The name of the Azure Search service to create or update. Search
        /// service names must only contain lowercase letters, digits or
        /// dashes, cannot use dash as the first two or last one characters,
        /// cannot contain consecutive dashes, and must be between 2 and 60
        /// characters in length. Search service names must be globally unique
        /// since they are part of the service URI
        /// (https://&lt;name&gt;.search.windows.net). You cannot change the
        /// service name after the service is created.
        /// </param>
        /// <param name='service'>
        /// The definition of the Search service to create or update.
        /// </param>
        /// <param name='searchManagementRequestOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<SearchService>> CreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string searchServiceName, SearchService service, SearchManagementRequestOptions searchManagementRequestOptions = default(SearchManagementRequestOptions), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Updates an existing Search service in the given resource group.
        /// <see href="https://aka.ms/search-manage" />
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the current subscription. You
        /// can obtain this value from the Azure Resource Manager API or the
        /// portal.
        /// </param>
        /// <param name='searchServiceName'>
        /// The name of the Azure Search service to update.
        /// </param>
        /// <param name='service'>
        /// The definition of the Search service to update.
        /// </param>
        /// <param name='searchManagementRequestOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<SearchService>> UpdateWithHttpMessagesAsync(string resourceGroupName, string searchServiceName, SearchService service, SearchManagementRequestOptions searchManagementRequestOptions = default(SearchManagementRequestOptions), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the Search service with the given name in the given resource
        /// group.
        /// <see href="https://aka.ms/search-manage" />
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the current subscription. You
        /// can obtain this value from the Azure Resource Manager API or the
        /// portal.
        /// </param>
        /// <param name='searchServiceName'>
        /// The name of the Azure Search service associated with the specified
        /// resource group.
        /// </param>
        /// <param name='searchManagementRequestOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<SearchService>> GetWithHttpMessagesAsync(string resourceGroupName, string searchServiceName, SearchManagementRequestOptions searchManagementRequestOptions = default(SearchManagementRequestOptions), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes a Search service in the given resource group, along with
        /// its associated resources.
        /// <see href="https://aka.ms/search-manage" />
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the current subscription. You
        /// can obtain this value from the Azure Resource Manager API or the
        /// portal.
        /// </param>
        /// <param name='searchServiceName'>
        /// The name of the Azure Search service associated with the specified
        /// resource group.
        /// </param>
        /// <param name='searchManagementRequestOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string searchServiceName, SearchManagementRequestOptions searchManagementRequestOptions = default(SearchManagementRequestOptions), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets a list of all Search services in the given resource group.
        /// <see href="https://aka.ms/search-manage" />
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the current subscription. You
        /// can obtain this value from the Azure Resource Manager API or the
        /// portal.
        /// </param>
        /// <param name='searchManagementRequestOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IEnumerable<SearchService>>> ListByResourceGroupWithHttpMessagesAsync(string resourceGroupName, SearchManagementRequestOptions searchManagementRequestOptions = default(SearchManagementRequestOptions), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Checks whether or not the given Search service name is available
        /// for use. Search service names must be globally unique since they
        /// are part of the service URI
        /// (https://&lt;name&gt;.search.windows.net).
        /// <see href="https://aka.ms/search-manage" />
        /// </summary>
        /// <param name='name'>
        /// The Search service name to validate. Search service names must only
        /// contain lowercase letters, digits or dashes, cannot use dash as the
        /// first two or last one characters, cannot contain consecutive
        /// dashes, and must be between 2 and 60 characters in length.
        /// </param>
        /// <param name='searchManagementRequestOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<CheckNameAvailabilityOutput>> CheckNameAvailabilityWithHttpMessagesAsync(string name, SearchManagementRequestOptions searchManagementRequestOptions = default(SearchManagementRequestOptions), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates or updates a Search service in the given resource group. If
        /// the Search service already exists, all properties will be updated
        /// with the given values.
        /// <see href="https://aka.ms/search-manage" />
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the current subscription. You
        /// can obtain this value from the Azure Resource Manager API or the
        /// portal.
        /// </param>
        /// <param name='searchServiceName'>
        /// The name of the Azure Search service to create or update. Search
        /// service names must only contain lowercase letters, digits or
        /// dashes, cannot use dash as the first two or last one characters,
        /// cannot contain consecutive dashes, and must be between 2 and 60
        /// characters in length. Search service names must be globally unique
        /// since they are part of the service URI
        /// (https://&lt;name&gt;.search.windows.net). You cannot change the
        /// service name after the service is created.
        /// </param>
        /// <param name='service'>
        /// The definition of the Search service to create or update.
        /// </param>
        /// <param name='searchManagementRequestOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<SearchService>> BeginCreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string searchServiceName, SearchService service, SearchManagementRequestOptions searchManagementRequestOptions = default(SearchManagementRequestOptions), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
