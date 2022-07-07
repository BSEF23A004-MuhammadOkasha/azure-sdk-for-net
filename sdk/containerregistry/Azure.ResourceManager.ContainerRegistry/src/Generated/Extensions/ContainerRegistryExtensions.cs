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
using Azure.ResourceManager.ContainerRegistry.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.ContainerRegistry
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.ContainerRegistry. </summary>
    public static partial class ContainerRegistryExtensions
    {
        private static SubscriptionResourceExtensionClient GetExtensionClient(SubscriptionResource subscriptionResource)
        {
            return subscriptionResource.GetCachedClient((client) =>
            {
                return new SubscriptionResourceExtensionClient(client, subscriptionResource.Id);
            }
            );
        }

        /// <summary>
        /// Checks whether the container registry name is available for use. The name must contain only alphanumeric characters, be globally unique, and between 5 and 50 characters in length.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.ContainerRegistry/checkNameAvailability
        /// Operation Id: Registries_CheckNameAvailability
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="content"> The object containing information for the availability request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static async Task<Response<RegistryNameStatus>> CheckNameAvailabilityRegistryAsync(this SubscriptionResource subscriptionResource, RegistryNameCheckContent content, CancellationToken cancellationToken = default)
        {
            Core.Argument.AssertNotNull(content, nameof(content));

            return await GetExtensionClient(subscriptionResource).CheckNameAvailabilityRegistryAsync(content, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Checks whether the container registry name is available for use. The name must contain only alphanumeric characters, be globally unique, and between 5 and 50 characters in length.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.ContainerRegistry/checkNameAvailability
        /// Operation Id: Registries_CheckNameAvailability
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="content"> The object containing information for the availability request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static Response<RegistryNameStatus> CheckNameAvailabilityRegistry(this SubscriptionResource subscriptionResource, RegistryNameCheckContent content, CancellationToken cancellationToken = default)
        {
            Core.Argument.AssertNotNull(content, nameof(content));

            return GetExtensionClient(subscriptionResource).CheckNameAvailabilityRegistry(content, cancellationToken);
        }

        /// <summary>
        /// Lists all the container registries under the specified subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.ContainerRegistry/registries
        /// Operation Id: Registries_List
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="RegistryResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<RegistryResource> GetRegistriesAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetRegistriesAsync(cancellationToken);
        }

        /// <summary>
        /// Lists all the container registries under the specified subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.ContainerRegistry/registries
        /// Operation Id: Registries_List
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="RegistryResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<RegistryResource> GetRegistries(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetRegistries(cancellationToken);
        }

        private static ResourceGroupResourceExtensionClient GetExtensionClient(ResourceGroupResource resourceGroupResource)
        {
            return resourceGroupResource.GetCachedClient((client) =>
            {
                return new ResourceGroupResourceExtensionClient(client, resourceGroupResource.Id);
            }
            );
        }

        /// <summary> Gets a collection of RegistryResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of RegistryResources and their operations over a RegistryResource. </returns>
        public static RegistryCollection GetRegistries(this ResourceGroupResource resourceGroupResource)
        {
            return GetExtensionClient(resourceGroupResource).GetRegistries();
        }

        /// <summary>
        /// Gets the properties of the specified container registry.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}
        /// Operation Id: Registries_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="registryName"> The name of the container registry. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="registryName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="registryName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<RegistryResource>> GetRegistryAsync(this ResourceGroupResource resourceGroupResource, string registryName, CancellationToken cancellationToken = default)
        {
            return await resourceGroupResource.GetRegistries().GetAsync(registryName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the properties of the specified container registry.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}
        /// Operation Id: Registries_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="registryName"> The name of the container registry. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="registryName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="registryName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<RegistryResource> GetRegistry(this ResourceGroupResource resourceGroupResource, string registryName, CancellationToken cancellationToken = default)
        {
            return resourceGroupResource.GetRegistries().Get(registryName, cancellationToken);
        }

        #region RegistryResource
        /// <summary>
        /// Gets an object representing a <see cref="RegistryResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="RegistryResource.CreateResourceIdentifier" /> to create a <see cref="RegistryResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="RegistryResource" /> object. </returns>
        public static RegistryResource GetRegistryResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                RegistryResource.ValidateResourceId(id);
                return new RegistryResource(client, id);
            }
            );
        }
        #endregion

        #region ContainerRegistryPrivateLinkResource
        /// <summary>
        /// Gets an object representing a <see cref="ContainerRegistryPrivateLinkResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ContainerRegistryPrivateLinkResource.CreateResourceIdentifier" /> to create a <see cref="ContainerRegistryPrivateLinkResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ContainerRegistryPrivateLinkResource" /> object. </returns>
        public static ContainerRegistryPrivateLinkResource GetContainerRegistryPrivateLinkResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                ContainerRegistryPrivateLinkResource.ValidateResourceId(id);
                return new ContainerRegistryPrivateLinkResource(client, id);
            }
            );
        }
        #endregion

        #region ContainerRegistryPrivateEndpointConnectionResource
        /// <summary>
        /// Gets an object representing a <see cref="ContainerRegistryPrivateEndpointConnectionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ContainerRegistryPrivateEndpointConnectionResource.CreateResourceIdentifier" /> to create a <see cref="ContainerRegistryPrivateEndpointConnectionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ContainerRegistryPrivateEndpointConnectionResource" /> object. </returns>
        public static ContainerRegistryPrivateEndpointConnectionResource GetContainerRegistryPrivateEndpointConnectionResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                ContainerRegistryPrivateEndpointConnectionResource.ValidateResourceId(id);
                return new ContainerRegistryPrivateEndpointConnectionResource(client, id);
            }
            );
        }
        #endregion

        #region ReplicationResource
        /// <summary>
        /// Gets an object representing a <see cref="ReplicationResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ReplicationResource.CreateResourceIdentifier" /> to create a <see cref="ReplicationResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ReplicationResource" /> object. </returns>
        public static ReplicationResource GetReplicationResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                ReplicationResource.ValidateResourceId(id);
                return new ReplicationResource(client, id);
            }
            );
        }
        #endregion

        #region WebhookResource
        /// <summary>
        /// Gets an object representing a <see cref="WebhookResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="WebhookResource.CreateResourceIdentifier" /> to create a <see cref="WebhookResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="WebhookResource" /> object. </returns>
        public static WebhookResource GetWebhookResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                WebhookResource.ValidateResourceId(id);
                return new WebhookResource(client, id);
            }
            );
        }
        #endregion

        #region AgentPoolResource
        /// <summary>
        /// Gets an object representing an <see cref="AgentPoolResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AgentPoolResource.CreateResourceIdentifier" /> to create an <see cref="AgentPoolResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AgentPoolResource" /> object. </returns>
        public static AgentPoolResource GetAgentPoolResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                AgentPoolResource.ValidateResourceId(id);
                return new AgentPoolResource(client, id);
            }
            );
        }
        #endregion

        #region RunResource
        /// <summary>
        /// Gets an object representing a <see cref="RunResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="RunResource.CreateResourceIdentifier" /> to create a <see cref="RunResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="RunResource" /> object. </returns>
        public static RunResource GetRunResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                RunResource.ValidateResourceId(id);
                return new RunResource(client, id);
            }
            );
        }
        #endregion

        #region TaskRunResource
        /// <summary>
        /// Gets an object representing a <see cref="TaskRunResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="TaskRunResource.CreateResourceIdentifier" /> to create a <see cref="TaskRunResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="TaskRunResource" /> object. </returns>
        public static TaskRunResource GetTaskRunResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                TaskRunResource.ValidateResourceId(id);
                return new TaskRunResource(client, id);
            }
            );
        }
        #endregion

        #region TaskResource
        /// <summary>
        /// Gets an object representing a <see cref="TaskResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="TaskResource.CreateResourceIdentifier" /> to create a <see cref="TaskResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="TaskResource" /> object. </returns>
        public static TaskResource GetTaskResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                TaskResource.ValidateResourceId(id);
                return new TaskResource(client, id);
            }
            );
        }
        #endregion
    }
}
