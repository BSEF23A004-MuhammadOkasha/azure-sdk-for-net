// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.MySql.FlexibleServers.Models;

namespace Azure.ResourceManager.MySql.FlexibleServers
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    internal partial class SubscriptionResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _mySqlFlexibleServerServersClientDiagnostics;
        private ServersRestOperations _mySqlFlexibleServerServersRestClient;
        private ClientDiagnostics _locationBasedCapabilitiesClientDiagnostics;
        private LocationBasedCapabilitiesRestOperations _locationBasedCapabilitiesRestClient;
        private ClientDiagnostics _checkVirtualNetworkSubnetUsageClientDiagnostics;
        private CheckVirtualNetworkSubnetUsageRestOperations _checkVirtualNetworkSubnetUsageRestClient;
        private ClientDiagnostics _checkNameAvailabilityClientDiagnostics;
        private CheckNameAvailabilityRestOperations _checkNameAvailabilityRestClient;
        private ClientDiagnostics _checkNameAvailabilityWithoutLocationClientDiagnostics;
        private CheckNameAvailabilityWithoutLocationRestOperations _checkNameAvailabilityWithoutLocationRestClient;

        /// <summary> Initializes a new instance of the <see cref="SubscriptionResourceExtensionClient"/> class for mocking. </summary>
        protected SubscriptionResourceExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SubscriptionResourceExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SubscriptionResourceExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics MySqlFlexibleServerServersClientDiagnostics => _mySqlFlexibleServerServersClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.MySql.FlexibleServers", MySqlFlexibleServerResource.ResourceType.Namespace, Diagnostics);
        private ServersRestOperations MySqlFlexibleServerServersRestClient => _mySqlFlexibleServerServersRestClient ??= new ServersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(MySqlFlexibleServerResource.ResourceType));
        private ClientDiagnostics LocationBasedCapabilitiesClientDiagnostics => _locationBasedCapabilitiesClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.MySql.FlexibleServers", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private LocationBasedCapabilitiesRestOperations LocationBasedCapabilitiesRestClient => _locationBasedCapabilitiesRestClient ??= new LocationBasedCapabilitiesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics CheckVirtualNetworkSubnetUsageClientDiagnostics => _checkVirtualNetworkSubnetUsageClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.MySql.FlexibleServers", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private CheckVirtualNetworkSubnetUsageRestOperations CheckVirtualNetworkSubnetUsageRestClient => _checkVirtualNetworkSubnetUsageRestClient ??= new CheckVirtualNetworkSubnetUsageRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics CheckNameAvailabilityClientDiagnostics => _checkNameAvailabilityClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.MySql.FlexibleServers", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private CheckNameAvailabilityRestOperations CheckNameAvailabilityRestClient => _checkNameAvailabilityRestClient ??= new CheckNameAvailabilityRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics CheckNameAvailabilityWithoutLocationClientDiagnostics => _checkNameAvailabilityWithoutLocationClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.MySql.FlexibleServers", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private CheckNameAvailabilityWithoutLocationRestOperations CheckNameAvailabilityWithoutLocationRestClient => _checkNameAvailabilityWithoutLocationRestClient ??= new CheckNameAvailabilityWithoutLocationRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// List all the servers in a given subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DBforMySQL/flexibleServers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Servers_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MySqlFlexibleServerResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MySqlFlexibleServerResource> GetMySqlFlexibleServersAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => MySqlFlexibleServerServersRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => MySqlFlexibleServerServersRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new MySqlFlexibleServerResource(Client, MySqlFlexibleServerData.DeserializeMySqlFlexibleServerData(e)), MySqlFlexibleServerServersClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetMySqlFlexibleServers", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List all the servers in a given subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DBforMySQL/flexibleServers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Servers_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MySqlFlexibleServerResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MySqlFlexibleServerResource> GetMySqlFlexibleServers(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => MySqlFlexibleServerServersRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => MySqlFlexibleServerServersRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new MySqlFlexibleServerResource(Client, MySqlFlexibleServerData.DeserializeMySqlFlexibleServerData(e)), MySqlFlexibleServerServersClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetMySqlFlexibleServers", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get capabilities at specified location in a given subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DBforMySQL/locations/{locationName}/capabilities</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LocationBasedCapabilities_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="locationName"> The name of the location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MySqlFlexibleServerCapabilityProperties" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MySqlFlexibleServerCapabilityProperties> GetLocationBasedCapabilitiesAsync(AzureLocation locationName, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => LocationBasedCapabilitiesRestClient.CreateListRequest(Id.SubscriptionId, locationName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => LocationBasedCapabilitiesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, locationName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, MySqlFlexibleServerCapabilityProperties.DeserializeMySqlFlexibleServerCapabilityProperties, LocationBasedCapabilitiesClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetLocationBasedCapabilities", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get capabilities at specified location in a given subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DBforMySQL/locations/{locationName}/capabilities</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LocationBasedCapabilities_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="locationName"> The name of the location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MySqlFlexibleServerCapabilityProperties" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MySqlFlexibleServerCapabilityProperties> GetLocationBasedCapabilities(AzureLocation locationName, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => LocationBasedCapabilitiesRestClient.CreateListRequest(Id.SubscriptionId, locationName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => LocationBasedCapabilitiesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, locationName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, MySqlFlexibleServerCapabilityProperties.DeserializeMySqlFlexibleServerCapabilityProperties, LocationBasedCapabilitiesClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetLocationBasedCapabilities", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get virtual network subnet usage for a given vNet resource id.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DBforMySQL/locations/{locationName}/checkVirtualNetworkSubnetUsage</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CheckVirtualNetworkSubnetUsage_Execute</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="locationName"> The name of the location. </param>
        /// <param name="mySqlFlexibleServerVirtualNetworkSubnetUsageParameter"> The required parameters for creating or updating a server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<MySqlFlexibleServerVirtualNetworkSubnetUsageResult>> ExecuteCheckVirtualNetworkSubnetUsageAsync(AzureLocation locationName, MySqlFlexibleServerVirtualNetworkSubnetUsageParameter mySqlFlexibleServerVirtualNetworkSubnetUsageParameter, CancellationToken cancellationToken = default)
        {
            using var scope = CheckVirtualNetworkSubnetUsageClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.ExecuteCheckVirtualNetworkSubnetUsage");
            scope.Start();
            try
            {
                var response = await CheckVirtualNetworkSubnetUsageRestClient.ExecuteAsync(Id.SubscriptionId, locationName, mySqlFlexibleServerVirtualNetworkSubnetUsageParameter, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get virtual network subnet usage for a given vNet resource id.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DBforMySQL/locations/{locationName}/checkVirtualNetworkSubnetUsage</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CheckVirtualNetworkSubnetUsage_Execute</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="locationName"> The name of the location. </param>
        /// <param name="mySqlFlexibleServerVirtualNetworkSubnetUsageParameter"> The required parameters for creating or updating a server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<MySqlFlexibleServerVirtualNetworkSubnetUsageResult> ExecuteCheckVirtualNetworkSubnetUsage(AzureLocation locationName, MySqlFlexibleServerVirtualNetworkSubnetUsageParameter mySqlFlexibleServerVirtualNetworkSubnetUsageParameter, CancellationToken cancellationToken = default)
        {
            using var scope = CheckVirtualNetworkSubnetUsageClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.ExecuteCheckVirtualNetworkSubnetUsage");
            scope.Start();
            try
            {
                var response = CheckVirtualNetworkSubnetUsageRestClient.Execute(Id.SubscriptionId, locationName, mySqlFlexibleServerVirtualNetworkSubnetUsageParameter, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Check the availability of name for server
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DBforMySQL/locations/{locationName}/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CheckNameAvailability_Execute</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="locationName"> The name of the location. </param>
        /// <param name="content"> The required parameters for checking if server name is available. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<MySqlFlexibleServerNameAvailabilityResult>> CheckMySqlFlexibleServerNameAvailabilityAsync(AzureLocation locationName, MySqlFlexibleServerNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            using var scope = CheckNameAvailabilityClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.CheckMySqlFlexibleServerNameAvailability");
            scope.Start();
            try
            {
                var response = await CheckNameAvailabilityRestClient.ExecuteAsync(Id.SubscriptionId, locationName, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Check the availability of name for server
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DBforMySQL/locations/{locationName}/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CheckNameAvailability_Execute</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="locationName"> The name of the location. </param>
        /// <param name="content"> The required parameters for checking if server name is available. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<MySqlFlexibleServerNameAvailabilityResult> CheckMySqlFlexibleServerNameAvailability(AzureLocation locationName, MySqlFlexibleServerNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            using var scope = CheckNameAvailabilityClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.CheckMySqlFlexibleServerNameAvailability");
            scope.Start();
            try
            {
                var response = CheckNameAvailabilityRestClient.Execute(Id.SubscriptionId, locationName, content, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Check the availability of name for server
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DBforMySQL/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CheckNameAvailabilityWithoutLocation_Execute</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The required parameters for checking if server name is available. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<MySqlFlexibleServerNameAvailabilityResult>> CheckMySqlFlexibleServerNameAvailabilityWithoutLocationAsync(MySqlFlexibleServerNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            using var scope = CheckNameAvailabilityWithoutLocationClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.CheckMySqlFlexibleServerNameAvailabilityWithoutLocation");
            scope.Start();
            try
            {
                var response = await CheckNameAvailabilityWithoutLocationRestClient.ExecuteAsync(Id.SubscriptionId, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Check the availability of name for server
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DBforMySQL/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CheckNameAvailabilityWithoutLocation_Execute</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The required parameters for checking if server name is available. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<MySqlFlexibleServerNameAvailabilityResult> CheckMySqlFlexibleServerNameAvailabilityWithoutLocation(MySqlFlexibleServerNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            using var scope = CheckNameAvailabilityWithoutLocationClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.CheckMySqlFlexibleServerNameAvailabilityWithoutLocation");
            scope.Start();
            try
            {
                var response = CheckNameAvailabilityWithoutLocationRestClient.Execute(Id.SubscriptionId, content, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
