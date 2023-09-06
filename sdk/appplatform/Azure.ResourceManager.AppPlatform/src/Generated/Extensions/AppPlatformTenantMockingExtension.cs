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
using Azure.ResourceManager.AppPlatform;
using Azure.ResourceManager.AppPlatform.Models;

namespace Azure.ResourceManager.AppPlatform.Mocking
{
    /// <summary> A class to add extension methods to TenantResource. </summary>
    public partial class AppPlatformTenantMockingExtension : ArmResource
    {
        private ClientDiagnostics _runtimeVersionsClientDiagnostics;
        private RuntimeVersionsRestOperations _runtimeVersionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="AppPlatformTenantMockingExtension"/> class for mocking. </summary>
        protected AppPlatformTenantMockingExtension()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AppPlatformTenantMockingExtension"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal AppPlatformTenantMockingExtension(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics RuntimeVersionsClientDiagnostics => _runtimeVersionsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.AppPlatform", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private RuntimeVersionsRestOperations RuntimeVersionsRestClient => _runtimeVersionsRestClient ??= new RuntimeVersionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Lists all of the available runtime versions supported by Microsoft.AppPlatform provider.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.AppPlatform/runtimeVersions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RuntimeVersions_ListRuntimeVersions</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AppPlatformSupportedRuntimeVersion" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AppPlatformSupportedRuntimeVersion> GetRuntimeVersionsAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => RuntimeVersionsRestClient.CreateListRuntimeVersionsRequest();
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, AppPlatformSupportedRuntimeVersion.DeserializeAppPlatformSupportedRuntimeVersion, RuntimeVersionsClientDiagnostics, Pipeline, "AppPlatformTenantMockingExtension.GetRuntimeVersions", "value", null, cancellationToken);
        }

        /// <summary>
        /// Lists all of the available runtime versions supported by Microsoft.AppPlatform provider.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.AppPlatform/runtimeVersions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RuntimeVersions_ListRuntimeVersions</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AppPlatformSupportedRuntimeVersion" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AppPlatformSupportedRuntimeVersion> GetRuntimeVersions(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => RuntimeVersionsRestClient.CreateListRuntimeVersionsRequest();
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, AppPlatformSupportedRuntimeVersion.DeserializeAppPlatformSupportedRuntimeVersion, RuntimeVersionsClientDiagnostics, Pipeline, "AppPlatformTenantMockingExtension.GetRuntimeVersions", "value", null, cancellationToken);
        }
    }
}
