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
using Azure.ResourceManager.Cdn.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Cdn
{
    /// <summary> A Class representing a AfdOriginGroup along with the instance operations that can be performed on it. </summary>
    public partial class AfdOriginGroup : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="AfdOriginGroup"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string profileName, string originGroupName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/originGroups/{originGroupName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _afdOriginGroupClientDiagnostics;
        private readonly AfdOriginGroupsRestOperations _afdOriginGroupRestClient;
        private readonly AfdOriginGroupData _data;

        /// <summary> Initializes a new instance of the <see cref="AfdOriginGroup"/> class for mocking. </summary>
        protected AfdOriginGroup()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "AfdOriginGroup"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal AfdOriginGroup(ArmClient client, AfdOriginGroupData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="AfdOriginGroup"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal AfdOriginGroup(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _afdOriginGroupClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Cdn", ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(ResourceType, out string afdOriginGroupApiVersion);
            _afdOriginGroupRestClient = new AfdOriginGroupsRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, afdOriginGroupApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Cdn/profiles/originGroups";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual AfdOriginGroupData Data
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

        /// <summary> Gets a collection of AfdOrigins in the AfdOrigin. </summary>
        /// <returns> An object representing collection of AfdOrigins and their operations over a AfdOrigin. </returns>
        public virtual AfdOriginCollection GetAfdOrigins()
        {
            return new AfdOriginCollection(Client, Id);
        }

        /// <summary>
        /// Gets an existing origin within an origin group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/originGroups/{originGroupName}/origins/{originName}
        /// Operation Id: AfdOrigins_Get
        /// </summary>
        /// <param name="originName"> Name of the origin which is unique within the profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="originName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="originName"/> is null. </exception>
        public virtual async Task<Response<AfdOrigin>> GetAfdOriginAsync(string originName, CancellationToken cancellationToken = default)
        {
            return await GetAfdOrigins().GetAsync(originName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets an existing origin within an origin group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/originGroups/{originGroupName}/origins/{originName}
        /// Operation Id: AfdOrigins_Get
        /// </summary>
        /// <param name="originName"> Name of the origin which is unique within the profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="originName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="originName"/> is null. </exception>
        public virtual Response<AfdOrigin> GetAfdOrigin(string originName, CancellationToken cancellationToken = default)
        {
            return GetAfdOrigins().Get(originName, cancellationToken);
        }

        /// <summary>
        /// Gets an existing origin group within a profile.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/originGroups/{originGroupName}
        /// Operation Id: AfdOriginGroups_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<AfdOriginGroup>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _afdOriginGroupClientDiagnostics.CreateScope("AfdOriginGroup.Get");
            scope.Start();
            try
            {
                var response = await _afdOriginGroupRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AfdOriginGroup(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an existing origin group within a profile.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/originGroups/{originGroupName}
        /// Operation Id: AfdOriginGroups_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<AfdOriginGroup> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _afdOriginGroupClientDiagnostics.CreateScope("AfdOriginGroup.Get");
            scope.Start();
            try
            {
                var response = _afdOriginGroupRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AfdOriginGroup(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes an existing origin group within a profile.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/originGroups/{originGroupName}
        /// Operation Id: AfdOriginGroups_Delete
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _afdOriginGroupClientDiagnostics.CreateScope("AfdOriginGroup.Delete");
            scope.Start();
            try
            {
                var response = await _afdOriginGroupRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new CdnArmOperation(_afdOriginGroupClientDiagnostics, Pipeline, _afdOriginGroupRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Deletes an existing origin group within a profile.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/originGroups/{originGroupName}
        /// Operation Id: AfdOriginGroups_Delete
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _afdOriginGroupClientDiagnostics.CreateScope("AfdOriginGroup.Delete");
            scope.Start();
            try
            {
                var response = _afdOriginGroupRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new CdnArmOperation(_afdOriginGroupClientDiagnostics, Pipeline, _afdOriginGroupRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Updates an existing origin group within a profile.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/originGroups/{originGroupName}
        /// Operation Id: AfdOriginGroups_Update
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Origin group properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<AfdOriginGroup>> UpdateAsync(WaitUntil waitUntil, PatchableAfdOriginGroupData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _afdOriginGroupClientDiagnostics.CreateScope("AfdOriginGroup.Update");
            scope.Start();
            try
            {
                var response = await _afdOriginGroupRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new CdnArmOperation<AfdOriginGroup>(new AfdOriginGroupOperationSource(Client), _afdOriginGroupClientDiagnostics, Pipeline, _afdOriginGroupRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.OriginalUri);
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
        /// Updates an existing origin group within a profile.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/originGroups/{originGroupName}
        /// Operation Id: AfdOriginGroups_Update
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Origin group properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<AfdOriginGroup> Update(WaitUntil waitUntil, PatchableAfdOriginGroupData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _afdOriginGroupClientDiagnostics.CreateScope("AfdOriginGroup.Update");
            scope.Start();
            try
            {
                var response = _afdOriginGroupRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new CdnArmOperation<AfdOriginGroup>(new AfdOriginGroupOperationSource(Client), _afdOriginGroupClientDiagnostics, Pipeline, _afdOriginGroupRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.OriginalUri);
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
        /// Checks the quota and actual usage of endpoints under the given CDN profile.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/originGroups/{originGroupName}/usages
        /// Operation Id: AfdOriginGroups_ListResourceUsage
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CdnUsage" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<CdnUsage> GetResourceUsageAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<CdnUsage>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _afdOriginGroupClientDiagnostics.CreateScope("AfdOriginGroup.GetResourceUsage");
                scope.Start();
                try
                {
                    var response = await _afdOriginGroupRestClient.ListResourceUsageAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<CdnUsage>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _afdOriginGroupClientDiagnostics.CreateScope("AfdOriginGroup.GetResourceUsage");
                scope.Start();
                try
                {
                    var response = await _afdOriginGroupRestClient.ListResourceUsageNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks the quota and actual usage of endpoints under the given CDN profile.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/originGroups/{originGroupName}/usages
        /// Operation Id: AfdOriginGroups_ListResourceUsage
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CdnUsage" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<CdnUsage> GetResourceUsage(CancellationToken cancellationToken = default)
        {
            Page<CdnUsage> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _afdOriginGroupClientDiagnostics.CreateScope("AfdOriginGroup.GetResourceUsage");
                scope.Start();
                try
                {
                    var response = _afdOriginGroupRestClient.ListResourceUsage(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<CdnUsage> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _afdOriginGroupClientDiagnostics.CreateScope("AfdOriginGroup.GetResourceUsage");
                scope.Start();
                try
                {
                    var response = _afdOriginGroupRestClient.ListResourceUsageNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }
    }
}
