// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.1.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ServiceBus
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// RulesOperations operations.
    /// </summary>
    public partial interface IRulesOperations
    {
        /// <summary>
        /// List all the rules within given topic-subscription
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the Resource group within the Azure subscription.
        /// </param>
        /// <param name='namespaceName'>
        /// The namespace name
        /// </param>
        /// <param name='topicName'>
        /// The topic name.
        /// </param>
        /// <param name='subscriptionName'>
        /// The subscription name.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<Rule>>> ListBySubscriptionsWithHttpMessagesAsync(string resourceGroupName, string namespaceName, string topicName, string subscriptionName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates a new rule and updates an existing rule
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the Resource group within the Azure subscription.
        /// </param>
        /// <param name='namespaceName'>
        /// The namespace name
        /// </param>
        /// <param name='topicName'>
        /// The topic name.
        /// </param>
        /// <param name='subscriptionName'>
        /// The subscription name.
        /// </param>
        /// <param name='ruleName'>
        /// The rule name.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to create a rule.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<Rule>> CreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string namespaceName, string topicName, string subscriptionName, string ruleName, Rule parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes an existing rule.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the Resource group within the Azure subscription.
        /// </param>
        /// <param name='namespaceName'>
        /// The namespace name
        /// </param>
        /// <param name='topicName'>
        /// The topic name.
        /// </param>
        /// <param name='subscriptionName'>
        /// The subscription name.
        /// </param>
        /// <param name='ruleName'>
        /// The rule name.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string namespaceName, string topicName, string subscriptionName, string ruleName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Retrieves the description for the specified rule.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the Resource group within the Azure subscription.
        /// </param>
        /// <param name='namespaceName'>
        /// The namespace name
        /// </param>
        /// <param name='topicName'>
        /// The topic name.
        /// </param>
        /// <param name='subscriptionName'>
        /// The subscription name.
        /// </param>
        /// <param name='ruleName'>
        /// The rule name.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<Rule>> GetWithHttpMessagesAsync(string resourceGroupName, string namespaceName, string topicName, string subscriptionName, string ruleName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// List all the rules within given topic-subscription
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<Rule>>> ListBySubscriptionsNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
