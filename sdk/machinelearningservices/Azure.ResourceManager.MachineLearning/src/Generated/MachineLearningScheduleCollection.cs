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
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.MachineLearning.Models;

namespace Azure.ResourceManager.MachineLearning
{
    /// <summary>
    /// A class representing a collection of <see cref="MachineLearningScheduleResource"/> and their operations.
    /// Each <see cref="MachineLearningScheduleResource"/> in the collection will belong to the same instance of <see cref="MachineLearningWorkspaceResource"/>.
    /// To get a <see cref="MachineLearningScheduleCollection"/> instance call the GetMachineLearningSchedules method from an instance of <see cref="MachineLearningWorkspaceResource"/>.
    /// </summary>
    public partial class MachineLearningScheduleCollection : ArmCollection, IEnumerable<MachineLearningScheduleResource>, IAsyncEnumerable<MachineLearningScheduleResource>
    {
        private readonly ClientDiagnostics _machineLearningScheduleSchedulesClientDiagnostics;
        private readonly SchedulesRestOperations _machineLearningScheduleSchedulesRestClient;

        /// <summary> Initializes a new instance of the <see cref="MachineLearningScheduleCollection"/> class for mocking. </summary>
        protected MachineLearningScheduleCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MachineLearningScheduleCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal MachineLearningScheduleCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _machineLearningScheduleSchedulesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.MachineLearning", MachineLearningScheduleResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(MachineLearningScheduleResource.ResourceType, out string machineLearningScheduleSchedulesApiVersion);
            _machineLearningScheduleSchedulesRestClient = new SchedulesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, machineLearningScheduleSchedulesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != MachineLearningWorkspaceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, MachineLearningWorkspaceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update schedule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/schedules/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Schedules_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
<<<<<<< HEAD
        /// <description>2024-04-01</description>
=======
        /// <description>2024-07-01-preview</description>
>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningScheduleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="name"> Schedule name. </param>
        /// <param name="data"> Schedule definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<MachineLearningScheduleResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string name, MachineLearningScheduleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _machineLearningScheduleSchedulesClientDiagnostics.CreateScope("MachineLearningScheduleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _machineLearningScheduleSchedulesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, data, cancellationToken).ConfigureAwait(false);
                var operation = new MachineLearningArmOperation<MachineLearningScheduleResource>(new MachineLearningScheduleOperationSource(Client), _machineLearningScheduleSchedulesClientDiagnostics, Pipeline, _machineLearningScheduleSchedulesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, data).Request, response, OperationFinalStateVia.OriginalUri);
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
        /// Create or update schedule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/schedules/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Schedules_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
<<<<<<< HEAD
        /// <description>2024-04-01</description>
=======
        /// <description>2024-07-01-preview</description>
>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningScheduleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="name"> Schedule name. </param>
        /// <param name="data"> Schedule definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<MachineLearningScheduleResource> CreateOrUpdate(WaitUntil waitUntil, string name, MachineLearningScheduleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _machineLearningScheduleSchedulesClientDiagnostics.CreateScope("MachineLearningScheduleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _machineLearningScheduleSchedulesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, data, cancellationToken);
                var operation = new MachineLearningArmOperation<MachineLearningScheduleResource>(new MachineLearningScheduleOperationSource(Client), _machineLearningScheduleSchedulesClientDiagnostics, Pipeline, _machineLearningScheduleSchedulesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, data).Request, response, OperationFinalStateVia.OriginalUri);
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
        /// Get schedule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/schedules/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Schedules_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
<<<<<<< HEAD
        /// <description>2024-04-01</description>
=======
        /// <description>2024-07-01-preview</description>
