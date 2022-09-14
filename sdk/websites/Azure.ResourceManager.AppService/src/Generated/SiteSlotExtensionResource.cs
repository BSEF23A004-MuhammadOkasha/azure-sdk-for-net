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
    /// A Class representing a SiteSlotExtension along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="SiteSlotExtensionResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetSiteSlotExtensionResource method.
    /// Otherwise you can get one from its parent resource <see cref="WebSiteSlotResource" /> using the GetSiteSlotExtension method.
    /// </summary>
    public partial class SiteSlotExtensionResource : MSDeployStatusResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SiteSlotExtensionResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string slot)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/extensions/MSDeploy";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _siteSlotExtensionWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _siteSlotExtensionWebAppsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SiteSlotExtensionResource"/> class for mocking. </summary>
        protected SiteSlotExtensionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SiteSlotExtensionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SiteSlotExtensionResource(ArmClient client, MSDeployStatusData data) : base(client, data)
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SiteSlotExtensionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SiteSlotExtensionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _siteSlotExtensionWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string siteSlotExtensionWebAppsApiVersion);
            _siteSlotExtensionWebAppsRestClient = new WebAppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, siteSlotExtensionWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Web/sites/slots/extensions";

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary> placeholder. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override async Task<Response<MSDeployStatusResource>> GetCoreAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _siteSlotExtensionWebAppsClientDiagnostics.CreateScope("SiteSlotExtensionResource.Get");
            scope.Start();
            try
            {
                var response = await _siteSlotExtensionWebAppsRestClient.GetMSDeployStatusSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
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
        /// Description for Get the status of the last MSDeploy operation.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/extensions/MSDeploy
        /// Operation Id: WebApps_GetMSDeployStatusSlot
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new virtual async Task<Response<SiteSlotExtensionResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            var value = await GetCoreAsync(cancellationToken);
            return Response.FromValue((SiteSlotExtensionResource)value.Value, value.GetRawResponse());
        }

        /// <summary> placeholder. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override Response<MSDeployStatusResource> GetCore(CancellationToken cancellationToken = default)
        {
            using var scope = _siteSlotExtensionWebAppsClientDiagnostics.CreateScope("SiteSlotExtensionResource.Get");
            scope.Start();
            try
            {
                var response = _siteSlotExtensionWebAppsRestClient.GetMSDeployStatusSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken);
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
        /// Description for Get the status of the last MSDeploy operation.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/extensions/MSDeploy
        /// Operation Id: WebApps_GetMSDeployStatusSlot
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new virtual Response<SiteSlotExtensionResource> Get(CancellationToken cancellationToken = default)
        {
            var value = GetCore(cancellationToken);
            return Response.FromValue((SiteSlotExtensionResource)value.Value, value.GetRawResponse());
        }

        /// <summary> placeholder. </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="msDeploy"> Details of MSDeploy operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="msDeploy"/> is null. </exception>
        protected override async Task<ArmOperation<MSDeployStatusResource>> CreateOrUpdateCoreAsync(WaitUntil waitUntil, MSDeploy msDeploy, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(msDeploy, nameof(msDeploy));

            using var scope = _siteSlotExtensionWebAppsClientDiagnostics.CreateScope("SiteSlotExtensionResource.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _siteSlotExtensionWebAppsRestClient.CreateMSDeployOperationSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, msDeploy, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceArmOperation<MSDeployStatusResource>(new MSDeployStatusOperationSource(Client), _siteSlotExtensionWebAppsClientDiagnostics, Pipeline, _siteSlotExtensionWebAppsRestClient.CreateCreateMSDeployOperationSlotRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, msDeploy).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Invoke the MSDeploy web app extension.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/extensions/MSDeploy
        /// Operation Id: WebApps_CreateMSDeployOperationSlot
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="msDeploy"> Details of MSDeploy operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="msDeploy"/> is null. </exception>
        [ForwardsClientCalls]
        public new virtual async Task<ArmOperation<SiteSlotExtensionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, MSDeploy msDeploy, CancellationToken cancellationToken = default)
        {
            var value = await CreateOrUpdateCoreAsync(waitUntil, msDeploy, cancellationToken);
            throw new InvalidOperationException();
        }

        /// <summary> placeholder. </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="msDeploy"> Details of MSDeploy operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="msDeploy"/> is null. </exception>
        protected override ArmOperation<MSDeployStatusResource> CreateOrUpdateCore(WaitUntil waitUntil, MSDeploy msDeploy, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(msDeploy, nameof(msDeploy));

            using var scope = _siteSlotExtensionWebAppsClientDiagnostics.CreateScope("SiteSlotExtensionResource.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _siteSlotExtensionWebAppsRestClient.CreateMSDeployOperationSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, msDeploy, cancellationToken);
                var operation = new AppServiceArmOperation<MSDeployStatusResource>(new MSDeployStatusOperationSource(Client), _siteSlotExtensionWebAppsClientDiagnostics, Pipeline, _siteSlotExtensionWebAppsRestClient.CreateCreateMSDeployOperationSlotRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, msDeploy).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Invoke the MSDeploy web app extension.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/extensions/MSDeploy
        /// Operation Id: WebApps_CreateMSDeployOperationSlot
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="msDeploy"> Details of MSDeploy operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="msDeploy"/> is null. </exception>
        [ForwardsClientCalls]
        public new virtual ArmOperation<SiteSlotExtensionResource> CreateOrUpdate(WaitUntil waitUntil, MSDeploy msDeploy, CancellationToken cancellationToken = default)
        {
            var value = CreateOrUpdateCore(waitUntil, msDeploy, cancellationToken);
            throw new InvalidOperationException();
        }

        /// <summary>
        /// Description for Get the MSDeploy Log for the last MSDeploy operation.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/extensions/MSDeploy/log
        /// Operation Id: WebApps_GetMSDeployLogSlot
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<MSDeployLog>> GetMSDeployLogSlotAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _siteSlotExtensionWebAppsClientDiagnostics.CreateScope("SiteSlotExtensionResource.GetMSDeployLogSlot");
            scope.Start();
            try
            {
                var response = await _siteSlotExtensionWebAppsRestClient.GetMSDeployLogSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get the MSDeploy Log for the last MSDeploy operation.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/extensions/MSDeploy/log
        /// Operation Id: WebApps_GetMSDeployLogSlot
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<MSDeployLog> GetMSDeployLogSlot(CancellationToken cancellationToken = default)
        {
            using var scope = _siteSlotExtensionWebAppsClientDiagnostics.CreateScope("SiteSlotExtensionResource.GetMSDeployLogSlot");
            scope.Start();
            try
            {
                var response = _siteSlotExtensionWebAppsRestClient.GetMSDeployLogSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken);
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
