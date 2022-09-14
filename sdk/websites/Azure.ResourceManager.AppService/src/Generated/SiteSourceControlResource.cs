// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.AppService
{
    /// <summary> TODO. </summary>
    public abstract partial class SiteSourceControlResource : ArmResource
    {
        internal static SiteSourceControlResource GetResource(ArmClient client, SiteSourceControlData data)
        {
            if (IsWebSiteSlotSourceControlResource(data.Id))
            {
                return new WebSiteSlotSourceControlResource(client, data);
            }
            if (IsWebSiteSourceControlResource(data.Id))
            {
                return new WebSiteSourceControlResource(client, data);
            }
            // TODO -- should we throw or return an UnknownResource?
            throw new InvalidOperationException();
        }

        internal static bool IsWebSiteSlotSourceControlResource(ResourceIdentifier id)
        {
            // checking the resource type
            if (id.ResourceType != WebSiteSlotSourceControlResource.ResourceType)
            {
                return false;
            }
            // checking the resource scope
            if (id.Parent.Parent.Parent.ResourceType != "Microsoft.Resources/resourceGroups")
            {
                return false;
            }
            // checking the resource name
            if (id.Name != "web")
            {
                return false;
            }
            return true;
        }

        internal static bool IsWebSiteSourceControlResource(ResourceIdentifier id)
        {
            // checking the resource type
            if (id.ResourceType != WebSiteSourceControlResource.ResourceType)
            {
                return false;
            }
            // checking the resource scope
            if (id.Parent.Parent.ResourceType != "Microsoft.Resources/resourceGroups")
            {
                return false;
            }
            // checking the resource name
            if (id.Name != "web")
            {
                return false;
            }
            return true;
        }

        private readonly SiteSourceControlData _data;

        /// <summary> Initializes a new instance of the <see cref="SiteSourceControlResource"/> class for mocking. </summary>
        protected SiteSourceControlResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SiteSourceControlResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SiteSourceControlResource(ArmClient client, SiteSourceControlData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SiteSourceControlResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SiteSourceControlResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SiteSourceControlData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        protected abstract Task<Response<SiteSourceControlResource>> GetCoreAsync(CancellationToken cancellationToken = default);

        /// <summary> placeholder. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public async Task<Response<SiteSourceControlResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            return await GetCoreAsync(cancellationToken);
        }

        protected abstract Response<SiteSourceControlResource> GetCore(CancellationToken cancellationToken = default);

        /// <summary> placeholder. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public Response<SiteSourceControlResource> Get(CancellationToken cancellationToken = default)
        {
            return GetCore(cancellationToken);
        }

        protected abstract Task<ArmOperation> DeleteCoreAsync(WaitUntil waitUntil, string additionalFlags = null, CancellationToken cancellationToken = default);

        /// <summary> placeholder. </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="additionalFlags"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, string additionalFlags = null, CancellationToken cancellationToken = default)
        {
            return await DeleteCoreAsync(waitUntil, additionalFlags, cancellationToken);
        }

        protected abstract ArmOperation DeleteCore(WaitUntil waitUntil, string additionalFlags = null, CancellationToken cancellationToken = default);

        /// <summary> placeholder. </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="additionalFlags"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public ArmOperation Delete(WaitUntil waitUntil, string additionalFlags = null, CancellationToken cancellationToken = default)
        {
            return DeleteCore(waitUntil, additionalFlags, cancellationToken);
        }

        protected abstract Task<Response<SiteSourceControlResource>> UpdateCoreAsync(SiteSourceControlData data, CancellationToken cancellationToken = default);

        /// <summary> placeholder. </summary>
        /// <param name="data"> JSON representation of a SiteSourceControl object. See example. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        [ForwardsClientCalls]
        public async Task<Response<SiteSourceControlResource>> UpdateAsync(SiteSourceControlData data, CancellationToken cancellationToken = default)
        {
            return await UpdateCoreAsync(data, cancellationToken);
        }

        protected abstract Response<SiteSourceControlResource> UpdateCore(SiteSourceControlData data, CancellationToken cancellationToken = default);

        /// <summary> placeholder. </summary>
        /// <param name="data"> JSON representation of a SiteSourceControl object. See example. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        [ForwardsClientCalls]
        public Response<SiteSourceControlResource> Update(SiteSourceControlData data, CancellationToken cancellationToken = default)
        {
            return UpdateCore(data, cancellationToken);
        }

        protected abstract Task<ArmOperation<SiteSourceControlResource>> CreateOrUpdateCoreAsync(WaitUntil waitUntil, SiteSourceControlData data, CancellationToken cancellationToken = default);

        /// <summary> placeholder. </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> JSON representation of a SiteSourceControl object. See example. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        [ForwardsClientCalls]
        public async Task<ArmOperation<SiteSourceControlResource>> CreateOrUpdateAsync(WaitUntil waitUntil, SiteSourceControlData data, CancellationToken cancellationToken = default)
        {
            return await CreateOrUpdateCoreAsync(waitUntil, data, cancellationToken);
        }

        protected abstract ArmOperation<SiteSourceControlResource> CreateOrUpdateCore(WaitUntil waitUntil, SiteSourceControlData data, CancellationToken cancellationToken = default);

        /// <summary> placeholder. </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> JSON representation of a SiteSourceControl object. See example. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        [ForwardsClientCalls]
        public ArmOperation<SiteSourceControlResource> CreateOrUpdate(WaitUntil waitUntil, SiteSourceControlData data, CancellationToken cancellationToken = default)
        {
            return CreateOrUpdateCore(waitUntil, data, cancellationToken);
        }
    }
}