>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningScheduleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Schedule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<MachineLearningScheduleResource>> GetAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _machineLearningScheduleSchedulesClientDiagnostics.CreateScope("MachineLearningScheduleCollection.Get");
            scope.Start();
            try
            {
                var response = await _machineLearningScheduleSchedulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MachineLearningScheduleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get schedule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/schedules/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Schedules_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
<<<<<<< HEAD
        /// <description>2024-04-01</description>
=======
        /// <description>2024-07-01-preview</description>
>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningScheduleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Schedule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<MachineLearningScheduleResource> Get(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _machineLearningScheduleSchedulesClientDiagnostics.CreateScope("MachineLearningScheduleCollection.Get");
            scope.Start();
            try
            {
                var response = _machineLearningScheduleSchedulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MachineLearningScheduleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List schedules in specified workspace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/schedules</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Schedules_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
<<<<<<< HEAD
        /// <description>2024-04-01</description>
=======
        /// <description>2024-07-01-preview</description>
>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningScheduleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skip"> Continuation token for pagination. </param>
        /// <param name="listViewType"> Status filter for schedule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MachineLearningScheduleResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MachineLearningScheduleResource> GetAllAsync(string skip = null, MachineLearningScheduleListViewType? listViewType = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _machineLearningScheduleSchedulesRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skip, listViewType);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _machineLearningScheduleSchedulesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skip, listViewType);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new MachineLearningScheduleResource(Client, MachineLearningScheduleData.DeserializeMachineLearningScheduleData(e)), _machineLearningScheduleSchedulesClientDiagnostics, Pipeline, "MachineLearningScheduleCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List schedules in specified workspace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/schedules</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Schedules_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
<<<<<<< HEAD
        /// <description>2024-04-01</description>
=======
        /// <description>2024-07-01-preview</description>
>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningScheduleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skip"> Continuation token for pagination. </param>
        /// <param name="listViewType"> Status filter for schedule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MachineLearningScheduleResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MachineLearningScheduleResource> GetAll(string skip = null, MachineLearningScheduleListViewType? listViewType = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _machineLearningScheduleSchedulesRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skip, listViewType);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _machineLearningScheduleSchedulesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skip, listViewType);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new MachineLearningScheduleResource(Client, MachineLearningScheduleData.DeserializeMachineLearningScheduleData(e)), _machineLearningScheduleSchedulesClientDiagnostics, Pipeline, "MachineLearningScheduleCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/schedules/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Schedules_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
<<<<<<< HEAD
        /// <description>2024-04-01</description>
=======
        /// <description>2024-07-01-preview</description>
>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningScheduleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Schedule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _machineLearningScheduleSchedulesClientDiagnostics.CreateScope("MachineLearningScheduleCollection.Exists");
            scope.Start();
            try
            {
                var response = await _machineLearningScheduleSchedulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/schedules/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Schedules_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
<<<<<<< HEAD
        /// <description>2024-04-01</description>
=======
        /// <description>2024-07-01-preview</description>
>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningScheduleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Schedule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<bool> Exists(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _machineLearningScheduleSchedulesClientDiagnostics.CreateScope("MachineLearningScheduleCollection.Exists");
            scope.Start();
            try
            {
                var response = _machineLearningScheduleSchedulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/schedules/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Schedules_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
<<<<<<< HEAD
        /// <description>2024-04-01</description>
=======
        /// <description>2024-07-01-preview</description>
>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningScheduleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Schedule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<NullableResponse<MachineLearningScheduleResource>> GetIfExistsAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _machineLearningScheduleSchedulesClientDiagnostics.CreateScope("MachineLearningScheduleCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _machineLearningScheduleSchedulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<MachineLearningScheduleResource>(response.GetRawResponse());
                return Response.FromValue(new MachineLearningScheduleResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/schedules/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Schedules_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
<<<<<<< HEAD
        /// <description>2024-04-01</description>
=======
        /// <description>2024-07-01-preview</description>
>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningScheduleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Schedule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual NullableResponse<MachineLearningScheduleResource> GetIfExists(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _machineLearningScheduleSchedulesClientDiagnostics.CreateScope("MachineLearningScheduleCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _machineLearningScheduleSchedulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<MachineLearningScheduleResource>(response.GetRawResponse());
                return Response.FromValue(new MachineLearningScheduleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<MachineLearningScheduleResource> IEnumerable<MachineLearningScheduleResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<MachineLearningScheduleResource> IAsyncEnumerable<MachineLearningScheduleResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
