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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Support
{
    /// <summary>
    /// A class representing a collection of <see cref="TenantFileWorkspaceResource"/> and their operations.
    /// Each <see cref="TenantFileWorkspaceResource"/> in the collection will belong to the same instance of <see cref="TenantResource"/>.
    /// To get a <see cref="TenantFileWorkspaceCollection"/> instance call the GetTenantFileWorkspaces method from an instance of <see cref="TenantResource"/>.
    /// </summary>
    public partial class TenantFileWorkspaceCollection : ArmCollection
    {
        private readonly ClientDiagnostics _tenantFileWorkspaceFileWorkspacesNoSubscriptionClientDiagnostics;
        private readonly FileWorkspacesNoSubscriptionRestOperations _tenantFileWorkspaceFileWorkspacesNoSubscriptionRestClient;

        /// <summary> Initializes a new instance of the <see cref="TenantFileWorkspaceCollection"/> class for mocking. </summary>
        protected TenantFileWorkspaceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="TenantFileWorkspaceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal TenantFileWorkspaceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _tenantFileWorkspaceFileWorkspacesNoSubscriptionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Support", TenantFileWorkspaceResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(TenantFileWorkspaceResource.ResourceType, out string tenantFileWorkspaceFileWorkspacesNoSubscriptionApiVersion);
            _tenantFileWorkspaceFileWorkspacesNoSubscriptionRestClient = new FileWorkspacesNoSubscriptionRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, tenantFileWorkspaceFileWorkspacesNoSubscriptionApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != TenantResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, TenantResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a new file workspace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Support/fileWorkspaces/{fileWorkspaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FileWorkspacesNoSubscription_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TenantFileWorkspaceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="fileWorkspaceName"> File workspace name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fileWorkspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fileWorkspaceName"/> is null. </exception>
        public virtual async Task<ArmOperation<TenantFileWorkspaceResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string fileWorkspaceName, CancellationToken cancellationToken = default)
        {
            if (fileWorkspaceName == null)
            {
                throw new ArgumentNullException(nameof(fileWorkspaceName));
            }
            if (fileWorkspaceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(fileWorkspaceName));
            }

            using var scope = _tenantFileWorkspaceFileWorkspacesNoSubscriptionClientDiagnostics.CreateScope("TenantFileWorkspaceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _tenantFileWorkspaceFileWorkspacesNoSubscriptionRestClient.CreateAsync(fileWorkspaceName, cancellationToken).ConfigureAwait(false);
                var operation = new SupportArmOperation<TenantFileWorkspaceResource>(Response.FromValue(new TenantFileWorkspaceResource(Client, response), response.GetRawResponse()));
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
        /// Creates a new file workspace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Support/fileWorkspaces/{fileWorkspaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FileWorkspacesNoSubscription_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TenantFileWorkspaceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="fileWorkspaceName"> File workspace name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fileWorkspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fileWorkspaceName"/> is null. </exception>
        public virtual ArmOperation<TenantFileWorkspaceResource> CreateOrUpdate(WaitUntil waitUntil, string fileWorkspaceName, CancellationToken cancellationToken = default)
        {
            if (fileWorkspaceName == null)
            {
                throw new ArgumentNullException(nameof(fileWorkspaceName));
            }
            if (fileWorkspaceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(fileWorkspaceName));
            }

            using var scope = _tenantFileWorkspaceFileWorkspacesNoSubscriptionClientDiagnostics.CreateScope("TenantFileWorkspaceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _tenantFileWorkspaceFileWorkspacesNoSubscriptionRestClient.Create(fileWorkspaceName, cancellationToken);
                var operation = new SupportArmOperation<TenantFileWorkspaceResource>(Response.FromValue(new TenantFileWorkspaceResource(Client, response), response.GetRawResponse()));
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
        /// Gets details for a specific file workspace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Support/fileWorkspaces/{fileWorkspaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FileWorkspacesNoSubscription_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TenantFileWorkspaceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fileWorkspaceName"> File Workspace Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fileWorkspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fileWorkspaceName"/> is null. </exception>
        public virtual async Task<Response<TenantFileWorkspaceResource>> GetAsync(string fileWorkspaceName, CancellationToken cancellationToken = default)
        {
            if (fileWorkspaceName == null)
            {
                throw new ArgumentNullException(nameof(fileWorkspaceName));
            }
            if (fileWorkspaceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(fileWorkspaceName));
            }

            using var scope = _tenantFileWorkspaceFileWorkspacesNoSubscriptionClientDiagnostics.CreateScope("TenantFileWorkspaceCollection.Get");
            scope.Start();
            try
            {
                var response = await _tenantFileWorkspaceFileWorkspacesNoSubscriptionRestClient.GetAsync(fileWorkspaceName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new TenantFileWorkspaceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets details for a specific file workspace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Support/fileWorkspaces/{fileWorkspaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FileWorkspacesNoSubscription_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TenantFileWorkspaceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fileWorkspaceName"> File Workspace Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fileWorkspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fileWorkspaceName"/> is null. </exception>
        public virtual Response<TenantFileWorkspaceResource> Get(string fileWorkspaceName, CancellationToken cancellationToken = default)
        {
            if (fileWorkspaceName == null)
            {
                throw new ArgumentNullException(nameof(fileWorkspaceName));
            }
            if (fileWorkspaceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(fileWorkspaceName));
            }

            using var scope = _tenantFileWorkspaceFileWorkspacesNoSubscriptionClientDiagnostics.CreateScope("TenantFileWorkspaceCollection.Get");
            scope.Start();
            try
            {
                var response = _tenantFileWorkspaceFileWorkspacesNoSubscriptionRestClient.Get(fileWorkspaceName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new TenantFileWorkspaceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Support/fileWorkspaces/{fileWorkspaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FileWorkspacesNoSubscription_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TenantFileWorkspaceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fileWorkspaceName"> File Workspace Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fileWorkspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fileWorkspaceName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string fileWorkspaceName, CancellationToken cancellationToken = default)
        {
            if (fileWorkspaceName == null)
            {
                throw new ArgumentNullException(nameof(fileWorkspaceName));
            }
            if (fileWorkspaceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(fileWorkspaceName));
            }

            using var scope = _tenantFileWorkspaceFileWorkspacesNoSubscriptionClientDiagnostics.CreateScope("TenantFileWorkspaceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _tenantFileWorkspaceFileWorkspacesNoSubscriptionRestClient.GetAsync(fileWorkspaceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Support/fileWorkspaces/{fileWorkspaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FileWorkspacesNoSubscription_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TenantFileWorkspaceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fileWorkspaceName"> File Workspace Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fileWorkspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fileWorkspaceName"/> is null. </exception>
        public virtual Response<bool> Exists(string fileWorkspaceName, CancellationToken cancellationToken = default)
        {
            if (fileWorkspaceName == null)
            {
                throw new ArgumentNullException(nameof(fileWorkspaceName));
            }
            if (fileWorkspaceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(fileWorkspaceName));
            }

            using var scope = _tenantFileWorkspaceFileWorkspacesNoSubscriptionClientDiagnostics.CreateScope("TenantFileWorkspaceCollection.Exists");
            scope.Start();
            try
            {
                var response = _tenantFileWorkspaceFileWorkspacesNoSubscriptionRestClient.Get(fileWorkspaceName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Support/fileWorkspaces/{fileWorkspaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FileWorkspacesNoSubscription_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TenantFileWorkspaceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fileWorkspaceName"> File Workspace Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fileWorkspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fileWorkspaceName"/> is null. </exception>
        public virtual async Task<NullableResponse<TenantFileWorkspaceResource>> GetIfExistsAsync(string fileWorkspaceName, CancellationToken cancellationToken = default)
        {
            if (fileWorkspaceName == null)
            {
                throw new ArgumentNullException(nameof(fileWorkspaceName));
            }
            if (fileWorkspaceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(fileWorkspaceName));
            }

            using var scope = _tenantFileWorkspaceFileWorkspacesNoSubscriptionClientDiagnostics.CreateScope("TenantFileWorkspaceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _tenantFileWorkspaceFileWorkspacesNoSubscriptionRestClient.GetAsync(fileWorkspaceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<TenantFileWorkspaceResource>(response.GetRawResponse());
                return Response.FromValue(new TenantFileWorkspaceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Support/fileWorkspaces/{fileWorkspaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FileWorkspacesNoSubscription_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TenantFileWorkspaceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fileWorkspaceName"> File Workspace Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fileWorkspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fileWorkspaceName"/> is null. </exception>
        public virtual NullableResponse<TenantFileWorkspaceResource> GetIfExists(string fileWorkspaceName, CancellationToken cancellationToken = default)
        {
            if (fileWorkspaceName == null)
            {
                throw new ArgumentNullException(nameof(fileWorkspaceName));
            }
            if (fileWorkspaceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(fileWorkspaceName));
            }

            using var scope = _tenantFileWorkspaceFileWorkspacesNoSubscriptionClientDiagnostics.CreateScope("TenantFileWorkspaceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _tenantFileWorkspaceFileWorkspacesNoSubscriptionRestClient.Get(fileWorkspaceName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<TenantFileWorkspaceResource>(response.GetRawResponse());
                return Response.FromValue(new TenantFileWorkspaceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
