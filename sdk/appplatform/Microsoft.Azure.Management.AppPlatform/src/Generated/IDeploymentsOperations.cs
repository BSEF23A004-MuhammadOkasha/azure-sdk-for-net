// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.AppPlatform
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// DeploymentsOperations operations.
    /// </summary>
    public partial interface IDeploymentsOperations
    {
        /// <summary>
        /// Get a Deployment and its properties.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the resource. You can
        /// obtain this value from the Azure Resource Manager API or the
        /// portal.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the Service resource.
        /// </param>
        /// <param name='appName'>
        /// The name of the App resource.
        /// </param>
        /// <param name='deploymentName'>
        /// The name of the Deployment resource.
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
        Task<AzureOperationResponse<DeploymentResource>> GetWithHttpMessagesAsync(string resourceGroupName, string serviceName, string appName, string deploymentName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Create a new Deployment or update an exiting Deployment.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the resource. You can
        /// obtain this value from the Azure Resource Manager API or the
        /// portal.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the Service resource.
        /// </param>
        /// <param name='appName'>
        /// The name of the App resource.
        /// </param>
        /// <param name='deploymentName'>
        /// The name of the Deployment resource.
        /// </param>
        /// <param name='deploymentResource'>
        /// Parameters for the create or update operation
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
        Task<AzureOperationResponse<DeploymentResource>> CreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string serviceName, string appName, string deploymentName, DeploymentResource deploymentResource = default(DeploymentResource), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Operation to delete a Deployment.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the resource. You can
        /// obtain this value from the Azure Resource Manager API or the
        /// portal.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the Service resource.
        /// </param>
        /// <param name='appName'>
        /// The name of the App resource.
        /// </param>
        /// <param name='deploymentName'>
        /// The name of the Deployment resource.
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
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string serviceName, string appName, string deploymentName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Operation to update an exiting Deployment.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the resource. You can
        /// obtain this value from the Azure Resource Manager API or the
        /// portal.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the Service resource.
        /// </param>
        /// <param name='appName'>
        /// The name of the App resource.
        /// </param>
        /// <param name='deploymentName'>
        /// The name of the Deployment resource.
        /// </param>
        /// <param name='deploymentResource'>
        /// Parameters for the update operation
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
        Task<AzureOperationResponse<DeploymentResource>> UpdateWithHttpMessagesAsync(string resourceGroupName, string serviceName, string appName, string deploymentName, DeploymentResource deploymentResource = default(DeploymentResource), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Handles requests to list all resources in an App.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the resource. You can
        /// obtain this value from the Azure Resource Manager API or the
        /// portal.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the Service resource.
        /// </param>
        /// <param name='appName'>
        /// The name of the App resource.
        /// </param>
        /// <param name='version'>
        /// Version of the deployments to be listed
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
        Task<AzureOperationResponse<IPage<DeploymentResource>>> ListWithHttpMessagesAsync(string resourceGroupName, string serviceName, string appName, IList<string> version = default(IList<string>), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// List deployments for a certain service
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the resource. You can
        /// obtain this value from the Azure Resource Manager API or the
        /// portal.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the Service resource.
        /// </param>
        /// <param name='version'>
        /// Version of the deployments to be listed
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
        Task<AzureOperationResponse<IPage<DeploymentResource>>> ListClusterAllDeploymentsWithHttpMessagesAsync(string resourceGroupName, string serviceName, IList<string> version = default(IList<string>), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Start the deployment.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the resource. You can
        /// obtain this value from the Azure Resource Manager API or the
        /// portal.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the Service resource.
        /// </param>
        /// <param name='appName'>
        /// The name of the App resource.
        /// </param>
        /// <param name='deploymentName'>
        /// The name of the Deployment resource.
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
        Task<AzureOperationResponse> StartWithHttpMessagesAsync(string resourceGroupName, string serviceName, string appName, string deploymentName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Stop the deployment.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the resource. You can
        /// obtain this value from the Azure Resource Manager API or the
        /// portal.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the Service resource.
        /// </param>
        /// <param name='appName'>
        /// The name of the App resource.
        /// </param>
        /// <param name='deploymentName'>
        /// The name of the Deployment resource.
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
        Task<AzureOperationResponse> StopWithHttpMessagesAsync(string resourceGroupName, string serviceName, string appName, string deploymentName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Restart the deployment.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the resource. You can
        /// obtain this value from the Azure Resource Manager API or the
        /// portal.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the Service resource.
        /// </param>
        /// <param name='appName'>
        /// The name of the App resource.
        /// </param>
        /// <param name='deploymentName'>
        /// The name of the Deployment resource.
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
        Task<AzureOperationResponse> RestartWithHttpMessagesAsync(string resourceGroupName, string serviceName, string appName, string deploymentName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get deployment log file URL
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the resource. You can
        /// obtain this value from the Azure Resource Manager API or the
        /// portal.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the Service resource.
        /// </param>
        /// <param name='appName'>
        /// The name of the App resource.
        /// </param>
        /// <param name='deploymentName'>
        /// The name of the Deployment resource.
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
        Task<AzureOperationResponse<LogFileUrlResponse>> GetLogFileUrlWithHttpMessagesAsync(string resourceGroupName, string serviceName, string appName, string deploymentName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Create a new Deployment or update an exiting Deployment.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the resource. You can
        /// obtain this value from the Azure Resource Manager API or the
        /// portal.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the Service resource.
        /// </param>
        /// <param name='appName'>
        /// The name of the App resource.
        /// </param>
        /// <param name='deploymentName'>
        /// The name of the Deployment resource.
        /// </param>
        /// <param name='deploymentResource'>
        /// Parameters for the create or update operation
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
        Task<AzureOperationResponse<DeploymentResource>> BeginCreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string serviceName, string appName, string deploymentName, DeploymentResource deploymentResource = default(DeploymentResource), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Operation to update an exiting Deployment.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the resource. You can
        /// obtain this value from the Azure Resource Manager API or the
        /// portal.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the Service resource.
        /// </param>
        /// <param name='appName'>
        /// The name of the App resource.
        /// </param>
        /// <param name='deploymentName'>
        /// The name of the Deployment resource.
        /// </param>
        /// <param name='deploymentResource'>
        /// Parameters for the update operation
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
        Task<AzureOperationResponse<DeploymentResource>> BeginUpdateWithHttpMessagesAsync(string resourceGroupName, string serviceName, string appName, string deploymentName, DeploymentResource deploymentResource = default(DeploymentResource), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Start the deployment.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the resource. You can
        /// obtain this value from the Azure Resource Manager API or the
        /// portal.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the Service resource.
        /// </param>
        /// <param name='appName'>
        /// The name of the App resource.
        /// </param>
        /// <param name='deploymentName'>
        /// The name of the Deployment resource.
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
        Task<AzureOperationResponse> BeginStartWithHttpMessagesAsync(string resourceGroupName, string serviceName, string appName, string deploymentName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Stop the deployment.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the resource. You can
        /// obtain this value from the Azure Resource Manager API or the
        /// portal.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the Service resource.
        /// </param>
        /// <param name='appName'>
        /// The name of the App resource.
        /// </param>
        /// <param name='deploymentName'>
        /// The name of the Deployment resource.
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
        Task<AzureOperationResponse> BeginStopWithHttpMessagesAsync(string resourceGroupName, string serviceName, string appName, string deploymentName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Restart the deployment.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the resource. You can
        /// obtain this value from the Azure Resource Manager API or the
        /// portal.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the Service resource.
        /// </param>
        /// <param name='appName'>
        /// The name of the App resource.
        /// </param>
        /// <param name='deploymentName'>
        /// The name of the Deployment resource.
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
        Task<AzureOperationResponse> BeginRestartWithHttpMessagesAsync(string resourceGroupName, string serviceName, string appName, string deploymentName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Handles requests to list all resources in an App.
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
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<DeploymentResource>>> ListNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// List deployments for a certain service
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
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<DeploymentResource>>> ListClusterAllDeploymentsNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
