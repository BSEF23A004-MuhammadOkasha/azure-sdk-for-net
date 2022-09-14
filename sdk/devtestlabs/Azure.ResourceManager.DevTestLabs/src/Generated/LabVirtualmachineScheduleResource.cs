// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.DevTestLabs.Models;

namespace Azure.ResourceManager.DevTestLabs
{
    /// <summary>
    /// A Class representing a LabVirtualmachineSchedule along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="LabVirtualmachineScheduleResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetLabVirtualmachineScheduleResource method.
    /// Otherwise you can get one from its parent resource <see cref="LabVirtualMachineResource" /> using the GetLabVirtualmachineSchedule method.
    /// </summary>
    public partial class LabVirtualmachineScheduleResource : BaseScheduleResource
    {
        /// <summary> Generate the resource identifier of a <see cref="LabVirtualmachineScheduleResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string labName, string virtualMachineName, string name)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/virtualmachines/{virtualMachineName}/schedules/{name}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _labVirtualmachineScheduleVirtualMachineSchedulesClientDiagnostics;
        private readonly VirtualMachineSchedulesRestOperations _labVirtualmachineScheduleVirtualMachineSchedulesRestClient;

        /// <summary> Initializes a new instance of the <see cref="LabVirtualmachineScheduleResource"/> class for mocking. </summary>
        protected LabVirtualmachineScheduleResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "LabVirtualmachineScheduleResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal LabVirtualmachineScheduleResource(ArmClient client, ScheduleData data) : base(client, data)
        {
        }

