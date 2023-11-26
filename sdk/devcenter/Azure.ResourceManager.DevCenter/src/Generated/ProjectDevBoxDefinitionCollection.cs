// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.DevCenter
{
    /// <summary>
    /// A class representing a collection of <see cref="ProjectDevBoxDefinitionResource"/> and their operations.
    /// Each <see cref="ProjectDevBoxDefinitionResource"/> in the collection will belong to the same instance of <see cref="DevCenterProjectResource"/>.
    /// To get a <see cref="ProjectDevBoxDefinitionCollection"/> instance call the GetProjectDevBoxDefinitions method from an instance of <see cref="DevCenterProjectResource"/>.
    /// </summary>
    public partial class ProjectDevBoxDefinitionCollection : ArmCollection, IEnumerable<ProjectDevBoxDefinitionResource>, IAsyncEnumerable<ProjectDevBoxDefinitionResource>
    {
        private readonly ClientDiagnostics _projectDevBoxDefinitionDevBoxDefinitionsClientDiagnostics;
        private readonly DevBoxDefinitionsRestOperations _projectDevBoxDefinitionDevBoxDefinitionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="ProjectDevBoxDefinitionCollection"/> class for mocking. </summary>
        protected ProjectDevBoxDefinitionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ProjectDevBoxDefinitionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ProjectDevBoxDefinitionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _projectDevBoxDefinitionDevBoxDefinitionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DevCenter", ProjectDevBoxDefinitionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ProjectDevBoxDefinitionResource.ResourceType, out string projectDevBoxDefinitionDevBoxDefinitionsApiVersion);
            _projectDevBoxDefinitionDevBoxDefinitionsRestClient = new DevBoxDefinitionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, projectDevBoxDefinitionDevBoxDefinitionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != DevCenterProjectResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, DevCenterProjectResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets a Dev Box definition configured for a project
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/projects/{projectName}/devboxdefinitions/{devBoxDefinitionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DevBoxDefinitions_GetByProject</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="devBoxDefinitionName"> The name of the Dev Box definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="devBoxDefinitionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="devBoxDefinitionName"/> is null. </exception>
        public virtual async Task<Response<ProjectDevBoxDefinitionResource>> GetAsync(string devBoxDefinitionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(devBoxDefinitionName, nameof(devBoxDefinitionName));

            using var scope = _projectDevBoxDefinitionDevBoxDefinitionsClientDiagnostics.CreateScope("ProjectDevBoxDefinitionCollection.Get");
            scope.Start();
            try
            {
                var response = await _projectDevBoxDefinitionDevBoxDefinitionsRestClient.GetByProjectAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, devBoxDefinitionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ProjectDevBoxDefinitionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a Dev Box definition configured for a project
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/projects/{projectName}/devboxdefinitions/{devBoxDefinitionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DevBoxDefinitions_GetByProject</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="devBoxDefinitionName"> The name of the Dev Box definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="devBoxDefinitionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="devBoxDefinitionName"/> is null. </exception>
        public virtual Response<ProjectDevBoxDefinitionResource> Get(string devBoxDefinitionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(devBoxDefinitionName, nameof(devBoxDefinitionName));

            using var scope = _projectDevBoxDefinitionDevBoxDefinitionsClientDiagnostics.CreateScope("ProjectDevBoxDefinitionCollection.Get");
            scope.Start();
            try
            {
                var response = _projectDevBoxDefinitionDevBoxDefinitionsRestClient.GetByProject(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, devBoxDefinitionName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ProjectDevBoxDefinitionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List Dev Box definitions configured for a project.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/projects/{projectName}/devboxdefinitions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DevBoxDefinitions_ListByProject</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> The maximum number of resources to return from the operation. Example: '$top=10'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ProjectDevBoxDefinitionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ProjectDevBoxDefinitionResource> GetAllAsync(int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _projectDevBoxDefinitionDevBoxDefinitionsRestClient.CreateListByProjectRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _projectDevBoxDefinitionDevBoxDefinitionsRestClient.CreateListByProjectNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new ProjectDevBoxDefinitionResource(Client, DevBoxDefinitionData.DeserializeDevBoxDefinitionData(e)), _projectDevBoxDefinitionDevBoxDefinitionsClientDiagnostics, Pipeline, "ProjectDevBoxDefinitionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List Dev Box definitions configured for a project.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/projects/{projectName}/devboxdefinitions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DevBoxDefinitions_ListByProject</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> The maximum number of resources to return from the operation. Example: '$top=10'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ProjectDevBoxDefinitionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ProjectDevBoxDefinitionResource> GetAll(int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _projectDevBoxDefinitionDevBoxDefinitionsRestClient.CreateListByProjectRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _projectDevBoxDefinitionDevBoxDefinitionsRestClient.CreateListByProjectNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new ProjectDevBoxDefinitionResource(Client, DevBoxDefinitionData.DeserializeDevBoxDefinitionData(e)), _projectDevBoxDefinitionDevBoxDefinitionsClientDiagnostics, Pipeline, "ProjectDevBoxDefinitionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/projects/{projectName}/devboxdefinitions/{devBoxDefinitionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DevBoxDefinitions_GetByProject</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="devBoxDefinitionName"> The name of the Dev Box definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="devBoxDefinitionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="devBoxDefinitionName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string devBoxDefinitionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(devBoxDefinitionName, nameof(devBoxDefinitionName));

            using var scope = _projectDevBoxDefinitionDevBoxDefinitionsClientDiagnostics.CreateScope("ProjectDevBoxDefinitionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _projectDevBoxDefinitionDevBoxDefinitionsRestClient.GetByProjectAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, devBoxDefinitionName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/projects/{projectName}/devboxdefinitions/{devBoxDefinitionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DevBoxDefinitions_GetByProject</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="devBoxDefinitionName"> The name of the Dev Box definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="devBoxDefinitionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="devBoxDefinitionName"/> is null. </exception>
        public virtual Response<bool> Exists(string devBoxDefinitionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(devBoxDefinitionName, nameof(devBoxDefinitionName));

            using var scope = _projectDevBoxDefinitionDevBoxDefinitionsClientDiagnostics.CreateScope("ProjectDevBoxDefinitionCollection.Exists");
            scope.Start();
            try
            {
                var response = _projectDevBoxDefinitionDevBoxDefinitionsRestClient.GetByProject(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, devBoxDefinitionName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/projects/{projectName}/devboxdefinitions/{devBoxDefinitionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DevBoxDefinitions_GetByProject</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="devBoxDefinitionName"> The name of the Dev Box definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="devBoxDefinitionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="devBoxDefinitionName"/> is null. </exception>
        public virtual async Task<NullableResponse<ProjectDevBoxDefinitionResource>> GetIfExistsAsync(string devBoxDefinitionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(devBoxDefinitionName, nameof(devBoxDefinitionName));

            using var scope = _projectDevBoxDefinitionDevBoxDefinitionsClientDiagnostics.CreateScope("ProjectDevBoxDefinitionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _projectDevBoxDefinitionDevBoxDefinitionsRestClient.GetByProjectAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, devBoxDefinitionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ProjectDevBoxDefinitionResource>(response.GetRawResponse());
                return Response.FromValue(new ProjectDevBoxDefinitionResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/projects/{projectName}/devboxdefinitions/{devBoxDefinitionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DevBoxDefinitions_GetByProject</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="devBoxDefinitionName"> The name of the Dev Box definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="devBoxDefinitionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="devBoxDefinitionName"/> is null. </exception>
        public virtual NullableResponse<ProjectDevBoxDefinitionResource> GetIfExists(string devBoxDefinitionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(devBoxDefinitionName, nameof(devBoxDefinitionName));

            using var scope = _projectDevBoxDefinitionDevBoxDefinitionsClientDiagnostics.CreateScope("ProjectDevBoxDefinitionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _projectDevBoxDefinitionDevBoxDefinitionsRestClient.GetByProject(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, devBoxDefinitionName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ProjectDevBoxDefinitionResource>(response.GetRawResponse());
                return Response.FromValue(new ProjectDevBoxDefinitionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ProjectDevBoxDefinitionResource> IEnumerable<ProjectDevBoxDefinitionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ProjectDevBoxDefinitionResource> IAsyncEnumerable<ProjectDevBoxDefinitionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
