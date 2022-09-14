// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.AppService.Models;

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A Class representing an AppServicePlanVirtualNetworkConnection along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct an <see cref="AppServicePlanVirtualNetworkConnectionResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetAppServicePlanVirtualNetworkConnectionResource method.
    /// Otherwise you can get one from its parent resource <see cref="AppServicePlanResource" /> using the GetAppServicePlanVirtualNetworkConnection method.
    /// </summary>
    public partial class AppServicePlanVirtualNetworkConnectionResource : VnetInfoResource
    {
        /// <summary> Generate the resource identifier of a <see cref="AppServicePlanVirtualNetworkConnectionResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string vnetName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/virtualNetworkConnections/{vnetName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _appServicePlanVirtualNetworkConnectionAppServicePlansClientDiagnostics;
        private readonly AppServicePlansRestOperations _appServicePlanVirtualNetworkConnectionAppServicePlansRestClient;

        /// <summary> Initializes a new instance of the <see cref="AppServicePlanVirtualNetworkConnectionResource"/> class for mocking. </summary>
        protected AppServicePlanVirtualNetworkConnectionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "AppServicePlanVirtualNetworkConnectionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal AppServicePlanVirtualNetworkConnectionResource(ArmClient client, VnetInfoResourceData data) : base(client, data)
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AppServicePlanVirtualNetworkConnectionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal AppServicePlanVirtualNetworkConnectionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _appServicePlanVirtualNetworkConnectionAppServicePlansClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string appServicePlanVirtualNetworkConnectionAppServicePlansApiVersion);
            _appServicePlanVirtualNetworkConnectionAppServicePlansRestClient = new AppServicePlansRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, appServicePlanVirtualNetworkConnectionAppServicePlansApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Web/serverfarms/virtualNetworkConnections";

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary> Gets a collection of AppServicePlanVirtualNetworkConnectionGatewayResources in the AppServicePlanVirtualNetworkConnection. </summary>
        /// <returns> An object representing collection of AppServicePlanVirtualNetworkConnectionGatewayResources and their operations over a AppServicePlanVirtualNetworkConnectionGatewayResource. </returns>
        public virtual AppServicePlanVirtualNetworkConnectionGatewayCollection GetAppServicePlanVirtualNetworkConnectionGateways()
        {
            return GetCachedClient(Client => new AppServicePlanVirtualNetworkConnectionGatewayCollection(Client, Id));
        }

        /// <summary>
        /// Description for Get a Virtual Network gateway.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/virtualNetworkConnections/{vnetName}/gateways/{gatewayName}
        /// Operation Id: AppServicePlans_GetVnetGateway
        /// </summary>
        /// <param name="gatewayName"> Name of the gateway. Only the &apos;primary&apos; gateway is supported. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="gatewayName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="gatewayName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<AppServicePlanVirtualNetworkConnectionGatewayResource>> GetAppServicePlanVirtualNetworkConnectionGatewayAsync(string gatewayName, CancellationToken cancellationToken = default)
        {
            return await GetAppServicePlanVirtualNetworkConnectionGateways().GetAsync(gatewayName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Description for Get a Virtual Network gateway.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/virtualNetworkConnections/{vnetName}/gateways/{gatewayName}
        /// Operation Id: AppServicePlans_GetVnetGateway
        /// </summary>
        /// <param name="gatewayName"> Name of the gateway. Only the &apos;primary&apos; gateway is supported. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="gatewayName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="gatewayName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual Response<AppServicePlanVirtualNetworkConnectionGatewayResource> GetAppServicePlanVirtualNetworkConnectionGateway(string gatewayName, CancellationToken cancellationToken = default)
        {
            return GetAppServicePlanVirtualNetworkConnectionGateways().Get(gatewayName, cancellationToken);
        }

        /// <summary> placeholder. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override async Task<Response<VnetInfoResource>> GetCoreAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _appServicePlanVirtualNetworkConnectionAppServicePlansClientDiagnostics.CreateScope("AppServicePlanVirtualNetworkConnectionResource.Get");
            scope.Start();
            try
            {
                var response = await _appServicePlanVirtualNetworkConnectionAppServicePlansRestClient.GetVnetFromServerFarmAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(GetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get a Virtual Network associated with an App Service plan.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/virtualNetworkConnections/{vnetName}
        /// Operation Id: AppServicePlans_GetVnetFromServerFarm
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new virtual async Task<Response<AppServicePlanVirtualNetworkConnectionResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            var value = await GetCoreAsync(cancellationToken);
            return Response.FromValue((AppServicePlanVirtualNetworkConnectionResource)value.Value, value.GetRawResponse());
        }

        /// <summary> placeholder. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override Response<VnetInfoResource> GetCore(CancellationToken cancellationToken = default)
        {
            using var scope = _appServicePlanVirtualNetworkConnectionAppServicePlansClientDiagnostics.CreateScope("AppServicePlanVirtualNetworkConnectionResource.Get");
            scope.Start();
            try
            {
                var response = _appServicePlanVirtualNetworkConnectionAppServicePlansRestClient.GetVnetFromServerFarm(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(GetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get a Virtual Network associated with an App Service plan.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/virtualNetworkConnections/{vnetName}
        /// Operation Id: AppServicePlans_GetVnetFromServerFarm
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new virtual Response<AppServicePlanVirtualNetworkConnectionResource> Get(CancellationToken cancellationToken = default)
        {
            var value = GetCore(cancellationToken);
            return Response.FromValue((AppServicePlanVirtualNetworkConnectionResource)value.Value, value.GetRawResponse());
        }

        /// <summary>
        /// Description for Get all routes that are associated with a Virtual Network in an App Service plan.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/virtualNetworkConnections/{vnetName}/routes
        /// Operation Id: AppServicePlans_ListRoutesForVnet
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VnetRoute" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VnetRoute> GetRoutesForVnetAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<VnetRoute>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _appServicePlanVirtualNetworkConnectionAppServicePlansClientDiagnostics.CreateScope("AppServicePlanVirtualNetworkConnectionResource.GetRoutesForVnet");
                scope.Start();
                try
                {
                    var response = await _appServicePlanVirtualNetworkConnectionAppServicePlansRestClient.ListRoutesForVnetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Description for Get all routes that are associated with a Virtual Network in an App Service plan.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/virtualNetworkConnections/{vnetName}/routes
        /// Operation Id: AppServicePlans_ListRoutesForVnet
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VnetRoute" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VnetRoute> GetRoutesForVnet(CancellationToken cancellationToken = default)
        {
            Page<VnetRoute> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _appServicePlanVirtualNetworkConnectionAppServicePlansClientDiagnostics.CreateScope("AppServicePlanVirtualNetworkConnectionResource.GetRoutesForVnet");
                scope.Start();
                try
                {
                    var response = _appServicePlanVirtualNetworkConnectionAppServicePlansRestClient.ListRoutesForVnet(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Description for Create or update a Virtual Network route in an App Service plan.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/virtualNetworkConnections/{vnetName}/routes/{routeName}
        /// Operation Id: AppServicePlans_CreateOrUpdateVnetRoute
        /// </summary>
        /// <param name="routeName"> Name of the Virtual Network route. </param>
        /// <param name="route"> Definition of the Virtual Network route. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="routeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="routeName"/> or <paramref name="route"/> is null. </exception>
        public virtual async Task<Response<VnetRoute>> CreateOrUpdateVnetRouteAsync(string routeName, VnetRoute route, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(routeName, nameof(routeName));
            Argument.AssertNotNull(route, nameof(route));

            using var scope = _appServicePlanVirtualNetworkConnectionAppServicePlansClientDiagnostics.CreateScope("AppServicePlanVirtualNetworkConnectionResource.CreateOrUpdateVnetRoute");
            scope.Start();
            try
            {
                var response = await _appServicePlanVirtualNetworkConnectionAppServicePlansRestClient.CreateOrUpdateVnetRouteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, routeName, route, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Create or update a Virtual Network route in an App Service plan.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/virtualNetworkConnections/{vnetName}/routes/{routeName}
        /// Operation Id: AppServicePlans_CreateOrUpdateVnetRoute
        /// </summary>
        /// <param name="routeName"> Name of the Virtual Network route. </param>
        /// <param name="route"> Definition of the Virtual Network route. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="routeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="routeName"/> or <paramref name="route"/> is null. </exception>
        public virtual Response<VnetRoute> CreateOrUpdateVnetRoute(string routeName, VnetRoute route, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(routeName, nameof(routeName));
            Argument.AssertNotNull(route, nameof(route));

            using var scope = _appServicePlanVirtualNetworkConnectionAppServicePlansClientDiagnostics.CreateScope("AppServicePlanVirtualNetworkConnectionResource.CreateOrUpdateVnetRoute");
            scope.Start();
            try
            {
                var response = _appServicePlanVirtualNetworkConnectionAppServicePlansRestClient.CreateOrUpdateVnetRoute(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, routeName, route, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Delete a Virtual Network route in an App Service plan.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/virtualNetworkConnections/{vnetName}/routes/{routeName}
        /// Operation Id: AppServicePlans_DeleteVnetRoute
        /// </summary>
        /// <param name="routeName"> Name of the Virtual Network route. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="routeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="routeName"/> is null. </exception>
        public virtual async Task<Response> DeleteVnetRouteAsync(string routeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(routeName, nameof(routeName));

            using var scope = _appServicePlanVirtualNetworkConnectionAppServicePlansClientDiagnostics.CreateScope("AppServicePlanVirtualNetworkConnectionResource.DeleteVnetRoute");
            scope.Start();
            try
            {
                var response = await _appServicePlanVirtualNetworkConnectionAppServicePlansRestClient.DeleteVnetRouteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, routeName, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Delete a Virtual Network route in an App Service plan.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/virtualNetworkConnections/{vnetName}/routes/{routeName}
        /// Operation Id: AppServicePlans_DeleteVnetRoute
        /// </summary>
        /// <param name="routeName"> Name of the Virtual Network route. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="routeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="routeName"/> is null. </exception>
        public virtual Response DeleteVnetRoute(string routeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(routeName, nameof(routeName));

            using var scope = _appServicePlanVirtualNetworkConnectionAppServicePlansClientDiagnostics.CreateScope("AppServicePlanVirtualNetworkConnectionResource.DeleteVnetRoute");
            scope.Start();
            try
            {
                var response = _appServicePlanVirtualNetworkConnectionAppServicePlansRestClient.DeleteVnetRoute(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, routeName, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Create or update a Virtual Network route in an App Service plan.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/virtualNetworkConnections/{vnetName}/routes/{routeName}
        /// Operation Id: AppServicePlans_UpdateVnetRoute
        /// </summary>
        /// <param name="routeName"> Name of the Virtual Network route. </param>
        /// <param name="route"> Definition of the Virtual Network route. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="routeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="routeName"/> or <paramref name="route"/> is null. </exception>
        public virtual async Task<Response<VnetRoute>> UpdateVnetRouteAsync(string routeName, VnetRoute route, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(routeName, nameof(routeName));
            Argument.AssertNotNull(route, nameof(route));

            using var scope = _appServicePlanVirtualNetworkConnectionAppServicePlansClientDiagnostics.CreateScope("AppServicePlanVirtualNetworkConnectionResource.UpdateVnetRoute");
            scope.Start();
            try
            {
                var response = await _appServicePlanVirtualNetworkConnectionAppServicePlansRestClient.UpdateVnetRouteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, routeName, route, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Create or update a Virtual Network route in an App Service plan.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/virtualNetworkConnections/{vnetName}/routes/{routeName}
        /// Operation Id: AppServicePlans_UpdateVnetRoute
        /// </summary>
        /// <param name="routeName"> Name of the Virtual Network route. </param>
        /// <param name="route"> Definition of the Virtual Network route. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="routeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="routeName"/> or <paramref name="route"/> is null. </exception>
        public virtual Response<VnetRoute> UpdateVnetRoute(string routeName, VnetRoute route, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(routeName, nameof(routeName));
            Argument.AssertNotNull(route, nameof(route));

            using var scope = _appServicePlanVirtualNetworkConnectionAppServicePlansClientDiagnostics.CreateScope("AppServicePlanVirtualNetworkConnectionResource.UpdateVnetRoute");
            scope.Start();
            try
            {
                var response = _appServicePlanVirtualNetworkConnectionAppServicePlansRestClient.UpdateVnetRoute(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, routeName, route, cancellationToken);
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
