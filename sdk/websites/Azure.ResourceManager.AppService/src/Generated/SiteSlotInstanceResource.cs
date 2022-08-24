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
    /// A Class representing a SiteSlotInstance along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="SiteSlotInstanceResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetSiteSlotInstanceResource method.
    /// Otherwise you can get one from its parent resource <see cref="AppServiceSlotResource" /> using the GetSiteSlotInstance method.
    /// </summary>
    public partial class SiteSlotInstanceResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SiteSlotInstanceResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string slot, string instanceId)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/instances/{instanceId}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _siteSlotInstanceWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _siteSlotInstanceWebAppsRestClient;
        private readonly WebSiteInstanceStatusData _data;

        /// <summary> Initializes a new instance of the <see cref="SiteSlotInstanceResource"/> class for mocking. </summary>
        protected SiteSlotInstanceResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SiteSlotInstanceResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SiteSlotInstanceResource(ArmClient client, WebSiteInstanceStatusData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SiteSlotInstanceResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SiteSlotInstanceResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _siteSlotInstanceWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string siteSlotInstanceWebAppsApiVersion);
            _siteSlotInstanceWebAppsRestClient = new WebAppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, siteSlotInstanceWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Web/sites/slots/instances";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual WebSiteInstanceStatusData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary> Gets a collection of SiteSlotInstanceProcessResources in the SiteSlotInstance. </summary>
        /// <returns> An object representing collection of SiteSlotInstanceProcessResources and their operations over a SiteSlotInstanceProcessResource. </returns>
        public virtual SiteSlotInstanceProcessCollection GetSiteSlotInstanceProcesses()
        {
            return GetCachedClient(Client => new SiteSlotInstanceProcessCollection(Client, Id));
        }

        /// <summary>
        /// Description for Get process information by its ID for a specific scaled-out instance in a web site.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/instances/{instanceId}/processes/{processId}
        /// Operation Id: WebApps_GetInstanceProcessSlot
        /// </summary>
        /// <param name="processId"> PID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="processId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="processId"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<SiteSlotInstanceProcessResource>> GetSiteSlotInstanceProcessAsync(string processId, CancellationToken cancellationToken = default)
        {
            return await GetSiteSlotInstanceProcesses().GetAsync(processId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Description for Get process information by its ID for a specific scaled-out instance in a web site.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/instances/{instanceId}/processes/{processId}
        /// Operation Id: WebApps_GetInstanceProcessSlot
        /// </summary>
        /// <param name="processId"> PID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="processId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="processId"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual Response<SiteSlotInstanceProcessResource> GetSiteSlotInstanceProcess(string processId, CancellationToken cancellationToken = default)
        {
            return GetSiteSlotInstanceProcesses().Get(processId, cancellationToken);
        }

        /// <summary>
        /// Description for Gets all scale-out instances of an app.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/instances/{instanceId}
        /// Operation Id: WebApps_GetInstanceInfoSlot
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SiteSlotInstanceResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _siteSlotInstanceWebAppsClientDiagnostics.CreateScope("SiteSlotInstanceResource.Get");
            scope.Start();
            try
            {
                var response = await _siteSlotInstanceWebAppsRestClient.GetInstanceInfoSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteSlotInstanceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Gets all scale-out instances of an app.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/instances/{instanceId}
        /// Operation Id: WebApps_GetInstanceInfoSlot
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SiteSlotInstanceResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _siteSlotInstanceWebAppsClientDiagnostics.CreateScope("SiteSlotInstanceResource.Get");
            scope.Start();
            try
            {
                var response = _siteSlotInstanceWebAppsRestClient.GetInstanceInfoSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteSlotInstanceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get the status of the last MSDeploy operation.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/instances/{instanceId}/extensions/MSDeploy
        /// Operation Id: WebApps_GetInstanceMsDeployStatusSlot
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<MSDeployStatus>> GetMSDeployStatusAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _siteSlotInstanceWebAppsClientDiagnostics.CreateScope("SiteSlotInstanceResource.GetMSDeployStatus");
            scope.Start();
            try
            {
                var response = await _siteSlotInstanceWebAppsRestClient.GetInstanceMSDeployStatusSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get the status of the last MSDeploy operation.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/instances/{instanceId}/extensions/MSDeploy
        /// Operation Id: WebApps_GetInstanceMsDeployStatusSlot
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<MSDeployStatus> GetMSDeployStatus(CancellationToken cancellationToken = default)
        {
            using var scope = _siteSlotInstanceWebAppsClientDiagnostics.CreateScope("SiteSlotInstanceResource.GetMSDeployStatus");
            scope.Start();
            try
            {
                var response = _siteSlotInstanceWebAppsRestClient.GetInstanceMSDeployStatusSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Invoke the MSDeploy web app extension.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/instances/{instanceId}/extensions/MSDeploy
        /// Operation Id: WebApps_CreateInstanceMSDeployOperationSlot
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="msDeploy"> Details of MSDeploy operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="msDeploy"/> is null. </exception>
        public virtual async Task<ArmOperation<MSDeployStatus>> ExecuteMSDeployOperationAsync(WaitUntil waitUntil, MSDeploy msDeploy, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(msDeploy, nameof(msDeploy));

            using var scope = _siteSlotInstanceWebAppsClientDiagnostics.CreateScope("SiteSlotInstanceResource.ExecuteMSDeployOperation");
            scope.Start();
            try
            {
                var response = await _siteSlotInstanceWebAppsRestClient.CreateInstanceMSDeployOperationSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, msDeploy, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceArmOperation<MSDeployStatus>(new MSDeployStatusOperationSource(), _siteSlotInstanceWebAppsClientDiagnostics, Pipeline, _siteSlotInstanceWebAppsRestClient.CreateCreateInstanceMSDeployOperationSlotRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, msDeploy).Request, response, OperationFinalStateVia.Location);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/instances/{instanceId}/extensions/MSDeploy
        /// Operation Id: WebApps_CreateInstanceMSDeployOperationSlot
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="msDeploy"> Details of MSDeploy operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="msDeploy"/> is null. </exception>
        public virtual ArmOperation<MSDeployStatus> ExecuteMSDeployOperation(WaitUntil waitUntil, MSDeploy msDeploy, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(msDeploy, nameof(msDeploy));

            using var scope = _siteSlotInstanceWebAppsClientDiagnostics.CreateScope("SiteSlotInstanceResource.ExecuteMSDeployOperation");
            scope.Start();
            try
            {
                var response = _siteSlotInstanceWebAppsRestClient.CreateInstanceMSDeployOperationSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, msDeploy, cancellationToken);
                var operation = new AppServiceArmOperation<MSDeployStatus>(new MSDeployStatusOperationSource(), _siteSlotInstanceWebAppsClientDiagnostics, Pipeline, _siteSlotInstanceWebAppsRestClient.CreateCreateInstanceMSDeployOperationSlotRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, msDeploy).Request, response, OperationFinalStateVia.Location);
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
        /// Description for Get the MSDeploy Log for the last MSDeploy operation.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/instances/{instanceId}/extensions/MSDeploy/log
        /// Operation Id: WebApps_GetInstanceMSDeployLogSlot
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<MSDeployLog>> GetInstanceMSDeployLogSlotAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _siteSlotInstanceWebAppsClientDiagnostics.CreateScope("SiteSlotInstanceResource.GetInstanceMSDeployLogSlot");
            scope.Start();
            try
            {
                var response = await _siteSlotInstanceWebAppsRestClient.GetInstanceMSDeployLogSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/instances/{instanceId}/extensions/MSDeploy/log
        /// Operation Id: WebApps_GetInstanceMSDeployLogSlot
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<MSDeployLog> GetInstanceMSDeployLogSlot(CancellationToken cancellationToken = default)
        {
            using var scope = _siteSlotInstanceWebAppsClientDiagnostics.CreateScope("SiteSlotInstanceResource.GetInstanceMSDeployLogSlot");
            scope.Start();
            try
            {
                var response = _siteSlotInstanceWebAppsRestClient.GetInstanceMSDeployLogSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
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
