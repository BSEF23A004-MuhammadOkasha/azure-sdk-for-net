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
    /// A Class representing a SiteSlotDomainOwnershipIdentifier along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="SiteSlotDomainOwnershipIdentifierResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetSiteSlotDomainOwnershipIdentifierResource method.
    /// Otherwise you can get one from its parent resource <see cref="AppServiceSlotResource" /> using the GetSiteSlotDomainOwnershipIdentifier method.
    /// </summary>
    public partial class SiteSlotDomainOwnershipIdentifierResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SiteSlotDomainOwnershipIdentifierResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string slot, string domainOwnershipIdentifierName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/domainOwnershipIdentifiers/{domainOwnershipIdentifierName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _siteSlotDomainOwnershipIdentifierWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _siteSlotDomainOwnershipIdentifierWebAppsRestClient;
        private readonly IdentifierData _data;

        /// <summary> Initializes a new instance of the <see cref="SiteSlotDomainOwnershipIdentifierResource"/> class for mocking. </summary>
        protected SiteSlotDomainOwnershipIdentifierResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SiteSlotDomainOwnershipIdentifierResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SiteSlotDomainOwnershipIdentifierResource(ArmClient client, IdentifierData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SiteSlotDomainOwnershipIdentifierResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SiteSlotDomainOwnershipIdentifierResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _siteSlotDomainOwnershipIdentifierWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string siteSlotDomainOwnershipIdentifierWebAppsApiVersion);
            _siteSlotDomainOwnershipIdentifierWebAppsRestClient = new WebAppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, siteSlotDomainOwnershipIdentifierWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Web/sites/slots/domainOwnershipIdentifiers";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual IdentifierData Data
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

        /// <summary>
        /// Description for Get domain ownership identifier for web app.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/domainOwnershipIdentifiers/{domainOwnershipIdentifierName}
        /// Operation Id: WebApps_GetDomainOwnershipIdentifierSlot
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SiteSlotDomainOwnershipIdentifierResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _siteSlotDomainOwnershipIdentifierWebAppsClientDiagnostics.CreateScope("SiteSlotDomainOwnershipIdentifierResource.Get");
            scope.Start();
            try
            {
                var response = await _siteSlotDomainOwnershipIdentifierWebAppsRestClient.GetDomainOwnershipIdentifierSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteSlotDomainOwnershipIdentifierResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get domain ownership identifier for web app.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/domainOwnershipIdentifiers/{domainOwnershipIdentifierName}
        /// Operation Id: WebApps_GetDomainOwnershipIdentifierSlot
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SiteSlotDomainOwnershipIdentifierResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _siteSlotDomainOwnershipIdentifierWebAppsClientDiagnostics.CreateScope("SiteSlotDomainOwnershipIdentifierResource.Get");
            scope.Start();
            try
            {
                var response = _siteSlotDomainOwnershipIdentifierWebAppsRestClient.GetDomainOwnershipIdentifierSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteSlotDomainOwnershipIdentifierResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Deletes a domain ownership identifier for a web app.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/domainOwnershipIdentifiers/{domainOwnershipIdentifierName}
        /// Operation Id: WebApps_DeleteDomainOwnershipIdentifierSlot
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _siteSlotDomainOwnershipIdentifierWebAppsClientDiagnostics.CreateScope("SiteSlotDomainOwnershipIdentifierResource.Delete");
            scope.Start();
            try
            {
                var response = await _siteSlotDomainOwnershipIdentifierWebAppsRestClient.DeleteDomainOwnershipIdentifierSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
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

        /// <summary>
        /// Description for Deletes a domain ownership identifier for a web app.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/domainOwnershipIdentifiers/{domainOwnershipIdentifierName}
        /// Operation Id: WebApps_DeleteDomainOwnershipIdentifierSlot
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _siteSlotDomainOwnershipIdentifierWebAppsClientDiagnostics.CreateScope("SiteSlotDomainOwnershipIdentifierResource.Delete");
            scope.Start();
            try
            {
                var response = _siteSlotDomainOwnershipIdentifierWebAppsRestClient.DeleteDomainOwnershipIdentifierSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
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

        /// <summary>
        /// Description for Creates a domain ownership identifier for web app, or updates an existing ownership identifier.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/domainOwnershipIdentifiers/{domainOwnershipIdentifierName}
        /// Operation Id: WebApps_UpdateDomainOwnershipIdentifierSlot
        /// </summary>
        /// <param name="data"> A JSON representation of the domain ownership properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<Response<SiteSlotDomainOwnershipIdentifierResource>> UpdateAsync(IdentifierData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _siteSlotDomainOwnershipIdentifierWebAppsClientDiagnostics.CreateScope("SiteSlotDomainOwnershipIdentifierResource.Update");
            scope.Start();
            try
            {
                var response = await _siteSlotDomainOwnershipIdentifierWebAppsRestClient.UpdateDomainOwnershipIdentifierSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new SiteSlotDomainOwnershipIdentifierResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Creates a domain ownership identifier for web app, or updates an existing ownership identifier.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/domainOwnershipIdentifiers/{domainOwnershipIdentifierName}
        /// Operation Id: WebApps_UpdateDomainOwnershipIdentifierSlot
        /// </summary>
        /// <param name="data"> A JSON representation of the domain ownership properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual Response<SiteSlotDomainOwnershipIdentifierResource> Update(IdentifierData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _siteSlotDomainOwnershipIdentifierWebAppsClientDiagnostics.CreateScope("SiteSlotDomainOwnershipIdentifierResource.Update");
            scope.Start();
            try
            {
                var response = _siteSlotDomainOwnershipIdentifierWebAppsRestClient.UpdateDomainOwnershipIdentifierSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data, cancellationToken);
                return Response.FromValue(new SiteSlotDomainOwnershipIdentifierResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
