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
using Azure.ResourceManager.DevSpaces.Mocking;
using Azure.ResourceManager.DevSpaces.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.DevSpaces
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.DevSpaces. </summary>
    public static partial class DevSpacesExtensions
    {
        private static DevSpacesArmClientMockingExtension GetDevSpacesArmClientMockingExtension(ArmClient client)
        {
            return client.GetCachedClient(client =>
            {
                return new DevSpacesArmClientMockingExtension(client);
            });
        }

        private static DevSpacesResourceGroupMockingExtension GetDevSpacesResourceGroupMockingExtension(ArmResource resource)
        {
            return resource.GetCachedClient(client =>
            {
                return new DevSpacesResourceGroupMockingExtension(client, resource.Id);
            });
        }

        private static DevSpacesSubscriptionMockingExtension GetDevSpacesSubscriptionMockingExtension(ArmResource resource)
        {
            return resource.GetCachedClient(client =>
            {
                return new DevSpacesSubscriptionMockingExtension(client, resource.Id);
            });
        }

        #region ControllerResource
        /// <summary>
        /// Gets an object representing a <see cref="ControllerResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ControllerResource.CreateResourceIdentifier" /> to create a <see cref="ControllerResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ControllerResource" /> object. </returns>
        public static ControllerResource GetControllerResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetDevSpacesArmClientMockingExtension(client).GetControllerResource(id);
        }
        #endregion

        /// <summary> Gets a collection of ControllerResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of ControllerResources and their operations over a ControllerResource. </returns>
        public static ControllerCollection GetControllers(this ResourceGroupResource resourceGroupResource)
        {
            return GetDevSpacesResourceGroupMockingExtension(resourceGroupResource).GetControllers();
        }

        /// <summary>
        /// Gets the properties for an Azure Dev Spaces Controller.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevSpaces/controllers/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Controllers_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="name"> Name of the resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<ControllerResource>> GetControllerAsync(this ResourceGroupResource resourceGroupResource, string name, CancellationToken cancellationToken = default)
        {
            return await GetDevSpacesResourceGroupMockingExtension(resourceGroupResource).GetControllerAsync(name, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the properties for an Azure Dev Spaces Controller.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevSpaces/controllers/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Controllers_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="name"> Name of the resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<ControllerResource> GetController(this ResourceGroupResource resourceGroupResource, string name, CancellationToken cancellationToken = default)
        {
            return GetDevSpacesResourceGroupMockingExtension(resourceGroupResource).GetController(name, cancellationToken);
        }

        /// <summary>
        /// Returns container host mapping object for a container host resource ID if an associated controller exists.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevSpaces/locations/{location}/checkContainerHostMapping</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContainerHostMappings_GetContainerHostMapping</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="location"> Location of the container host. </param>
        /// <param name="containerHostMapping"> The ContainerHostMapping to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="containerHostMapping"/> is null. </exception>
        public static async Task<Response<ContainerHostMapping>> GetContainerHostMappingContainerHostMappingAsync(this ResourceGroupResource resourceGroupResource, AzureLocation location, ContainerHostMapping containerHostMapping, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(containerHostMapping, nameof(containerHostMapping));

            return await GetDevSpacesResourceGroupMockingExtension(resourceGroupResource).GetContainerHostMappingContainerHostMappingAsync(location, containerHostMapping, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Returns container host mapping object for a container host resource ID if an associated controller exists.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevSpaces/locations/{location}/checkContainerHostMapping</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContainerHostMappings_GetContainerHostMapping</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="location"> Location of the container host. </param>
        /// <param name="containerHostMapping"> The ContainerHostMapping to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="containerHostMapping"/> is null. </exception>
        public static Response<ContainerHostMapping> GetContainerHostMappingContainerHostMapping(this ResourceGroupResource resourceGroupResource, AzureLocation location, ContainerHostMapping containerHostMapping, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(containerHostMapping, nameof(containerHostMapping));

            return GetDevSpacesResourceGroupMockingExtension(resourceGroupResource).GetContainerHostMappingContainerHostMapping(location, containerHostMapping, cancellationToken);
        }

        /// <summary>
        /// Lists all the Azure Dev Spaces Controllers with their properties in the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DevSpaces/controllers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Controllers_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ControllerResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<ControllerResource> GetControllersAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetDevSpacesSubscriptionMockingExtension(subscriptionResource).GetControllersAsync(cancellationToken);
        }

        /// <summary>
        /// Lists all the Azure Dev Spaces Controllers with their properties in the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DevSpaces/controllers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Controllers_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ControllerResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<ControllerResource> GetControllers(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetDevSpacesSubscriptionMockingExtension(subscriptionResource).GetControllers(cancellationToken);
        }
    }
}
