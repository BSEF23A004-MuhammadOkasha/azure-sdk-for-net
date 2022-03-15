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
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A Class representing a DataMaskingPolicy along with the instance operations that can be performed on it. </summary>
    public partial class DataMaskingPolicy : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="DataMaskingPolicy"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serverName, string databaseName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/dataMaskingPolicies/Default";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _dataMaskingPolicyClientDiagnostics;
        private readonly DataMaskingPoliciesRestOperations _dataMaskingPolicyRestClient;
        private readonly ClientDiagnostics _dataMaskingRulesClientDiagnostics;
        private readonly DataMaskingRulesRestOperations _dataMaskingRulesRestClient;
        private readonly DataMaskingPolicyData _data;

        /// <summary> Initializes a new instance of the <see cref="DataMaskingPolicy"/> class for mocking. </summary>
        protected DataMaskingPolicy()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "DataMaskingPolicy"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal DataMaskingPolicy(ArmClient client, DataMaskingPolicyData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="DataMaskingPolicy"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal DataMaskingPolicy(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _dataMaskingPolicyClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(ResourceType, out string dataMaskingPolicyApiVersion);
            _dataMaskingPolicyRestClient = new DataMaskingPoliciesRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, dataMaskingPolicyApiVersion);
            _dataMaskingRulesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ProviderConstants.DefaultProviderNamespace, DiagnosticOptions);
            _dataMaskingRulesRestClient = new DataMaskingRulesRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Sql/servers/databases/dataMaskingPolicies";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual DataMaskingPolicyData Data
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

        /// <summary>
        /// Gets a database data masking policy.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/dataMaskingPolicies/Default
        /// Operation Id: DataMaskingPolicies_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<DataMaskingPolicy>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _dataMaskingPolicyClientDiagnostics.CreateScope("DataMaskingPolicy.Get");
            scope.Start();
            try
            {
                var response = await _dataMaskingPolicyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataMaskingPolicy(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a database data masking policy.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/dataMaskingPolicies/Default
        /// Operation Id: DataMaskingPolicies_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DataMaskingPolicy> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _dataMaskingPolicyClientDiagnostics.CreateScope("DataMaskingPolicy.Get");
            scope.Start();
            try
            {
                var response = _dataMaskingPolicyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataMaskingPolicy(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates a database data masking policy
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/dataMaskingPolicies/Default
        /// Operation Id: DataMaskingPolicies_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="parameters"> Parameters for creating or updating a data masking policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public virtual async Task<ArmOperation<DataMaskingPolicy>> CreateOrUpdateAsync(WaitUntil waitUntil, DataMaskingPolicyData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _dataMaskingPolicyClientDiagnostics.CreateScope("DataMaskingPolicy.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _dataMaskingPolicyRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation<DataMaskingPolicy>(Response.FromValue(new DataMaskingPolicy(Client, response), response.GetRawResponse()));
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
        /// Creates or updates a database data masking policy
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/dataMaskingPolicies/Default
        /// Operation Id: DataMaskingPolicies_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="parameters"> Parameters for creating or updating a data masking policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public virtual ArmOperation<DataMaskingPolicy> CreateOrUpdate(WaitUntil waitUntil, DataMaskingPolicyData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _dataMaskingPolicyClientDiagnostics.CreateScope("DataMaskingPolicy.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _dataMaskingPolicyRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, parameters, cancellationToken);
                var operation = new SqlArmOperation<DataMaskingPolicy>(Response.FromValue(new DataMaskingPolicy(Client, response), response.GetRawResponse()));
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
        /// Creates or updates a database data masking rule.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/dataMaskingPolicies/Default/rules/{dataMaskingRuleName}
        /// Operation Id: DataMaskingRules_CreateOrUpdate
        /// </summary>
        /// <param name="dataMaskingRuleName"> The name of the data masking rule. </param>
        /// <param name="parameters"> The required parameters for creating or updating a data masking rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataMaskingRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataMaskingRuleName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual async Task<Response<DataMaskingRule>> CreateOrUpdateDataMaskingRuleAsync(string dataMaskingRuleName, DataMaskingRule parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataMaskingRuleName, nameof(dataMaskingRuleName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _dataMaskingRulesClientDiagnostics.CreateScope("DataMaskingPolicy.CreateOrUpdateDataMaskingRule");
            scope.Start();
            try
            {
                var response = await _dataMaskingRulesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, dataMaskingRuleName, parameters, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates a database data masking rule.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/dataMaskingPolicies/Default/rules/{dataMaskingRuleName}
        /// Operation Id: DataMaskingRules_CreateOrUpdate
        /// </summary>
        /// <param name="dataMaskingRuleName"> The name of the data masking rule. </param>
        /// <param name="parameters"> The required parameters for creating or updating a data masking rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataMaskingRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataMaskingRuleName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual Response<DataMaskingRule> CreateOrUpdateDataMaskingRule(string dataMaskingRuleName, DataMaskingRule parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataMaskingRuleName, nameof(dataMaskingRuleName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _dataMaskingRulesClientDiagnostics.CreateScope("DataMaskingPolicy.CreateOrUpdateDataMaskingRule");
            scope.Start();
            try
            {
                var response = _dataMaskingRulesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, dataMaskingRuleName, parameters, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of database data masking rules.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/dataMaskingPolicies/Default/rules
        /// Operation Id: DataMaskingRules_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DataMaskingRule" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DataMaskingRule> GetDataMaskingRulesAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<DataMaskingRule>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _dataMaskingRulesClientDiagnostics.CreateScope("DataMaskingPolicy.GetDataMaskingRules");
                scope.Start();
                try
                {
                    var response = await _dataMaskingRulesRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Gets a list of database data masking rules.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/dataMaskingPolicies/Default/rules
        /// Operation Id: DataMaskingRules_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DataMaskingRule" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DataMaskingRule> GetDataMaskingRules(CancellationToken cancellationToken = default)
        {
            Page<DataMaskingRule> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _dataMaskingRulesClientDiagnostics.CreateScope("DataMaskingPolicy.GetDataMaskingRules");
                scope.Start();
                try
                {
                    var response = _dataMaskingRulesRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }
    }
}
