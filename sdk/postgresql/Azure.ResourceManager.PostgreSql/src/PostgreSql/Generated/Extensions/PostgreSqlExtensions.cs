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
using Azure.ResourceManager.PostgreSql.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.PostgreSql
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.PostgreSql. </summary>
    public static partial class PostgreSqlExtensions
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
        /// List all the servers in a given subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DBforPostgreSQL/servers
        /// Operation Id: Servers_List
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PostgreSqlServerResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<PostgreSqlServerResource> GetPostgreSqlServersAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetPostgreSqlServersAsync(cancellationToken);
        }

        /// <summary>
        /// List all the servers in a given subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DBforPostgreSQL/servers
        /// Operation Id: Servers_List
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PostgreSqlServerResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<PostgreSqlServerResource> GetPostgreSqlServers(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetPostgreSqlServers(cancellationToken);
        }

        /// <summary>
        /// List all the performance tiers at specified location in a given subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DBforPostgreSQL/locations/{locationName}/performanceTiers
        /// Operation Id: LocationBasedPerformanceTier_List
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="locationName"> The name of the location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PostgreSqlPerformanceTierProperties" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<PostgreSqlPerformanceTierProperties> GetLocationBasedPerformanceTiersAsync(this SubscriptionResource subscriptionResource, AzureLocation locationName, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetLocationBasedPerformanceTiersAsync(locationName, cancellationToken);
        }

        /// <summary>
        /// List all the performance tiers at specified location in a given subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DBforPostgreSQL/locations/{locationName}/performanceTiers
        /// Operation Id: LocationBasedPerformanceTier_List
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="locationName"> The name of the location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PostgreSqlPerformanceTierProperties" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<PostgreSqlPerformanceTierProperties> GetLocationBasedPerformanceTiers(this SubscriptionResource subscriptionResource, AzureLocation locationName, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetLocationBasedPerformanceTiers(locationName, cancellationToken);
        }

        /// <summary>
        /// Check the availability of name for resource
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DBforPostgreSQL/checkNameAvailability
        /// Operation Id: CheckNameAvailability_Execute
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="content"> The required parameters for checking if resource name is available. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static async Task<Response<PostgreSqlNameAvailabilityResult>> CheckPostgreSqlNameAvailabilityAsync(this SubscriptionResource subscriptionResource, PostgreSqlNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            return await GetExtensionClient(subscriptionResource).CheckPostgreSqlNameAvailabilityAsync(content, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Check the availability of name for resource
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DBforPostgreSQL/checkNameAvailability
        /// Operation Id: CheckNameAvailability_Execute
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="content"> The required parameters for checking if resource name is available. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static Response<PostgreSqlNameAvailabilityResult> CheckPostgreSqlNameAvailability(this SubscriptionResource subscriptionResource, PostgreSqlNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            return GetExtensionClient(subscriptionResource).CheckPostgreSqlNameAvailability(content, cancellationToken);
        }

        private static ResourceGroupResourceExtensionClient GetExtensionClient(ResourceGroupResource resourceGroupResource)
        {
            return resourceGroupResource.GetCachedClient((client) =>
            {
                return new ResourceGroupResourceExtensionClient(client, resourceGroupResource.Id);
            }
            );
        }

        /// <summary> Gets a collection of PostgreSqlServerResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of PostgreSqlServerResources and their operations over a PostgreSqlServerResource. </returns>
        public static PostgreSqlServerCollection GetPostgreSqlServers(this ResourceGroupResource resourceGroupResource)
        {
            return GetExtensionClient(resourceGroupResource).GetPostgreSqlServers();
        }

        /// <summary>
        /// Gets information about a server.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/servers/{serverName}
        /// Operation Id: Servers_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<PostgreSqlServerResource>> GetPostgreSqlServerAsync(this ResourceGroupResource resourceGroupResource, string serverName, CancellationToken cancellationToken = default)
        {
            return await resourceGroupResource.GetPostgreSqlServers().GetAsync(serverName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets information about a server.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/servers/{serverName}
        /// Operation Id: Servers_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<PostgreSqlServerResource> GetPostgreSqlServer(this ResourceGroupResource resourceGroupResource, string serverName, CancellationToken cancellationToken = default)
        {
            return resourceGroupResource.GetPostgreSqlServers().Get(serverName, cancellationToken);
        }

        #region PostgreSqlServerResource
        /// <summary>
        /// Gets an object representing a <see cref="PostgreSqlServerResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PostgreSqlServerResource.CreateResourceIdentifier" /> to create a <see cref="PostgreSqlServerResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PostgreSqlServerResource" /> object. </returns>
        public static PostgreSqlServerResource GetPostgreSqlServerResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                PostgreSqlServerResource.ValidateResourceId(id);
                return new PostgreSqlServerResource(client, id);
            }
            );
        }
        #endregion

        #region PostgreSqlFirewallRuleResource
        /// <summary>
        /// Gets an object representing a <see cref="PostgreSqlFirewallRuleResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PostgreSqlFirewallRuleResource.CreateResourceIdentifier" /> to create a <see cref="PostgreSqlFirewallRuleResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PostgreSqlFirewallRuleResource" /> object. </returns>
        public static PostgreSqlFirewallRuleResource GetPostgreSqlFirewallRuleResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                PostgreSqlFirewallRuleResource.ValidateResourceId(id);
                return new PostgreSqlFirewallRuleResource(client, id);
            }
            );
        }
        #endregion

        #region PostgreSqlVirtualNetworkRuleResource
        /// <summary>
        /// Gets an object representing a <see cref="PostgreSqlVirtualNetworkRuleResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PostgreSqlVirtualNetworkRuleResource.CreateResourceIdentifier" /> to create a <see cref="PostgreSqlVirtualNetworkRuleResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PostgreSqlVirtualNetworkRuleResource" /> object. </returns>
        public static PostgreSqlVirtualNetworkRuleResource GetPostgreSqlVirtualNetworkRuleResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                PostgreSqlVirtualNetworkRuleResource.ValidateResourceId(id);
                return new PostgreSqlVirtualNetworkRuleResource(client, id);
            }
            );
        }
        #endregion

        #region PostgreSqlDatabaseResource
        /// <summary>
        /// Gets an object representing a <see cref="PostgreSqlDatabaseResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PostgreSqlDatabaseResource.CreateResourceIdentifier" /> to create a <see cref="PostgreSqlDatabaseResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PostgreSqlDatabaseResource" /> object. </returns>
        public static PostgreSqlDatabaseResource GetPostgreSqlDatabaseResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                PostgreSqlDatabaseResource.ValidateResourceId(id);
                return new PostgreSqlDatabaseResource(client, id);
            }
            );
        }
        #endregion

        #region PostgreSqlConfigurationResource
        /// <summary>
        /// Gets an object representing a <see cref="PostgreSqlConfigurationResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PostgreSqlConfigurationResource.CreateResourceIdentifier" /> to create a <see cref="PostgreSqlConfigurationResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PostgreSqlConfigurationResource" /> object. </returns>
        public static PostgreSqlConfigurationResource GetPostgreSqlConfigurationResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                PostgreSqlConfigurationResource.ValidateResourceId(id);
                return new PostgreSqlConfigurationResource(client, id);
            }
            );
        }
        #endregion

        #region PostgreSqlServerAdministratorResource
        /// <summary>
        /// Gets an object representing a <see cref="PostgreSqlServerAdministratorResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PostgreSqlServerAdministratorResource.CreateResourceIdentifier" /> to create a <see cref="PostgreSqlServerAdministratorResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PostgreSqlServerAdministratorResource" /> object. </returns>
        public static PostgreSqlServerAdministratorResource GetPostgreSqlServerAdministratorResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                PostgreSqlServerAdministratorResource.ValidateResourceId(id);
                return new PostgreSqlServerAdministratorResource(client, id);
            }
            );
        }
        #endregion

        #region PostgreSqlServerSecurityAlertPolicyResource
        /// <summary>
        /// Gets an object representing a <see cref="PostgreSqlServerSecurityAlertPolicyResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PostgreSqlServerSecurityAlertPolicyResource.CreateResourceIdentifier" /> to create a <see cref="PostgreSqlServerSecurityAlertPolicyResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PostgreSqlServerSecurityAlertPolicyResource" /> object. </returns>
        public static PostgreSqlServerSecurityAlertPolicyResource GetPostgreSqlServerSecurityAlertPolicyResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                PostgreSqlServerSecurityAlertPolicyResource.ValidateResourceId(id);
                return new PostgreSqlServerSecurityAlertPolicyResource(client, id);
            }
            );
        }
        #endregion

        #region PostgreSqlPrivateEndpointConnectionResource
        /// <summary>
        /// Gets an object representing a <see cref="PostgreSqlPrivateEndpointConnectionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PostgreSqlPrivateEndpointConnectionResource.CreateResourceIdentifier" /> to create a <see cref="PostgreSqlPrivateEndpointConnectionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PostgreSqlPrivateEndpointConnectionResource" /> object. </returns>
        public static PostgreSqlPrivateEndpointConnectionResource GetPostgreSqlPrivateEndpointConnectionResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                PostgreSqlPrivateEndpointConnectionResource.ValidateResourceId(id);
                return new PostgreSqlPrivateEndpointConnectionResource(client, id);
            }
            );
        }
        #endregion

        #region PostgreSqlPrivateLinkResource
        /// <summary>
        /// Gets an object representing a <see cref="PostgreSqlPrivateLinkResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PostgreSqlPrivateLinkResource.CreateResourceIdentifier" /> to create a <see cref="PostgreSqlPrivateLinkResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PostgreSqlPrivateLinkResource" /> object. </returns>
        public static PostgreSqlPrivateLinkResource GetPostgreSqlPrivateLinkResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                PostgreSqlPrivateLinkResource.ValidateResourceId(id);
                return new PostgreSqlPrivateLinkResource(client, id);
            }
            );
        }
        #endregion

        #region PostgreSqlServerKeyResource
        /// <summary>
        /// Gets an object representing a <see cref="PostgreSqlServerKeyResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PostgreSqlServerKeyResource.CreateResourceIdentifier" /> to create a <see cref="PostgreSqlServerKeyResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PostgreSqlServerKeyResource" /> object. </returns>
        public static PostgreSqlServerKeyResource GetPostgreSqlServerKeyResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                PostgreSqlServerKeyResource.ValidateResourceId(id);
                return new PostgreSqlServerKeyResource(client, id);
            }
            );
        }
        #endregion
    }
}
