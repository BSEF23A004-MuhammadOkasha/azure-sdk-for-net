// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Core.Resources;

namespace Azure.ResourceManager.NewResources
{
    /// <summary> Extension methods for convenient access on SubscriptionOperations in a client. </summary>
    public static partial class SubscriptionExtensions
    {
        #region DeploymentScript
        private static DeploymentScriptsRestOperations GetDeploymentScriptsRestOperations(ClientDiagnostics clientDiagnostics, TokenCredential credential, ArmClientOptions clientOptions, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            return new DeploymentScriptsRestOperations(clientDiagnostics, pipeline, subscriptionId, endpoint);
        }

        /// <summary> Lists the DeploymentScripts for this Azure.ResourceManager.Core.SubscriptionOperations. </summary>
        /// <param name="subscription"> The <see cref="SubscriptionOperations" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <return> A collection of resource operations that may take multiple service requests to iterate over. </return>
        public static AsyncPageable<DeploymentScript> ListDeploymentScriptAsync(this SubscriptionOperations subscription, CancellationToken cancellationToken = default)
        {
            return subscription.ListResourcesAsync((baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                var restOperations = GetDeploymentScriptsRestOperations(clientDiagnostics, credential, options, pipeline, subscription.Id.SubscriptionId, baseUri);
                var result = ListBySubscriptionAsync(clientDiagnostics, restOperations);
                return new PhWrappingAsyncPageable<DeploymentScriptData, DeploymentScript>(
                result,
                s => new DeploymentScript(subscription, s));
            }
            );
        }

