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
    /// A Class representing a WebSiteSlotPremierAddOn along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="WebSiteSlotPremierAddOnResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetWebSiteSlotPremierAddOnResource method.
    /// Otherwise you can get one from its parent resource <see cref="WebSiteSlotResource" /> using the GetWebSiteSlotPremierAddOn method.
    /// </summary>
    public partial class WebSiteSlotPremierAddOnResource : PremierAddOnResource
    {
        /// <summary> Generate the resource identifier of a <see cref="WebSiteSlotPremierAddOnResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string slot, string premierAddOnName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/premieraddons/{premierAddOnName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _webSiteSlotPremierAddOnWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _webSiteSlotPremierAddOnWebAppsRestClient;

        /// <summary> Initializes a new instance of the <see cref="WebSiteSlotPremierAddOnResource"/> class for mocking. </summary>
        protected WebSiteSlotPremierAddOnResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "WebSiteSlotPremierAddOnResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal WebSiteSlotPremierAddOnResource(ArmClient client, PremierAddOnData data) : base(client, data)
        {
        }

        /// <summary> Initializes a new instance of the <see cref="WebSiteSlotPremierAddOnResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal WebSiteSlotPremierAddOnResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _webSiteSlotPremierAddOnWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string webSiteSlotPremierAddOnWebAppsApiVersion);
            _webSiteSlotPremierAddOnWebAppsRestClient = new WebAppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, webSiteSlotPremierAddOnWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Web/sites/slots/premieraddons";

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary> placeholder. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override async Task<Response<PremierAddOnResource>> GetCoreAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _webSiteSlotPremierAddOnWebAppsClientDiagnostics.CreateScope("WebSiteSlotPremierAddOnResource.Get");
            scope.Start();
            try
            {
                var response = await _webSiteSlotPremierAddOnWebAppsRestClient.GetPremierAddOnSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
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
        /// Description for Gets a named add-on of an app.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/premieraddons/{premierAddOnName}
        /// Operation Id: WebApps_GetPremierAddOnSlot
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new virtual async Task<Response<WebSiteSlotPremierAddOnResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            var value = await GetCoreAsync(cancellationToken);
            return Response.FromValue((WebSiteSlotPremierAddOnResource)value.Value, value.GetRawResponse());
        }

        /// <summary> placeholder. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override Response<PremierAddOnResource> GetCore(CancellationToken cancellationToken = default)
        {
            using var scope = _webSiteSlotPremierAddOnWebAppsClientDiagnostics.CreateScope("WebSiteSlotPremierAddOnResource.Get");
            scope.Start();
            try
            {
                var response = _webSiteSlotPremierAddOnWebAppsRestClient.GetPremierAddOnSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
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
        /// Description for Gets a named add-on of an app.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/premieraddons/{premierAddOnName}
        /// Operation Id: WebApps_GetPremierAddOnSlot
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new virtual Response<WebSiteSlotPremierAddOnResource> Get(CancellationToken cancellationToken = default)
        {
            var value = GetCore(cancellationToken);
            return Response.FromValue((WebSiteSlotPremierAddOnResource)value.Value, value.GetRawResponse());
        }

        /// <summary> placeholder. </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override async Task<ArmOperation> DeleteCoreAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _webSiteSlotPremierAddOnWebAppsClientDiagnostics.CreateScope("WebSiteSlotPremierAddOnResource.Delete");
            scope.Start();
            try
            {
                var response = await _webSiteSlotPremierAddOnWebAppsRestClient.DeletePremierAddOnSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> placeholder. </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override ArmOperation DeleteCore(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _webSiteSlotPremierAddOnWebAppsClientDiagnostics.CreateScope("WebSiteSlotPremierAddOnResource.Delete");
            scope.Start();
            try
            {
                var response = _webSiteSlotPremierAddOnWebAppsRestClient.DeletePremierAddOnSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new AppServiceArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> placeholder. </summary>
        /// <param name="premierAddOn"> A JSON representation of the edited premier add-on. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="premierAddOn"/> is null. </exception>
        protected override async Task<Response<PremierAddOnResource>> UpdateCoreAsync(PremierAddOnPatchResource premierAddOn, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(premierAddOn, nameof(premierAddOn));

            using var scope = _webSiteSlotPremierAddOnWebAppsClientDiagnostics.CreateScope("WebSiteSlotPremierAddOnResource.Update");
            scope.Start();
            try
            {
                var response = await _webSiteSlotPremierAddOnWebAppsRestClient.UpdatePremierAddOnSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, premierAddOn, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(GetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Updates a named add-on of an app.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/premieraddons/{premierAddOnName}
        /// Operation Id: WebApps_UpdatePremierAddOnSlot
        /// </summary>
        /// <param name="premierAddOn"> A JSON representation of the edited premier add-on. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="premierAddOn"/> is null. </exception>
        [ForwardsClientCalls]
        public new virtual async Task<Response<WebSiteSlotPremierAddOnResource>> UpdateAsync(PremierAddOnPatchResource premierAddOn, CancellationToken cancellationToken = default)
        {
            var value = await UpdateCoreAsync(premierAddOn, cancellationToken);
            return Response.FromValue((WebSiteSlotPremierAddOnResource)value.Value, value.GetRawResponse());
        }

        /// <summary> placeholder. </summary>
        /// <param name="premierAddOn"> A JSON representation of the edited premier add-on. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="premierAddOn"/> is null. </exception>
        protected override Response<PremierAddOnResource> UpdateCore(PremierAddOnPatchResource premierAddOn, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(premierAddOn, nameof(premierAddOn));

            using var scope = _webSiteSlotPremierAddOnWebAppsClientDiagnostics.CreateScope("WebSiteSlotPremierAddOnResource.Update");
            scope.Start();
            try
            {
                var response = _webSiteSlotPremierAddOnWebAppsRestClient.UpdatePremierAddOnSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, premierAddOn, cancellationToken);
                return Response.FromValue(GetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Updates a named add-on of an app.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/premieraddons/{premierAddOnName}
        /// Operation Id: WebApps_UpdatePremierAddOnSlot
        /// </summary>
        /// <param name="premierAddOn"> A JSON representation of the edited premier add-on. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="premierAddOn"/> is null. </exception>
        [ForwardsClientCalls]
        public new virtual Response<WebSiteSlotPremierAddOnResource> Update(PremierAddOnPatchResource premierAddOn, CancellationToken cancellationToken = default)
        {
            var value = UpdateCore(premierAddOn, cancellationToken);
            return Response.FromValue((WebSiteSlotPremierAddOnResource)value.Value, value.GetRawResponse());
        }
    }
}
