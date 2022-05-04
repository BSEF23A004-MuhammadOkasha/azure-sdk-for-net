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
using Azure.ResourceManager.ElasticSan.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.ElasticSan
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.ElasticSan. </summary>
    public static partial class ElasticSanExtensions
    {
        private static TenantResourceExtensionClient GetExtensionClient(TenantResource tenantResource)
        {
            return tenantResource.GetCachedClient((client) =>
            {
                return new TenantResourceExtensionClient(client, tenantResource.Id);
            }
            );
        }

        /// <summary>
        /// List all the available Skus in the region and information related to them
        /// Request Path: /providers/Microsoft.ElasticSan/skus
        /// Operation Id: Skus_List
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="filter"> Specify $filter=&apos;location eq &lt;location&gt;&apos; to filter on location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ResourceTypeSku" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<ResourceTypeSku> GetSkusAsync(this TenantResource tenantResource, string filter = null, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(tenantResource).GetSkusAsync(filter, cancellationToken);
        }

        /// <summary>
        /// List all the available Skus in the region and information related to them
        /// Request Path: /providers/Microsoft.ElasticSan/skus
        /// Operation Id: Skus_List
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="filter"> Specify $filter=&apos;location eq &lt;location&gt;&apos; to filter on location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ResourceTypeSku" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<ResourceTypeSku> GetSkus(this TenantResource tenantResource, string filter = null, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(tenantResource).GetSkus(filter, cancellationToken);
        }

        private static SubscriptionResourceExtensionClient GetExtensionClient(SubscriptionResource subscriptionResource)
        {
            return subscriptionResource.GetCachedClient((client) =>
            {
                return new SubscriptionResourceExtensionClient(client, subscriptionResource.Id);
            }
            );
        }

        /// <summary>
        /// Gets a list of ElasticSans in a subscription
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.ElasticSan/elasticSans
        /// Operation Id: ElasticSans_ListBySubscription
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ElasticSanResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<ElasticSanResource> GetElasticSansAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetElasticSansAsync(cancellationToken);
        }

        /// <summary>
        /// Gets a list of ElasticSans in a subscription
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.ElasticSan/elasticSans
        /// Operation Id: ElasticSans_ListBySubscription
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ElasticSanResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<ElasticSanResource> GetElasticSans(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetElasticSans(cancellationToken);
        }

        private static ResourceGroupResourceExtensionClient GetExtensionClient(ResourceGroupResource resourceGroupResource)
        {
            return resourceGroupResource.GetCachedClient((client) =>
            {
                return new ResourceGroupResourceExtensionClient(client, resourceGroupResource.Id);
            }
            );
        }

        /// <summary> Gets a collection of ElasticSanResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of ElasticSanResources and their operations over a ElasticSanResource. </returns>
        public static ElasticSanCollection GetElasticSans(this ResourceGroupResource resourceGroupResource)
        {
            return GetExtensionClient(resourceGroupResource).GetElasticSans();
        }

        /// <summary>
        /// Get a ElasticSan.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ElasticSan/elasticSans/{elasticSanName}
        /// Operation Id: ElasticSans_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="elasticSanName"> The name of the ElasticSan. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="elasticSanName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="elasticSanName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<ElasticSanResource>> GetElasticSanAsync(this ResourceGroupResource resourceGroupResource, string elasticSanName, CancellationToken cancellationToken = default)
        {
            return await resourceGroupResource.GetElasticSans().GetAsync(elasticSanName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a ElasticSan.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ElasticSan/elasticSans/{elasticSanName}
        /// Operation Id: ElasticSans_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="elasticSanName"> The name of the ElasticSan. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="elasticSanName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="elasticSanName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<ElasticSanResource> GetElasticSan(this ResourceGroupResource resourceGroupResource, string elasticSanName, CancellationToken cancellationToken = default)
        {
            return resourceGroupResource.GetElasticSans().Get(elasticSanName, cancellationToken);
        }

        #region ElasticSanResource
        /// <summary>
        /// Gets an object representing an <see cref="ElasticSanResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ElasticSanResource.CreateResourceIdentifier" /> to create an <see cref="ElasticSanResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ElasticSanResource" /> object. </returns>
        public static ElasticSanResource GetElasticSanResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                ElasticSanResource.ValidateResourceId(id);
                return new ElasticSanResource(client, id);
            }
            );
        }
        #endregion

        #region VolumeGroupResource
        /// <summary>
        /// Gets an object representing a <see cref="VolumeGroupResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="VolumeGroupResource.CreateResourceIdentifier" /> to create a <see cref="VolumeGroupResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="VolumeGroupResource" /> object. </returns>
        public static VolumeGroupResource GetVolumeGroupResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                VolumeGroupResource.ValidateResourceId(id);
                return new VolumeGroupResource(client, id);
            }
            );
        }
        #endregion

        #region VolumeResource
        /// <summary>
        /// Gets an object representing a <see cref="VolumeResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="VolumeResource.CreateResourceIdentifier" /> to create a <see cref="VolumeResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="VolumeResource" /> object. </returns>
        public static VolumeResource GetVolumeResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                VolumeResource.ValidateResourceId(id);
                return new VolumeResource(client, id);
            }
            );
        }
        #endregion
    }
}
