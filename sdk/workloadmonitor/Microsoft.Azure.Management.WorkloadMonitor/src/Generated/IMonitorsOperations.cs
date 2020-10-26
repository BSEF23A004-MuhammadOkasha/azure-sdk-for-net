// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.WorkloadMonitor
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// MonitorsOperations operations.
    /// </summary>
    public partial interface IMonitorsOperations
    {
        /// <summary>
        /// Get list of a monitors of a resource (with optional filter).
        /// </summary>
        /// <param name='subscriptionId'>
        /// The subscriptionId of the resource
        /// </param>
        /// <param name='resourceGroupName'>
        /// The resourceGroupName of the resource
        /// </param>
        /// <param name='resourceNamespace'>
        /// The resourceNamespace of the resource
        /// </param>
        /// <param name='resourceType'>
        /// The resourceType of the resource
        /// </param>
        /// <param name='resourceName'>
        /// The resourceType of the resource
        /// </param>
        /// <param name='filter'>
        /// list example: $filter=monitorName eq
        /// 'logical-disks|C:|disk-free-space-mb'; history example:
        /// $filter=isHeartbeat eq false
        /// </param>
        /// <param name='expand'>
        /// ex: $expand=evidence,configuration
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="DefaultErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<Models.Monitor>>> ListWithHttpMessagesAsync(string subscriptionId, string resourceGroupName, string resourceNamespace, string resourceType, string resourceName, string filter = default(string), string expand = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get the current status of a monitor of a resource.
        /// </summary>
        /// <param name='subscriptionId'>
        /// The subscriptionId of the resource
        /// </param>
        /// <param name='resourceGroupName'>
        /// The resourceGroupName of the resource
        /// </param>
        /// <param name='resourceNamespace'>
        /// The resourceNamespace of the resource
        /// </param>
        /// <param name='resourceType'>
        /// The resourceType of the resource
        /// </param>
        /// <param name='resourceName'>
        /// The resourceType of the resource
        /// </param>
        /// <param name='monitorId'>
        /// The monitorId of the resource (url encoded)
        /// </param>
        /// <param name='expand'>
        /// ex: $expand=evidence,configuration
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="DefaultErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<Models.Monitor>> GetWithHttpMessagesAsync(string subscriptionId, string resourceGroupName, string resourceNamespace, string resourceType, string resourceName, string monitorId, string expand = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get history of a monitor of a resource (with optional filter).
        /// </summary>
        /// <param name='subscriptionId'>
        /// The subscriptionId of the resource
        /// </param>
        /// <param name='resourceGroupName'>
        /// The resourceGroupName of the resource
        /// </param>
        /// <param name='resourceNamespace'>
        /// The resourceNamespace of the resource
        /// </param>
        /// <param name='resourceType'>
        /// The resourceType of the resource
        /// </param>
        /// <param name='resourceName'>
        /// The resourceType of the resource
        /// </param>
        /// <param name='monitorId'>
        /// The monitorId of the resource (url encoded)
        /// </param>
        /// <param name='filter'>
        /// list example: $filter=monitorName eq
        /// 'logical-disks|C:|disk-free-space-mb'; history example:
        /// $filter=isHeartbeat eq false
        /// </param>
        /// <param name='expand'>
        /// ex: $expand=evidence,configuration
        /// </param>
        /// <param name='startTimestampUtc'>
        /// The start Timestamp for the desired history
        /// </param>
        /// <param name='endTimestampUtc'>
        /// The end Timestamp for the desired history
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="DefaultErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<MonitorStateChange>>> ListStateChangesWithHttpMessagesAsync(string subscriptionId, string resourceGroupName, string resourceNamespace, string resourceType, string resourceName, string monitorId, string filter = default(string), string expand = default(string), System.DateTime? startTimestampUtc = default(System.DateTime?), System.DateTime? endTimestampUtc = default(System.DateTime?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get the status of a monitor at a specific timestamp in history.
        /// </summary>
        /// <param name='subscriptionId'>
        /// The subscriptionId of the resource
        /// </param>
        /// <param name='resourceGroupName'>
        /// The resourceGroupName of the resource
        /// </param>
        /// <param name='resourceNamespace'>
        /// The resourceNamespace of the resource
        /// </param>
        /// <param name='resourceType'>
        /// The resourceType of the resource
        /// </param>
        /// <param name='resourceName'>
        /// The resourceType of the resource
        /// </param>
        /// <param name='monitorId'>
        /// The monitorId of the resource (url encoded)
        /// </param>
        /// <param name='timestampUnix'>
        /// The timestamp of the state change (Unix format)
        /// </param>
        /// <param name='expand'>
        /// ex: $expand=evidence,configuration
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="DefaultErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<MonitorStateChange>> GetStateChangeWithHttpMessagesAsync(string subscriptionId, string resourceGroupName, string resourceNamespace, string resourceType, string resourceName, string monitorId, string timestampUnix, string expand = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get list of a monitors of a resource (with optional filter).
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
        /// <exception cref="DefaultErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<Models.Monitor>>> ListNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get history of a monitor of a resource (with optional filter).
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
        /// <exception cref="DefaultErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<MonitorStateChange>>> ListStateChangesNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
