// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A Class representing a WebSiteSlotTriggeredWebJobHistory along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="WebSiteSlotTriggeredWebJobHistoryResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetWebSiteSlotTriggeredWebJobHistoryResource method.
    /// Otherwise you can get one from its parent resource <see cref="WebSiteSlotTriggeredWebJobResource"/> using the GetWebSiteSlotTriggeredWebJobHistory method.
    /// </summary>
    public partial class WebSiteSlotTriggeredWebJobHistoryResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="WebSiteSlotTriggeredWebJobHistoryResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="name"> The name. </param>
        /// <param name="slot"> The slot. </param>
        /// <param name="webJobName"> The webJobName. </param>
        /// <param name="id"> The id. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string slot, string webJobName, string id)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/triggeredwebjobs/{webJobName}/history/{id}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _webSiteSlotTriggeredWebJobHistoryWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _webSiteSlotTriggeredWebJobHistoryWebAppsRestClient;
        private readonly TriggeredJobHistoryData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Web/sites/slots/triggeredwebjobs/history";

        /// <summary> Initializes a new instance of the <see cref="WebSiteSlotTriggeredWebJobHistoryResource"/> class for mocking. </summary>
        protected WebSiteSlotTriggeredWebJobHistoryResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="WebSiteSlotTriggeredWebJobHistoryResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal WebSiteSlotTriggeredWebJobHistoryResource(ArmClient client, TriggeredJobHistoryData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="WebSiteSlotTriggeredWebJobHistoryResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal WebSiteSlotTriggeredWebJobHistoryResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _webSiteSlotTriggeredWebJobHistoryWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string webSiteSlotTriggeredWebJobHistoryWebAppsApiVersion);
            _webSiteSlotTriggeredWebJobHistoryWebAppsRestClient = new WebAppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, webSiteSlotTriggeredWebJobHistoryWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual TriggeredJobHistoryData Data
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
        /// Description for Gets a triggered web job's history by its ID for an app, , or a deployment slot.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/triggeredwebjobs/{webJobName}/history/{id}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetTriggeredWebJobHistorySlot</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WebSiteSlotTriggeredWebJobHistoryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<WebSiteSlotTriggeredWebJobHistoryResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _webSiteSlotTriggeredWebJobHistoryWebAppsClientDiagnostics.CreateScope("WebSiteSlotTriggeredWebJobHistoryResource.Get");
            scope.Start();
            try
            {
                var response = await _webSiteSlotTriggeredWebJobHistoryWebAppsRestClient.GetTriggeredWebJobHistorySlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WebSiteSlotTriggeredWebJobHistoryResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Gets a triggered web job's history by its ID for an app, , or a deployment slot.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/triggeredwebjobs/{webJobName}/history/{id}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetTriggeredWebJobHistorySlot</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WebSiteSlotTriggeredWebJobHistoryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<WebSiteSlotTriggeredWebJobHistoryResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _webSiteSlotTriggeredWebJobHistoryWebAppsClientDiagnostics.CreateScope("WebSiteSlotTriggeredWebJobHistoryResource.Get");
            scope.Start();
            try
            {
                var response = _webSiteSlotTriggeredWebJobHistoryWebAppsRestClient.GetTriggeredWebJobHistorySlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WebSiteSlotTriggeredWebJobHistoryResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
