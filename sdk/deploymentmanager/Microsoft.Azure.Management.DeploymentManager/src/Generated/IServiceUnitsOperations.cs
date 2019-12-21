// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DeploymentManager
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// ServiceUnitsOperations operations.
    /// </summary>
    public partial interface IServiceUnitsOperations
    {
        /// <summary>
        /// Creates or updates a service unit under the service in the service
        /// topology.
        /// </summary>
        /// <remarks>
        /// This is an asynchronous operation and can be polled to completion
        /// using the operation resource returned by this operation.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='serviceTopologyName'>
        /// The name of the service topology .
        /// </param>
        /// <param name='serviceName'>
        /// The name of the service resource.
        /// </param>
        /// <param name='serviceUnitName'>
        /// The name of the service unit resource.
        /// </param>
        /// <param name='serviceUnitInfo'>
        /// The service unit resource object.
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
        Task<AzureOperationResponse<ServiceUnitResource,ServiceUnitsCreateOrUpdateHeaders>> CreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string serviceTopologyName, string serviceName, string serviceUnitName, ServiceUnitResource serviceUnitInfo, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the service unit.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='serviceTopologyName'>
        /// The name of the service topology .
        /// </param>
        /// <param name='serviceName'>
        /// The name of the service resource.
        /// </param>
        /// <param name='serviceUnitName'>
        /// The name of the service unit resource.
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
        Task<AzureOperationResponse<ServiceUnitResource>> GetWithHttpMessagesAsync(string resourceGroupName, string serviceTopologyName, string serviceName, string serviceUnitName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes the service unit.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='serviceTopologyName'>
        /// The name of the service topology .
        /// </param>
        /// <param name='serviceName'>
        /// The name of the service resource.
        /// </param>
        /// <param name='serviceUnitName'>
        /// The name of the service unit resource.
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
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string serviceTopologyName, string serviceName, string serviceUnitName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists the service units under a service in the service topology.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='serviceTopologyName'>
        /// The name of the service topology .
        /// </param>
        /// <param name='serviceName'>
        /// The name of the service resource.
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
        Task<AzureOperationResponse<IList<ServiceUnitResource>>> ListWithHttpMessagesAsync(string resourceGroupName, string serviceTopologyName, string serviceName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates or updates a service unit under the service in the service
        /// topology.
        /// </summary>
        /// <remarks>
        /// This is an asynchronous operation and can be polled to completion
        /// using the operation resource returned by this operation.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='serviceTopologyName'>
        /// The name of the service topology .
        /// </param>
        /// <param name='serviceName'>
        /// The name of the service resource.
        /// </param>
        /// <param name='serviceUnitName'>
        /// The name of the service unit resource.
        /// </param>
        /// <param name='serviceUnitInfo'>
        /// The service unit resource object.
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
        Task<AzureOperationResponse<ServiceUnitResource,ServiceUnitsCreateOrUpdateHeaders>> BeginCreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string serviceTopologyName, string serviceName, string serviceUnitName, ServiceUnitResource serviceUnitInfo, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
