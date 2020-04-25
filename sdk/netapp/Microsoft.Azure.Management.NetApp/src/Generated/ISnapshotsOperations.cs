// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.NetApp
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// SnapshotsOperations operations.
    /// </summary>
    public partial interface ISnapshotsOperations
    {
        /// <summary>
        /// Describe all snapshots
        /// </summary>
        /// <remarks>
        /// List all snapshots associated with the volume
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='accountName'>
        /// The name of the NetApp account
        /// </param>
        /// <param name='poolName'>
        /// The name of the capacity pool
        /// </param>
        /// <param name='volumeName'>
        /// The name of the volume
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
        Task<AzureOperationResponse<IEnumerable<Snapshot>>> ListWithHttpMessagesAsync(string resourceGroupName, string accountName, string poolName, string volumeName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Describe a snapshot
        /// </summary>
        /// <remarks>
        /// Get details of the specified snapshot
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='accountName'>
        /// The name of the NetApp account
        /// </param>
        /// <param name='poolName'>
        /// The name of the capacity pool
        /// </param>
        /// <param name='volumeName'>
        /// The name of the volume
        /// </param>
        /// <param name='snapshotName'>
        /// The name of the mount target
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
        Task<AzureOperationResponse<Snapshot>> GetWithHttpMessagesAsync(string resourceGroupName, string accountName, string poolName, string volumeName, string snapshotName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Create a snapshot
        /// </summary>
        /// <remarks>
        /// Create the specified snapshot within the given volume
        /// </remarks>
        /// <param name='body'>
        /// Snapshot object supplied in the body of the operation.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='accountName'>
        /// The name of the NetApp account
        /// </param>
        /// <param name='poolName'>
        /// The name of the capacity pool
        /// </param>
        /// <param name='volumeName'>
        /// The name of the volume
        /// </param>
        /// <param name='snapshotName'>
        /// The name of the mount target
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
        Task<AzureOperationResponse<Snapshot>> CreateWithHttpMessagesAsync(Snapshot body, string resourceGroupName, string accountName, string poolName, string volumeName, string snapshotName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Update a snapshot
        /// </summary>
        /// <remarks>
        /// Patch a snapshot
        /// </remarks>
        /// <param name='body'>
        /// Snapshot object supplied in the body of the operation.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='accountName'>
        /// The name of the NetApp account
        /// </param>
        /// <param name='poolName'>
        /// The name of the capacity pool
        /// </param>
        /// <param name='volumeName'>
        /// The name of the volume
        /// </param>
        /// <param name='snapshotName'>
        /// The name of the mount target
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
        Task<AzureOperationResponse<Snapshot>> UpdateWithHttpMessagesAsync(object body, string resourceGroupName, string accountName, string poolName, string volumeName, string snapshotName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Delete a snapshot
        /// </summary>
        /// <remarks>
        /// Delete snapshot
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='accountName'>
        /// The name of the NetApp account
        /// </param>
        /// <param name='poolName'>
        /// The name of the capacity pool
        /// </param>
        /// <param name='volumeName'>
        /// The name of the volume
        /// </param>
        /// <param name='snapshotName'>
        /// The name of the mount target
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
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string accountName, string poolName, string volumeName, string snapshotName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Create a snapshot
        /// </summary>
        /// <remarks>
        /// Create the specified snapshot within the given volume
        /// </remarks>
        /// <param name='body'>
        /// Snapshot object supplied in the body of the operation.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='accountName'>
        /// The name of the NetApp account
        /// </param>
        /// <param name='poolName'>
        /// The name of the capacity pool
        /// </param>
        /// <param name='volumeName'>
        /// The name of the volume
        /// </param>
        /// <param name='snapshotName'>
        /// The name of the mount target
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
        Task<AzureOperationResponse<Snapshot>> BeginCreateWithHttpMessagesAsync(Snapshot body, string resourceGroupName, string accountName, string poolName, string volumeName, string snapshotName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Update a snapshot
        /// </summary>
        /// <remarks>
        /// Patch a snapshot
        /// </remarks>
        /// <param name='body'>
        /// Snapshot object supplied in the body of the operation.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='accountName'>
        /// The name of the NetApp account
        /// </param>
        /// <param name='poolName'>
        /// The name of the capacity pool
        /// </param>
        /// <param name='volumeName'>
        /// The name of the volume
        /// </param>
        /// <param name='snapshotName'>
        /// The name of the mount target
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
        Task<AzureOperationResponse<Snapshot>> BeginUpdateWithHttpMessagesAsync(object body, string resourceGroupName, string accountName, string poolName, string volumeName, string snapshotName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Delete a snapshot
        /// </summary>
        /// <remarks>
        /// Delete snapshot
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='accountName'>
        /// The name of the NetApp account
        /// </param>
        /// <param name='poolName'>
        /// The name of the capacity pool
        /// </param>
        /// <param name='volumeName'>
        /// The name of the volume
        /// </param>
        /// <param name='snapshotName'>
        /// The name of the mount target
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
        Task<AzureOperationResponse> BeginDeleteWithHttpMessagesAsync(string resourceGroupName, string accountName, string poolName, string volumeName, string snapshotName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
