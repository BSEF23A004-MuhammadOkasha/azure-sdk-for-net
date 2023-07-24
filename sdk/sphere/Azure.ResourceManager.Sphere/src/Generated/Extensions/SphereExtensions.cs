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

namespace Azure.ResourceManager.Sphere
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.Sphere. </summary>
    public static partial class SphereExtensions
    {
        private static ResourceGroupResourceExtensionClient GetResourceGroupResourceExtensionClient(ArmResource resource)
        {
            return resource.GetCachedClient(client =>
            {
                return new ResourceGroupResourceExtensionClient(client, resource.Id);
            });
        }

        private static ResourceGroupResourceExtensionClient GetResourceGroupResourceExtensionClient(ArmClient client, ResourceIdentifier scope)
        {
            return client.GetResourceClient(() =>
            {
                return new ResourceGroupResourceExtensionClient(client, scope);
            });
        }

        private static SubscriptionResourceExtensionClient GetSubscriptionResourceExtensionClient(ArmResource resource)
        {
            return resource.GetCachedClient(client =>
            {
                return new SubscriptionResourceExtensionClient(client, resource.Id);
            });
        }

        private static SubscriptionResourceExtensionClient GetSubscriptionResourceExtensionClient(ArmClient client, ResourceIdentifier scope)
        {
            return client.GetResourceClient(() =>
            {
                return new SubscriptionResourceExtensionClient(client, scope);
            });
        }
        #region SphereCatalogResource
        /// <summary>
        /// Gets an object representing a <see cref="SphereCatalogResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SphereCatalogResource.CreateResourceIdentifier" /> to create a <see cref="SphereCatalogResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SphereCatalogResource" /> object. </returns>
        public static SphereCatalogResource GetSphereCatalogResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                SphereCatalogResource.ValidateResourceId(id);
                return new SphereCatalogResource(client, id);
            }
            );
        }
        #endregion

        #region SphereCertificateResource
        /// <summary>
        /// Gets an object representing a <see cref="SphereCertificateResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SphereCertificateResource.CreateResourceIdentifier" /> to create a <see cref="SphereCertificateResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SphereCertificateResource" /> object. </returns>
        public static SphereCertificateResource GetSphereCertificateResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                SphereCertificateResource.ValidateResourceId(id);
                return new SphereCertificateResource(client, id);
            }
            );
        }
        #endregion

        #region SphereImageResource
        /// <summary>
        /// Gets an object representing a <see cref="SphereImageResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SphereImageResource.CreateResourceIdentifier" /> to create a <see cref="SphereImageResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SphereImageResource" /> object. </returns>
        public static SphereImageResource GetSphereImageResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                SphereImageResource.ValidateResourceId(id);
                return new SphereImageResource(client, id);
            }
            );
        }
        #endregion

        #region SphereProductResource
        /// <summary>
        /// Gets an object representing a <see cref="SphereProductResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SphereProductResource.CreateResourceIdentifier" /> to create a <see cref="SphereProductResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SphereProductResource" /> object. </returns>
        public static SphereProductResource GetSphereProductResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                SphereProductResource.ValidateResourceId(id);
                return new SphereProductResource(client, id);
            }
            );
        }
        #endregion

        #region SphereDeviceGroupResource
        /// <summary>
        /// Gets an object representing a <see cref="SphereDeviceGroupResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SphereDeviceGroupResource.CreateResourceIdentifier" /> to create a <see cref="SphereDeviceGroupResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SphereDeviceGroupResource" /> object. </returns>
        public static SphereDeviceGroupResource GetSphereDeviceGroupResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                SphereDeviceGroupResource.ValidateResourceId(id);
                return new SphereDeviceGroupResource(client, id);
            }
            );
        }
        #endregion

        #region SphereDeploymentResource
        /// <summary>
        /// Gets an object representing a <see cref="SphereDeploymentResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SphereDeploymentResource.CreateResourceIdentifier" /> to create a <see cref="SphereDeploymentResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SphereDeploymentResource" /> object. </returns>
        public static SphereDeploymentResource GetSphereDeploymentResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                SphereDeploymentResource.ValidateResourceId(id);
                return new SphereDeploymentResource(client, id);
            }
            );
        }
        #endregion

        #region SphereDeviceResource
        /// <summary>
        /// Gets an object representing a <see cref="SphereDeviceResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SphereDeviceResource.CreateResourceIdentifier" /> to create a <see cref="SphereDeviceResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SphereDeviceResource" /> object. </returns>
        public static SphereDeviceResource GetSphereDeviceResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                SphereDeviceResource.ValidateResourceId(id);
                return new SphereDeviceResource(client, id);
            }
            );
        }
        #endregion

        /// <summary> Gets a collection of SphereCatalogResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of SphereCatalogResources and their operations over a SphereCatalogResource. </returns>
        public static SphereCatalogCollection GetSphereCatalogs(this ResourceGroupResource resourceGroupResource)
        {
            return GetResourceGroupResourceExtensionClient(resourceGroupResource).GetSphereCatalogs();
        }

        /// <summary>
        /// Get a Catalog
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureSphere/catalogs/{catalogName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Catalogs_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="catalogName"> Name of catalog. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="catalogName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="catalogName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<SphereCatalogResource>> GetSphereCatalogAsync(this ResourceGroupResource resourceGroupResource, string catalogName, CancellationToken cancellationToken = default)
        {
            return await resourceGroupResource.GetSphereCatalogs().GetAsync(catalogName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a Catalog
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureSphere/catalogs/{catalogName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Catalogs_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="catalogName"> Name of catalog. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="catalogName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="catalogName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<SphereCatalogResource> GetSphereCatalog(this ResourceGroupResource resourceGroupResource, string catalogName, CancellationToken cancellationToken = default)
        {
            return resourceGroupResource.GetSphereCatalogs().Get(catalogName, cancellationToken);
        }

        /// <summary>
        /// List Catalog resources by subscription ID
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AzureSphere/catalogs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Catalogs_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SphereCatalogResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<SphereCatalogResource> GetSphereCatalogsAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetSubscriptionResourceExtensionClient(subscriptionResource).GetSphereCatalogsAsync(cancellationToken);
        }

        /// <summary>
        /// List Catalog resources by subscription ID
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AzureSphere/catalogs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Catalogs_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SphereCatalogResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<SphereCatalogResource> GetSphereCatalogs(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetSubscriptionResourceExtensionClient(subscriptionResource).GetSphereCatalogs(cancellationToken);
        }
    }
}
