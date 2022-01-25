// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DevTestLabs
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Azure.OData;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for GlobalSchedulesOperations.
    /// </summary>
    public static partial class GlobalSchedulesOperationsExtensions
    {
            /// <summary>
            /// List schedules in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            public static IPage<Schedule> ListBySubscription(this IGlobalSchedulesOperations operations, ODataQuery<Schedule> odataQuery = default(ODataQuery<Schedule>))
            {
                return operations.ListBySubscriptionAsync(odataQuery).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List schedules in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Schedule>> ListBySubscriptionAsync(this IGlobalSchedulesOperations operations, ODataQuery<Schedule> odataQuery = default(ODataQuery<Schedule>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListBySubscriptionWithHttpMessagesAsync(odataQuery, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List schedules in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            public static IPage<Schedule> ListByResourceGroup(this IGlobalSchedulesOperations operations, string resourceGroupName, ODataQuery<Schedule> odataQuery = default(ODataQuery<Schedule>))
            {
                return operations.ListByResourceGroupAsync(resourceGroupName, odataQuery).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List schedules in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Schedule>> ListByResourceGroupAsync(this IGlobalSchedulesOperations operations, string resourceGroupName, ODataQuery<Schedule> odataQuery = default(ODataQuery<Schedule>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupWithHttpMessagesAsync(resourceGroupName, odataQuery, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get schedule.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='name'>
            /// The name of the schedule.
            /// </param>
            public static Schedule Get(this IGlobalSchedulesOperations operations, string resourceGroupName, string name)
            {
                return operations.GetAsync(resourceGroupName, name).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get schedule.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='name'>
            /// The name of the schedule.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Schedule> GetAsync(this IGlobalSchedulesOperations operations, string resourceGroupName, string name, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, name, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or replace an existing schedule.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='name'>
            /// The name of the schedule.
            /// </param>
            /// <param name='schedule'>
            /// A schedule.
            /// </param>
            public static Schedule CreateOrUpdate(this IGlobalSchedulesOperations operations, string resourceGroupName, string name, Schedule schedule)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, name, schedule).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or replace an existing schedule.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='name'>
            /// The name of the schedule.
            /// </param>
            /// <param name='schedule'>
            /// A schedule.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Schedule> CreateOrUpdateAsync(this IGlobalSchedulesOperations operations, string resourceGroupName, string name, Schedule schedule, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, name, schedule, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete schedule.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='name'>
            /// The name of the schedule.
            /// </param>
            public static void Delete(this IGlobalSchedulesOperations operations, string resourceGroupName, string name)
            {
                operations.DeleteAsync(resourceGroupName, name).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete schedule.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='name'>
            /// The name of the schedule.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IGlobalSchedulesOperations operations, string resourceGroupName, string name, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, name, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Allows modifying tags of schedules. All other properties will be ignored.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='name'>
            /// The name of the schedule.
            /// </param>
            /// <param name='schedule'>
            /// Allows modifying tags of schedules. All other properties will be ignored.
            /// </param>
            public static Schedule Update(this IGlobalSchedulesOperations operations, string resourceGroupName, string name, ScheduleFragment schedule)
            {
                return operations.UpdateAsync(resourceGroupName, name, schedule).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Allows modifying tags of schedules. All other properties will be ignored.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='name'>
            /// The name of the schedule.
            /// </param>
            /// <param name='schedule'>
            /// Allows modifying tags of schedules. All other properties will be ignored.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Schedule> UpdateAsync(this IGlobalSchedulesOperations operations, string resourceGroupName, string name, ScheduleFragment schedule, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, name, schedule, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Execute a schedule. This operation can take a while to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='name'>
            /// The name of the schedule.
            /// </param>
            public static void Execute(this IGlobalSchedulesOperations operations, string resourceGroupName, string name)
            {
                operations.ExecuteAsync(resourceGroupName, name).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Execute a schedule. This operation can take a while to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='name'>
            /// The name of the schedule.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ExecuteAsync(this IGlobalSchedulesOperations operations, string resourceGroupName, string name, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.ExecuteWithHttpMessagesAsync(resourceGroupName, name, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Updates a schedule's target resource Id. This operation can take a while to
            /// complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='name'>
            /// The name of the schedule.
            /// </param>
            /// <param name='retargetScheduleProperties'>
            /// Properties for retargeting a virtual machine schedule.
            /// </param>
            public static void Retarget(this IGlobalSchedulesOperations operations, string resourceGroupName, string name, RetargetScheduleProperties retargetScheduleProperties)
            {
                operations.RetargetAsync(resourceGroupName, name, retargetScheduleProperties).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates a schedule's target resource Id. This operation can take a while to
            /// complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='name'>
            /// The name of the schedule.
            /// </param>
            /// <param name='retargetScheduleProperties'>
            /// Properties for retargeting a virtual machine schedule.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task RetargetAsync(this IGlobalSchedulesOperations operations, string resourceGroupName, string name, RetargetScheduleProperties retargetScheduleProperties, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.RetargetWithHttpMessagesAsync(resourceGroupName, name, retargetScheduleProperties, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Execute a schedule. This operation can take a while to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='name'>
            /// The name of the schedule.
            /// </param>
            public static void BeginExecute(this IGlobalSchedulesOperations operations, string resourceGroupName, string name)
            {
                operations.BeginExecuteAsync(resourceGroupName, name).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Execute a schedule. This operation can take a while to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='name'>
            /// The name of the schedule.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginExecuteAsync(this IGlobalSchedulesOperations operations, string resourceGroupName, string name, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginExecuteWithHttpMessagesAsync(resourceGroupName, name, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Updates a schedule's target resource Id. This operation can take a while to
            /// complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='name'>
            /// The name of the schedule.
            /// </param>
            /// <param name='retargetScheduleProperties'>
            /// Properties for retargeting a virtual machine schedule.
            /// </param>
            public static void BeginRetarget(this IGlobalSchedulesOperations operations, string resourceGroupName, string name, RetargetScheduleProperties retargetScheduleProperties)
            {
                operations.BeginRetargetAsync(resourceGroupName, name, retargetScheduleProperties).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates a schedule's target resource Id. This operation can take a while to
            /// complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='name'>
            /// The name of the schedule.
            /// </param>
            /// <param name='retargetScheduleProperties'>
            /// Properties for retargeting a virtual machine schedule.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginRetargetAsync(this IGlobalSchedulesOperations operations, string resourceGroupName, string name, RetargetScheduleProperties retargetScheduleProperties, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginRetargetWithHttpMessagesAsync(resourceGroupName, name, retargetScheduleProperties, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// List schedules in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<Schedule> ListBySubscriptionNext(this IGlobalSchedulesOperations operations, string nextPageLink)
            {
                return operations.ListBySubscriptionNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List schedules in a subscription.
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
            public static async Task<IPage<Schedule>> ListBySubscriptionNextAsync(this IGlobalSchedulesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListBySubscriptionNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List schedules in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<Schedule> ListByResourceGroupNext(this IGlobalSchedulesOperations operations, string nextPageLink)
            {
                return operations.ListByResourceGroupNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List schedules in a resource group.
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
            public static async Task<IPage<Schedule>> ListByResourceGroupNextAsync(this IGlobalSchedulesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
