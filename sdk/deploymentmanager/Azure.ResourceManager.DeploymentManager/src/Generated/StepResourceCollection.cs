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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.DeploymentManager
{
    /// <summary>
    /// A class representing a collection of <see cref="StepResource" /> and their operations.
    /// Each <see cref="StepResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="StepResourceCollection" /> instance call the GetStepResources method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class StepResourceCollection : ArmCollection, IEnumerable<StepResource>, IAsyncEnumerable<StepResource>
    {
        private readonly ClientDiagnostics _stepResourceStepsClientDiagnostics;
        private readonly StepsRestOperations _stepResourceStepsRestClient;

        /// <summary> Initializes a new instance of the <see cref="StepResourceCollection"/> class for mocking. </summary>
        protected StepResourceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="StepResourceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal StepResourceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _stepResourceStepsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DeploymentManager", StepResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(StepResource.ResourceType, out string stepResourceStepsApiVersion);
            _stepResourceStepsRestClient = new StepsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, stepResourceStepsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Synchronously creates a new step or updates an existing step.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeploymentManager/steps/{stepName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Steps_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="stepName"> The name of the deployment step. </param>
        /// <param name="data"> The step object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="stepName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="stepName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<StepResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string stepName, StepResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(stepName, nameof(stepName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _stepResourceStepsClientDiagnostics.CreateScope("StepResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _stepResourceStepsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, stepName, data, cancellationToken).ConfigureAwait(false);
                var operation = new DeploymentManagerArmOperation<StepResource>(Response.FromValue(new StepResource(Client, response), response.GetRawResponse()));
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
        /// Synchronously creates a new step or updates an existing step.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeploymentManager/steps/{stepName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Steps_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="stepName"> The name of the deployment step. </param>
        /// <param name="data"> The step object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="stepName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="stepName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<StepResource> CreateOrUpdate(WaitUntil waitUntil, string stepName, StepResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(stepName, nameof(stepName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _stepResourceStepsClientDiagnostics.CreateScope("StepResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _stepResourceStepsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, stepName, data, cancellationToken);
                var operation = new DeploymentManagerArmOperation<StepResource>(Response.FromValue(new StepResource(Client, response), response.GetRawResponse()));
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
        /// Gets the step.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeploymentManager/steps/{stepName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Steps_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="stepName"> The name of the deployment step. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="stepName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="stepName"/> is null. </exception>
        public virtual async Task<Response<StepResource>> GetAsync(string stepName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(stepName, nameof(stepName));

            using var scope = _stepResourceStepsClientDiagnostics.CreateScope("StepResourceCollection.Get");
            scope.Start();
            try
            {
                var response = await _stepResourceStepsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, stepName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StepResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the step.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeploymentManager/steps/{stepName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Steps_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="stepName"> The name of the deployment step. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="stepName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="stepName"/> is null. </exception>
        public virtual Response<StepResource> Get(string stepName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(stepName, nameof(stepName));

            using var scope = _stepResourceStepsClientDiagnostics.CreateScope("StepResourceCollection.Get");
            scope.Start();
            try
            {
                var response = _stepResourceStepsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, stepName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StepResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the steps in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeploymentManager/steps</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Steps_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="StepResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<StepResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _stepResourceStepsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, (e, o) => new StepResource(Client, StepResourceData.DeserializeStepResourceData(e)), _stepResourceStepsClientDiagnostics, Pipeline, "StepResourceCollection.GetAll", "", null, cancellationToken);
        }

        /// <summary>
        /// Lists the steps in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeploymentManager/steps</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Steps_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="StepResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<StepResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _stepResourceStepsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, (e, o) => new StepResource(Client, StepResourceData.DeserializeStepResourceData(e)), _stepResourceStepsClientDiagnostics, Pipeline, "StepResourceCollection.GetAll", "", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeploymentManager/steps/{stepName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Steps_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="stepName"> The name of the deployment step. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="stepName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="stepName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string stepName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(stepName, nameof(stepName));

            using var scope = _stepResourceStepsClientDiagnostics.CreateScope("StepResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _stepResourceStepsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, stepName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeploymentManager/steps/{stepName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Steps_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="stepName"> The name of the deployment step. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="stepName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="stepName"/> is null. </exception>
        public virtual Response<bool> Exists(string stepName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(stepName, nameof(stepName));

            using var scope = _stepResourceStepsClientDiagnostics.CreateScope("StepResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = _stepResourceStepsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, stepName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<StepResource> IEnumerable<StepResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<StepResource> IAsyncEnumerable<StepResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
