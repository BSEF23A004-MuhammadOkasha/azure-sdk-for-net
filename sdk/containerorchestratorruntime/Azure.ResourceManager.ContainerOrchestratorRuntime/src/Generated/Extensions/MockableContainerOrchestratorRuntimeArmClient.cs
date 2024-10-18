// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.ContainerOrchestratorRuntime.Mocking
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public partial class MockableContainerOrchestratorRuntimeArmClient : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableContainerOrchestratorRuntimeArmClient"/> class for mocking. </summary>
        protected MockableContainerOrchestratorRuntimeArmClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableContainerOrchestratorRuntimeArmClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableContainerOrchestratorRuntimeArmClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        internal MockableContainerOrchestratorRuntimeArmClient(ArmClient client) : this(client, ResourceIdentifier.Root)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of ConnectedClusterStorageClassResources in the ArmClient. </summary>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <returns> An object representing collection of ConnectedClusterStorageClassResources and their operations over a ConnectedClusterStorageClassResource. </returns>
        public virtual ConnectedClusterStorageClassCollection GetConnectedClusterStorageClasses(ResourceIdentifier scope)
        {
            return new ConnectedClusterStorageClassCollection(Client, scope);
        }

        /// <summary>
        /// Get a StorageClassResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.KubernetesRuntime/storageClasses/{storageClassName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageClassResource_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ConnectedClusterStorageClassResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <param name="storageClassName"> The name of the the storage class. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="storageClassName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="storageClassName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<ConnectedClusterStorageClassResource>> GetConnectedClusterStorageClassAsync(ResourceIdentifier scope, string storageClassName, CancellationToken cancellationToken = default)
        {
            return await GetConnectedClusterStorageClasses(scope).GetAsync(storageClassName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a StorageClassResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.KubernetesRuntime/storageClasses/{storageClassName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageClassResource_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ConnectedClusterStorageClassResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <param name="storageClassName"> The name of the the storage class. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="storageClassName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="storageClassName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<ConnectedClusterStorageClassResource> GetConnectedClusterStorageClass(ResourceIdentifier scope, string storageClassName, CancellationToken cancellationToken = default)
        {
            return GetConnectedClusterStorageClasses(scope).Get(storageClassName, cancellationToken);
        }

        /// <summary> Gets a collection of ConnectedClusterLoadBalancerResources in the ArmClient. </summary>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <returns> An object representing collection of ConnectedClusterLoadBalancerResources and their operations over a ConnectedClusterLoadBalancerResource. </returns>
        public virtual ConnectedClusterLoadBalancerCollection GetConnectedClusterLoadBalancers(ResourceIdentifier scope)
        {
            return new ConnectedClusterLoadBalancerCollection(Client, scope);
        }

        /// <summary>
        /// Get a LoadBalancer
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.KubernetesRuntime/loadBalancers/{loadBalancerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LoadBalancer_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ConnectedClusterLoadBalancerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <param name="loadBalancerName"> The name of the LoadBalancer. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="loadBalancerName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="loadBalancerName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<ConnectedClusterLoadBalancerResource>> GetConnectedClusterLoadBalancerAsync(ResourceIdentifier scope, string loadBalancerName, CancellationToken cancellationToken = default)
        {
            return await GetConnectedClusterLoadBalancers(scope).GetAsync(loadBalancerName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a LoadBalancer
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.KubernetesRuntime/loadBalancers/{loadBalancerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LoadBalancer_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ConnectedClusterLoadBalancerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <param name="loadBalancerName"> The name of the LoadBalancer. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="loadBalancerName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="loadBalancerName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<ConnectedClusterLoadBalancerResource> GetConnectedClusterLoadBalancer(ResourceIdentifier scope, string loadBalancerName, CancellationToken cancellationToken = default)
        {
            return GetConnectedClusterLoadBalancers(scope).Get(loadBalancerName, cancellationToken);
        }

        /// <summary> Gets a collection of ConnectedClusterBgpPeerResources in the ArmClient. </summary>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <returns> An object representing collection of ConnectedClusterBgpPeerResources and their operations over a ConnectedClusterBgpPeerResource. </returns>
        public virtual ConnectedClusterBgpPeerCollection GetConnectedClusterBgpPeers(ResourceIdentifier scope)
        {
            return new ConnectedClusterBgpPeerCollection(Client, scope);
        }

        /// <summary>
        /// Get a BgpPeer
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.KubernetesRuntime/bgpPeers/{bgpPeerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BgpPeer_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ConnectedClusterBgpPeerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <param name="bgpPeerName"> The name of the BgpPeer. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="bgpPeerName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="bgpPeerName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<ConnectedClusterBgpPeerResource>> GetConnectedClusterBgpPeerAsync(ResourceIdentifier scope, string bgpPeerName, CancellationToken cancellationToken = default)
        {
            return await GetConnectedClusterBgpPeers(scope).GetAsync(bgpPeerName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a BgpPeer
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.KubernetesRuntime/bgpPeers/{bgpPeerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BgpPeer_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ConnectedClusterBgpPeerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <param name="bgpPeerName"> The name of the BgpPeer. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="bgpPeerName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="bgpPeerName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<ConnectedClusterBgpPeerResource> GetConnectedClusterBgpPeer(ResourceIdentifier scope, string bgpPeerName, CancellationToken cancellationToken = default)
        {
            return GetConnectedClusterBgpPeers(scope).Get(bgpPeerName, cancellationToken);
        }

        /// <summary> Gets a collection of ConnectedClusterServiceResources in the ArmClient. </summary>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <returns> An object representing collection of ConnectedClusterServiceResources and their operations over a ConnectedClusterServiceResource. </returns>
        public virtual ConnectedClusterServiceCollection GetConnectedClusterServices(ResourceIdentifier scope)
        {
            return new ConnectedClusterServiceCollection(Client, scope);
        }

        /// <summary>
        /// Get a ServiceResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.KubernetesRuntime/services/{serviceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServiceResource_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ConnectedClusterServiceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <param name="serviceName"> The name of the the service. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="serviceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<ConnectedClusterServiceResource>> GetConnectedClusterServiceAsync(ResourceIdentifier scope, string serviceName, CancellationToken cancellationToken = default)
        {
            return await GetConnectedClusterServices(scope).GetAsync(serviceName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a ServiceResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.KubernetesRuntime/services/{serviceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServiceResource_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ConnectedClusterServiceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <param name="serviceName"> The name of the the service. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="serviceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<ConnectedClusterServiceResource> GetConnectedClusterService(ResourceIdentifier scope, string serviceName, CancellationToken cancellationToken = default)
        {
            return GetConnectedClusterServices(scope).Get(serviceName, cancellationToken);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ConnectedClusterStorageClassResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ConnectedClusterStorageClassResource.CreateResourceIdentifier" /> to create a <see cref="ConnectedClusterStorageClassResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ConnectedClusterStorageClassResource"/> object. </returns>
        public virtual ConnectedClusterStorageClassResource GetConnectedClusterStorageClassResource(ResourceIdentifier id)
        {
            ConnectedClusterStorageClassResource.ValidateResourceId(id);
            return new ConnectedClusterStorageClassResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ConnectedClusterLoadBalancerResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ConnectedClusterLoadBalancerResource.CreateResourceIdentifier" /> to create a <see cref="ConnectedClusterLoadBalancerResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ConnectedClusterLoadBalancerResource"/> object. </returns>
        public virtual ConnectedClusterLoadBalancerResource GetConnectedClusterLoadBalancerResource(ResourceIdentifier id)
        {
            ConnectedClusterLoadBalancerResource.ValidateResourceId(id);
            return new ConnectedClusterLoadBalancerResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ConnectedClusterBgpPeerResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ConnectedClusterBgpPeerResource.CreateResourceIdentifier" /> to create a <see cref="ConnectedClusterBgpPeerResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ConnectedClusterBgpPeerResource"/> object. </returns>
        public virtual ConnectedClusterBgpPeerResource GetConnectedClusterBgpPeerResource(ResourceIdentifier id)
        {
            ConnectedClusterBgpPeerResource.ValidateResourceId(id);
            return new ConnectedClusterBgpPeerResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ConnectedClusterServiceResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ConnectedClusterServiceResource.CreateResourceIdentifier" /> to create a <see cref="ConnectedClusterServiceResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ConnectedClusterServiceResource"/> object. </returns>
        public virtual ConnectedClusterServiceResource GetConnectedClusterServiceResource(ResourceIdentifier id)
        {
            ConnectedClusterServiceResource.ValidateResourceId(id);
            return new ConnectedClusterServiceResource(Client, id);
        }
    }
}
