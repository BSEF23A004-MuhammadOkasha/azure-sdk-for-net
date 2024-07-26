// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Quota.Models;

namespace Azure.ResourceManager.Quota.Mocking
{
    /// <summary> A class to add extension methods to TenantResource. </summary>
    public partial class MockableQuotaTenantResource : ArmResource
    {
        private ClientDiagnostics _quotaOperationClientDiagnostics;
        private QuotaOperationRestOperations _quotaOperationRestClient;

        /// <summary> Initializes a new instance of the <see cref="MockableQuotaTenantResource"/> class for mocking. </summary>
        protected MockableQuotaTenantResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableQuotaTenantResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableQuotaTenantResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics QuotaOperationClientDiagnostics => _quotaOperationClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Quota", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private QuotaOperationRestOperations QuotaOperationRestClient => _quotaOperationRestClient ??= new QuotaOperationRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// List all the operations supported by the Microsoft.Quota resource provider.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Quota/operations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>QuotaOperation_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="QuotaOperationResult"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<QuotaOperationResult> GetQuotaOperationsAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => QuotaOperationRestClient.CreateListRequest();
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => QuotaOperationRestClient.CreateListNextPageRequest(nextLink);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => QuotaOperationResult.DeserializeQuotaOperationResult(e), QuotaOperationClientDiagnostics, Pipeline, "MockableQuotaTenantResource.GetQuotaOperations", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List all the operations supported by the Microsoft.Quota resource provider.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Quota/operations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>QuotaOperation_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="QuotaOperationResult"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<QuotaOperationResult> GetQuotaOperations(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => QuotaOperationRestClient.CreateListRequest();
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => QuotaOperationRestClient.CreateListNextPageRequest(nextLink);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => QuotaOperationResult.DeserializeQuotaOperationResult(e), QuotaOperationClientDiagnostics, Pipeline, "MockableQuotaTenantResource.GetQuotaOperations", "value", "nextLink", cancellationToken);
        }
    }
}