        /// <summary> Initializes a new instance of the <see cref="LabVirtualmachineScheduleResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal LabVirtualmachineScheduleResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _labVirtualmachineScheduleVirtualMachineSchedulesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DevTestLabs", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string labVirtualmachineScheduleVirtualMachineSchedulesApiVersion);
            _labVirtualmachineScheduleVirtualMachineSchedulesRestClient = new VirtualMachineSchedulesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, labVirtualmachineScheduleVirtualMachineSchedulesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.DevTestLab/labs/virtualmachines/schedules";

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary> placeholder. </summary>
        /// <param name="expand"> Specify the $expand query. Example: &apos;properties($select=status)&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override async Task<Response<BaseScheduleResource>> GetCoreAsync(string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _labVirtualmachineScheduleVirtualMachineSchedulesClientDiagnostics.CreateScope("LabVirtualmachineScheduleResource.Get");
            scope.Start();
            try
            {
                var response = await _labVirtualmachineScheduleVirtualMachineSchedulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(GetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get schedule.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/virtualmachines/{virtualMachineName}/schedules/{name}
        /// Operation Id: VirtualMachineSchedules_Get
        /// </summary>
        /// <param name="expand"> Specify the $expand query. Example: &apos;properties($select=status)&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new virtual async Task<Response<LabVirtualmachineScheduleResource>> GetAsync(string expand = null, CancellationToken cancellationToken = default)
        {
            var value = await GetCoreAsync(expand, cancellationToken);
            return Response.FromValue((LabVirtualmachineScheduleResource)value.Value, value.GetRawResponse());
        }

        /// <summary> placeholder. </summary>
        /// <param name="expand"> Specify the $expand query. Example: &apos;properties($select=status)&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override Response<BaseScheduleResource> GetCore(string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _labVirtualmachineScheduleVirtualMachineSchedulesClientDiagnostics.CreateScope("LabVirtualmachineScheduleResource.Get");
            scope.Start();
            try
            {
                var response = _labVirtualmachineScheduleVirtualMachineSchedulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, expand, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(GetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get schedule.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/virtualmachines/{virtualMachineName}/schedules/{name}
        /// Operation Id: VirtualMachineSchedules_Get
        /// </summary>
        /// <param name="expand"> Specify the $expand query. Example: &apos;properties($select=status)&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new virtual Response<LabVirtualmachineScheduleResource> Get(string expand = null, CancellationToken cancellationToken = default)
        {
            var value = GetCore(expand, cancellationToken);
            return Response.FromValue((LabVirtualmachineScheduleResource)value.Value, value.GetRawResponse());
        }

        /// <summary> placeholder. </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override async Task<ArmOperation> DeleteCoreAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _labVirtualmachineScheduleVirtualMachineSchedulesClientDiagnostics.CreateScope("LabVirtualmachineScheduleResource.Delete");
            scope.Start();
            try
            {
                var response = await _labVirtualmachineScheduleVirtualMachineSchedulesRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new DevTestLabsArmOperation(response);
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

        /// <summary> placeholder. </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override ArmOperation DeleteCore(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _labVirtualmachineScheduleVirtualMachineSchedulesClientDiagnostics.CreateScope("LabVirtualmachineScheduleResource.Delete");
            scope.Start();
            try
            {
                var response = _labVirtualmachineScheduleVirtualMachineSchedulesRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new DevTestLabsArmOperation(response);
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

        /// <summary> placeholder. </summary>
        /// <param name="schedule"> A schedule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="schedule"/> is null. </exception>
        protected override async Task<Response<BaseScheduleResource>> UpdateCoreAsync(ScheduleFragment schedule, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(schedule, nameof(schedule));

            using var scope = _labVirtualmachineScheduleVirtualMachineSchedulesClientDiagnostics.CreateScope("LabVirtualmachineScheduleResource.Update");
            scope.Start();
            try
            {
                var response = await _labVirtualmachineScheduleVirtualMachineSchedulesRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, schedule, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(GetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Allows modifying tags of schedules. All other properties will be ignored.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/virtualmachines/{virtualMachineName}/schedules/{name}
        /// Operation Id: VirtualMachineSchedules_Update
        /// </summary>
        /// <param name="schedule"> A schedule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="schedule"/> is null. </exception>
        [ForwardsClientCalls]
        public new virtual async Task<Response<LabVirtualmachineScheduleResource>> UpdateAsync(ScheduleFragment schedule, CancellationToken cancellationToken = default)
        {
            var value = await UpdateCoreAsync(schedule, cancellationToken);
            return Response.FromValue((LabVirtualmachineScheduleResource)value.Value, value.GetRawResponse());
        }

        /// <summary> placeholder. </summary>
        /// <param name="schedule"> A schedule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="schedule"/> is null. </exception>
        protected override Response<BaseScheduleResource> UpdateCore(ScheduleFragment schedule, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(schedule, nameof(schedule));

            using var scope = _labVirtualmachineScheduleVirtualMachineSchedulesClientDiagnostics.CreateScope("LabVirtualmachineScheduleResource.Update");
            scope.Start();
            try
            {
                var response = _labVirtualmachineScheduleVirtualMachineSchedulesRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, schedule, cancellationToken);
                return Response.FromValue(GetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Allows modifying tags of schedules. All other properties will be ignored.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/virtualmachines/{virtualMachineName}/schedules/{name}
        /// Operation Id: VirtualMachineSchedules_Update
        /// </summary>
        /// <param name="schedule"> A schedule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="schedule"/> is null. </exception>
        [ForwardsClientCalls]
        public new virtual Response<LabVirtualmachineScheduleResource> Update(ScheduleFragment schedule, CancellationToken cancellationToken = default)
        {
            var value = UpdateCore(schedule, cancellationToken);
            return Response.FromValue((LabVirtualmachineScheduleResource)value.Value, value.GetRawResponse());
        }

        /// <summary> placeholder. </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override async Task<ArmOperation> ExecuteCoreAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _labVirtualmachineScheduleVirtualMachineSchedulesClientDiagnostics.CreateScope("LabVirtualmachineScheduleResource.Execute");
            scope.Start();
            try
            {
                var response = await _labVirtualmachineScheduleVirtualMachineSchedulesRestClient.ExecuteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new DevTestLabsArmOperation(_labVirtualmachineScheduleVirtualMachineSchedulesClientDiagnostics, Pipeline, _labVirtualmachineScheduleVirtualMachineSchedulesRestClient.CreateExecuteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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

        /// <summary> placeholder. </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override ArmOperation ExecuteCore(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _labVirtualmachineScheduleVirtualMachineSchedulesClientDiagnostics.CreateScope("LabVirtualmachineScheduleResource.Execute");
            scope.Start();
            try
            {
                var response = _labVirtualmachineScheduleVirtualMachineSchedulesRestClient.Execute(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new DevTestLabsArmOperation(_labVirtualmachineScheduleVirtualMachineSchedulesClientDiagnostics, Pipeline, _labVirtualmachineScheduleVirtualMachineSchedulesRestClient.CreateExecuteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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

        /// <summary> placeholder. </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        protected override async Task<Response<BaseScheduleResource>> AddTagCoreAsync(string key, string value, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));
            Argument.AssertNotNull(value, nameof(value));

            using var scope = _labVirtualmachineScheduleVirtualMachineSchedulesClientDiagnostics.CreateScope("LabVirtualmachineScheduleResource.AddTag");
            scope.Start();
            try
            {
                if (await CanUseTagResourceAsync(cancellationToken: cancellationToken).ConfigureAwait(false))
                {
                    var originalTags = await GetTagResource().GetAsync(cancellationToken).ConfigureAwait(false);
                    originalTags.Value.Data.TagValues[key] = value;
                    await GetTagResource().CreateOrUpdateAsync(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                    var originalResponse = await _labVirtualmachineScheduleVirtualMachineSchedulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, null, cancellationToken).ConfigureAwait(false);
                    return Response.FromValue(GetResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
                }
                else
                {
                    var current = (await GetAsync(cancellationToken: cancellationToken).ConfigureAwait(false)).Value.Data;
                    var patch = new ScheduleFragment();
                    foreach (var tag in current.Tags)
                    {
                        patch.Tags.Add(tag);
                    }
                    patch.Tags[key] = value;
                    var result = await UpdateAsync(patch, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return result;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Add a tag to the current resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/virtualmachines/{virtualMachineName}/schedules/{name}
        /// Operation Id: VirtualMachineSchedules_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        [ForwardsClientCalls]
        public new virtual async Task<Response<LabVirtualmachineScheduleResource>> AddTagAsync(string key, string value, CancellationToken cancellationToken = default)
        {
            var value0 = await AddTagCoreAsync(key, value, cancellationToken);
            return Response.FromValue((LabVirtualmachineScheduleResource)value0.Value, value0.GetRawResponse());
        }

        /// <summary> placeholder. </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        protected override Response<BaseScheduleResource> AddTagCore(string key, string value, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));
            Argument.AssertNotNull(value, nameof(value));

            using var scope = _labVirtualmachineScheduleVirtualMachineSchedulesClientDiagnostics.CreateScope("LabVirtualmachineScheduleResource.AddTag");
            scope.Start();
            try
            {
                if (CanUseTagResource(cancellationToken: cancellationToken))
                {
                    var originalTags = GetTagResource().Get(cancellationToken);
                    originalTags.Value.Data.TagValues[key] = value;
                    GetTagResource().CreateOrUpdate(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken);
                    var originalResponse = _labVirtualmachineScheduleVirtualMachineSchedulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, null, cancellationToken);
                    return Response.FromValue(GetResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
                }
                else
                {
                    var current = Get(cancellationToken: cancellationToken).Value.Data;
                    var patch = new ScheduleFragment();
                    foreach (var tag in current.Tags)
                    {
                        patch.Tags.Add(tag);
                    }
                    patch.Tags[key] = value;
                    var result = Update(patch, cancellationToken: cancellationToken);
                    return result;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Add a tag to the current resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/virtualmachines/{virtualMachineName}/schedules/{name}
        /// Operation Id: VirtualMachineSchedules_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        [ForwardsClientCalls]
        public new virtual Response<LabVirtualmachineScheduleResource> AddTag(string key, string value, CancellationToken cancellationToken = default)
        {
            var value0 = AddTagCore(key, value, cancellationToken);
            return Response.FromValue((LabVirtualmachineScheduleResource)value0.Value, value0.GetRawResponse());
        }

        /// <summary> placeholder. </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        protected override async Task<Response<BaseScheduleResource>> SetTagsCoreAsync(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tags, nameof(tags));

            using var scope = _labVirtualmachineScheduleVirtualMachineSchedulesClientDiagnostics.CreateScope("LabVirtualmachineScheduleResource.SetTags");
            scope.Start();
            try
            {
                if (await CanUseTagResourceAsync(cancellationToken: cancellationToken).ConfigureAwait(false))
                {
                    await GetTagResource().DeleteAsync(WaitUntil.Completed, cancellationToken: cancellationToken).ConfigureAwait(false);
                    var originalTags = await GetTagResource().GetAsync(cancellationToken).ConfigureAwait(false);
                    originalTags.Value.Data.TagValues.ReplaceWith(tags);
                    await GetTagResource().CreateOrUpdateAsync(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                    var originalResponse = await _labVirtualmachineScheduleVirtualMachineSchedulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, null, cancellationToken).ConfigureAwait(false);
                    return Response.FromValue(GetResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
                }
                else
                {
                    var current = (await GetAsync(cancellationToken: cancellationToken).ConfigureAwait(false)).Value.Data;
                    var patch = new ScheduleFragment();
                    patch.Tags.ReplaceWith(tags);
                    var result = await UpdateAsync(patch, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return result;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Replace the tags on the resource with the given set.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/virtualmachines/{virtualMachineName}/schedules/{name}
        /// Operation Id: VirtualMachineSchedules_Get
        /// </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        [ForwardsClientCalls]
        public new virtual async Task<Response<LabVirtualmachineScheduleResource>> SetTagsAsync(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            var value = await SetTagsCoreAsync(tags, cancellationToken);
            return Response.FromValue((LabVirtualmachineScheduleResource)value.Value, value.GetRawResponse());
        }

        /// <summary> placeholder. </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        protected override Response<BaseScheduleResource> SetTagsCore(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tags, nameof(tags));

            using var scope = _labVirtualmachineScheduleVirtualMachineSchedulesClientDiagnostics.CreateScope("LabVirtualmachineScheduleResource.SetTags");
            scope.Start();
            try
            {
                if (CanUseTagResource(cancellationToken: cancellationToken))
                {
                    GetTagResource().Delete(WaitUntil.Completed, cancellationToken: cancellationToken);
                    var originalTags = GetTagResource().Get(cancellationToken);
                    originalTags.Value.Data.TagValues.ReplaceWith(tags);
                    GetTagResource().CreateOrUpdate(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken);
                    var originalResponse = _labVirtualmachineScheduleVirtualMachineSchedulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, null, cancellationToken);
                    return Response.FromValue(GetResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
                }
                else
                {
                    var current = Get(cancellationToken: cancellationToken).Value.Data;
                    var patch = new ScheduleFragment();
                    patch.Tags.ReplaceWith(tags);
                    var result = Update(patch, cancellationToken: cancellationToken);
                    return result;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Replace the tags on the resource with the given set.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/virtualmachines/{virtualMachineName}/schedules/{name}
        /// Operation Id: VirtualMachineSchedules_Get
        /// </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        [ForwardsClientCalls]
        public new virtual Response<LabVirtualmachineScheduleResource> SetTags(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            var value = SetTagsCore(tags, cancellationToken);
            return Response.FromValue((LabVirtualmachineScheduleResource)value.Value, value.GetRawResponse());
        }

        /// <summary> placeholder. </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        protected override async Task<Response<BaseScheduleResource>> RemoveTagCoreAsync(string key, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));

            using var scope = _labVirtualmachineScheduleVirtualMachineSchedulesClientDiagnostics.CreateScope("LabVirtualmachineScheduleResource.RemoveTag");
            scope.Start();
            try
            {
                if (await CanUseTagResourceAsync(cancellationToken: cancellationToken).ConfigureAwait(false))
                {
                    var originalTags = await GetTagResource().GetAsync(cancellationToken).ConfigureAwait(false);
                    originalTags.Value.Data.TagValues.Remove(key);
                    await GetTagResource().CreateOrUpdateAsync(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                    var originalResponse = await _labVirtualmachineScheduleVirtualMachineSchedulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, null, cancellationToken).ConfigureAwait(false);
                    return Response.FromValue(GetResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
                }
                else
                {
                    var current = (await GetAsync(cancellationToken: cancellationToken).ConfigureAwait(false)).Value.Data;
                    var patch = new ScheduleFragment();
                    foreach (var tag in current.Tags)
                    {
                        patch.Tags.Add(tag);
                    }
                    patch.Tags.Remove(key);
                    var result = await UpdateAsync(patch, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return result;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Removes a tag by key from the resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/virtualmachines/{virtualMachineName}/schedules/{name}
        /// Operation Id: VirtualMachineSchedules_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        [ForwardsClientCalls]
        public new virtual async Task<Response<LabVirtualmachineScheduleResource>> RemoveTagAsync(string key, CancellationToken cancellationToken = default)
        {
            var value = await RemoveTagCoreAsync(key, cancellationToken);
            return Response.FromValue((LabVirtualmachineScheduleResource)value.Value, value.GetRawResponse());
        }

        /// <summary> placeholder. </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        protected override Response<BaseScheduleResource> RemoveTagCore(string key, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));

            using var scope = _labVirtualmachineScheduleVirtualMachineSchedulesClientDiagnostics.CreateScope("LabVirtualmachineScheduleResource.RemoveTag");
            scope.Start();
            try
            {
                if (CanUseTagResource(cancellationToken: cancellationToken))
                {
                    var originalTags = GetTagResource().Get(cancellationToken);
                    originalTags.Value.Data.TagValues.Remove(key);
                    GetTagResource().CreateOrUpdate(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken);
                    var originalResponse = _labVirtualmachineScheduleVirtualMachineSchedulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, null, cancellationToken);
                    return Response.FromValue(GetResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
                }
                else
                {
                    var current = Get(cancellationToken: cancellationToken).Value.Data;
                    var patch = new ScheduleFragment();
                    foreach (var tag in current.Tags)
                    {
                        patch.Tags.Add(tag);
                    }
                    patch.Tags.Remove(key);
                    var result = Update(patch, cancellationToken: cancellationToken);
                    return result;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Removes a tag by key from the resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/virtualmachines/{virtualMachineName}/schedules/{name}
        /// Operation Id: VirtualMachineSchedules_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        [ForwardsClientCalls]
        public new virtual Response<LabVirtualmachineScheduleResource> RemoveTag(string key, CancellationToken cancellationToken = default)
        {
            var value = RemoveTagCore(key, cancellationToken);
            return Response.FromValue((LabVirtualmachineScheduleResource)value.Value, value.GetRawResponse());
        }
    }
}