        /// <summary> Lists all deployment scripts for a given subscription. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="restOperations"> Resource client operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        private static AsyncPageable<DeploymentScriptData> ListBySubscriptionAsync(ClientDiagnostics clientDiagnostics, DeploymentScriptsRestOperations restOperations, CancellationToken cancellationToken = default)
        {
            async Task<Page<DeploymentScriptData>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = clientDiagnostics.CreateScope("DeploymentScriptOperations.ListBySubscription");
                scope.Start();
                try
                {
                    var response = await restOperations.ListBySubscriptionAsync(cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<DeploymentScriptData>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = clientDiagnostics.CreateScope("DeploymentScriptOperations.ListBySubscription");
                scope.Start();
                try
                {
                    var response = await restOperations.ListBySubscriptionNextPageAsync(nextLink, cancellationToken).ConfigureAwait(false);
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

        /// <summary> Lists the DeploymentScripts for this Azure.ResourceManager.Core.SubscriptionOperations. </summary>
        /// <param name="subscription"> The <see cref="SubscriptionOperations" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <return> A collection of resource operations that may take multiple service requests to iterate over. </return>
        public static Pageable<DeploymentScript> ListDeploymentScript(this SubscriptionOperations subscription, CancellationToken cancellationToken = default)
        {
            return subscription.ListResources((baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                var restOperations = GetDeploymentScriptsRestOperations(clientDiagnostics, credential, options, pipeline, subscription.Id.SubscriptionId, baseUri);
                var result = ListBySubscription(clientDiagnostics, restOperations);
                return new PhWrappingPageable<DeploymentScriptData, DeploymentScript>(
                result,
                s => new DeploymentScript(subscription, s));
            }
            );
        }

        /// <summary> Lists all deployment scripts for a given subscription. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="restOperations"> Resource client operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        private static Pageable<DeploymentScriptData> ListBySubscription(ClientDiagnostics clientDiagnostics, DeploymentScriptsRestOperations restOperations, CancellationToken cancellationToken = default)
        {
            Page<DeploymentScriptData> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = clientDiagnostics.CreateScope("DeploymentScriptOperations.ListBySubscription");
                scope.Start();
                try
                {
                    var response = restOperations.ListBySubscription(cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<DeploymentScriptData> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = clientDiagnostics.CreateScope("DeploymentScriptOperations.ListBySubscription");
                scope.Start();
                try
                {
                    var response = restOperations.ListBySubscriptionNextPage(nextLink, cancellationToken);
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

        /// <summary> Filters the list of DeploymentScripts for a Azure.ResourceManager.Core.SubscriptionOperations represented as generic resources. </summary>
        /// <param name="subscription"> The <see cref="SubscriptionOperations" /> instance the method will execute against. </param>
        /// <param name="filter"> The string to filter the list. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <return> A collection of resource operations that may take multiple service requests to iterate over. </return>
        public static AsyncPageable<Core.GenericResource> ListDeploymentScriptByNameAsync(this SubscriptionOperations subscription, string filter, int? top, CancellationToken cancellationToken = default)
        {
            ResourceFilterCollection filters = new(DeploymentScriptOperations.ResourceType);
            filters.SubstringFilter = filter;
            return ResourceListOperations.ListAtContextAsync(subscription, filters, top, cancellationToken);
        }

        /// <summary> Filters the list of DeploymentScripts for a Azure.ResourceManager.Core.SubscriptionOperations represented as generic resources. </summary>
        /// <param name="subscription"> The <see cref="SubscriptionOperations" /> instance the method will execute against. </param>
        /// <param name="filter"> The string to filter the list. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <return> A collection of resource operations that may take multiple service requests to iterate over. </return>
        public static Pageable<Core.GenericResource> ListDeploymentScriptByName(this SubscriptionOperations subscription, string filter, int? top, CancellationToken cancellationToken = default)
        {
            ResourceFilterCollection filters = new(DeploymentScriptOperations.ResourceType);
            filters.SubstringFilter = filter;
            return ResourceListOperations.ListAtContext(subscription, filters, top, cancellationToken);
        }
        #endregion

        #region Application
        private static ApplicationsRestOperations GetApplicationsRestOperations(ClientDiagnostics clientDiagnostics, TokenCredential credential, ArmClientOptions clientOptions, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            return new ApplicationsRestOperations(clientDiagnostics, pipeline, subscriptionId, endpoint);
        }

        /// <summary> Lists the Applications for this Azure.ResourceManager.Core.SubscriptionOperations. </summary>
        /// <param name="subscription"> The <see cref="SubscriptionOperations" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <return> A collection of resource operations that may take multiple service requests to iterate over. </return>
        public static AsyncPageable<Application> ListApplicationAsync(this SubscriptionOperations subscription, CancellationToken cancellationToken = default)
        {
            return subscription.ListResourcesAsync((baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                var restOperations = GetApplicationsRestOperations(clientDiagnostics, credential, options, pipeline, subscription.Id.SubscriptionId, baseUri);
                var result = ListBySubscriptionAsync(clientDiagnostics, restOperations);
                return new PhWrappingAsyncPageable<ApplicationData, Application>(
                result,
                s => new Application(subscription, s));
            }
            );
        }

        /// <summary> Gets all the applications within a subscription. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="restOperations"> Resource client operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        private static AsyncPageable<ApplicationData> ListBySubscriptionAsync(ClientDiagnostics clientDiagnostics, ApplicationsRestOperations restOperations, CancellationToken cancellationToken = default)
        {
            async Task<Page<ApplicationData>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = clientDiagnostics.CreateScope("ApplicationOperations.ListBySubscription");
                scope.Start();
                try
                {
                    var response = await restOperations.ListBySubscriptionAsync(cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ApplicationData>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = clientDiagnostics.CreateScope("ApplicationOperations.ListBySubscription");
                scope.Start();
                try
                {
                    var response = await restOperations.ListBySubscriptionNextPageAsync(nextLink, cancellationToken).ConfigureAwait(false);
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

        /// <summary> Lists the Applications for this Azure.ResourceManager.Core.SubscriptionOperations. </summary>
        /// <param name="subscription"> The <see cref="SubscriptionOperations" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <return> A collection of resource operations that may take multiple service requests to iterate over. </return>
        public static Pageable<Application> ListApplication(this SubscriptionOperations subscription, CancellationToken cancellationToken = default)
        {
            return subscription.ListResources<Application>((baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                var restOperations = GetApplicationsRestOperations(clientDiagnostics, credential, options, pipeline, subscription.Id.SubscriptionId, baseUri);
                var result = ListBySubscription(clientDiagnostics, restOperations);
                return new PhWrappingPageable<ApplicationData, Application>(
                result,
                s => new Application(subscription, s));
            }
            );
        }

        /// <summary> Gets all the applications within a subscription. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="restOperations"> Resource client operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        private static Pageable<ApplicationData> ListBySubscription(ClientDiagnostics clientDiagnostics, ApplicationsRestOperations restOperations, CancellationToken cancellationToken = default)
        {
            Page<ApplicationData> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = clientDiagnostics.CreateScope("ApplicationOperations.ListBySubscription");
                scope.Start();
                try
                {
                    var response = restOperations.ListBySubscription(cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ApplicationData> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = clientDiagnostics.CreateScope("ApplicationOperations.ListBySubscription");
                scope.Start();
                try
                {
                    var response = restOperations.ListBySubscriptionNextPage(nextLink, cancellationToken);
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

        /// <summary> Filters the list of Applications for a Azure.ResourceManager.Core.SubscriptionOperations represented as generic resources. </summary>
        /// <param name="subscription"> The <see cref="SubscriptionOperations" /> instance the method will execute against. </param>
        /// <param name="filter"> The string to filter the list. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <return> A collection of resource operations that may take multiple service requests to iterate over. </return>
        public static AsyncPageable<Core.GenericResource> ListApplicationByNameAsync(this SubscriptionOperations subscription, string filter, int? top, CancellationToken cancellationToken = default)
        {
            ResourceFilterCollection filters = new(ApplicationOperations.ResourceType);
            filters.SubstringFilter = filter;
            return ResourceListOperations.ListAtContextAsync(subscription, filters, top, cancellationToken);
        }

        /// <summary> Filters the list of Applications for a Azure.ResourceManager.Core.SubscriptionOperations represented as generic resources. </summary>
        /// <param name="subscription"> The <see cref="SubscriptionOperations" /> instance the method will execute against. </param>
        /// <param name="filter"> The string to filter the list. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <return> A collection of resource operations that may take multiple service requests to iterate over. </return>
        public static Pageable<Core.GenericResource> ListApplicationByName(this SubscriptionOperations subscription, string filter, int? top, CancellationToken cancellationToken = default)
        {
            ResourceFilterCollection filters = new(ApplicationOperations.ResourceType);
            filters.SubstringFilter = filter;
            return ResourceListOperations.ListAtContext(subscription, filters, top, cancellationToken);
        }
        #endregion

        #region PolicyAssignment
        private static PolicyAssignmentsRestOperations GetPolicyAssignmentsRestOperations(ClientDiagnostics clientDiagnostics, TokenCredential credential, ArmClientOptions clientOptions, HttpPipeline pipeline, Uri endpoint = null)
        {
            return new PolicyAssignmentsRestOperations(clientDiagnostics, pipeline, endpoint);
        }

        /// <summary> Lists the PolicyAssignment for this Azure.ResourceManager.Core.SubscriptionOperations. </summary>
        /// <param name="subscription"> The <see cref="SubscriptionOperations" /> instance the method will execute against. </param>
        /// <param name="filter"> The filter to apply on the operation. Valid values for $filter are: &apos;atScope()&apos; or &apos;policyDefinitionId eq &apos;{value}&apos;&apos;. If $filter is not provided, no filtering is performed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <return> A collection of resource operations that may take multiple service requests to iterate over. </return>
        public static Pageable<PolicyAssignment> ListPolicyAssignment(this SubscriptionOperations subscription, string filter = null, CancellationToken cancellationToken = default)
        {
            return subscription.ListResources((baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                var restOperations = GetPolicyAssignmentsRestOperations(clientDiagnostics, credential, options, pipeline, baseUri);
                var result = ListForSubscription(clientDiagnostics, restOperations, subscription.Id.SubscriptionId, filter, cancellationToken);
                return new PhWrappingPageable<PolicyAssignmentData, PolicyAssignment>(
                result,
                s => new PolicyAssignment(subscription, s));
            }
            );
        }

        public static AsyncPageable<PolicyAssignment> ListPolicyAssignmentAsync(this SubscriptionOperations subscription, string filter = null, CancellationToken cancellationToken = default)
        {
            return subscription.ListResourcesAsync((baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                var restOperations = GetPolicyAssignmentsRestOperations(clientDiagnostics, credential, options, pipeline, baseUri);
                var result = ListForSubscriptionAsync(clientDiagnostics, restOperations, subscription.Id.SubscriptionId, filter, cancellationToken);
                return new PhWrappingAsyncPageable<PolicyAssignmentData, PolicyAssignment>(
                result,
                s => new PolicyAssignment(subscription, s));
            }
            );
        }

        /// <summary> This operation retrieves the list of all policy assignments associated with the given subscription that match the optional given $filter. Valid values for $filter are: &apos;atScope()&apos; or &apos;policyDefinitionId eq &apos;{value}&apos;&apos;. If $filter is not provided, the unfiltered list includes all policy assignments associated with the subscription, including those that apply directly or from management groups that contain the given subscription, as well as any applied to objects contained within the subscription. If $filter=atScope() is provided, the returned list includes all policy assignments that apply to the subscription, which is everything in the unfiltered list except those applied to objects contained within the subscription. If $filter=policyDefinitionId eq &apos;{value}&apos; is provided, the returned list includes all policy assignments of the policy definition whose id is {value}. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="restOperations"> Resource client operations. </param>
        /// <param name="filter"> The filter to apply on the operation. Valid values for $filter are: &apos;atScope()&apos; or &apos;policyDefinitionId eq &apos;{value}&apos;&apos;. If $filter is not provided, no filtering is performed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <param name="subscriptionId"> The Microsoft Azure subscription ID. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> is null. </exception>
        /// <returns> A collection of <see cref="PolicyAssignment" /> that may take multiple service requests to iterate over. </returns>
        private static Pageable<PolicyAssignmentData> ListForSubscription(ClientDiagnostics clientDiagnostics, PolicyAssignmentsRestOperations restOperations, string subscriptionId, string filter = null, CancellationToken cancellationToken = default)
        {
            Page<PolicyAssignmentData> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = clientDiagnostics.CreateScope("PolicyAssignmentTenantContainer.List");
                scope.Start();
                try
                {
                    var response = restOperations.List(subscriptionId, filter, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<PolicyAssignmentData> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = clientDiagnostics.CreateScope("PolicyAssignmentTenantContainer.List");
                scope.Start();
                try
                {
                    var response = restOperations.ListNextPage(nextLink, filter, cancellationToken: cancellationToken);
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

        /// <summary> This operation retrieves the list of all policy assignments associated with the given subscription that match the optional given $filter. Valid values for $filter are: &apos;atScope()&apos; or &apos;policyDefinitionId eq &apos;{value}&apos;&apos;. If $filter is not provided, the unfiltered list includes all policy assignments associated with the subscription, including those that apply directly or from management groups that contain the given subscription, as well as any applied to objects contained within the subscription. If $filter=atScope() is provided, the returned list includes all policy assignments that apply to the subscription, which is everything in the unfiltered list except those applied to objects contained within the subscription. If $filter=policyDefinitionId eq &apos;{value}&apos; is provided, the returned list includes all policy assignments of the policy definition whose id is {value}. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="restOperations"> Resource client operations. </param>
        /// <param name="filter"> The filter to apply on the operation. Valid values for $filter are: &apos;atScope()&apos; or &apos;policyDefinitionId eq &apos;{value}&apos;&apos;. If $filter is not provided, no filtering is performed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <param name="subscriptionId"> The Microsoft Azure subscription ID. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> is null. </exception>
        /// <returns> An async collection of <see cref="PolicyAssignment" /> that may take multiple service requests to iterate over. </returns>
        private static AsyncPageable<PolicyAssignmentData> ListForSubscriptionAsync(ClientDiagnostics clientDiagnostics, PolicyAssignmentsRestOperations restOperations, string subscriptionId, string filter = null, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            async Task<Page<PolicyAssignmentData>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = clientDiagnostics.CreateScope("PolicyAssignmentTenantContainer.List");
                scope.Start();
                try
                {
                    var response = await restOperations.ListAsync(subscriptionId, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<PolicyAssignmentData>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = clientDiagnostics.CreateScope("PolicyAssignmentTenantContainer.List");
                scope.Start();
                try
                {
                    var response = await restOperations.ListNextPageAsync(nextLink, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        #endregion
    }
}
