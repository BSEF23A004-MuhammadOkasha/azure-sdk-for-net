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

namespace Azure.ResourceManager.Sql
{
    /// <summary> TODO. </summary>
    public abstract partial class SensitivityLabelResource : ArmResource
    {
        internal static SensitivityLabelResource GetResource(ArmClient client, SensitivityLabelData data)
        {
            if (IsManagedDatabaseSensitivityLabelResource(data.Id))
            {
                return new ManagedDatabaseSensitivityLabelResource(client, data);
            }
            if (IsSqlDatabaseSensitivityLabelResource(data.Id))
            {
                return new SqlDatabaseSensitivityLabelResource(client, data);
            }
            // TODO -- should we throw or return an UnknownResource?
            throw new InvalidOperationException();
        }

        internal static bool IsManagedDatabaseSensitivityLabelResource(ResourceIdentifier id)
        {
            // checking the resource type
            if (id.ResourceType != ManagedDatabaseSensitivityLabelResource.ResourceType)
            {
                return false;
            }
            // checking the resource scope
            if (id.Parent.Parent.Parent.Parent.Parent.Parent.ResourceType != "Microsoft.Resources/resourceGroups")
            {
                return false;
            }
            return true;
        }

        internal static bool IsSqlDatabaseSensitivityLabelResource(ResourceIdentifier id)
        {
            // checking the resource type
            if (id.ResourceType != SqlDatabaseSensitivityLabelResource.ResourceType)
            {
                return false;
            }
            // checking the resource scope
            if (id.Parent.Parent.Parent.Parent.Parent.Parent.ResourceType != "Microsoft.Resources/resourceGroups")
            {
                return false;
            }
            return true;
        }

        private readonly SensitivityLabelData _data;

        /// <summary> Initializes a new instance of the <see cref="SensitivityLabelResource"/> class for mocking. </summary>
        protected SensitivityLabelResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SensitivityLabelResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SensitivityLabelResource(ArmClient client, SensitivityLabelData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SensitivityLabelResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SensitivityLabelResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SensitivityLabelData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        protected abstract Task<Response<SensitivityLabelResource>> GetCoreAsync(CancellationToken cancellationToken = default);

        /// <summary> placeholder. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public async Task<Response<SensitivityLabelResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            return await GetCoreAsync(cancellationToken);
        }

        protected abstract Response<SensitivityLabelResource> GetCore(CancellationToken cancellationToken = default);

        /// <summary> placeholder. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public Response<SensitivityLabelResource> Get(CancellationToken cancellationToken = default)
        {
            return GetCore(cancellationToken);
        }

        protected abstract Task<ArmOperation> DeleteCoreAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default);

        /// <summary> placeholder. </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            return await DeleteCoreAsync(waitUntil, cancellationToken);
        }

        protected abstract ArmOperation DeleteCore(WaitUntil waitUntil, CancellationToken cancellationToken = default);

        /// <summary> placeholder. </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            return DeleteCore(waitUntil, cancellationToken);
        }

        protected abstract Task<ArmOperation<SensitivityLabelResource>> UpdateCoreAsync(WaitUntil waitUntil, SensitivityLabelData data, CancellationToken cancellationToken = default);

        /// <summary> placeholder. </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The column sensitivity label resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        [ForwardsClientCalls]
        public async Task<ArmOperation<SensitivityLabelResource>> UpdateAsync(WaitUntil waitUntil, SensitivityLabelData data, CancellationToken cancellationToken = default)
        {
            return await UpdateCoreAsync(waitUntil, data, cancellationToken);
        }

        protected abstract ArmOperation<SensitivityLabelResource> UpdateCore(WaitUntil waitUntil, SensitivityLabelData data, CancellationToken cancellationToken = default);

        /// <summary> placeholder. </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The column sensitivity label resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        [ForwardsClientCalls]
        public ArmOperation<SensitivityLabelResource> Update(WaitUntil waitUntil, SensitivityLabelData data, CancellationToken cancellationToken = default)
        {
            return UpdateCore(waitUntil, data, cancellationToken);
        }
    }
}
