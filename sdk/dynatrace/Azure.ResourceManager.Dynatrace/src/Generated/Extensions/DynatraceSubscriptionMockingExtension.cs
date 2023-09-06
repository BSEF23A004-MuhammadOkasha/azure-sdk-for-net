// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Dynatrace;

namespace Azure.ResourceManager.Dynatrace.Mocking
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    public partial class DynatraceSubscriptionMockingExtension : ArmResource
    {
        private ClientDiagnostics _dynatraceMonitorMonitorsClientDiagnostics;
        private MonitorsRestOperations _dynatraceMonitorMonitorsRestClient;

        /// <summary> Initializes a new instance of the <see cref="DynatraceSubscriptionMockingExtension"/> class for mocking. </summary>
        protected DynatraceSubscriptionMockingExtension()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DynatraceSubscriptionMockingExtension"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal DynatraceSubscriptionMockingExtension(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics DynatraceMonitorMonitorsClientDiagnostics => _dynatraceMonitorMonitorsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Dynatrace", DynatraceMonitorResource.ResourceType.Namespace, Diagnostics);
        private MonitorsRestOperations DynatraceMonitorMonitorsRestClient => _dynatraceMonitorMonitorsRestClient ??= new MonitorsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(DynatraceMonitorResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// List all MonitorResource by subscriptionId
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Dynatrace.Observability/monitors</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Monitors_ListBySubscriptionId</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DynatraceMonitorResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DynatraceMonitorResource> GetDynatraceMonitorsAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => DynatraceMonitorMonitorsRestClient.CreateListBySubscriptionIdRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => DynatraceMonitorMonitorsRestClient.CreateListBySubscriptionIdNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new DynatraceMonitorResource(Client, DynatraceMonitorData.DeserializeDynatraceMonitorData(e)), DynatraceMonitorMonitorsClientDiagnostics, Pipeline, "DynatraceSubscriptionMockingExtension.GetDynatraceMonitors", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List all MonitorResource by subscriptionId
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Dynatrace.Observability/monitors</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Monitors_ListBySubscriptionId</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DynatraceMonitorResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DynatraceMonitorResource> GetDynatraceMonitors(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => DynatraceMonitorMonitorsRestClient.CreateListBySubscriptionIdRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => DynatraceMonitorMonitorsRestClient.CreateListBySubscriptionIdNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new DynatraceMonitorResource(Client, DynatraceMonitorData.DeserializeDynatraceMonitorData(e)), DynatraceMonitorMonitorsClientDiagnostics, Pipeline, "DynatraceSubscriptionMockingExtension.GetDynatraceMonitors", "value", "nextLink", cancellationToken);
        }
    }
}
