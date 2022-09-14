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

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A Class representing a SiteSlotProcessModule along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="SiteSlotProcessModuleResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetSiteSlotProcessModuleResource method.
    /// Otherwise you can get one from its parent resource <see cref="SiteSlotProcessResource" /> using the GetSiteSlotProcessModule method.
    /// </summary>
    public partial class SiteSlotProcessModuleResource : ProcessModuleInfoResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SiteSlotProcessModuleResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string slot, string processId, string baseAddress)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/processes/{processId}/modules/{baseAddress}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _siteSlotProcessModuleWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _siteSlotProcessModuleWebAppsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SiteSlotProcessModuleResource"/> class for mocking. </summary>
        protected SiteSlotProcessModuleResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SiteSlotProcessModuleResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SiteSlotProcessModuleResource(ArmClient client, ProcessModuleInfoData data) : base(client, data)
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SiteSlotProcessModuleResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SiteSlotProcessModuleResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _siteSlotProcessModuleWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string siteSlotProcessModuleWebAppsApiVersion);
            _siteSlotProcessModuleWebAppsRestClient = new WebAppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, siteSlotProcessModuleWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Web/sites/slots/processes/modules";

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary> placeholder. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override async Task<Response<ProcessModuleInfoResource>> GetCoreAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _siteSlotProcessModuleWebAppsClientDiagnostics.CreateScope("SiteSlotProcessModuleResource.Get");
            scope.Start();
            try
            {
                var response = await _siteSlotProcessModuleWebAppsRestClient.GetProcessModuleSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
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
        /// Description for Get process information by its ID for a specific scaled-out instance in a web site.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/processes/{processId}/modules/{baseAddress}
        /// Operation Id: WebApps_GetProcessModuleSlot
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new virtual async Task<Response<SiteSlotProcessModuleResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            var value = await GetCoreAsync(cancellationToken);
            return Response.FromValue((SiteSlotProcessModuleResource)value.Value, value.GetRawResponse());
        }

        /// <summary> placeholder. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override Response<ProcessModuleInfoResource> GetCore(CancellationToken cancellationToken = default)
        {
            using var scope = _siteSlotProcessModuleWebAppsClientDiagnostics.CreateScope("SiteSlotProcessModuleResource.Get");
            scope.Start();
            try
            {
                var response = _siteSlotProcessModuleWebAppsRestClient.GetProcessModuleSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
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
        /// Description for Get process information by its ID for a specific scaled-out instance in a web site.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/processes/{processId}/modules/{baseAddress}
        /// Operation Id: WebApps_GetProcessModuleSlot
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new virtual Response<SiteSlotProcessModuleResource> Get(CancellationToken cancellationToken = default)
        {
            var value = GetCore(cancellationToken);
            return Response.FromValue((SiteSlotProcessModuleResource)value.Value, value.GetRawResponse());
        }
    }
}
