// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Security
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for JitNetworkAccessPoliciesOperations.
    /// </summary>
    public static partial class JitNetworkAccessPoliciesOperationsExtensions
    {
            /// <summary>
            /// Policies for protecting resources using Just-in-Time access control.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<JitNetworkAccessPolicy> List(this IJitNetworkAccessPoliciesOperations operations)
            {
                return operations.ListAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Policies for protecting resources using Just-in-Time access control.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<JitNetworkAccessPolicy>> ListAsync(this IJitNetworkAccessPoliciesOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Policies for protecting resources using Just-in-Time access control for the
            /// subscription, location
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='ascLocation'>
            /// The location where ASC stores the data of the subscription. can be
            /// retrieved from Get locations
            /// </param>
            public static IPage<JitNetworkAccessPolicy> ListByRegion(this IJitNetworkAccessPoliciesOperations operations, string ascLocation)
            {
                return operations.ListByRegionAsync(ascLocation).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Policies for protecting resources using Just-in-Time access control for the
            /// subscription, location
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='ascLocation'>
            /// The location where ASC stores the data of the subscription. can be
            /// retrieved from Get locations
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<JitNetworkAccessPolicy>> ListByRegionAsync(this IJitNetworkAccessPoliciesOperations operations, string ascLocation, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByRegionWithHttpMessagesAsync(ascLocation, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Policies for protecting resources using Just-in-Time access control for the
            /// subscription, location
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            public static IPage<JitNetworkAccessPolicy> ListByResourceGroup(this IJitNetworkAccessPoliciesOperations operations, string resourceGroupName)
            {
                return operations.ListByResourceGroupAsync(resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Policies for protecting resources using Just-in-Time access control for the
            /// subscription, location
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<JitNetworkAccessPolicy>> ListByResourceGroupAsync(this IJitNetworkAccessPoliciesOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Policies for protecting resources using Just-in-Time access control for the
            /// subscription, location
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='ascLocation'>
            /// The location where ASC stores the data of the subscription. can be
            /// retrieved from Get locations
            /// </param>
            public static IPage<JitNetworkAccessPolicy> ListByResourceGroupAndRegion(this IJitNetworkAccessPoliciesOperations operations, string resourceGroupName, string ascLocation)
            {
                return operations.ListByResourceGroupAndRegionAsync(resourceGroupName, ascLocation).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Policies for protecting resources using Just-in-Time access control for the
            /// subscription, location
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='ascLocation'>
            /// The location where ASC stores the data of the subscription. can be
            /// retrieved from Get locations
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<JitNetworkAccessPolicy>> ListByResourceGroupAndRegionAsync(this IJitNetworkAccessPoliciesOperations operations, string resourceGroupName, string ascLocation, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupAndRegionWithHttpMessagesAsync(resourceGroupName, ascLocation, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Policies for protecting resources using Just-in-Time access control for the
            /// subscription, location
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='ascLocation'>
            /// The location where ASC stores the data of the subscription. can be
            /// retrieved from Get locations
            /// </param>
            /// <param name='jitNetworkAccessPolicyName'>
            /// Name of a Just-in-Time access configuration policy.
            /// </param>
            public static JitNetworkAccessPolicy Get(this IJitNetworkAccessPoliciesOperations operations, string resourceGroupName, string ascLocation, string jitNetworkAccessPolicyName)
            {
                return operations.GetAsync(resourceGroupName, ascLocation, jitNetworkAccessPolicyName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Policies for protecting resources using Just-in-Time access control for the
            /// subscription, location
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='ascLocation'>
            /// The location where ASC stores the data of the subscription. can be
            /// retrieved from Get locations
            /// </param>
            /// <param name='jitNetworkAccessPolicyName'>
            /// Name of a Just-in-Time access configuration policy.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<JitNetworkAccessPolicy> GetAsync(this IJitNetworkAccessPoliciesOperations operations, string resourceGroupName, string ascLocation, string jitNetworkAccessPolicyName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, ascLocation, jitNetworkAccessPolicyName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create a policy for protecting resources using Just-in-Time access control
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='ascLocation'>
            /// The location where ASC stores the data of the subscription. can be
            /// retrieved from Get locations
            /// </param>
            /// <param name='jitNetworkAccessPolicyName'>
            /// Name of a Just-in-Time access configuration policy.
            /// </param>
            /// <param name='body'>
            /// </param>
            public static JitNetworkAccessPolicy CreateOrUpdate(this IJitNetworkAccessPoliciesOperations operations, string resourceGroupName, string ascLocation, string jitNetworkAccessPolicyName, JitNetworkAccessPolicy body)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, ascLocation, jitNetworkAccessPolicyName, body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create a policy for protecting resources using Just-in-Time access control
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='ascLocation'>
            /// The location where ASC stores the data of the subscription. can be
            /// retrieved from Get locations
            /// </param>
            /// <param name='jitNetworkAccessPolicyName'>
            /// Name of a Just-in-Time access configuration policy.
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<JitNetworkAccessPolicy> CreateOrUpdateAsync(this IJitNetworkAccessPoliciesOperations operations, string resourceGroupName, string ascLocation, string jitNetworkAccessPolicyName, JitNetworkAccessPolicy body, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, ascLocation, jitNetworkAccessPolicyName, body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete a Just-in-Time access control policy.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='ascLocation'>
            /// The location where ASC stores the data of the subscription. can be
            /// retrieved from Get locations
            /// </param>
            /// <param name='jitNetworkAccessPolicyName'>
            /// Name of a Just-in-Time access configuration policy.
            /// </param>
            public static void Delete(this IJitNetworkAccessPoliciesOperations operations, string resourceGroupName, string ascLocation, string jitNetworkAccessPolicyName)
            {
                operations.DeleteAsync(resourceGroupName, ascLocation, jitNetworkAccessPolicyName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete a Just-in-Time access control policy.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='ascLocation'>
            /// The location where ASC stores the data of the subscription. can be
            /// retrieved from Get locations
            /// </param>
            /// <param name='jitNetworkAccessPolicyName'>
            /// Name of a Just-in-Time access configuration policy.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IJitNetworkAccessPoliciesOperations operations, string resourceGroupName, string ascLocation, string jitNetworkAccessPolicyName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, ascLocation, jitNetworkAccessPolicyName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Initiate a JIT access from a specific Just-in-Time policy configuration.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='ascLocation'>
            /// The location where ASC stores the data of the subscription. can be
            /// retrieved from Get locations
            /// </param>
            /// <param name='jitNetworkAccessPolicyName'>
            /// Name of a Just-in-Time access configuration policy.
            /// </param>
            /// <param name='virtualMachines'>
            /// A list of virtual machines &amp; ports to open access for
            /// </param>
            /// <param name='justification'>
            /// The justification for making the initiate request
            /// </param>
            public static JitNetworkAccessRequest Initiate(this IJitNetworkAccessPoliciesOperations operations, string resourceGroupName, string ascLocation, string jitNetworkAccessPolicyName, IList<JitNetworkAccessPolicyInitiateVirtualMachine> virtualMachines, string justification = default(string))
            {
                return operations.InitiateAsync(resourceGroupName, ascLocation, jitNetworkAccessPolicyName, virtualMachines, justification).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Initiate a JIT access from a specific Just-in-Time policy configuration.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='ascLocation'>
            /// The location where ASC stores the data of the subscription. can be
            /// retrieved from Get locations
            /// </param>
            /// <param name='jitNetworkAccessPolicyName'>
            /// Name of a Just-in-Time access configuration policy.
            /// </param>
            /// <param name='virtualMachines'>
            /// A list of virtual machines &amp; ports to open access for
            /// </param>
            /// <param name='justification'>
            /// The justification for making the initiate request
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<JitNetworkAccessRequest> InitiateAsync(this IJitNetworkAccessPoliciesOperations operations, string resourceGroupName, string ascLocation, string jitNetworkAccessPolicyName, IList<JitNetworkAccessPolicyInitiateVirtualMachine> virtualMachines, string justification = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.InitiateWithHttpMessagesAsync(resourceGroupName, ascLocation, jitNetworkAccessPolicyName, virtualMachines, justification, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Policies for protecting resources using Just-in-Time access control.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<JitNetworkAccessPolicy> ListNext(this IJitNetworkAccessPoliciesOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Policies for protecting resources using Just-in-Time access control.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<JitNetworkAccessPolicy>> ListNextAsync(this IJitNetworkAccessPoliciesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Policies for protecting resources using Just-in-Time access control for the
            /// subscription, location
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<JitNetworkAccessPolicy> ListByRegionNext(this IJitNetworkAccessPoliciesOperations operations, string nextPageLink)
            {
                return operations.ListByRegionNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Policies for protecting resources using Just-in-Time access control for the
            /// subscription, location
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<JitNetworkAccessPolicy>> ListByRegionNextAsync(this IJitNetworkAccessPoliciesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByRegionNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Policies for protecting resources using Just-in-Time access control for the
            /// subscription, location
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<JitNetworkAccessPolicy> ListByResourceGroupNext(this IJitNetworkAccessPoliciesOperations operations, string nextPageLink)
            {
                return operations.ListByResourceGroupNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Policies for protecting resources using Just-in-Time access control for the
            /// subscription, location
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<JitNetworkAccessPolicy>> ListByResourceGroupNextAsync(this IJitNetworkAccessPoliciesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Policies for protecting resources using Just-in-Time access control for the
            /// subscription, location
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<JitNetworkAccessPolicy> ListByResourceGroupAndRegionNext(this IJitNetworkAccessPoliciesOperations operations, string nextPageLink)
            {
                return operations.ListByResourceGroupAndRegionNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Policies for protecting resources using Just-in-Time access control for the
            /// subscription, location
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<JitNetworkAccessPolicy>> ListByResourceGroupAndRegionNextAsync(this IJitNetworkAccessPoliciesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupAndRegionNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
