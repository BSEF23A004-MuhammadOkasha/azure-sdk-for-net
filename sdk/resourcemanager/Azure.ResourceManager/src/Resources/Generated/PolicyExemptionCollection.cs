// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Management;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Resources
{
    /// <summary> A class representing collection of PolicyExemption and their operations over its parent. </summary>
    public partial class PolicyExemptionCollection : ArmCollection, IEnumerable<PolicyExemption>, IAsyncEnumerable<PolicyExemption>
    {
        private readonly ClientDiagnostics _policyExemptionClientDiagnostics;
        private readonly PolicyExemptionsRestOperations _policyExemptionRestClient;

        /// <summary> Initializes a new instance of the <see cref="PolicyExemptionCollection"/> class for mocking. </summary>
        protected PolicyExemptionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="PolicyExemptionCollection"/> class. </summary>
        /// <param name="armClient"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal PolicyExemptionCollection(ArmClient armClient, ResourceIdentifier id) : base(armClient, id)
        {
            _policyExemptionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Resources", PolicyExemption.ResourceType.Namespace, DiagnosticOptions);
            ArmClient.TryGetApiVersion(PolicyExemption.ResourceType, out string policyExemptionApiVersion);
            _policyExemptionRestClient = new PolicyExemptionsRestOperations(_policyExemptionClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, policyExemptionApiVersion);
        }

        /// RequestPath: /{scope}/providers/Microsoft.Authorization/policyExemptions/{policyExemptionName}
        /// ContextualPath: /{scope}
        /// OperationId: PolicyExemptions_CreateOrUpdate
        /// <summary> This operation creates or updates a policy exemption with the given scope and name. Policy exemptions apply to all resources contained within their scope. For example, when you create a policy exemption at resource group scope for a policy assignment at the same or above level, the exemption exempts to all applicable resources in the resource group. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="policyExemptionName"> The name of the policy exemption to delete. </param>
        /// <param name="parameters"> Parameters for the policy exemption. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyExemptionName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyExemptionName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<PolicyExemptionCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string policyExemptionName, PolicyExemptionData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(policyExemptionName, nameof(policyExemptionName));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _policyExemptionClientDiagnostics.CreateScope("PolicyExemptionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _policyExemptionRestClient.CreateOrUpdateAsync(Id, policyExemptionName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new PolicyExemptionCreateOrUpdateOperation(ArmClient, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /{scope}/providers/Microsoft.Authorization/policyExemptions/{policyExemptionName}
        /// ContextualPath: /{scope}
        /// OperationId: PolicyExemptions_CreateOrUpdate
        /// <summary> This operation creates or updates a policy exemption with the given scope and name. Policy exemptions apply to all resources contained within their scope. For example, when you create a policy exemption at resource group scope for a policy assignment at the same or above level, the exemption exempts to all applicable resources in the resource group. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="policyExemptionName"> The name of the policy exemption to delete. </param>
        /// <param name="parameters"> Parameters for the policy exemption. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyExemptionName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyExemptionName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual PolicyExemptionCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string policyExemptionName, PolicyExemptionData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(policyExemptionName, nameof(policyExemptionName));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _policyExemptionClientDiagnostics.CreateScope("PolicyExemptionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _policyExemptionRestClient.CreateOrUpdate(Id, policyExemptionName, parameters, cancellationToken);
                var operation = new PolicyExemptionCreateOrUpdateOperation(ArmClient, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /{scope}/providers/Microsoft.Authorization/policyExemptions/{policyExemptionName}
        /// ContextualPath: /{scope}
        /// OperationId: PolicyExemptions_Get
        /// <summary> This operation retrieves a single policy exemption, given its name and the scope it was created at. </summary>
        /// <param name="policyExemptionName"> The name of the policy exemption to delete. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyExemptionName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyExemptionName"/> is null. </exception>
        public async virtual Task<Response<PolicyExemption>> GetAsync(string policyExemptionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(policyExemptionName, nameof(policyExemptionName));

            using var scope = _policyExemptionClientDiagnostics.CreateScope("PolicyExemptionCollection.Get");
            scope.Start();
            try
            {
                var response = await _policyExemptionRestClient.GetAsync(Id, policyExemptionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _policyExemptionClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new PolicyExemption(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /{scope}/providers/Microsoft.Authorization/policyExemptions/{policyExemptionName}
        /// ContextualPath: /{scope}
        /// OperationId: PolicyExemptions_Get
        /// <summary> This operation retrieves a single policy exemption, given its name and the scope it was created at. </summary>
        /// <param name="policyExemptionName"> The name of the policy exemption to delete. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyExemptionName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyExemptionName"/> is null. </exception>
        public virtual Response<PolicyExemption> Get(string policyExemptionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(policyExemptionName, nameof(policyExemptionName));

            using var scope = _policyExemptionClientDiagnostics.CreateScope("PolicyExemptionCollection.Get");
            scope.Start();
            try
            {
                var response = _policyExemptionRestClient.Get(Id, policyExemptionName, cancellationToken);
                if (response.Value == null)
                    throw _policyExemptionClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PolicyExemption(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Authorization/policyExemptions
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: PolicyExemptions_List
        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Authorization/policyExemptions
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: PolicyExemptions_ListForResourceGroup
        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{parentResourcePath}/{resourceType}/{resourceName}/providers/Microsoft.Authorization/policyExemptions
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{parentResourcePath}/{resourceType}/{resourceName}
        /// OperationId: PolicyExemptions_ListForResource
        /// RequestPath: /providers/Microsoft.Management/managementGroups/{managementGroupId}/providers/Microsoft.Authorization/policyExemptions
        /// ContextualPath: /providers/Microsoft.Management/managementGroups/{managementGroupId}
        /// OperationId: PolicyExemptions_ListForManagementGroup
        /// <summary> This operation retrieves the list of all policy exemptions associated with the given subscription that match the optional given $filter. Valid values for $filter are: &apos;atScope()&apos;, &apos;atExactScope()&apos;, &apos;excludeExpired()&apos; or &apos;policyAssignmentId eq &apos;{value}&apos;&apos;. If $filter is not provided, the unfiltered list includes all policy exemptions associated with the subscription, including those that apply directly or from management groups that contain the given subscription, as well as any applied to objects contained within the subscription. </summary>
        /// <param name="filter"> The filter to apply on the operation. Valid values for $filter are: &apos;atScope()&apos;, &apos;atExactScope()&apos;, &apos;excludeExpired()&apos; or &apos;policyAssignmentId eq &apos;{value}&apos;&apos;. If $filter is not provided, no filtering is performed. If $filter is not provided, the unfiltered list includes all policy exemptions associated with the scope, including those that apply directly or apply from containing scopes. If $filter=atScope() is provided, the returned list only includes all policy exemptions that apply to the scope, which is everything in the unfiltered list except those applied to sub scopes contained within the given scope. If $filter=atExactScope() is provided, the returned list only includes all policy exemptions that at the given scope. If $filter=excludeExpired() is provided, the returned list only includes all policy exemptions that either haven&apos;t expired or didn&apos;t set expiration date. If $filter=policyAssignmentId eq &apos;{value}&apos; is provided. the returned list only includes all policy exemptions that are associated with the give policyAssignmentId. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PolicyExemption" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<PolicyExemption> GetAllAsync(string filter = null, CancellationToken cancellationToken = default)
        {
            if (Id.ResourceType == Subscription.ResourceType)
            {
                async Task<Page<PolicyExemption>> FirstPageFunc(int? pageSizeHint)
                {
                    using var scope = _policyExemptionClientDiagnostics.CreateScope("PolicyExemptionCollection.GetAll");
                    scope.Start();
                    try
                    {
                        var response = await _policyExemptionRestClient.ListAsync(Id.SubscriptionId, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                        return Page.FromValues(response.Value.Value.Select(value => new PolicyExemption(ArmClient, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                async Task<Page<PolicyExemption>> NextPageFunc(string nextLink, int? pageSizeHint)
                {
                    using var scope = _policyExemptionClientDiagnostics.CreateScope("PolicyExemptionCollection.GetAll");
                    scope.Start();
                    try
                    {
                        var response = await _policyExemptionRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                        return Page.FromValues(response.Value.Value.Select(value => new PolicyExemption(ArmClient, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
            }
            else if (Id.ResourceType == ResourceGroup.ResourceType)
            {
                async Task<Page<PolicyExemption>> FirstPageFunc(int? pageSizeHint)
                {
                    using var scope = _policyExemptionClientDiagnostics.CreateScope("PolicyExemptionCollection.GetAll");
                    scope.Start();
                    try
                    {
                        var response = await _policyExemptionRestClient.ListForResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                        return Page.FromValues(response.Value.Value.Select(value => new PolicyExemption(ArmClient, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                async Task<Page<PolicyExemption>> NextPageFunc(string nextLink, int? pageSizeHint)
                {
                    using var scope = _policyExemptionClientDiagnostics.CreateScope("PolicyExemptionCollection.GetAll");
                    scope.Start();
                    try
                    {
                        var response = await _policyExemptionRestClient.ListForResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                        return Page.FromValues(response.Value.Value.Select(value => new PolicyExemption(ArmClient, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
            }
            else if (Id.ResourceType == ManagementGroup.ResourceType)
            {
                async Task<Page<PolicyExemption>> FirstPageFunc(int? pageSizeHint)
                {
                    using var scope = _policyExemptionClientDiagnostics.CreateScope("PolicyExemptionCollection.GetAll");
                    scope.Start();
                    try
                    {
                        var response = await _policyExemptionRestClient.ListForManagementGroupAsync(Id.Name, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                        return Page.FromValues(response.Value.Value.Select(value => new PolicyExemption(ArmClient, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                async Task<Page<PolicyExemption>> NextPageFunc(string nextLink, int? pageSizeHint)
                {
                    using var scope = _policyExemptionClientDiagnostics.CreateScope("PolicyExemptionCollection.GetAll");
                    scope.Start();
                    try
                    {
                        var response = await _policyExemptionRestClient.ListForManagementGroupNextPageAsync(nextLink, Id.Name, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                        return Page.FromValues(response.Value.Value.Select(value => new PolicyExemption(ArmClient, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
            }
            else
            {
                async Task<Page<PolicyExemption>> FirstPageFunc(int? pageSizeHint)
                {
                    using var scope = _policyExemptionClientDiagnostics.CreateScope("PolicyExemptionCollection.GetAll");
                    scope.Start();
                    try
                    {
                        var response = await _policyExemptionRestClient.ListForResourceAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.ResourceType.Namespace, Id.Parent.SubstringAfterProviderNamespace(), Id.ResourceType.GetLastType(), Id.Name, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                        return Page.FromValues(response.Value.Value.Select(value => new PolicyExemption(ArmClient, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                async Task<Page<PolicyExemption>> NextPageFunc(string nextLink, int? pageSizeHint)
                {
                    using var scope = _policyExemptionClientDiagnostics.CreateScope("PolicyExemptionCollection.GetAll");
                    scope.Start();
                    try
                    {
                        var response = await _policyExemptionRestClient.ListForResourceNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.ResourceType.Namespace, Id.Parent.SubstringAfterProviderNamespace(), Id.ResourceType.GetLastType(), Id.Name, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                        return Page.FromValues(response.Value.Value.Select(value => new PolicyExemption(ArmClient, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Authorization/policyExemptions
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: PolicyExemptions_List
        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Authorization/policyExemptions
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: PolicyExemptions_ListForResourceGroup
        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{parentResourcePath}/{resourceType}/{resourceName}/providers/Microsoft.Authorization/policyExemptions
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{parentResourcePath}/{resourceType}/{resourceName}
        /// OperationId: PolicyExemptions_ListForResource
        /// RequestPath: /providers/Microsoft.Management/managementGroups/{managementGroupId}/providers/Microsoft.Authorization/policyExemptions
        /// ContextualPath: /providers/Microsoft.Management/managementGroups/{managementGroupId}
        /// OperationId: PolicyExemptions_ListForManagementGroup
        /// <summary> This operation retrieves the list of all policy exemptions associated with the given subscription that match the optional given $filter. Valid values for $filter are: &apos;atScope()&apos;, &apos;atExactScope()&apos;, &apos;excludeExpired()&apos; or &apos;policyAssignmentId eq &apos;{value}&apos;&apos;. If $filter is not provided, the unfiltered list includes all policy exemptions associated with the subscription, including those that apply directly or from management groups that contain the given subscription, as well as any applied to objects contained within the subscription. </summary>
        /// <param name="filter"> The filter to apply on the operation. Valid values for $filter are: &apos;atScope()&apos;, &apos;atExactScope()&apos;, &apos;excludeExpired()&apos; or &apos;policyAssignmentId eq &apos;{value}&apos;&apos;. If $filter is not provided, no filtering is performed. If $filter is not provided, the unfiltered list includes all policy exemptions associated with the scope, including those that apply directly or apply from containing scopes. If $filter=atScope() is provided, the returned list only includes all policy exemptions that apply to the scope, which is everything in the unfiltered list except those applied to sub scopes contained within the given scope. If $filter=atExactScope() is provided, the returned list only includes all policy exemptions that at the given scope. If $filter=excludeExpired() is provided, the returned list only includes all policy exemptions that either haven&apos;t expired or didn&apos;t set expiration date. If $filter=policyAssignmentId eq &apos;{value}&apos; is provided. the returned list only includes all policy exemptions that are associated with the give policyAssignmentId. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PolicyExemption" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<PolicyExemption> GetAll(string filter = null, CancellationToken cancellationToken = default)
        {
            if (Id.ResourceType == Subscription.ResourceType)
            {
                Page<PolicyExemption> FirstPageFunc(int? pageSizeHint)
                {
                    using var scope = _policyExemptionClientDiagnostics.CreateScope("PolicyExemptionCollection.GetAll");
                    scope.Start();
                    try
                    {
                        var response = _policyExemptionRestClient.List(Id.SubscriptionId, filter, cancellationToken: cancellationToken);
                        return Page.FromValues(response.Value.Value.Select(value => new PolicyExemption(ArmClient, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                Page<PolicyExemption> NextPageFunc(string nextLink, int? pageSizeHint)
                {
                    using var scope = _policyExemptionClientDiagnostics.CreateScope("PolicyExemptionCollection.GetAll");
                    scope.Start();
                    try
                    {
                        var response = _policyExemptionRestClient.ListNextPage(nextLink, Id.SubscriptionId, filter, cancellationToken: cancellationToken);
                        return Page.FromValues(response.Value.Value.Select(value => new PolicyExemption(ArmClient, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
            }
            else if (Id.ResourceType == ResourceGroup.ResourceType)
            {
                Page<PolicyExemption> FirstPageFunc(int? pageSizeHint)
                {
                    using var scope = _policyExemptionClientDiagnostics.CreateScope("PolicyExemptionCollection.GetAll");
                    scope.Start();
                    try
                    {
                        var response = _policyExemptionRestClient.ListForResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, filter, cancellationToken: cancellationToken);
                        return Page.FromValues(response.Value.Value.Select(value => new PolicyExemption(ArmClient, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                Page<PolicyExemption> NextPageFunc(string nextLink, int? pageSizeHint)
                {
                    using var scope = _policyExemptionClientDiagnostics.CreateScope("PolicyExemptionCollection.GetAll");
                    scope.Start();
                    try
                    {
                        var response = _policyExemptionRestClient.ListForResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, filter, cancellationToken: cancellationToken);
                        return Page.FromValues(response.Value.Value.Select(value => new PolicyExemption(ArmClient, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
            }
            else if (Id.ResourceType == ManagementGroup.ResourceType)
            {
                Page<PolicyExemption> FirstPageFunc(int? pageSizeHint)
                {
                    using var scope = _policyExemptionClientDiagnostics.CreateScope("PolicyExemptionCollection.GetAll");
                    scope.Start();
                    try
                    {
                        var response = _policyExemptionRestClient.ListForManagementGroup(Id.Name, filter, cancellationToken: cancellationToken);
                        return Page.FromValues(response.Value.Value.Select(value => new PolicyExemption(ArmClient, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                Page<PolicyExemption> NextPageFunc(string nextLink, int? pageSizeHint)
                {
                    using var scope = _policyExemptionClientDiagnostics.CreateScope("PolicyExemptionCollection.GetAll");
                    scope.Start();
                    try
                    {
                        var response = _policyExemptionRestClient.ListForManagementGroupNextPage(nextLink, Id.Name, filter, cancellationToken: cancellationToken);
                        return Page.FromValues(response.Value.Value.Select(value => new PolicyExemption(ArmClient, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
            }
            else
            {
                Page<PolicyExemption> FirstPageFunc(int? pageSizeHint)
                {
                    using var scope = _policyExemptionClientDiagnostics.CreateScope("PolicyExemptionCollection.GetAll");
                    scope.Start();
                    try
                    {
                        var response = _policyExemptionRestClient.ListForResource(Id.SubscriptionId, Id.ResourceGroupName, Id.ResourceType.Namespace, Id.Parent.SubstringAfterProviderNamespace(), Id.ResourceType.GetLastType(), Id.Name, filter, cancellationToken: cancellationToken);
                        return Page.FromValues(response.Value.Value.Select(value => new PolicyExemption(ArmClient, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                Page<PolicyExemption> NextPageFunc(string nextLink, int? pageSizeHint)
                {
                    using var scope = _policyExemptionClientDiagnostics.CreateScope("PolicyExemptionCollection.GetAll");
                    scope.Start();
                    try
                    {
                        var response = _policyExemptionRestClient.ListForResourceNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.ResourceType.Namespace, Id.Parent.SubstringAfterProviderNamespace(), Id.ResourceType.GetLastType(), Id.Name, filter, cancellationToken: cancellationToken);
                        return Page.FromValues(response.Value.Value.Select(value => new PolicyExemption(ArmClient, value)), response.Value.NextLink, response.GetRawResponse());
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

        /// RequestPath: /{scope}/providers/Microsoft.Authorization/policyExemptions/{policyExemptionName}
        /// ContextualPath: /{scope}
        /// OperationId: PolicyExemptions_Get
        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="policyExemptionName"> The name of the policy exemption to delete. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyExemptionName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyExemptionName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string policyExemptionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(policyExemptionName, nameof(policyExemptionName));

            using var scope = _policyExemptionClientDiagnostics.CreateScope("PolicyExemptionCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(policyExemptionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /{scope}/providers/Microsoft.Authorization/policyExemptions/{policyExemptionName}
        /// ContextualPath: /{scope}
        /// OperationId: PolicyExemptions_Get
        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="policyExemptionName"> The name of the policy exemption to delete. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyExemptionName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyExemptionName"/> is null. </exception>
        public virtual Response<bool> Exists(string policyExemptionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(policyExemptionName, nameof(policyExemptionName));

            using var scope = _policyExemptionClientDiagnostics.CreateScope("PolicyExemptionCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(policyExemptionName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /{scope}/providers/Microsoft.Authorization/policyExemptions/{policyExemptionName}
        /// ContextualPath: /{scope}
        /// OperationId: PolicyExemptions_Get
        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="policyExemptionName"> The name of the policy exemption to delete. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyExemptionName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyExemptionName"/> is null. </exception>
        public async virtual Task<Response<PolicyExemption>> GetIfExistsAsync(string policyExemptionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(policyExemptionName, nameof(policyExemptionName));

            using var scope = _policyExemptionClientDiagnostics.CreateScope("PolicyExemptionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _policyExemptionRestClient.GetAsync(Id, policyExemptionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<PolicyExemption>(null, response.GetRawResponse());
                return Response.FromValue(new PolicyExemption(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /{scope}/providers/Microsoft.Authorization/policyExemptions/{policyExemptionName}
        /// ContextualPath: /{scope}
        /// OperationId: PolicyExemptions_Get
        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="policyExemptionName"> The name of the policy exemption to delete. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyExemptionName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyExemptionName"/> is null. </exception>
        public virtual Response<PolicyExemption> GetIfExists(string policyExemptionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(policyExemptionName, nameof(policyExemptionName));

            using var scope = _policyExemptionClientDiagnostics.CreateScope("PolicyExemptionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _policyExemptionRestClient.Get(Id, policyExemptionName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<PolicyExemption>(null, response.GetRawResponse());
                return Response.FromValue(new PolicyExemption(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<PolicyExemption> IEnumerable<PolicyExemption>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<PolicyExemption> IAsyncEnumerable<PolicyExemption>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
