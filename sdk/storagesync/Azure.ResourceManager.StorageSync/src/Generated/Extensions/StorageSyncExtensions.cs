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
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.StorageSync.Models;

namespace Azure.ResourceManager.StorageSync
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.StorageSync. </summary>
    public static partial class StorageSyncExtensions
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
        /// Check the give namespace name availability.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.StorageSync/locations/{locationName}/checkNameAvailability
        /// Operation Id: StorageSyncServices_CheckNameAvailability
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="locationName"> The desired region for the name check. </param>
        /// <param name="content"> Parameters to check availability of the given namespace name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="locationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="locationName"/> or <paramref name="content"/> is null. </exception>
        public static async Task<Response<StorageSyncNameAvailabilityResult>> CheckNameAvailabilityStorageSyncServiceAsync(this SubscriptionResource subscriptionResource, string locationName, StorageSyncNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(locationName, nameof(locationName));
            Argument.AssertNotNull(content, nameof(content));

            return await GetExtensionClient(subscriptionResource).CheckNameAvailabilityStorageSyncServiceAsync(locationName, content, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Check the give namespace name availability.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.StorageSync/locations/{locationName}/checkNameAvailability
        /// Operation Id: StorageSyncServices_CheckNameAvailability
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="locationName"> The desired region for the name check. </param>
        /// <param name="content"> Parameters to check availability of the given namespace name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="locationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="locationName"/> or <paramref name="content"/> is null. </exception>
        public static Response<StorageSyncNameAvailabilityResult> CheckNameAvailabilityStorageSyncService(this SubscriptionResource subscriptionResource, string locationName, StorageSyncNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(locationName, nameof(locationName));
            Argument.AssertNotNull(content, nameof(content));

            return GetExtensionClient(subscriptionResource).CheckNameAvailabilityStorageSyncService(locationName, content, cancellationToken);
        }

        /// <summary>
        /// Get a StorageSyncService list by subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.StorageSync/storageSyncServices
        /// Operation Id: StorageSyncServices_ListBySubscription
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="StorageSyncServiceResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<StorageSyncServiceResource> GetStorageSyncServicesAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetStorageSyncServicesAsync(cancellationToken);
        }

        /// <summary>
        /// Get a StorageSyncService list by subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.StorageSync/storageSyncServices
        /// Operation Id: StorageSyncServices_ListBySubscription
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="StorageSyncServiceResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<StorageSyncServiceResource> GetStorageSyncServices(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetStorageSyncServices(cancellationToken);
        }

        private static ResourceGroupResourceExtensionClient GetExtensionClient(ResourceGroupResource resourceGroupResource)
        {
            return resourceGroupResource.GetCachedClient((client) =>
            {
                return new ResourceGroupResourceExtensionClient(client, resourceGroupResource.Id);
            }
            );
        }

        /// <summary> Gets a collection of StorageSyncServiceResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of StorageSyncServiceResources and their operations over a StorageSyncServiceResource. </returns>
        public static StorageSyncServiceCollection GetStorageSyncServices(this ResourceGroupResource resourceGroupResource)
        {
            return GetExtensionClient(resourceGroupResource).GetStorageSyncServices();
        }

        /// <summary>
        /// Get a given StorageSyncService.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageSync/storageSyncServices/{storageSyncServiceName}
        /// Operation Id: StorageSyncServices_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="storageSyncServiceName"> Name of Storage Sync Service resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageSyncServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageSyncServiceName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<StorageSyncServiceResource>> GetStorageSyncServiceAsync(this ResourceGroupResource resourceGroupResource, string storageSyncServiceName, CancellationToken cancellationToken = default)
        {
            return await resourceGroupResource.GetStorageSyncServices().GetAsync(storageSyncServiceName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a given StorageSyncService.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageSync/storageSyncServices/{storageSyncServiceName}
        /// Operation Id: StorageSyncServices_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="storageSyncServiceName"> Name of Storage Sync Service resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageSyncServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageSyncServiceName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<StorageSyncServiceResource> GetStorageSyncService(this ResourceGroupResource resourceGroupResource, string storageSyncServiceName, CancellationToken cancellationToken = default)
        {
            return resourceGroupResource.GetStorageSyncServices().Get(storageSyncServiceName, cancellationToken);
        }

        #region StorageSyncServiceResource
        /// <summary>
        /// Gets an object representing a <see cref="StorageSyncServiceResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="StorageSyncServiceResource.CreateResourceIdentifier" /> to create a <see cref="StorageSyncServiceResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="StorageSyncServiceResource" /> object. </returns>
        public static StorageSyncServiceResource GetStorageSyncServiceResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                StorageSyncServiceResource.ValidateResourceId(id);
                return new StorageSyncServiceResource(client, id);
            }
            );
        }
        #endregion

        #region StorageSyncPrivateEndpointConnectionResource
        /// <summary>
        /// Gets an object representing a <see cref="StorageSyncPrivateEndpointConnectionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="StorageSyncPrivateEndpointConnectionResource.CreateResourceIdentifier" /> to create a <see cref="StorageSyncPrivateEndpointConnectionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="StorageSyncPrivateEndpointConnectionResource" /> object. </returns>
        public static StorageSyncPrivateEndpointConnectionResource GetStorageSyncPrivateEndpointConnectionResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                StorageSyncPrivateEndpointConnectionResource.ValidateResourceId(id);
                return new StorageSyncPrivateEndpointConnectionResource(client, id);
            }
            );
        }
        #endregion

        #region StorageSyncGroupResource
        /// <summary>
        /// Gets an object representing a <see cref="StorageSyncGroupResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="StorageSyncGroupResource.CreateResourceIdentifier" /> to create a <see cref="StorageSyncGroupResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="StorageSyncGroupResource" /> object. </returns>
        public static StorageSyncGroupResource GetStorageSyncGroupResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                StorageSyncGroupResource.ValidateResourceId(id);
                return new StorageSyncGroupResource(client, id);
            }
            );
        }
        #endregion

        #region CloudEndpointResource
        /// <summary>
        /// Gets an object representing a <see cref="CloudEndpointResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="CloudEndpointResource.CreateResourceIdentifier" /> to create a <see cref="CloudEndpointResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="CloudEndpointResource" /> object. </returns>
        public static CloudEndpointResource GetCloudEndpointResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                CloudEndpointResource.ValidateResourceId(id);
                return new CloudEndpointResource(client, id);
            }
            );
        }
        #endregion

        #region ServerEndpointResource
        /// <summary>
        /// Gets an object representing a <see cref="ServerEndpointResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ServerEndpointResource.CreateResourceIdentifier" /> to create a <see cref="ServerEndpointResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ServerEndpointResource" /> object. </returns>
        public static ServerEndpointResource GetServerEndpointResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                ServerEndpointResource.ValidateResourceId(id);
                return new ServerEndpointResource(client, id);
            }
            );
        }
        #endregion

        #region RegisteredServerResource
        /// <summary>
        /// Gets an object representing a <see cref="RegisteredServerResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="RegisteredServerResource.CreateResourceIdentifier" /> to create a <see cref="RegisteredServerResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="RegisteredServerResource" /> object. </returns>
        public static RegisteredServerResource GetRegisteredServerResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                RegisteredServerResource.ValidateResourceId(id);
                return new RegisteredServerResource(client, id);
            }
            );
        }
        #endregion

        #region StorageSyncWorkflowResource
        /// <summary>
        /// Gets an object representing a <see cref="StorageSyncWorkflowResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="StorageSyncWorkflowResource.CreateResourceIdentifier" /> to create a <see cref="StorageSyncWorkflowResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="StorageSyncWorkflowResource" /> object. </returns>
        public static StorageSyncWorkflowResource GetStorageSyncWorkflowResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                StorageSyncWorkflowResource.ValidateResourceId(id);
                return new StorageSyncWorkflowResource(client, id);
            }
            );
        }
        #endregion
    }
}
