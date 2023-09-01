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

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing a collection of <see cref="SecurityRuleResource" /> and their operations.
    /// Each <see cref="SecurityRuleResource" /> in the collection will belong to the same instance of <see cref="NetworkSecurityGroupResource" />.
    /// To get a <see cref="SecurityRuleCollection" /> instance call the GetSecurityRules method from an instance of <see cref="NetworkSecurityGroupResource" />.
    /// </summary>
    public partial class SecurityRuleCollection : ArmCollection, IEnumerable<SecurityRuleResource>, IAsyncEnumerable<SecurityRuleResource>
    {
        private readonly ClientDiagnostics _securityRuleClientDiagnostics;
        private readonly SecurityRulesRestOperations _securityRuleRestClient;

        /// <summary> Initializes a new instance of the <see cref="SecurityRuleCollection"/> class for mocking. </summary>
        protected SecurityRuleCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SecurityRuleCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SecurityRuleCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _securityRuleClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", SecurityRuleResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SecurityRuleResource.ResourceType, out string securityRuleApiVersion);
            _securityRuleRestClient = new SecurityRulesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, securityRuleApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != NetworkSecurityGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, NetworkSecurityGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a security rule in the specified network security group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkSecurityGroups/{networkSecurityGroupName}/securityRules/{securityRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SecurityRules_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="securityRuleName"> The name of the security rule. </param>
        /// <param name="data"> Parameters supplied to the create or update network security rule operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="securityRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="securityRuleName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SecurityRuleResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string securityRuleName, SecurityRuleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(securityRuleName, nameof(securityRuleName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _securityRuleClientDiagnostics.CreateScope("SecurityRuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _securityRuleRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, securityRuleName, data, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<SecurityRuleResource>(new SecurityRuleOperationSource(Client), _securityRuleClientDiagnostics, Pipeline, _securityRuleRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, securityRuleName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates or updates a security rule in the specified network security group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkSecurityGroups/{networkSecurityGroupName}/securityRules/{securityRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SecurityRules_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="securityRuleName"> The name of the security rule. </param>
        /// <param name="data"> Parameters supplied to the create or update network security rule operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="securityRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="securityRuleName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SecurityRuleResource> CreateOrUpdate(WaitUntil waitUntil, string securityRuleName, SecurityRuleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(securityRuleName, nameof(securityRuleName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _securityRuleClientDiagnostics.CreateScope("SecurityRuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _securityRuleRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, securityRuleName, data, cancellationToken);
                var operation = new NetworkArmOperation<SecurityRuleResource>(new SecurityRuleOperationSource(Client), _securityRuleClientDiagnostics, Pipeline, _securityRuleRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, securityRuleName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Get the specified network security rule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkSecurityGroups/{networkSecurityGroupName}/securityRules/{securityRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SecurityRules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="securityRuleName"> The name of the security rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="securityRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="securityRuleName"/> is null. </exception>
        public virtual async Task<Response<SecurityRuleResource>> GetAsync(string securityRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(securityRuleName, nameof(securityRuleName));

            using var scope = _securityRuleClientDiagnostics.CreateScope("SecurityRuleCollection.Get");
            scope.Start();
            try
            {
                var response = await _securityRuleRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, securityRuleName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SecurityRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the specified network security rule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkSecurityGroups/{networkSecurityGroupName}/securityRules/{securityRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SecurityRules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="securityRuleName"> The name of the security rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="securityRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="securityRuleName"/> is null. </exception>
        public virtual Response<SecurityRuleResource> Get(string securityRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(securityRuleName, nameof(securityRuleName));

            using var scope = _securityRuleClientDiagnostics.CreateScope("SecurityRuleCollection.Get");
            scope.Start();
            try
            {
                var response = _securityRuleRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, securityRuleName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SecurityRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all security rules in a network security group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkSecurityGroups/{networkSecurityGroupName}/securityRules</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SecurityRules_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SecurityRuleResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SecurityRuleResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _securityRuleRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _securityRuleRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new SecurityRuleResource(Client, SecurityRuleData.DeserializeSecurityRuleData(e)), _securityRuleClientDiagnostics, Pipeline, "SecurityRuleCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets all security rules in a network security group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkSecurityGroups/{networkSecurityGroupName}/securityRules</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SecurityRules_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SecurityRuleResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SecurityRuleResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _securityRuleRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _securityRuleRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new SecurityRuleResource(Client, SecurityRuleData.DeserializeSecurityRuleData(e)), _securityRuleClientDiagnostics, Pipeline, "SecurityRuleCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkSecurityGroups/{networkSecurityGroupName}/securityRules/{securityRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SecurityRules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="securityRuleName"> The name of the security rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="securityRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="securityRuleName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string securityRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(securityRuleName, nameof(securityRuleName));

            using var scope = _securityRuleClientDiagnostics.CreateScope("SecurityRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = await _securityRuleRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, securityRuleName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkSecurityGroups/{networkSecurityGroupName}/securityRules/{securityRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SecurityRules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="securityRuleName"> The name of the security rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="securityRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="securityRuleName"/> is null. </exception>
        public virtual Response<bool> Exists(string securityRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(securityRuleName, nameof(securityRuleName));

            using var scope = _securityRuleClientDiagnostics.CreateScope("SecurityRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = _securityRuleRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, securityRuleName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SecurityRuleResource> IEnumerable<SecurityRuleResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SecurityRuleResource> IAsyncEnumerable<SecurityRuleResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
