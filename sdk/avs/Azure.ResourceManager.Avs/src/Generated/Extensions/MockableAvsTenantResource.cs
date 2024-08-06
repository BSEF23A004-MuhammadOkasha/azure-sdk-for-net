// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Avs.Models;

namespace Azure.ResourceManager.Avs.Mocking
{
    /// <summary> A class to add extension methods to TenantResource. </summary>
    public partial class MockableAvsTenantResource : ArmResource
    {
        private ClientDiagnostics _operationsClientDiagnostics;
        private OperationsRestOperations _operationsRestClient;

        /// <summary> Initializes a new instance of the <see cref="MockableAvsTenantResource"/> class for mocking. </summary>
        protected MockableAvsTenantResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableAvsTenantResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableAvsTenantResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics OperationsClientDiagnostics => _operationsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Avs", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private OperationsRestOperations OperationsRestClient => _operationsRestClient ??= new OperationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// List the operations for the provider
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.AVS/operations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Operations_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="Models.Operation"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<Models.Operation> GetOperationsAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => OperationsRestClient.CreateListRequest();
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => OperationsRestClient.CreateListNextPageRequest(nextLink);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => Models.Operation.DeserializeOperation(e), OperationsClientDiagnostics, Pipeline, "MockableAvsTenantResource.GetOperations", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List the operations for the provider
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.AVS/operations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Operations_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="Models.Operation"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<Models.Operation> GetOperations(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => OperationsRestClient.CreateListRequest();
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => OperationsRestClient.CreateListNextPageRequest(nextLink);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => Models.Operation.DeserializeOperation(e), OperationsClientDiagnostics, Pipeline, "MockableAvsTenantResource.GetOperations", "value", "nextLink", cancellationToken);
        }
    }
}
