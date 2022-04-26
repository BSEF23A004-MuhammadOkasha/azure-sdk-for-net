// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.EventGrid
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// PartnerTopicEventSubscriptionsOperations operations.
    /// </summary>
    public partial interface IPartnerTopicEventSubscriptionsOperations
    {
        /// <summary>
        /// Get an event subscription of a partner topic.
        /// </summary>
        /// <remarks>
        /// Get properties of an event subscription of a partner topic.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the user's subscription.
        /// </param>
        /// <param name='partnerTopicName'>
        /// Name of the partner topic.
        /// </param>
        /// <param name='eventSubscriptionName'>
        /// Name of the event subscription to be found. Event subscription
        /// names must be between 3 and 100 characters in length and use
        /// alphanumeric letters only.
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
        Task<AzureOperationResponse<EventSubscription>> GetWithHttpMessagesAsync(string resourceGroupName, string partnerTopicName, string eventSubscriptionName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Create or update an event subscription of a partner topic.
        /// </summary>
        /// <remarks>
        /// Asynchronously creates or updates an event subscription of a
        /// partner topic with the specified parameters. Existing event
        /// subscriptions will be updated with this API.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the user's subscription.
        /// </param>
        /// <param name='partnerTopicName'>
        /// Name of the partner topic.
        /// </param>
        /// <param name='eventSubscriptionName'>
        /// Name of the event subscription to be created. Event subscription
        /// names must be between 3 and 100 characters in length and use
        /// alphanumeric letters only.
        /// </param>
        /// <param name='eventSubscriptionInfo'>
        /// Event subscription properties containing the destination and filter
        /// information.
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
        Task<AzureOperationResponse<EventSubscription>> CreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string partnerTopicName, string eventSubscriptionName, EventSubscription eventSubscriptionInfo, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Delete an event subscription of a partner topic.
        /// </summary>
        /// <remarks>
        /// Delete an existing event subscription of a partner topic.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the user's subscription.
        /// </param>
        /// <param name='partnerTopicName'>
        /// Name of the partner topic.
        /// </param>
        /// <param name='eventSubscriptionName'>
        /// Name of the event subscription to be created. Event subscription
        /// names must be between 3 and 100 characters in length and use
        /// alphanumeric letters only.
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
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string partnerTopicName, string eventSubscriptionName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Update event subscription of a partner topic.
        /// </summary>
        /// <remarks>
        /// Update an existing event subscription of a partner topic.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the user's subscription.
        /// </param>
        /// <param name='partnerTopicName'>
        /// Name of the partner topic.
        /// </param>
        /// <param name='eventSubscriptionName'>
        /// Name of the event subscription to be created. Event subscription
        /// names must be between 3 and 100 characters in length and use
        /// alphanumeric letters only.
        /// </param>
        /// <param name='eventSubscriptionUpdateParameters'>
        /// Updated event subscription information.
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
        Task<AzureOperationResponse<EventSubscription>> UpdateWithHttpMessagesAsync(string resourceGroupName, string partnerTopicName, string eventSubscriptionName, EventSubscriptionUpdateParameters eventSubscriptionUpdateParameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get full URL of an event subscription of a partner topic.
        /// </summary>
        /// <remarks>
        /// Get the full endpoint URL for an event subscription of a partner
        /// topic.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the user's subscription.
        /// </param>
        /// <param name='partnerTopicName'>
        /// Name of the partner topic.
        /// </param>
        /// <param name='eventSubscriptionName'>
        /// Name of the event subscription to be created. Event subscription
        /// names must be between 3 and 100 characters in length and use
        /// alphanumeric letters only.
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
        Task<AzureOperationResponse<EventSubscriptionFullUrl>> GetFullUrlWithHttpMessagesAsync(string resourceGroupName, string partnerTopicName, string eventSubscriptionName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// List event subscriptions of a partner topic.
        /// </summary>
        /// <remarks>
        /// List event subscriptions that belong to a specific partner topic.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the user's subscription.
        /// </param>
        /// <param name='partnerTopicName'>
        /// Name of the partner topic.
        /// </param>
        /// <param name='filter'>
        /// The query used to filter the search results using OData syntax.
        /// Filtering is permitted on the 'name' property only and with limited
        /// number of OData operations. These operations are: the 'contains'
        /// function as well as the following logical operations: not, and, or,
        /// eq (for equal), and ne (for not equal). No arithmetic operations
        /// are supported. The following is a valid filter example:
        /// $filter=contains(namE, 'PATTERN') and name ne 'PATTERN-1'. The
        /// following is not a valid filter example: $filter=location eq
        /// 'westus'.
        /// </param>
        /// <param name='top'>
        /// The number of results to return per page for the list operation.
        /// Valid range for top parameter is 1 to 100. If not specified, the
        /// default number of results to be returned is 20 items per page.
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
        Task<AzureOperationResponse<IPage<EventSubscription>>> ListByPartnerTopicWithHttpMessagesAsync(string resourceGroupName, string partnerTopicName, string filter = default(string), int? top = default(int?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get delivery attributes for an event subscription of a partner
        /// topic.
        /// </summary>
        /// <remarks>
        /// Get all delivery attributes for an event subscription of a partner
        /// topic.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the user's subscription.
        /// </param>
        /// <param name='partnerTopicName'>
        /// Name of the partner topic.
        /// </param>
        /// <param name='eventSubscriptionName'>
        /// Name of the event subscription to be created. Event subscription
        /// names must be between 3 and 100 characters in length and use
        /// alphanumeric letters only.
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
        Task<AzureOperationResponse<DeliveryAttributeListResult>> GetDeliveryAttributesWithHttpMessagesAsync(string resourceGroupName, string partnerTopicName, string eventSubscriptionName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Create or update an event subscription of a partner topic.
        /// </summary>
        /// <remarks>
        /// Asynchronously creates or updates an event subscription of a
        /// partner topic with the specified parameters. Existing event
        /// subscriptions will be updated with this API.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the user's subscription.
        /// </param>
        /// <param name='partnerTopicName'>
        /// Name of the partner topic.
        /// </param>
        /// <param name='eventSubscriptionName'>
        /// Name of the event subscription to be created. Event subscription
        /// names must be between 3 and 100 characters in length and use
        /// alphanumeric letters only.
        /// </param>
        /// <param name='eventSubscriptionInfo'>
        /// Event subscription properties containing the destination and filter
        /// information.
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
        Task<AzureOperationResponse<EventSubscription>> BeginCreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string partnerTopicName, string eventSubscriptionName, EventSubscription eventSubscriptionInfo, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Delete an event subscription of a partner topic.
        /// </summary>
        /// <remarks>
        /// Delete an existing event subscription of a partner topic.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the user's subscription.
        /// </param>
        /// <param name='partnerTopicName'>
        /// Name of the partner topic.
        /// </param>
        /// <param name='eventSubscriptionName'>
        /// Name of the event subscription to be created. Event subscription
        /// names must be between 3 and 100 characters in length and use
        /// alphanumeric letters only.
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
        Task<AzureOperationResponse> BeginDeleteWithHttpMessagesAsync(string resourceGroupName, string partnerTopicName, string eventSubscriptionName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Update event subscription of a partner topic.
        /// </summary>
        /// <remarks>
        /// Update an existing event subscription of a partner topic.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the user's subscription.
        /// </param>
        /// <param name='partnerTopicName'>
        /// Name of the partner topic.
        /// </param>
        /// <param name='eventSubscriptionName'>
        /// Name of the event subscription to be created. Event subscription
        /// names must be between 3 and 100 characters in length and use
        /// alphanumeric letters only.
        /// </param>
        /// <param name='eventSubscriptionUpdateParameters'>
        /// Updated event subscription information.
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
        Task<AzureOperationResponse<EventSubscription>> BeginUpdateWithHttpMessagesAsync(string resourceGroupName, string partnerTopicName, string eventSubscriptionName, EventSubscriptionUpdateParameters eventSubscriptionUpdateParameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// List event subscriptions of a partner topic.
        /// </summary>
        /// <remarks>
        /// List event subscriptions that belong to a specific partner topic.
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
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<EventSubscription>>> ListByPartnerTopicNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
